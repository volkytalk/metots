using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin","Murat","Kerem","Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler[4] = "ilker";
            //Console.WriteLine(isimler[4]);
            //ctrl k ctrl c yorum satırı ctrl k ctrl u yorum satırından normal satıra
            //üstteki gibi yazdığımızda daha sonra bi eleman ekleyemeyiz 5 i elemanı eklemeye çalıştığımda hata verir en başta sınırları ne yaparsan
            //o kadar sonradan newlersen olanları kaybedersin new demek yeni referans adresi demektir  

            List<string> isimler2 = new List<string> {"Engin","Murat","Kerem","Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            Console.ReadLine();
            
            //liste/koleksiyonlar dizilerden daha efektifdir


        }
    }
}
