using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTask_.Models;

public class HourlyEmployee : IEmployee
{
    public static int _id = 0;

    public HourlyEmployee()
    {
        _id ++;
        this.Id = _id;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public double HourlyRate { get; set; }
    public double HoursWorked { get; set; }

    public double CalculateSalary()
    {
        return this.HourlyRate * this.HoursWorked;
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
