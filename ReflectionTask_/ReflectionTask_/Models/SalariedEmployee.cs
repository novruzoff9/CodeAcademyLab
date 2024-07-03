using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTask_.Models;

public class SalariedEmployee : IEmployee
{
    public static int _id = 0;

    public SalariedEmployee()
    {
        _id++;
        this.Id = _id;
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    public double MonthlySalary { get; set; }

    public double CalculateSalary()
    {
        return MonthlySalary;
    }

    public void DisplayDetails()
    {
        PropertyInfo[] properties = this
                .GetType()
                .GetProperties();

        string propertyLength = properties
            .Select(p => p.Name)
            .OrderByDescending(name => name.Length)
            .FirstOrDefault();


        foreach (PropertyInfo property in properties)
        {
            Console.WriteLine($"{property.Name.PadRight(propertyLength.Length)} : {property.GetValue(this)}");
        }

        Console.WriteLine(new string('-', 30));
    }
}
