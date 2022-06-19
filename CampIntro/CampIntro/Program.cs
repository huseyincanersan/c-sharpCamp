using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip guvenligi
            //Do not yourself - Kendini tekrarlama
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun >dolarBugun)
            {
                Console.WriteLine("Azalis Butonu");
            }
            else if(dolarDun < dolarBugun)
            {
                Console.WriteLine("Artis Butonu");
            }
            else
            {
                Console.WriteLine("Esittir Butonu");
            }


            if (sistemeGirisYapmismi == false)
            {
                Console.WriteLine("Kayit ol");
            }
            else
            {
                Console.WriteLine("Kullanici ayarlari");
            }

            Console.WriteLine(kategoriEtiketi);



        }
    }
}
