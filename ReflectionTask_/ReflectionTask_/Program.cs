using ReflectionTask_.Models;

namespace ReflectionTask_;

internal class Program
{
    static void Main(string[] args)
    {
        HourlyEmployee hourlyEmployee1 = new HourlyEmployee();
        hourlyEmployee1.Name = "Faiq";
        hourlyEmployee1.Surname = "Abbasov";
        hourlyEmployee1.Age = 24;
        hourlyEmployee1.HoursWorked = 27.6;
        hourlyEmployee1.HourlyRate = 2.3;

        HourlyEmployee hourlyEmployee2 = new HourlyEmployee();
        hourlyEmployee2.Name = "Mehemmed";
        hourlyEmployee2.Surname = "Dadasov";
        hourlyEmployee2.Age = 27;
        hourlyEmployee2.HoursWorked = 34.6;
        hourlyEmployee2.HourlyRate = 2.1;

        SalariedEmployee salariedEmployee = new SalariedEmployee();
        salariedEmployee.Name = "Orxan";
        salariedEmployee.Surname = "Quliyev";
        salariedEmployee.Age = 24;
        salariedEmployee.MonthlySalary = 456.23;

        SalariedEmployee salariedEmployee2 = new SalariedEmployee();
        salariedEmployee2.Name = "Kenan";
        salariedEmployee2.Surname = "Memmedov";
        salariedEmployee2.Age = 29;
        salariedEmployee2.MonthlySalary = 523.79;

        Console.WriteLine(hourlyEmployee1.CalculateSalary());
        Console.WriteLine(hourlyEmployee2.CalculateSalary());
        hourlyEmployee1.DisplayDetails();
        hourlyEmployee2.DisplayDetails();

        Console.WriteLine(salariedEmployee.CalculateSalary());
        Console.WriteLine(salariedEmployee2.CalculateSalary());
        salariedEmployee.DisplayDetails();
        salariedEmployee2.DisplayDetails();
    }
}
