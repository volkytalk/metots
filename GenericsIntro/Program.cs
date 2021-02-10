using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //c# da list olmasaydı nasıl yazılırdı
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");
            
        }
    }
}
