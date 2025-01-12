using System;

class Araba
{
    // Özellikler
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }

    private int _kapiSayisi;

    public int KapiSayisi
    {
        get { return _kapiSayisi; }
        set
        {
            if (value == 2 || value == 4)
            {
                _kapiSayisi = value;
            }
            else
            {
                Console.WriteLine("Geçersiz Kapı Sayısı! Kapı Sayısı 2 veya 4 olmalıdır.");
                _kapiSayisi = -1;
            }
        }
    }

    // Constructor
    public Araba(string marka, string model, string renk, int kapiSayisi)
    {
        Marka = marka;
        Model = model;
        Renk = renk;
        KapiSayisi = kapiSayisi;
    }

    // Bilgileri Yazdırma Metodu
    public void BilgileriYazdir()
    {
        Console.WriteLine($"Marka : {Marka}");
        Console.WriteLine($"Model : {Model}");
        Console.WriteLine($"Renk : {Renk}");
        Console.WriteLine($"Kapı Sayısı : {KapiSayisi}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Geçerli Kapı Sayısı
        Araba araba1 = new Araba("Toyota", "Corolla", "Beyaz", 4);
        araba1.BilgileriYazdir();

        Console.WriteLine(); // Çıktılar arasında boşluk bırakmak için

        // Geçersiz Kapı Sayısı
        Araba araba2 = new Araba("BMW", "3 Serisi", "Siyah", 3);
        araba2.BilgileriYazdir();
    }
}
