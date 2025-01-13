using System;

public class BaseKisi
{
    public string Ad { get; set; } // Property for First Name
    public string Soyad { get; set; } // Property for Last Name

    public void Yazdir()
    {
        // Method to print First Name and Last Name to the console
        Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}");
    }
}

public class Ogrenci : BaseKisi
{
    public string OgrenciNo { get; set; } // Property for Student Number

    public void Yazdir()
    {
        // Method to print Student Number, First Name, and Last Name to the console
        Console.WriteLine($"Öğrenci No: {OgrenciNo}, Ad: {Ad}, Soyad: {Soyad}");
    }
}

public class Ogretmen : BaseKisi
{
    public decimal Maas { get; set; } // Property for Salary

    public void Yazdir()
    {
        // Method to print Salary, First Name, and Last Name to the console
        Console.WriteLine($"Maaş: {Maas}, Ad: {Ad}, Soyad: {Soyad}");
    }
}

public class Program
{
    public static void Main()
    {
        // Creating a Student object and assigning values
        Ogrenci ogrenci = new Ogrenci
        {
            Ad = "Ali", // First Name
            Soyad = "Veli", // Last Name
            OgrenciNo = "12345" // Student Number
        };
        
        // Calling the Yazdir method to print the student's information
        ogrenci.Yazdir();

        // Creating a Teacher object and assigning values
        Ogretmen ogretmen = new Ogretmen
        {
            Ad = "Ayşe", // First Name
            Soyad = "Kara", // Last Name
            Maas = 5000m // Salary
        };
        
        // Calling the Yazdir method to print the teacher's information
        ogretmen.Yazdir();
    }
}
