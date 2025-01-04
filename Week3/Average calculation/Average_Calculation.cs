using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ortalama Hesaplama Programına Hoş Geldiniz!");

        try
        {
            // Notları al
            Console.Write("Birinci notunuzu girin (0-100): ");
            double not1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İkinci notunuzu girin (0-100): ");
            double not2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Üçüncü notunuzu girin (0-100): ");
            double not3 = Convert.ToDouble(Console.ReadLine());

            // Notların geçerliliğini kontrol et
            if (not1 < 0 || not1 > 100 || not2 < 0 || not2 > 100 || not3 < 0 || not3 > 100)
            {
                Console.WriteLine("Hata: Notlar 0 ile 100 arasında olmalıdır.");
                return;
            }

            // Ortalama hesaplama
            double ortalama = (not1 + not2 + not3) / 3;
            Console.WriteLine($"\nOrtalamanız: {ortalama:F2}");

            // Harf notu ve mesaj belirleme
            string harfNotu = GetHarfNotu(ortalama);

            // Harf notuna göre ek mesaj belirleme
            string ekMesaj = GetEkMesaj(harfNotu);

            // Sonuçları yazdırma 
            Console.WriteLine($"Harf Notunuz: {harfNotu}");
            Console.WriteLine(ekMesaj);
        }
        catch (FormatException)
        {
            Console.WriteLine("Hata: Lütfen geçerli bir sayı girin.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Beklenmeyen bir hata oluştu: {ex.Message}");
        }

        Console.WriteLine("\nProgram sona erdi. Çıkmak için bir tuşa basın.");
        Console.ReadKey();
    }

    static string GetHarfNotu(double ortalama)
    {
        // Not aralıkları ve karşılık gelen harf notları
        var notlar = new (double min, double max, string harfNotu)[]
        {
            (90, 100, "AA"),
            (85, 89, "BA"),
            (80, 84, "BB"),
            (75, 79, "CB"),
            (70, 74, "CC"),
            (65, 69, "DC"),
            (60, 64, "DD"),
            (55, 59, "FD"),
            (0, 54, "FF")
        };

        // Uygun harf notunu döndür
        foreach (var (min, max, harfNotu) in notlar)
        {
            if (ortalama >= min && ortalama <= max)
            {
                return harfNotu;
            }
        }

        return "FF"; // Fallback (gerçekten bu durumu hiç görmemelisiniz, sadece güvenlik için)
    }

    static string GetEkMesaj(string harfNotu)
    {
        if (harfNotu == "AA")
        {
            return "Ajda Pekkan gibisin.";
        }
        else if (harfNotu == "BB" || harfNotu == "BA" || harfNotu == "AA")
        {
            return "Ajda Pekkan senin için gurur duyuyor.";
        }
        else if (harfNotu == "CB" || harfNotu == "CC" || harfNotu == "DC" || harfNotu == "DD")
        {
            return "Ajda Pekkan sana küsmüş, haberin olsun.";
        }
        else
        {
            return "Ajda Pekkan sana küfür edecek, kendini hazırla.";
        }
    }
}