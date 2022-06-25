using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo2
{
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Calisan Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Calisan  Guncellendi");
        }
    }
}
