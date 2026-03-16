using System;

class Employee
{
    // Properties
    public string Name { get; set; }
    public double BaseSalary { get; set; }

    // Virtual method
    public virtual double CalculateSalary()
    {
        return BaseSalary;
    }
}

class Manager : Employee
{
    // Override method
    public override double CalculateSalary()
    {
        return BaseSalary + (BaseSalary * 0.20);
    }
}

class Developer : Employee
{
    // Override method
    public override double CalculateSalary()
    {
        return BaseSalary + (BaseSalary * 0.10);
    }
}

class Program
{
    static void Main()
    {
        double baseSalary = 50000;

        // Runtime polymorphism
        Employee manager = new Manager();
        manager.BaseSalary = baseSalary;

        Employee developer = new Developer();
        developer.BaseSalary = baseSalary;

        Console.WriteLine("Manager Salary = " + manager.CalculateSalary());
        Console.WriteLine("Developer Salary = " + developer.CalculateSalary());
    }
}
