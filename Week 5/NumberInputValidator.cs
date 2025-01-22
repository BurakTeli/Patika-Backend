using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Welcome message to the user
        Console.WriteLine("This program requires you to enter a number within a specific range.");
        Console.WriteLine("If you don't want to continue, type 'exit' to quit.");

        // Define the range for valid numbers
        int min = 1; // Minimum allowed value
        int max = 100; // Maximum allowed value
        bool isValidInput = false; // Flag to track if valid input has been received

        while (!isValidInput)
        {
            // Prompt the user to enter a number
            Console.WriteLine($"Please enter a number between {min} and {max}:");

            // Read user input
            string input = Console.ReadLine();

            // Check if the user wants to exit
            if (input?.ToLower() == "exit")
            {
                Console.WriteLine("Exiting the program. Have a great day!");
                break; // Exit the loop and terminate the program
            }

            try
            {
                // Try to convert the input to an integer
                int number = Convert.ToInt32(input);

                // Check if the number is within the valid range
                if (number >= min && number <= max)
                {
                    Console.WriteLine($"Congratulations! {number} is a valid number.");
                    isValidInput = true; // Set the flag to true to exit the loop
                }
                else
                {
                    // Inform the user that the number is out of range
                    Console.WriteLine($"Error: Please enter a number between {min} and {max}.");
                }
            }
            catch (FormatException)
            {
                // Handle cases where the input is not a valid number
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            catch (Exception ex)
            {
                // Handle unexpected errors
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                // Notify the user that the process is complete, regardless of success or failure
                Console.WriteLine("Operation completed.");
            }
        }
    }
}
