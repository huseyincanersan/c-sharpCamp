using System;
using System.Collections.Generic;
using System.Text;

namespace AbstarctTemp
{
   abstract class GeometrikSekil
    {
        //abstract siniflardan nesne olusturamayiz

        double alan;
        string isim;
        Nokta[] noktalar;
        int noktaSayisi;

        public GeometrikSekil(string isim,int noktaSayisi)
        {
            this.Isim = isim;
            this.NoktaSayisi = noktaSayisi;

        }

        public abstract double alanHesapla();
        public abstract void ozellikYazdir();

        public double Alan { get => alan; set => alan = value; }
        public string Isim { get => isim; set => isim = value; }
        internal Nokta[] Noktalar { get => noktalar; set => noktalar = value; }
        public int NoktaSayisi { get => noktaSayisi; set => noktaSayisi = value; }

        public void noktaUret(int noktaSayisi)
        {
            Random r = new Random();
            Noktalar = new Nokta[noktaSayisi];

            for (int i = 0; i < noktaSayisi; i++)
            {
                Noktalar[i] = new Nokta(r.Next(-20, 20), r.Next(-20, 20));
            }
        }



    }
}
