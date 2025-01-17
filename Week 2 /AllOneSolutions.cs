using System;

class Program
{
    static void Main()
    {
        // 1 - Çıktı
        Console.WriteLine("Merhaba");
        Console.WriteLine("Nasılsın ?");
        Console.WriteLine("İyiyim");
        Console.WriteLine("Sen nasılsın ?");

        // 2 - Metinsel ve tam sayı veri tutma
        string metin = "Merhaba Dünya";
        int sayi = 42;
        Console.WriteLine("Metinsel Değer: " + metin);
        Console.WriteLine("Tam Sayı Değer: " + sayi);

        // 3 - Rastgele sayı üretme
        Random random = new Random();
        int rastgeleSayi = random.Next();
        Console.WriteLine("Rastgele Sayı: " + rastgeleSayi);

        // 4 - Rastgele sayının 3'e bölümünden kalan
        int kalan = rastgeleSayi % 3;
        Console.WriteLine("3'e Bölümünden Kalan: " + kalan);

        // 5 - Yaş kontrolü
        Console.Write("Yaşınızı girin: ");
        int yas = int.Parse(Console.ReadLine());
        Console.WriteLine(yas > 18 ? "+" : "-");

        // 6 - 10 kez yazdırma
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem.");
        }

        // 7 - İki metinsel değerin yerini değiştirme
        Console.Write("Birinci ismi girin: ");
        string isim1 = Console.ReadLine();
        Console.Write("İkinci ismi girin: ");
        string isim2 = Console.ReadLine();
        string temp = isim1;
        isim1 = isim2;
        isim2 = temp;
        Console.WriteLine("Yer Değiştirildi: " + isim1 + " - " + isim2);

        // 8 - Değer döndürmeyen metot
        BenDegerDondurmem();

        // 9 - İki sayının toplamını döndüren metot
        Console.WriteLine("Toplam: " + Topla(5, 10));

        // 10 - True/False alıp string döndüren metot
        Console.Write("True veya False girin: ");
        bool input = bool.Parse(Console.ReadLine());
        Console.WriteLine(TrueFalseToString(input));

        // 11 - 3 kişinin yaşlarını alıp en yaşlıyı dönen metot
        Console.WriteLine("En yaşlı yaş: " + EnYasli(25, 40, 35));

        // 12 - Sınırsız sayıda sayı alıp en büyüğünü dönen metot
        Console.WriteLine("En büyük sayı: " + EnBuyukSayi());

        // 13 - İsimlerin yerini değiştiren metot
        Console.WriteLine("Yer değiştirilen isimler: " + YerDegistir("Ali", "Veli"));

        // 14 - Sayının tek mi çift mi olduğunu dönen metot
        Console.Write("Bir sayı girin: ");
        int sayiTekCift = int.Parse(Console.ReadLine());
        Console.WriteLine("Tek mi Çift mi: " + TekMiCiftMi(sayiTekCift));

        // 15 - Hız ve zaman ile yol hesaplayan metot
        Console.Write("Hız girin: ");
        double hiz = double.Parse(Console.ReadLine());
        Console.Write("Zaman girin: ");
        double zaman = double.Parse(Console.ReadLine());
        Console.WriteLine("Gidilen Yol: " + GidilenYol(hiz, zaman));

        // 16 - Dairenin alanını hesaplayan metot
        Console.Write("Yarıçap girin: ");
        double yaricap = double.Parse(Console.ReadLine());
        Console.WriteLine("Dairenin Alanı: " + DaireAlani(yaricap));

        // 17 - Cümleyi büyük ve küçük harf yazdırma
        string cumle = "Zaman bir GeRi SayIm";
        Console.WriteLine(cumle.ToUpper());
        Console.WriteLine(cumle.ToLower());

        // 18 - Başındaki ve sonundaki boşlukları silme
        string metinBosluklu = "    Selamlar   ";
        string temizMetin = metinBosluklu.Trim();
        Console.WriteLine("Temizlenmiş Metin: " + temizMetin);
    }

    static void BenDegerDondurmem()
    {
        Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma");
    }

    static int Topla(int a, int b)
    {
        return a + b;
    }

    static string TrueFalseToString(bool value)
    {
        return value ? "Doğru" : "Yanlış";
    }

    static int EnYasli(int yas1, int yas2, int yas3)
    {
        return Math.Max(yas1, Math.Max(yas2, yas3));
    }

    static int EnBuyukSayi()
    {
        Console.WriteLine("Sayıları girin (Bitirmek için -1):");
        int max = int.MinValue;
        while (true)
        {
            int sayi = int.Parse(Console.ReadLine());
            if (sayi == -1) break;
            if (sayi > max) max = sayi;
        }
        return max;
    }

    static string YerDegistir(string isim1, string isim2)
    {
        return isim2 + " - " + isim1;
    }

    static bool TekMiCiftMi(int sayi)
    {
        return sayi % 2 == 0;
    }

    static double GidilenYol(double hiz, double zaman)
    {
        return hiz * zaman;
    }

    static double DaireAlani(double yaricap)
    {
        return Math.PI * yaricap * yaricap;
    }
}
