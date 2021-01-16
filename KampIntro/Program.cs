using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 6000;
            long tcNo = 20718654793;
            bool TrueOrFalse = true;
            double dolarYesterday = 7.45;
            double dolarToday = 7.45;

            if (dolarYesterday > dolarToday)
            {
                print("Düşüş Butonu");
            }
            else if (dolarToday > dolarYesterday)
            {
                print("Yükseliş Butonu");
            }
            else
            {
                print("Sabit Butonu");
            }

        }

        static void print(string x)
        {
            Console.WriteLine(x);
        }
    }
}
