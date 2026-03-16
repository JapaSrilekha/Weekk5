using System;

class BankAccount
{
    // Private fields
    private int accountNumber;
    private double balance;

    // Property for Account Number
    public int AccountNumber
    {
        get { return accountNumber; }
        set { accountNumber = value; }
    }

    // Property for Balance (read-only outside)
    public double Balance
    {
        get { return balance; }
    }

    // Deposit Method
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine("Amount Deposited: " + amount);
            Console.WriteLine("Updated Balance: " + balance);
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    // Withdraw Method
    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
        else if (amount > balance)
        {
            Console.WriteLine("Insufficient balance.");
        }
        else
        {
            balance -= amount;
            Console.WriteLine("Amount Withdrawn: " + amount);
            Console.WriteLine("Current Balance: " + balance);
        }
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        account.AccountNumber = 101;

        account.Deposit(5000);
        account.Withdraw(2000);
    }
}
