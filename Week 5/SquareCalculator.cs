using System;

class Program
{
    static void Main()
    {
        try
        {
            // Ask the user to enter a number
            Console.Write("Please enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());
            
            // Calculate the square of the number
            double square = number * number;
            
            // Display the result
            Console.WriteLine($"The square of the entered number is: {square}");
        }
        catch (FormatException)
        {
            // Display error message for invalid input
            Console.WriteLine("Invalid input! Please enter a valid number.");
        }
    }
}
