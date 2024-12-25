using System;

class Program
{
    static void Main()
    {
        // 1. Görev
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
        }

        Console.WriteLine("--------------------------------");

        // 2. Görev
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("--------------------------------");

        // 3. Görev
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("--------------------------------");

        // 4. Görev
        int toplam = 0;

        for (int i = 50; i <= 150; i++)
        {
            toplam += i;
        }
        Console.WriteLine($"50 ile 150 arasındaki sayıların toplamı: {toplam}");

        Console.WriteLine("--------------------------------");

        // 5. Görev
        int toplamCift = 0;
        int toplamTek = 0;

        // 1 ile 120 arasındaki sayıları döngü ile kontrol et
        for (int i = 1; i <= 120; i++)
        {
            if (i % 2 == 0) // Çift sayıları kontrol et
            {
                toplamCift += i; // Çift sayıları toplamCift'e ekle
            }
            else // Tek sayıları kontrol et
            {
                toplamTek += i; // Tek sayıları toplamTek'e ekle
            }
        }

        // Çift ve tek sayıların toplamını sadece bir kez ekrana yazdır
        Console.WriteLine($"1 ile 120 arasındaki çift sayıların toplamı: {toplamCift}");
        Console.WriteLine($"1 ile 120 arasındaki tek sayıların toplamı: {toplamTek}");
    }
}
