using AdoGenericService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoGenericService.Services;

public interface IService<T> where T : BaseEntity
{
    Task<bool> Add(T entity);
    Task<bool> Update(T entity);
    /*Task<bool> Delete(int id);
    Task<bool> Delete(T entity);
    Task<IEnumerable<T>> GetAll();
    Task<bool> BetById(int id);*/
}


public class Service<T> : IService<T> where T : BaseEntity
{
    public async Task<bool> Add(T entity)
    {
        Console.WriteLine($"{entity.GetType().Name} -> Added entity");
        return true;
    }

    public async Task<bool> Update(T entity)
    {
        Console.WriteLine($"{entity.GetType().Name} -> Updated entity");
        return true;
    }
}