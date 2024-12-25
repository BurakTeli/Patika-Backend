using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            // 1. Kullanıcıdan gitmek istediği lokasyonu alıyoruz
            Console.WriteLine("Lütfen gitmek istediğiniz lokasyonu giriniz: BODRUM, MARMARİS, ÇEŞME");
            string lokasyon = Console.ReadLine().Trim().ToUpper();

            // Lokasyon doğrulaması
            while (lokasyon != "BODRUM" && lokasyon != "MARMARİS" && lokasyon != "ÇEŞME")
            {
                Console.WriteLine("Listede olmayan lokasyon girdiniz\n");
                Console.WriteLine("BODRUM , ÇEŞME , MARMARİS");
                lokasyon = Console.ReadLine().Trim().ToUpper(); // Burada kullanıcıdan yeni bir lokasyon alıyoruz
            }

            // 2. Kullanıcıdan kişi sayısını alıyoruz
            Console.WriteLine("Kaç kişi için tatil planlamak istiyorsunuz?");
            int kisiSayisi;
            while (int.TryParse(Console.ReadLine(), out kisiSayisi) == false || kisiSayisi <= 0)
            {
                Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir sayı giriniz.");
            }

            // 3. Lokasyon bilgilerini ekrana yazdırıyoruz
            int paketFiyati = 0;
            string lokasyonOzeti = "";
            switch (lokasyon)
            {
                case "BODRUM":
                    paketFiyati = 4000;
                    lokasyonOzeti = "Bodrum'da tatil yaparak, güzel plajlar ve gece hayatı ile keyifli bir tatil geçirebilirsiniz.";
                    break;
                case "MARMARİS":
                    paketFiyati = 3000;
                    lokasyonOzeti = "Marmaris'te, doğa ile iç içe bir tatil yapabilir, deniz ve orman gezileri yapabilirsiniz.";
                    break;
                case "ÇEŞME":
                    paketFiyati = 5000;
                    lokasyonOzeti = "Çeşme'de denizin ve güneşin tadını çıkarabilir, popüler plajları keşfedebilirsiniz.";
                    break;
            }
            Console.WriteLine($"Seçtiğiniz lokasyon: {lokasyon.ToUpper()}");
            Console.WriteLine($"Lokasyon Özeti: {lokasyonOzeti}");

            // 4. Kullanıcıya ulaşım tercihini soruyoruz
            Console.WriteLine("Ulaşım aracınızı seçiniz: \n1 - Kara yolu (Kişi başı 1500 TL) \n2 - Hava yolu (Kişi başı 4000 TL)");

            int ulasimSecimi;
            while (!int.TryParse(Console.ReadLine(), out ulasimSecimi) || (ulasimSecimi != 1 && ulasimSecimi != 2))
            {
                Console.WriteLine("Geçersiz seçim. Lütfen 1 ya da 2 seçeneğinden birini giriniz.");
            }

            int ulasimFiyati = (ulasimSecimi == 1) ? 1500 : 4000;

            // 5. Toplam fiyat hesaplaması
            int toplamFiyat = (paketFiyati + ulasimFiyati) * kisiSayisi;
            Console.WriteLine($"Seçtiğiniz lokasyon: {lokasyon.ToUpper()}");
            Console.WriteLine($"Kişi sayısı: {kisiSayisi}");
            Console.WriteLine($"Ulaşım seçiminiz: {(ulasimSecimi == 1 ? "Kara yolu" : "Hava yolu")}");
            Console.WriteLine($"Toplam fiyat: {toplamFiyat} TL");

            // 6. Başka bir tatil planı yapmak isteyip istemediğini soruyoruz
            Console.WriteLine("Başka bir tatil planı yapmak ister misiniz? (Evet/Hayır)");
            string devam = Console.ReadLine().Trim().ToLower();
            if (devam != "evet")
            {
                Console.WriteLine("İyi günler dileriz!");
                break;
            }
        }
    }
}
