using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    class Worker : IWorker,ISalary,IEat
    {
        public void Eat()
        {
            Console.WriteLine("Worker Yemek yedi");
        }

        public void GetSalary()
        {
            Console.WriteLine("Maas Aldi");
        }

        public void Work()
        {
            Console.WriteLine("Calisan Calisti");
        }
    }
}
