using System;

namespace DegerveReferansTipleri
{
    class Program
    {
        //Ara konu
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);
            


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);
            Console.ReadLine();

            //2. sorunun cevabı 999 peki niye => değer tipleri int,decimal,float,bool(0,1 tutar),,,,,,array,class,interface= referans tipleridir.Bundan dolayı farklı çalışır
            //stack yukarıdan aşağı sırayla iner ve okumaya göre değer atar 1. soruda bundan dolayı sayi1 30 oldu 13. satır okununcada sayi2 ye 65 verildi 
            //heap denende ise sayilar1 dizisinin referans numarasıyla sayilar2nin referans nolarını eşitledi ancak içindeki değerler ile eşitlemedi
        }
    }
}
