using System;

namespace matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            dortIslem dortislem = new dortIslem();
            dortislem.Topla(5, 6);
            dortislem.Topla(6, 9);
            Console.ReadLine();
        }

    }
}
