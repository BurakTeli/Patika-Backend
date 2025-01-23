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
}

public class ComedyTVShow
{
    public string ShowName { get; set; }
    public string ShowType { get; set; }
    public string Director { get; set; }

    // Constructor to create a comedy TV show object
    public ComedyTVShow(string showName, string showType, string director)
    {
        ShowName = showName;
        ShowType = showType;
        Director = director;
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

        // Filter comedy TV shows
        List<ComedyTVShow> comedyShows = tvShows
            .Where(show => show.ShowType.ToLower().Contains("comedy"))
            .Select(show => new ComedyTVShow(show.ShowName, show.ShowType, show.Director))
            .ToList();

        // Sort the comedy TV shows by name and director
        var sortedComedyShows = comedyShows
            .OrderBy(show => show.ShowName)
            .ThenBy(show => show.Director)
            .ToList();

        // Print the sorted comedy TV shows
        Console.WriteLine("\nComedy TV Shows:");
        foreach (var show in sortedComedyShows)
        {
            Console.WriteLine($"Show Name: {show.ShowName}, Show Type: {show.ShowType}, Director: {show.Director}");
        }
    }
}
