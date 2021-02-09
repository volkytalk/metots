using System;
using System.Collections.Generic;
using System.Text;

namespace metots
{
    class SepetManager
    {
        //naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler Sepete eklendi : "+ urun.UrunAdi);
        }
        
        public void Ekle2(string urunAdi,string Aciklama,double fiyat)
        {
            Console.WriteLine("Tebrikler Sepete eklendi : " + urunAdi);
        }
        //
        
    }
}
