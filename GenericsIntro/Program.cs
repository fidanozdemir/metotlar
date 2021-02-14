using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> kelimeler = new MyDictionary<string>();
            kelimeler.Add("ayna");

            Console.WriteLine(kelimeler.Length + " eklendi!");

            kelimeler.Add("balon");

            Console.WriteLine(kelimeler.Length + " eklendi!");

            foreach (var kelime in kelimeler.Items)
            {
                Console.WriteLine(kelime + " eklendi.");
            }

        }
    }
}
