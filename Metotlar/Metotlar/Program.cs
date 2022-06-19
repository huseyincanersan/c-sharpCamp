using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();

            product1.Name = "Elma";
            product1.Price = 15;
            product1.Explanation = "Amasya Elmasi";

            Product product2 = new Product();
            
            product2.Name = "Cilek";
            product2.Price = 12;
            product2.Explanation = "Taze Cilek";

            Product product3 = new Product();

            product3.Name = "Karpuz";
            product3.Price = 80;
            product3.Explanation = "Diyarbakir karpuzu";

            Product[] products = new Product[] {product1,product2,product3 };

            foreach (var pro in products)
            {
                Console.WriteLine("Urun adi: " + pro.Name + " Urun Fiyati: "+ pro.Price + " Urun aciklamasi: " + pro.Explanation);
            }

            Console.WriteLine("---------Metotlar-----------");

            SepetManager sepetManager = new SepetManager();

            sepetManager.Addsepet(product1);
            sepetManager.Addsepet(product2);
            sepetManager.Addsepet(product3);


        }
    }
}
