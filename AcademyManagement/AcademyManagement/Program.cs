using AcademyManagement.Business;
using AcademyManagement.Models;
using System.Data;
using System.Data.SqlClient;

namespace AcademyManagement
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Repository.AddStudent("Covdet", "Mikayilzade", "Cocu", "C1903");
            //Update(2, "Covdet", "Mikayilzade", "Cocu", "C1903");
            //DeleteById(3);
        }

        
    }
}
