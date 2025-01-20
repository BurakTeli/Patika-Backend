using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Define the list to store coffee names
        List<string> coffeeList = new List<string>();

        Console.WriteLine("Please enter 5 coffee names:");

        // Get coffee names from the user
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Coffee {i + 1}: ");
            string coffeeName = Console.ReadLine();
            coffeeList.Add(coffeeName);
        }

        Console.WriteLine("\nEntered Coffee Names:");

        // Display the coffee names using a foreach loop
        int count = 1;
        foreach (string coffee in coffeeList)
        {
            Console.WriteLine($"Coffee {count}: {coffee}");
            count++;
        }
    }
}
