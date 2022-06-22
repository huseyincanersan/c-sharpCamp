using System;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> adYas = new MyDictionary<string, int>();

            adYas.Add("can", 21);

            adYas.Add("huseyin", 22);

            Console.WriteLine(adYas.Count);

            adYas.Add("seher", 25);

            Console.WriteLine(adYas.Count);

            adYas.ShowDictionary();

            //foreach (var item in adYas)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
