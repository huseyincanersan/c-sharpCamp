using System;
using System.Collections.Generic;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IWorker> workers = new List<IWorker> { new Manager(), new Worker(), new Robot() };

            foreach (var item in workers)
            {
                item.Work();
                
            }

            List<IEat> eats = new List<IEat> { new Manager(), new Worker() };

            foreach (var item in eats)
            {
                item.Eat();
            }
        }
    }
}
