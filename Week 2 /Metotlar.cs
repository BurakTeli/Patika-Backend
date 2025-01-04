using System;

class Program
{
    // Geriye değer döndürmeyen void metot
    static void SevdiğimSarkı()
    {
        Console.WriteLine("I never feared death or dyin' (whoo)");
        Console.WriteLine("I only fear never tryin' (whoo)");
        Console.WriteLine("I am whatever I am");
        Console.WriteLine("Only God can judge me now");
    }

    // Geriye tamsayı döndüren metot
    static int RastgeleSayıMod2()
    {
        Random random = new Random();
        int sayi = random.Next();
        return sayi % 2; // Sayının 2'ye bölümünden kalan
    }

    // Parametre alan ve geriye değer döndüren metot
    static int CarpmaIslemi(int sayi1, int sayi2)
    {
        return sayi1 * sayi2;
    }

    // Parametre alan ve geriye değer döndürmeyen metot
    static void Hosgeldiniz(string isim, string soyisim)
    {
        Console.WriteLine($"Hoş Geldiniz {isim} {soyisim}");
    }

    static void Main()
    {
        // Metotları çağırma
        SevdiğimSarkı();

        int kalan = RastgeleSayıMod2();
        Console.WriteLine($"Rastgele sayının 2'ye bölümünden kalan: {kalan}");

        int carpim = CarpmaIslemi(5, 10);
        Console.WriteLine($"Çarpma sonucu: {carpim}");

        Hosgeldiniz("Burak", "Yılmaz");
    }
}
