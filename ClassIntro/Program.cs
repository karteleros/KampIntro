using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim = "Erhan";

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Teacher = "Engin Demirog";
            kurs1.IzlanmeOrani = 86;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Teacher = "Kerem Varış";
            kurs2.IzlanmeOrani = 70;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "JavaScript";
            kurs3.Teacher = "Selman Kahya";
            kurs3.IzlanmeOrani = 98;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "Python";
            kurs4.Teacher = "Berkay Bilgin";
            kurs4.IzlanmeOrani = 100;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Teacher);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Teacher { get; set; }
        public int IzlanmeOrani { get; set; }

    }

}
