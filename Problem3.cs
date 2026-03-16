using System;

class Product
{
    // Private fields
    private string name;
    private double price;

    // Property for Name
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Property for Price with validation
    public double Price
    {
        get { return price; }
        set
        {
            if (value >= 0)
                price = value;
            else
                Console.WriteLine("Price cannot be negative.");
        }
    }

    // Virtual method
    public virtual double CalculateDiscount()
    {
        return price;
    }
}

class Electronics : Product
{
    public override double CalculateDiscount()
    {
        return Price - (Price * 0.05);   // 5% discount
    }
}

class Clothing : Product
{
    public override double CalculateDiscount()
    {
        return Price - (Price * 0.15);   // 15% discount
    }
}

class Program
{
    static void Main()
    {
        // Base class reference (Polymorphism)
        Product product;

        product = new Electronics();
        product.Name = "Laptop";
        product.Price = 20000;

        Console.WriteLine("Electronics Final Price after 5% discount = " + product.CalculateDiscount());

        product = new Clothing();
        product.Name = "Shirt";
        product.Price = 2000;

        Console.WriteLine("Clothing Final Price after 15% discount = " + product.CalculateDiscount());
    }
}
