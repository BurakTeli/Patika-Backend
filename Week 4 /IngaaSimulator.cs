using System;

class Bebek
{
    // Property'ler
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public DateTime DogumTarihi { get; private set; }

    // 1. Default Constructor
    public Bebek()
    {
        DogumTarihi = DateTime.Now; // O anki tarih ve saat
        Console.WriteLine("Ingaaaa (Default Constructor)");
    }

    // 2. Parametreli Constructor
    public Bebek(string ad, string soyad)
    {
        Ad = ad;
        Soyad = soyad;
        DogumTarihi = DateTime.Now; // O anki tarih ve saat
        Console.WriteLine("Ingaaaa (Parametreli Constructor)");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Default Constructor ile nesne oluşturma
        Bebek bebek1 = new Bebek();
        Console.WriteLine($"Bebek 1 -> Ad: {bebek1.Ad}, Soyad: {bebek1.Soyad}, Doğum Tarihi: {bebek1.DogumTarihi}");

        // Parametreli Constructor ile nesne oluşturma
        Bebek bebek2 = new Bebek("Ali", "Veli");
        Console.WriteLine($"Bebek 2 -> Ad: {bebek2.Ad}, Soyad: {bebek2.Soyad}, Doğum Tarihi: {bebek2.DogumTarihi}");
    }
}
