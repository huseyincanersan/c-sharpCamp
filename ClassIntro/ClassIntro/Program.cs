using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "can";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "Can";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "Can";
            kurs2.IzlenmeOrani = 98;
            
            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Can";
            kurs3.IzlenmeOrani = 52;

            //  Console.WriteLine(kurs1.KursAdi+":"+kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen);
            }

        }
    }

    class Kurs
    {

        public string KursAdi { get; set; }

        public String Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }

        


    }
}
