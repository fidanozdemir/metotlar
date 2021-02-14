using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] kelimeler = new string[] { "ayna", "balon", "kitap", "okul" };
            //Console.WriteLine(kelimeler[0]);
            //Console.WriteLine(kelimeler[1]);
            //Console.WriteLine(kelimeler[2]);
            //Console.WriteLine(kelimeler[3]);

            //kelimeler = new string[5];
            //kelimeler[4] = "vazo";
            //Console.WriteLine(kelimeler[4]);
            //Console.WriteLine(kelimeler[0]);

            List<string> kelimeler2 = new List<string> { "ayna", "balon", "kitap", "okul" };
            Console.WriteLine(kelimeler2[0]);
            Console.WriteLine(kelimeler2[1]);
            Console.WriteLine(kelimeler2[2]);
            Console.WriteLine(kelimeler2[3]);
            kelimeler2.Add("vazo");
            Console.WriteLine(kelimeler2[4]);
            Console.WriteLine(kelimeler2[0]);

        }
    }
}
