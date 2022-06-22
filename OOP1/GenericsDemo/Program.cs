using System;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> sehirler = new MyList<string>();

            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);
            sehirler.Add("Istanbul");

            Console.WriteLine(sehirler.Count);

            foreach (var item in sehirler.Items)
            {
                Console.WriteLine(item);
            }






        }
    }
}
