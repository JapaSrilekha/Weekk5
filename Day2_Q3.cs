using System;

// Custom Exception Class
class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message)
    {
    }
}

// BankAccount Class
class BankAccount
{
    private double balance;

    public BankAccount(double balance)
    {
        this.balance = balance;
    }

    public void Withdraw(double amount)
    {
        if (amount > balance)
        {
            // Throw custom exception
            throw new InsufficientBalanceException("Withdrawal amount exceeds available balance");
        }

        balance -= amount;
        Console.WriteLine("Withdrawal Successful!");
        Console.WriteLine("Remaining Balance: " + balance);
    }
}

// Main Program
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Balance: ");
        double balance = double.Parse(Console.ReadLine());

        Console.Write("Enter Withdraw Amount: ");
        double amount = double.Parse(Console.ReadLine());

        BankAccount account = new BankAccount(balance);

        try
        {
            account.Withdraw(amount);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Transaction completed.");
        }

        Console.WriteLine("Program continues...");
    }
}