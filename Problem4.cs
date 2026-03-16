using System;

class Vehicle
{
    // Private fields
    private string brand;
    private double rentalRatePerDay;

    // Properties
    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public double RentalRatePerDay
    {
        get { return rentalRatePerDay; }
        set
        {
            if (value >= 0)
                rentalRatePerDay = value;
            else
                Console.WriteLine("Invalid rental rate.");
        }
    }

    // Virtual method
    public virtual double CalculateRental(int days)
    {
        return RentalRatePerDay * days;
    }
}

class Car : Vehicle
{
    public override double CalculateRental(int days)
    {
        if (days <= 0)
        {
            Console.WriteLine("Invalid number of days.");
            return 0;
        }

        double total = RentalRatePerDay * days;
        return total + 500; // Insurance charge
    }
}

class Bike : Vehicle
{
    public override double CalculateRental(int days)
    {
        if (days <= 0)
        {
            Console.WriteLine("Invalid number of days.");
            return 0;
        }

        double total = RentalRatePerDay * days;
        return total - (total * 0.05); // 5% discount
    }
}

class Program
{
    static void Main()
    {
        Vehicle vehicle;

        // Car Rental
        vehicle = new Car();
        vehicle.Brand = "Toyota";
        vehicle.RentalRatePerDay = 2000;

        Console.WriteLine("Car Total Rental = " + vehicle.CalculateRental(3));

        // Bike Rental
        vehicle = new Bike();
        vehicle.Brand = "Honda";
        vehicle.RentalRatePerDay = 1000;

        Console.WriteLine("Bike Total Rental = " + vehicle.CalculateRental(3));
    }
}
