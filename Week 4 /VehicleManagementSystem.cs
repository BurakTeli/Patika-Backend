using System;

// Interface: IDriveable
public interface IDriveable
{
    void StartEngine();
    void StopEngine();
    void Drive();
}

// Interface: IFuelable
public interface IFuelable
{
    void Refuel(double liters);
    double FuelLevel { get; }
}

// Abstract Class: Vehicle
public abstract class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    // Constructor
    public Vehicle(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    // Abstract method (every vehicle should have a method to display information)
    public abstract void DisplayInfo();
}

// Concrete Class: Car
public class Car : Vehicle, IDriveable, IFuelable
{
    private double fuelLevel;

    // Constructor
    public Car(string make, string model, int year) : base(make, model, year) { }

    // Implement IDriveable methods
    public void StartEngine()
    {
        Console.WriteLine("The car engine is starting...");
    }

    public void StopEngine()
    {
        Console.WriteLine("The car engine is stopping...");
    }

    public void Drive()
    {
        Console.WriteLine("The car is driving...");
    }

    // Implement IFuelable methods
    public void Refuel(double liters)
    {
        fuelLevel += liters;
        Console.WriteLine($"Refueled {liters} liters. Current fuel level: {fuelLevel} liters.");
    }

    public double FuelLevel => fuelLevel;

    // Implement DisplayInfo method
    public override void DisplayInfo()
    {
        Console.WriteLine($"Car: {Make} {Model} ({Year})");
    }
}

// Concrete Class: Bike
public class Bike : Vehicle, IDriveable
{
    // Constructor
    public Bike(string make, string model, int year) : base(make, model, year) { }

    // Implement IDriveable methods
    public void StartEngine()
    {
        Console.WriteLine("The bike engine is starting...");
    }

    public void StopEngine()
    {
        Console.WriteLine("The bike engine is stopping...");
    }

    public void Drive()
    {
        Console.WriteLine("The bike is riding...");
    }

    // Implement DisplayInfo method
    public override void DisplayInfo()
    {
        Console.WriteLine($"Bike: {Make} {Model} ({Year})");
    }
}

// Concrete Class: Truck
public class Truck : Vehicle, IDriveable, IFuelable
{
    private double fuelLevel;

    // Constructor
    public Truck(string make, string model, int year) : base(make, model, year) { }

    // Implement IDriveable methods
    public void StartEngine()
    {
        Console.WriteLine("The truck engine is starting...");
    }

    public void StopEngine()
    {
        Console.WriteLine("The truck engine is stopping...");
    }

    public void Drive()
    {
        Console.WriteLine("The truck is driving...");
    }

    // Implement IFuelable methods
    public void Refuel(double liters)
    {
        fuelLevel += liters;
        Console.WriteLine($"Refueled {liters} liters. Current fuel level: {fuelLevel} liters.");
    }

    public double FuelLevel => fuelLevel;

    // Implement DisplayInfo method
    public override void DisplayInfo()
    {
        Console.WriteLine($"Truck: {Make} {Model} ({Year})");
    }
}

class Program
{
    static void Main()
    {
        // Car instance
        Car myCar = new Car("Toyota", "Camry", 2020);
        myCar.DisplayInfo();
        myCar.StartEngine();
        myCar.Drive();
        myCar.Refuel(40);
        Console.WriteLine($"Fuel Level: {myCar.FuelLevel} liters");
        myCar.StopEngine();

        Console.WriteLine();

        // Bike instance
        Bike myBike = new Bike("Yamaha", "MT-07", 2022);
        myBike.DisplayInfo();
        myBike.StartEngine();
        myBike.Drive();
        myBike.StopEngine();

        Console.WriteLine();

        // Truck instance
        Truck myTruck = new Truck("Volvo", "FH16", 2023);
        myTruck.DisplayInfo();
        myTruck.StartEngine();
        myTruck.Drive();
        myTruck.Refuel(150);
        Console.WriteLine($"Fuel Level: {myTruck.FuelLevel} liters");
        myTruck.StopEngine();
    }
}
