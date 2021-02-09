using System;
using System.Collections.Generic;
using System.Text;

namespace metots
{
    public class Urun
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int stokAdedi { get; set; }
        //encapsulation-Düzen içine sokma denebilir
        //birden fazla bilgiyi ortak başlıkta toplayan yapı
    }
}
