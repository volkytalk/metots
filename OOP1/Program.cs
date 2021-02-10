using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.id = 1;
            product1.CategortId = 2;
            product1.productName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;


            //alttaki şekildede tanımlanabilir
            Product product2 = new Product {id=2,CategortId=5,UnitsInStock=5,productName="Kalem",UnitPrice=35};

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.productName);

            int toplamasonucu = productManager.Topla1(2, 3);
            Console.WriteLine( toplamasonucu*2);
            Console.ReadLine();

            //referans numarasını olarak product1 i adde yolladığından masa kamera olarak değişti
            //int double bool gibi veri dtipleri değer tipi
            //diziler classlar abstract classlar interfaceler referans tipidir


        }
    }
}
