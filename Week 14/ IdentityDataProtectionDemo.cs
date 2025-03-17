using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

// User model with validation
public class User
{
    public int Id { get; set; }
    
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    
    [Required]
    public string PasswordHash { get; set; }
}

// Database context using Entity Framework Core
public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=users.db");
    }
}

// Service for handling user registration and password hashing
public class UserService
{
    private readonly AppDbContext _context;
    
    public UserService(AppDbContext context)
    {
        _context = context;
    }

    public async Task RegisterUserAsync(string email, string password)
    {
        var hashedPassword = HashPassword(password);
        var user = new User { Email = email, PasswordHash = hashedPassword };
        
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
    }

    // Hash password using ASP.NET Core Data Protection approach
    private string HashPassword(string password)
    {
        byte[] salt = new byte[16];
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(salt);
        }
        
        string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 10000,
            numBytesRequested: 32));
        
        return Convert.ToBase64String(salt) + ":" + hashed;
    }
}

// Main entry point to set up the database and register users
public class Program
{
    public static async Task Main(string[] args)
    {
        using var context = new AppDbContext();
        await context.Database.MigrateAsync();
        
        var userService = new UserService(context);
        
        await userService.RegisterUserAsync("user@example.com", "password123");
        await userService.RegisterUserAsync("admin@example.com", "adminpassword");
        
        Console.WriteLine("Users successfully registered and stored in database.");
    }
}
