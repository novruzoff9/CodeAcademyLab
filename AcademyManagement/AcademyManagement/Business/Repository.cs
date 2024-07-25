using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Business
{
    public class Repository : IRepository
    {
        readonly static string connection = "Server=TITAN06\\SQLEXPRESS;Database=academy;Integrated Security=True;";
        public void GetById(int id)
        {
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Students where Id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("id", id);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                Console.WriteLine("Bu id-də istifadəçi tapılmamışdır");
                con.Close();
                return;
            }


            Console.WriteLine($"{dr["Id"]} : {dr["FirstName"]}, {dr["LastName"]}, {dr["UserName"]}, {dr["Password"]}");
            con.Close();
        }

        public void Update(int id, string firstname, string lastname, string username, string password)
        {
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update Students set Firstname=@firstname, LastName=@lastname, UserName=@username, Password=@password where id=@id";
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("firstname", firstname);
            cmd.Parameters.AddWithValue("lastname", lastname);
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", password);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void GetAll()
        {
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Students";
            cmd.CommandType = CommandType.Text;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine($"{dr["Id"]} : {dr["FirstName"]}, {dr["LastName"]}, {dr["UserName"]}, {dr["Password"]}");
            }
            con.Close();
        }

        public void AddStudent(string firstname, string lastname, string username, string password)
        {
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.CommandText = "insert into Students VALUES(@firstname,@lastname,@username,@password);";

            cmd.Parameters.AddWithValue("@firstname", firstname);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.CommandType = CommandType.Text;

            cmd.Connection = con;

            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Data uğurla əlavə olundu!");
        }

        public void DeleteById(int id)
        {
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from Students where Id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data uğurla silindi");
            con.Close();
        }
    }
}
