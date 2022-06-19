using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string kurs1 = "Yazilim gelistirici kampi";
            string kurs2 = "Programlamaya baslangic icin temel kurs";
            string kurs3 = "Java"; */

            //array

            string[] kurslar = new string[] { "Yazilim gelistirici kampi", "Programlamaya baslangic icin temel kurs","Java","Python" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            //for each dongusu dizileri kolay dolasmak icin kullanilir
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Footer");

           /*for (int i = 1; i <= 10; i+=2)
            {
                Console.WriteLine(i);
            }*/
        }
    }
}
