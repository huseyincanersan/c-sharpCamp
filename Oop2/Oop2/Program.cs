using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "can";
            musteri1.Soyadi = "Ersan";
            musteri1.TcNo = "132456456";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "13456467";
            musteri2.SirketAdi = "Ersan AS";
            musteri2.VergiNo = "123124213";


            Musteri msuteri3 = new GercekMusteri();

            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(musteri4);





        }
    }
}
