using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> AdYas = new Dictionary<string, int>();

            AdYas.Add("can", 21);
            AdYas.Add("huseyin", 21);
            AdYas.Add("gizem", 21);

            foreach (var item in AdYas)
            {
                Console.WriteLine(item);
            }

            var eleman = AdYas.Count();

            Console.WriteLine("Eleman sayisi: "+eleman);

            AdYas.Remove("huseyin");

            foreach (var item in AdYas)
            {
                Console.WriteLine(item);
            }

            var elemanSayisi = AdYas.Count();

            Console.WriteLine("Eleman sayisi: " + elemanSayisi);
        }
    }
}
