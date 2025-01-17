using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Hoşgeldiniz mesajı
        Console.WriteLine("Patika Plus Gala Gecesine Hoşgeldiniz.");

        // Davetlilerin isimlerini içeren bir liste oluşturuluyor
        List<string> davetliler = new List<string>
        {
            "Bülent Ersoy",
            "Ajda Pekkan",
            "Ebru Gündes",
            "Hadise",
            "Hande Yener",
            "Tarkan",
            "Funda Arar",
            "Demet Akalin"
        };

        // Başlık yazdırma
        Console.WriteLine("** Davetliler: ** ");

        // foreach döngüsü ile davetlilerin isimlerini ekrana yazdırma
        foreach (string davetli in davetliler)
        {
            Console.WriteLine(davetli);
        }
    }
}
