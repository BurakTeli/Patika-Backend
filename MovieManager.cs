using System;
using System.Collections.Generic;

class Movie
{
    // Movie properties
    public double ImdbRating { get; set; }
    public string Name { get; set; }

    // Constructor to initialize the movie object
    public Movie(string name, double imdbRating)
    {
        Name = name;
        ImdbRating = imdbRating;
    }
}

class Program
{
    static void Main()
    {
        // List to store the movies
        List<Movie> movieList = new List<Movie>
        {
            new Movie("The Shawshank Redemption", 9.3),
            new Movie("The Godfather", 9.2),
            new Movie("The Dark Knight", 9.0),
            new Movie("Pulp Fiction", 8.9),
            new Movie("Forrest Gump", 8.8)
        };

        string addAnotherMovie = "y"; // Variable to control the loop

        // Loop to allow the user to enter unlimited number of movies
        while (addAnotherMovie.ToLower() == "y")
        {
            // Ask the user for movie name and IMDB rating
            Console.Write("Enter the movie name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the IMDB rating: ");
            double imdbRating = Convert.ToDouble(Console.ReadLine());

            // Create a new movie object and add it to the list
            movieList.Add(new Movie(name, imdbRating));

            // Ask the user if they want to add another movie
            Console.Write("Do you want to add another movie? (y/h): ");
            addAnotherMovie = Console.ReadLine();
        }

        // Display all movies
        Console.WriteLine("\nAll Movies:");
        foreach (var movie in movieList)
        {
            Console.WriteLine($"Movie Name: {movie.Name}, IMDB Rating: {movie.ImdbRating}");
        }

        // Display movies with IMDB rating between 4 and 9
        Console.WriteLine("\nMovies with IMDB Rating between 4 and 9:");
        foreach (var movie in movieList)
        {
            if (movie.ImdbRating >= 4 && movie.ImdbRating <= 9)
            {
                Console.WriteLine($"Movie Name: {movie.Name}, IMDB Rating: {movie.ImdbRating}");
            }
        }

        // Display movies whose name starts with 'A'
        Console.WriteLine("\nMovies whose name starts with 'A':");
        foreach (var movie in movieList)
        {
            if (movie.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Movie Name: {movie.Name}, IMDB Rating: {movie.ImdbRating}");
            }
        }
    }
}
