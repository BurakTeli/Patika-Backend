using System;

class Program
{
    static void Main()
    {
        int dogruCevapSayisi = 0;

        Console.WriteLine("Burak Telli'nin Düzenlemiş olduğu Kim Milyoner Olmak İste Yarşmasına HOŞ Geldiniz !!");
        Console.WriteLine("Kurallarımız");
        Console.WriteLine("3 adet sorumuzdan 2 sanesini doğru bilirseniz ödülümüzü kazanacaksınız");

        Console.WriteLine("İlk sorumuz geliyor");

        Console.WriteLine("Kızınca sinirlenen hayvan nedir ?");
        Console.WriteLine(" A) Lama ------ B) Deve");
        Console.Write("Cevabınız = (A/B) ");

        string cevap1 = Console.ReadLine().ToUpper();
        if (cevap1 == "A")
        {
            dogruCevapSayisi++;
            Console.WriteLine("Doğru cevap");
        }
        else
        {
            Console.WriteLine("Hatalı cevap verdiniz");
        }

        Console.WriteLine("İkinci sorumuz geliyorrrr, hazır mısınız?");
        Console.WriteLine("Dünya'ya en yakın gezegen hangisidir ?");
        Console.WriteLine("A) Venüs ------ B) Mars");
        Console.Write("Cevabınız = (A/B) ");

        string cevap2 = Console.ReadLine().ToUpper();
        if (cevap2 == "A")
        {
            dogruCevapSayisi++;
            Console.WriteLine("Doğru cevap");
        }
        else
        {
            Console.WriteLine("Hatalı cevap verdiniz");
        }

        Console.WriteLine("Veee Son sorumuza geldik !!!!!");
        Console.WriteLine("5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ? ");
        Console.WriteLine("A) 7 ------ B) 12");
        Console.Write("Cevabınız = (A/B) ");

        string cevap3 = Console.ReadLine().ToUpper();
        if (cevap3 == "B")
        {
            dogruCevapSayisi++;
            Console.WriteLine("Tebrikler Doğru Cevap Verdiniz");
        }
        else
        {
            Console.WriteLine("Cevabınız Hatalıdır");
        }

        if (dogruCevapSayisi >= 2)
        {
            Console.WriteLine("Tebrikler kazandınız");
        }
        else
        {
            Console.WriteLine("Kazanamadınız");
        }
    }
}
