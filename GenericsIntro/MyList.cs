using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    //list komutu olmasaydı..
    class MyList<T>
    {
        T[] items;

        //constructor--- newlendiğinde çalışan bölüme denir T dizisini newlemek istediğimizde 0 elemanlı olsun diye bu şekilde yazdık
        public MyList()
        {
            items = new T[0];
                
        } 
        public void Add(T item)
        {
            T[] tempArray = items;
            // tempArray ile referans numaram uçmasın diye tempArray ile tutturdum newleyince referans numaraları uçar
            //4. dersin 2 saat 35 dk yı izle
            items = new T[items.Length+1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
            //items.length eleman sayısı +1 dediğimdede 1 arttırdım yani 1 elemanlı bir items dizisi oluşturdum
        }
    }
}
