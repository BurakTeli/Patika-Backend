

class Program
{
    static void Main()
        
    {
        Console.WriteLine("Patika Plus Gala Gecesine Hoşgeldiniz.");

        List<string> davetliler = new List<string>
        {
            "Bülent Ersoy",
            "Ajda Pekkan",
            "Ebru Gündes",
            "Hadise",
            "Hande Yener",
            "Tarkan",
            "Funda Arar",
            "Demet Akalin"
        };
        Console.WriteLine("** Davetliler: ** ");

        foreach (string davetli in davetliler)
        {
            Console.WriteLine(davetli);
        }
    }
}
