using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo2
{
    class AssistantManageer : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Asistan Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Asistan Guncellendi");
        }
    }
}
