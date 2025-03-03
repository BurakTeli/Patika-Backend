using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main()
    {
        using (var context = new PatikaFirstDbContext())
        {
            context.Database.Migrate(); // Veritabanını oluştur ve güncelle

            // Örnek veri ekleme
            if (!context.Movies.Any())
            {
                context.Movies.Add(new Movie { Title = "Inception", Genre = "Sci-Fi", ReleaseYear = 2010 });
            }

            if (!context.Games.Any())
            {
                context.Games.Add(new Game { Name = "The Witcher 3", Platform = "PC", Rating = 9.8m });
            }

            context.SaveChanges();

            Console.WriteLine("Veritabanı başarıyla oluşturuldu ve veriler eklendi.");
        }
    }
}

// Film (Movie) Modeli
public class Movie
{
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    [Required]
    public string Genre { get; set; }

    public int ReleaseYear { get; set; }
}

// Oyun (Game) Modeli
public class Game
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Platform { get; set; }

    [Range(0, 10)]
    public decimal Rating { get; set; }
}

// DbContext (Veritabanı Bağlantısı)
public class PatikaFirstDbContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Game> Games { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=PatikaCodeFirstDb1;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
