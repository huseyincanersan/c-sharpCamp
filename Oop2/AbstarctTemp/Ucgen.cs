using System;
using System.Collections.Generic;
using System.Text;

namespace AbstarctTemp
{
    class Ucgen : GeometrikSekil
    {

        public Ucgen(string isim,int noktaSayisi):base(isim,noktaSayisi)
        {

        }

      

        public override double alanHesapla()
        {
            double a = Math.Sqrt(Math.Pow(Noktalar[0].X - Noktalar[1].X, 2) + Math.Pow(Noktalar[0].Y - Noktalar[1].Y, 2));
            double b = Math.Sqrt(Math.Pow(Noktalar[1].X - Noktalar[2].X, 2) + Math.Pow(Noktalar[1].Y - Noktalar[2].Y, 2));
            double c = Math.Sqrt(Math.Pow(Noktalar[2].X - Noktalar[0].X, 2) + Math.Pow(Noktalar[2].Y - Noktalar[0].Y, 2));

            double s = (a + b + c) / 2;
            double alan = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            base.Alan = alan;
            return alan;
        }

        public override void ozellikYazdir()
        {
            for (int i = 0; i < Noktalar.Length; i++)
            {
                Console.WriteLine((i+1)+". nokta degerleri: (x:{0},y{1})",Noktalar[i].X,Noktalar[i].Y);
            }
            Console.WriteLine(Isim+" Alani: {0}",base.Alan);
        }
    }
}
