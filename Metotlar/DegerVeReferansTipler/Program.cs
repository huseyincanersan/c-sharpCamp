using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //deger tipler int - string - bool - decimal
            // deger tipler stack kisminda depolanir
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

            //sayi1 ????
            //Console.WriteLine(sayi1);


            //referans tipler array-class-interface
            //referans tipler stack kisminda tanimlanir heap kisminda degerlenir

            int[] sayilar1 = new int[] {10,20,30 };
            int[] sayilar2 = new int[] { 100, 500, 1000 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;

            //sayilar1[0] ????

            //Console.WriteLine(sayilar1[0]);


        }
    }
}
