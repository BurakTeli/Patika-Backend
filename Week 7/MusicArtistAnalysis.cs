using System;
using System.Collections.Generic;
using System.Linq;

// Class to represent each artist
class Artist
{
    public string Name { get; set; }
    public string MusicGenre { get; set; }
    public int DebutYear { get; set; }
    public long AlbumSales { get; set; }

    // Constructor to initialize an artist object
    public Artist(string name, string musicGenre, int debutYear, long albumSales)
    {
        Name = name;
        MusicGenre = musicGenre;
        DebutYear = debutYear;
        AlbumSales = albumSales;
    }
}

class Program
{
    static void Main()
    {
        // List to hold all artist objects
        List<Artist> artists = new List<Artist>
        {
            new Artist("Ajda Pekkan", "Pop", 1968, 20000000),
            new Artist("Sezen Aksu", "Turkish Folk Music / Pop", 1971, 10000000),
            new Artist("Funda Arar", "Pop", 1999, 3000000),
            new Artist("Sertab Erener", "Pop", 1994, 5000000),
            new Artist("Sila", "Pop", 2009, 3000000),
            new Artist("Serdar Ortaç", "Pop", 1994, 10000000),
            new Artist("Tarkan", "Pop", 1992, 40000000),
            new Artist("Hande Yener", "Pop", 1999, 7000000),
            new Artist("Hadise", "Pop", 2005, 5000000),
            new Artist("Gülben Ergen", "Pop", 1997, 10000000),
            new Artist("Neset Ertas", "Turkish Folk Music / Turkish Classical Music", 1960, 2000000)
        };

        // Artists whose name starts with 'S'
        var artistsWithS = artists.Where(a => a.Name.StartsWith("S")).ToList();
        Console.WriteLine("Artists whose name starts with 'S':");
        foreach (var artist in artistsWithS)
        {
            Console.WriteLine(artist.Name);
        }

        // Artists with album sales over 10 million
        var salesOver10Million = artists.Where(a => a.AlbumSales > 10000000).ToList();
        Console.WriteLine("\nArtists with album sales over 10 million:");
        foreach (var artist in salesOver10Million)
        {
            Console.WriteLine(artist.Name);
        }

        // Artists who debuted before 2000 and make pop music
        var popArtistsBefore2000 = artists.Where(a => a.DebutYear < 2000 && a.MusicGenre.Contains("Pop"))
                                          .OrderBy(a => a.DebutYear)
                                          .ThenBy(a => a.Name)
                                          .ToList();
        Console.WriteLine("\nArtists who debuted before 2000 and make pop music:");
        foreach (var artist in popArtistsBefore2000)
        {
            Console.WriteLine($"{artist.Name} ({artist.DebutYear})");
        }

        // Artist with the highest album sales
        var topSeller = artists.OrderByDescending(a => a.AlbumSales).First();
        Console.WriteLine($"\nArtist with the highest album sales: {topSeller.Name} ({topSeller.AlbumSales} albums)");

        // The most recent and the oldest debuting artist
        var mostRecent = artists.OrderByDescending(a => a.DebutYear).First();
        var oldest = artists.OrderBy(a => a.DebutYear).First();
        Console.WriteLine($"\nMost recent debuting artist: {mostRecent.Name} ({mostRecent.DebutYear})");
        Console.WriteLine($"Oldest debuting artist: {oldest.Name} ({oldest.DebutYear})");
    }
}
