using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Burak manava hoş geldiniz");
        Console.WriteLine("Elma = 2 TL");
        Console.WriteLine("Armut = 3 TL");
        Console.WriteLine("Çilek = 4 Tl");
        Console.WriteLine("Muz = 3 Tl");


        Console.Write("Hangi meyveyi satın almak istersiniz? (Elma/Armut/Çilek/Muz/Diğer):");
        string friut = Console.ReadLine();

        int price;

        switch (friut.ToLower())
        {
            case "elma":
                price = 2;
                break;
            case "armut":
                price = 3;
                break;
            case "çilek":
                price = 4;
                break;
            case "muz":
                price = 3;
                break;
            default:
                price = 4;
                break;
        }

        Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {price} TL");
    }
}