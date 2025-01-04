using System;
using Internal;

class Program
{
    static void Main()
    {
        // Oyunu başlatan metot çağrılıyor
        RastgeleSayiBulmaOyunu();
    }

    static void RastgeleSayiBulmaOyunu()
    {
        Random random = new Random();
        int hedefSayi = random.Next(1, 101); // 1 ile 100 arasında rastgele bir sayı
        int tahminHakki = 5; // Kullanıcının toplam hakkı
        int tahmin;

        Console.WriteLine("Rastgele Sayı Bulma Oyununa Hoş Geldiniz!");
        Console.WriteLine("Bilgisayar 1 ile 100 arasında bir sayı tuttu. 5 hakkınız var!");

        for (int hak = tahminHakki; hak > 0; hak--)
        {
            Console.Write($"\n{hak} hakkınız kaldı. Tahmininizi girin: ");

            // Kullanıcıdan tahmini al
            if (int.TryParse(Console.ReadLine(), out tahmin))
            {
                if (tahmin == hedefSayi)
                {
                    Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");
                    return; // Oyunu bitir
                }
                else if (tahmin < hedefSayi)
                {
                    Console.WriteLine("Yukarı!");
                }
                else
                {
                    Console.WriteLine("Aşağı!");
                }
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir sayı girin.");
            }
        }

        Console.WriteLine($"\nMaalesef hakkınız bitti. Doğru sayı: {hedefSayi}");
    }
}
