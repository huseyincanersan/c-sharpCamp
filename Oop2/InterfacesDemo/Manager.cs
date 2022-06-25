using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Manager Yemek yedi");
        }

        public void GetSalary()
        {
            Console.WriteLine("Maas Aldi");
        }

        public void Work()
        {
            Console.WriteLine(" Manager Calisti");
        }
    }
}
