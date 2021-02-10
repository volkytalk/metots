using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product)
        {
            //productın içindekileri
            Console.WriteLine(product.productName + "eklendi.");


        }

        public void Update(Product product)
        {
            Console.WriteLine(product.productName + "güncellendi.");
        }

        public int Topla1(int sayi1, int sayi2)
        {

            return sayi1 + sayi2;
        }
        public void Topla2(int sayi1, int sayi2)
        {

            Console.WriteLine(sayi1 + sayi2);
            //void kullanırsak git yap bitir oluyor

            //ancak int gibi kullanırsam daha sonra o değeri başka yerdede kullanabiliriz return bundan önemli

        }
    }
}
