﻿using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı", 
                "Programlamaya başlangıç için temel kurs", "Java", "Python" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("\n-------------------------------------\n");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");
        }
    }
}
