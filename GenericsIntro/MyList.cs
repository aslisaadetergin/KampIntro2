using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>  //T verilmesinin sebebi yazılımcı istediği türü verebilsin diyedir
    {
        T[] items;  //constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;  //tempArray = geçiciDizi
            items = new T[items.Length + 1];  //items.Length eleman sayısını verir

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item; // boyutunun -1 inci olmasının sebebi  dan başladığı içidir


        }
    }
}
