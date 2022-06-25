using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo2
{
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Musteri Eklenndi");
        }

        public void Update()
        {
            Console.WriteLine("Musteri Guncellendi");
        }
    }
}
