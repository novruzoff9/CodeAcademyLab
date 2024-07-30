using AdoGenericService.Models;
using Microsoft.Data.SqlClient;
using PluralizeService.Core;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoGenericService.Services;

public interface IService<T> where T : BaseEntity
{
    Task<bool> Add(T entity);
    //Task<bool> Update(T entity);
    /*Task<bool> Delete(int id);
    Task<bool> Delete(T entity);
    Task<IEnumerable<T>> GetAll();
    Task<bool> GetById(int id);*/
}

public static class Helper
{
    public static string GetTableName<T>(this T entity) where T : BaseEntity => PluralizationProvider.Pluralize(typeof(T).Name);

}
public class Service<T> : IService<T> where T : BaseEntity
{

    public async Task<bool> Add(T entity)
    {
        string tableName = entity.GetTableName();

        Console.WriteLine(tableName);

        string connection = "Server=TITAN06\\SQLEXPRESS;database=Northwind;Trusted_Connection=Yes;TrustServerCertificate=True"; 

        var columnaNameValues = typeof(T).GetProperties().
            Where(p => p.GetValue(entity) != null && p.GetCustomAttribute<PrimaryKeyAttribute>() == null)
            .ToDictionary(p => p.Name, p => p.GetValue(entity));

        string command = $"INSERT INTO {tableName}({string.Join(',', columnaNameValues.Keys)}) VALUES(@{string.Join(",@", columnaNameValues.Keys)})";

 

        using SqlConnection sqlConnection = new(connection);
        using SqlCommand sqlCommand = new(command, sqlConnection);

        foreach (var item in columnaNameValues)
        {
            sqlCommand.Parameters.AddWithValue(item.Key, item.Value);
        }

        if (sqlConnection.State == System.Data.ConnectionState.Closed)
        {
            await sqlConnection.OpenAsync();
        }

        bool result = await sqlCommand.ExecuteNonQueryAsync() > 0;

        sqlConnection.Close(); 
        return result;
    }
 
}