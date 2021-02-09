using System;

namespace metots
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Urun urun1 = new Urun();
            urun1.UrunAdi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            //type-safe -- tip güvenli
            foreach (var urun in urunler)
            {
                //foreachteki urun takma addır x de diyebilirdik,Urunede var yazabilirdik
                Console.WriteLine(urun.UrunAdi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------------");
                

            }
            Console.WriteLine("-------------METOTLAR------------- \n");
            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);

            sepetmanager.Ekle2("Yeşil Armut", "Yesil armut", 12);
            sepetmanager.Ekle2("Yeşil Elma", "Yesil elma", 12);
            sepetmanager.Ekle2("Beyaz karpuz", "Beyaz karpuz", 12);
            //39,40,41 satırdaki kodlar doğru kullanım değildir çünkü stokadedini girmeye kalktığında değişiklik yaparken zorlanacaksın

            Console.ReadLine();

        }
       
    }
}
