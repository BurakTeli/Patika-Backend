using System;
using System.Collections.Generic;

class Car
{
    public DateTime ProductionDate { get; private set; }
    public string SerialNumber { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int DoorCount { get; set; }

    // Constructor initializes the production date to the current time
    public Car()
    {
        ProductionDate = DateTime.Now;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>(); // List to store all created cars

        while (true)
        {
            // Ask the user if they want to produce a car
            Console.Write("Do you want to produce a car? (y/n): ");
            string response = Console.ReadLine().Trim().ToLower();

            if (response == "n")
            {
                // Exit the program if the user does not want to produce a car
                break;
            }
            else if (response == "y")
            {
                // Create a new car object
                Car newCar = new Car();

                // Get car details from the user
                Console.Write("Serial Number: ");
                newCar.SerialNumber = Console.ReadLine();

                Console.Write("Brand: ");
                newCar.Brand = Console.ReadLine();

                Console.Write("Model: ");
                newCar.Model = Console.ReadLine();

                Console.Write("Color: ");
                newCar.Color = Console.ReadLine();

                // Get the number of doors and validate the input
                while (true)
                {
                    Console.Write("Number of Doors: ");
                    string doorCountInput = Console.ReadLine();

                    try
                    {
                        newCar.DoorCount = int.Parse(doorCountInput); // Try to parse the input to an integer
                        break; // Exit the loop if the input is valid
                    }
                    catch (FormatException)
                    {
                        // Handle invalid input and prompt the user again
                        Console.WriteLine("Invalid input! Please enter a numeric value.");
                    }
                }

                // Add the new car to the list
                cars.Add(newCar);
                Console.WriteLine("Car successfully produced!\n");

                // Ask the user if they want to produce another car
                Console.Write("Do you want to produce another car? (y/n): ");
                string continueResponse = Console.ReadLine().Trim().ToLower();
                if (continueResponse == "n")
                {
                    break;
                }
            }
            else
            {
                // Inform the user about invalid input
                Console.WriteLine("Invalid response! Please enter 'y' or 'n'.\n");
            }
        }

        // Display all produced cars
        Console.WriteLine("\nProduced cars:");
        foreach (var car in cars)
        {
            Console.WriteLine($"Serial Number: {car.SerialNumber}, Brand: {car.Brand}");
        }

        Console.WriteLine("\nProgram terminated.");
    }
}
