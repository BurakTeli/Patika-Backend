ausing System;

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
            string harfNotu = GetHarfNotu(ortalama, out string mesaj);

            // Harf notuna göre ek mesaj belirleme
            string ekMesaj = GetEkMesaj(harfNotu);

            // Sonuçları yazdırma 
            Console.WriteLine($"Harf Notunuz: {harfNotu}");
            Console.WriteLine(mesaj);
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

    static string GetHarfNotu(double ortalama, out string mesaj)
    {
        switch (ortalama)
        {
            case >= 90:
                mesaj = "Ajda Pekkan senle çok gurur duyardı.";
                return "AA";
            case >= 85:
                mesaj = "Ajda Pekkan gibisin, gurur duyardı.";
                return "BA";
            case >= 80:
                mesaj = "Ajda Pekkan sevindi.";
                return "BB";
            case >= 75:
                mesaj = "Ajda Pekkan ne diyeceğini bilemedi.";
                return "CB";
            case >= 70:
                mesaj = "Ajda Pekkan üzgün.";
                return "CC";
            case >= 65:
                mesaj = "Ajda Pekkan üzgün.";
                return "DC";
            case >= 60:
                mesaj = "Ajda Pekkan küfür edecek.";
                return "DD";
            case >= 55:
                mesaj = "Ajda Pekkan ...........";
                return "FD";
            default:
                mesaj = "Ajda Pekkan ...........";
                return "FF";
        }
    }

    static string GetEkMesaj(string harfNotu)
    {
        switch (harfNotu)
        {
            case "BB":
            case "BA":
            case "AA":
                return "Ajda Pekkan senin için gurur duyuyor.";
            case "CB":
            case "CC":
            case "DC":
            case "DD":
                return "Ajda Pekkan sana küsmüş, haberin olsun.";
            default:
                return "Ajda Pekkan sana küfür edecek, kendini hazırla.";
        }
    }
}
