using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Average Calculation Program!");

        try
        {
            // Get the grades from the user
            Console.Write("Enter your first grade (0-100): ");
            double grade1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your second grade (0-100): ");
            double grade2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your third grade (0-100): ");
            double grade3 = Convert.ToDouble(Console.ReadLine());

            // Validate the grades
            if (grade1 < 0 || grade1 > 100 || grade2 < 0 || grade2 > 100 || grade3 < 0 || grade3 > 100)
            {
                Console.WriteLine("Error: Grades must be between 0 and 100.");
                return;
            }

            // Calculate the average using double type
            double average = (grade1 + grade2 + grade3) / 3;
            Console.WriteLine($"\nYour average: {average:F2}");

            // Determine the letter grade and message
            string letterGrade = GetLetterGrade(average);

            // Get the additional message based on the letter grade
            string additionalMessage = GetAdditionalMessage(letterGrade);

            // Print the results
            Console.WriteLine($"Your Letter Grade: {letterGrade}");
            Console.WriteLine(additionalMessage);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid number.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }

        Console.WriteLine("\nThe program has ended. Press any key to exit.");
        Console.ReadKey();
    }

    static string GetLetterGrade(double average)
    {
        // Define grade ranges and corresponding letter grades
        var grades = new (double min, double max, string letterGrade)[]
        {
            (90, 100, "AA"),
            (85, 89, "BA"),
            (80, 84, "BB"),
            (75, 79, "CB"),
            (70, 74, "CC"),
            (65, 69, "DC"),
            (60, 64, "DD"),
            (55, 59, "FD"),
            (0, 54, "FF")
        };

        // Return the appropriate letter grade based on the average
        foreach (var (min, max, letterGrade) in grades)
        {
            if (average >= min && average <= max)
            {
                return letterGrade;
            }
        }

        return "FF"; // Fallback (this case should never occur, added for safety)
    }

    static string GetAdditionalMessage(string letterGrade)
    {
        // Return an appropriate message based on the letter grade
        if (letterGrade == "AA")
        {
            return "Ajda Pekkan gibisin.;
        }
        else if (letterGrade == "BB" || letterGrade == "BA" || letterGrade == "AA")
        {
            return "Ajda Pekkan senin için gurur duyuyor.";
        }
        else if (letterGrade == "CB" || letterGrade == "CC" || letterGrade == "DC" || letterGrade == "DD")
        {
            return "Ajda Pekkan sana küsmüş, haberin olsun.";
        }
        else
        {
            return "Ajda Pekkan sana küfür edecek, kendini hazırla.";
        }
    }
}
