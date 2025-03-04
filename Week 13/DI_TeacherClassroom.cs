using System;
using Microsoft.Extensions.DependencyInjection;

// Base interface for Teacher
public interface IOgretmen
{
    string GetInfo();
}

// Teacher class implementing IOgretmen interface
public class Teacher : IOgretmen
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Constructor to initialize teacher properties
    public Teacher(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    // Returns teacher's full name
    public string GetInfo()
    {
        return $"Teacher: {FirstName} {LastName}";
    }
}

// ClassRoom class that depends on IOgretmen
public class ClassRoom
{
    private readonly IOgretmen _teacher;

    // Constructor Injection - Teacher dependency is injected via constructor
    public ClassRoom(IOgretmen teacher)
    {
        _teacher = teacher;
    }

    // Returns the teacher's info
    public void GetTeacherInfo()
    {
        Console.WriteLine(_teacher.GetInfo());
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Setting up Dependency Injection container
        var serviceProvider = new ServiceCollection()
            .AddScoped<IOgretmen>(sp => new Teacher("John", "Doe")) // Scoped lifetime for Teacher
            .AddScoped<ClassRoom>() // ClassRoom will use the same teacher instance in the same scope
            .BuildServiceProvider();

        // Resolving the ClassRoom dependency
        var classRoom = serviceProvider.GetRequiredService<ClassRoom>();

        // Display teacher info
        classRoom.GetTeacherInfo();
    }
}
