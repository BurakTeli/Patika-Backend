using System;

class Program
{
    static void Main(string[] args)
    {
        
        string tcKimlikNo = "12345678910"; 
        string adi = "Burak"; 
        string soyadi = "Telli"; 
        string telefonNo = "5554443322"; 
        int yas = 20; 

       
        decimal ilkUrunFiyati = 250;
        decimal ikinciUrunFiyati = 350; 

 
        decimal toplamHarcama = ilkUrunFiyati + ikinciUrunFiyati;
        decimal patikaPuan = toplamHarcama * 0.10m;


        Console.WriteLine($"{tcKimlikNo} Tc numaralı {adi} {soyadi} isimli kişi için kayıt oluşturulmuştur.");

    
        Console.WriteLine($"{telefonNo} telefon numarasına bildirim mesajı gönderilmiştir.");

        
        Console.WriteLine($"{toplamHarcama} toplam harcama karşılığı kazanılan 10% Patika Puan miktarı -> {patikaPuan} TL'dir.");
    }
}
