using System;

namespace SchoolManagementSystem
{
    // Person sınıfı
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        // Bilgileri döndüren bir metot
        public string GetInfo()
        {
            return $"Ad: {FirstName}, Soyad: {LastName}, Doğum Tarihi: {BirthDate.ToShortDateString()}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Öğrenci nesneleri oluşturuluyor
            Person student1 = new Person
            {
                FirstName = "Burak",
                LastName = "TEllİ",
                BirthDate = new DateTime(2005, 6, 15)
            };

            Person student2 = new Person
            {
                FirstName = "Mehmet",
                LastName = "Kara",
                BirthDate = new DateTime(2006, 3, 10)
            };

            // Öğretmen nesneleri oluşturuluyor
            Person teacher1 = new Person
            {
                FirstName = "Nİl Sude",
                LastName = "Demir",
                BirthDate = new DateTime(1980, 12, 20)
            };

            Person teacher2 = new Person
            {
                FirstName = "Elif",
                LastName = "Çelik",
                BirthDate = new DateTime(1985, 7, 5)
            };

            // Bilgiler konsola yazdırılıyor
            Console.WriteLine("Öğrenciler:");
            Console.WriteLine(student1.GetInfo());
            Console.WriteLine(student2.GetInfo());

            Console.WriteLine("\nÖğretmenler:");
            Console.WriteLine(teacher1.GetInfo());
            Console.WriteLine(teacher2.GetInfo());
        }
    }
}
