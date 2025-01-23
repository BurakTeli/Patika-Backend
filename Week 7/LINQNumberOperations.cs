using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create a list of 10 random numbers
        Random rand = new Random();
        List<int> numbers = Enumerable.Range(0, 10).Select(_ => rand.Next(-50, 50)).ToList();

        // Print the generated list of numbers
        Console.WriteLine("List: " + string.Join(", ", numbers));

        // Find and print even numbers
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));

        // Find and print odd numbers
        var oddNumbers = numbers.Where(n => n % 2 != 0);
        Console.WriteLine("Odd numbers: " + string.Join(", ", oddNumbers));

        // Find and print negative numbers
        var negativeNumbers = numbers.Where(n => n < 0);
        Console.WriteLine("Negative numbers: " + string.Join(", ", negativeNumbers));

        // Find and print positive numbers
        var positiveNumbers = numbers.Where(n => n > 0);
        Console.WriteLine("Positive numbers: " + string.Join(", ", positiveNumbers));

        // Find and print numbers greater than 15 and less than 22
        var between15and22 = numbers.Where(n => n > 15 && n < 22);
        Console.WriteLine("Numbers greater than 15 and less than 22: " + string.Join(", ", between15and22));

        // Find and print the square of each number
        var squares = numbers.Select(n => n * n).ToList();
        Console.WriteLine("Squares of each number: " + string.Join(", ", squares));
    }
}
