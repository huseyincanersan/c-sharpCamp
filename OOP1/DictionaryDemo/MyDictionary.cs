using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryDemo
{
    class MyDictionary<A,T>
    {
        A[] items;
        T[] items2;
        

        public MyDictionary()
        {
            items = new A[0];
            items2 = new T[0];
        }

        public void Add(A item,T item2)
        {
            A[] tempArray = items;
            T[] tempArray2 = items2;

            items = new A[items.Length + 1];
            items2 = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            for (int i = 0; i < tempArray2.Length; i++)
            {
                items2[i] = tempArray2[i];
            }

            items[items.Length - 1] = item;
            items2[items2.Length - 1] = item2;

        }

        public int Count
        {
            get { return items.Length; }
        }

        public A[] Items
        {
            get { return items; }
        }

        public void ShowDictionary()
        {

            Console.WriteLine(items[0]);
            Console.WriteLine(items2[0]);
            //for (int i = 0; i < items.Length; i++)
            //{
            //    Console.WriteLine(items[i]+" "+items2[i]);
            //}
        }

        //public T[] Items2
        //{
        //    get { return items2; }
        //    set { items2 = value; }
           
        //}




    }
}
