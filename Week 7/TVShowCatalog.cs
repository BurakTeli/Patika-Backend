using System;
using System.Collections.Generic;
using System.Linq;

public class TVShow
{
    public string ShowName { get; set; }
    public int Year { get; set; }
    public string ShowType { get; set; }
    public string Director { get; set; }
    public string FirstBroadcastPlatform { get; set; }
    public int StartYear { get; set; }

    // Constructor to create a new TV show object
    public TVShow(string showName, int year, string showType, string director, string firstBroadcastPlatform, int startYear)
    {
        ShowName = showName;
        Year = year;
        ShowType = showType;
        Director = director;
        FirstBroadcastPlatform = firstBroadcastPlatform;
        StartYear = startYear;
    }

    // Override ToString() to print TV show details
    public override string ToString()
    {
        return $"{ShowName} ({ShowType}) - Director: {Director}, Start Year: {StartYear}";
    }
}

class Program
{
    static void Main()
    {
        // Adding the provided TV shows to the list
        List<TVShow> tvShows = new List<TVShow>
        {
            new TVShow("Avrupa Yakası", 2004, "Comedy", "Yüksel Aksu", "Kanal D", 2004),
            new TVShow("Yalan Dünya", 2012, "Comedy", "Gülseren Buda Baskaya", "Fox TV", 2012),
            new TVShow("Jet Sosyete", 2018, "Comedy", "Gülseren Buda Baskaya", "TV8", 2018),
            new TVShow("Dadi", 2006, "Comedy", "Yusuf Pirhasan", "Kanal D", 2006),
            new TVShow("Belali Baldiz", 2007, "Comedy", "Yüksel Aksu", "Kanal D", 2007),
            new TVShow("Arka Sokaklar", 2004, "Police, Drama", "Orhan Oguz", "Kanal D", 2004),
            new TVShow("Ask-i Memnu", 2008, "Drama, Romance", "Hilal Saral", "Kanal D", 2008),
            new TVShow("Muhtesem Yüzyıl", 2011, "Historical, Drama", "Mercan Cilingiroglu", "Star TV", 2011),
            new TVShow("Yaprak Dökümü", 2006, "Drama", "Serdar Akar", "Kanal D", 2006)
        };

        // Filtering comedy TV shows
        var comedyShows = tvShows.Where(show => show.ShowType.ToLower().Contains("comedy")).ToList();
        PrintList(comedyShows);

        // Filtering TV shows that started after 2010
        var showsAfter2010 = tvShows.Where(show => show.StartYear > 2010).ToList();
        PrintList(showsAfter2010);

        // Sorting TV shows by year and director
        var sortedByYearAndDirector = tvShows.OrderBy(show => show.StartYear).ThenBy(show => show.Director).ToList();
        PrintList(sortedByYearAndDirector);

        // Finding the TV show with the earliest start year
        var earliestStartYearShow = tvShows.OrderBy(show => show.StartYear).First();
        Console.WriteLine("\nTV Show with the earliest start year:");
        Console.WriteLine(earliestStartYearShow);
        Console.WriteLine("----------");

        // Finding the TV show with the latest start year
        var latestStartYearShow = tvShows.OrderByDescending(show => show.StartYear).First();
        Console.WriteLine("\nTV Show with the latest start year:");
        Console.WriteLine(latestStartYearShow);
        Console.WriteLine("----------");
    }

    // Method to print the contents of a list
    static void PrintList<T>(List<T> list)
    {
        // Check if the list has any elements
        if (list.Any())
        {
            // Print each element in the list
            list.ForEach(x => Console.WriteLine(x));
        }
        else
        {
            // Print a message if the list is empty
            Console.WriteLine("Listede eleman bulunamadı!");
        }

        // Print a separator line
        Console.WriteLine("----------");
    }
}
