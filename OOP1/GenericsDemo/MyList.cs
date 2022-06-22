using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo
{
    class MyList<A>
    {
        A[] items;

        public MyList()
        {
            items = new A[0];
        }


        public void Add(A item)
        {
            A[] tempArray = items;

            items = new A[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }

        public int Count
        {
            get { return items.Length; }
        }

        public A[] Items
        {
            get { return items;}
            
        }


        
    }
}
