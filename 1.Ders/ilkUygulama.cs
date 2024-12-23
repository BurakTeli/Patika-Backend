using System;

namespace KendiniTanıt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Değişkenleri tanımlama
            string ad = "Burak";
            string soyad = "Telli";
            string amac = "Patika eğitime katılma amacım kendimi geliştirmek ve aklımdaki start-upları kendi başıma yapabilmek.";

            // Bilgileri ekrana yazdırma
            Console.WriteLine("Adım: " + ad);
            Console.WriteLine("Soyadım: " + soyad);
            Console.WriteLine(amac);

            // Programın hemen kapanmaması için bekletme
            Console.WriteLine("\nÇıkmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
