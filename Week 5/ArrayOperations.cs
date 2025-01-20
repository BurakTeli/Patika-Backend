using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Step 1: Define an array to hold 10 integers
        List<int> numbers = new List<int>();

        // Step 2: Fill the array with numbers and display them using a foreach loop
        Console.WriteLine("Please enter 10 integers:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Number {i + 1}: ");
            int number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        Console.WriteLine("\nEntered numbers:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        // Step 3: Add a new value (11th element) to the array from user input
        Console.Write("\nEnter a number to add to the array (11th element): ");
        int newNumber = int.Parse(Console.ReadLine());
        numbers.Add(newNumber);

        // Step 4: Sort the array in descending order and display it
        numbers.Sort(); // Sorts the list in ascending order
        numbers.Reverse(); // Reverses the list to make it descending

        Console.WriteLine("\nArray sorted in descending order:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
