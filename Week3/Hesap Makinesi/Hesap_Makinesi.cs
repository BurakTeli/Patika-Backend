using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hesap Makinesi Uygulamasına Hoş Geldiniz!");

        try
        {
            // Kullanıcıdan ilk sayıyı al
            Console.Write("Birinci sayıyı girin: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            // Kullanıcıdan ikinci sayıyı al
            Console.Write("İkinci sayıyı girin: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            // İşlem seçeneklerini göster
            Console.WriteLine("\nYapmak istediğiniz işlemi seçin:");
            Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Çıkarma");
            Console.WriteLine("3 - Çarpma");
            Console.WriteLine("4 - Bölme");
            Console.WriteLine("5 - Karesini Alma (Birinci Sayının)");

            // Kullanıcıdan işlem seçimi al
            Console.Write("Seçiminizi yapın (1-5): ");
            int secim = Convert.ToInt32(Console.ReadLine());

            // İşlemi gerçekleştirme
            switch (secim)
            {
                case 1:
                    Console.WriteLine($"Sonuç: {sayi1} + {sayi2} = {sayi1 + sayi2}");
                    break;
                case 2:
                    Console.WriteLine($"Sonuç: {sayi1} - {sayi2} = {sayi1 - sayi2}");
                    break;
                case 3:
                    Console.WriteLine($"Sonuç: {sayi1} * {sayi2} = {sayi1 * sayi2}");
                    break;
                case 4:
                    if (sayi2 != 0)
                    {
                        Console.WriteLine($"Sonuç: {sayi1} / {sayi2} = {(double)sayi1 / sayi2}");
                    }
                    else
                    {
                        Console.WriteLine("Hata: Sıfıra bölme işlemi yapılamaz.");
                    }
                    break;
                case 5:
                    Console.WriteLine($"Sonuç: {sayi1}^2 = {sayi1 * sayi1}");
                    break;
                default:
                    Console.WriteLine("Hatalı bir seçim yaptınız. Lütfen 1-5 arasında bir değer girin.");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Hata: Lütfen geçerli bir sayı girin.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Beklenmeyen bir hata oluştu: {ex.Message}");
        }

        Console.WriteLine("Program sona erdi. Çıkmak için bir tuşa basın.");
        Console.ReadKey();
    }
}
