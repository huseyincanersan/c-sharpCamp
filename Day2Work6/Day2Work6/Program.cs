using System;

namespace Day2Work6
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.productName = "Bilgisayar";
            urun1.productPrice = 15000;
            urun1.discountRate = 4.32;

            Product urun2 = new Product();
            urun2.productName = "Telefon";
            urun2.productPrice = 8500;
            urun2.discountRate = 3.33;

            Product urun3 = new Product();
            urun3.productName = "Televizyon";
            urun3.productPrice = 32000;
            urun3.discountRate = 13.5;

            Product urun4 = new Product();
            urun4.productName = "Camasir Makinesi";
            urun4.productPrice = 8600;
            urun4.discountRate = 12.6;

            Product[] urunler = new Product[] {urun1,urun2,urun3,urun4 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.productName + " fiyati :" + urun.productPrice + " indirim orani :" + urun.discountRate);
            }

            Console.WriteLine("Footer");




        }

        class Product
        {
            public string productName { get; set; }

            public int productPrice { get; set; }

            public double discountRate { get; set; }
        }
    }
}
