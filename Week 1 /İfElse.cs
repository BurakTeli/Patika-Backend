using System;

class Program
{
    static void Main()
    {
        Console.Write("Lütfen bir sayı giriniz : ");
        int number  = int.Parse(Console.ReadLine());

        if (number > 10 )
        {
            Console.WriteLine("Girilen sayı 10' dan büyüktür");
        }
        else
        {
            Console.WriteLine("Girilen sayı 10'dan küçüktür");
        }
        if (number % 2 == 0)
        {
            Console.WriteLine("Girilen sayı Çift sayıdır");
        }
        else
        {
            Console.WriteLine("Girilen sayı tek sayıdır");
        }
    }

}