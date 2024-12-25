using System;
using Internal;

class Program
{
    static void Main()
    {
        int limit;

        Console.WriteLine("Bir limit değeri giriniz:");
        limit = Convert.ToInt32(Console.ReadLine());

        // while döngüsü ile sayaç
        int sayac = 0;
        while (sayac <= limit)
        {
            Console.WriteLine("Ben bir Patika'lıyım");
            sayac++;
        }

        Console.WriteLine("\n-------------------------\n");

        // do-while döngüsü ile sayaç
        int sayac2 = 0;
        do
        {
            Console.WriteLine("Ben bir Patika'lıyım");
            sayac2++;
        } while (sayac2 <= limit);

        // Farklılıklar:
        // - `while` döngüsünde koşul, döngüye girmeden önce kontrol edilir. Eğer koşul başlangıçta sağlanmazsa döngü hiç çalışmaz.
        // - `do-while` döngüsünde koşul, döngü sonunda kontrol edilir. Bu yüzden döngü en az bir kez çalışır, koşul sağlanmasa bile.
    }
}
