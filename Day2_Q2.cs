using System;

class Calculator
{
    public void Divide(int numerator, int denominator)
    {
        try
        {
            int result = numerator / denominator;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("Operation completed safely");
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        int numerator, denominator;

        Console.Write("Enter Numerator: ");
        while (!int.TryParse(Console.ReadLine(), out numerator))
        {
            Console.Write("Invalid input! Enter a number: ");
        }

        Console.Write("Enter Denominator: ");
        while (!int.TryParse(Console.ReadLine(), out denominator))
        {
            Console.Write("Invalid input! Enter a number: ");
        }

        calc.Divide(numerator, denominator);

        Console.WriteLine("\nProgram continues...");
    }
}