using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Word kelime1 = new Word();
            kelime1.Id = 1;
            kelime1.FirstLetter = "a";
            kelime1.WordName = "Ayna";
            kelime1.CountOfLetter = 4;

            Word kelime2 = new Word { Id = 2, FirstLetter = "b", WordName = "balon", CountOfLetter = 5 };

            WordManager kelimeManager = new WordManager();
            kelimeManager.Add(kelime1);
            Console.WriteLine(kelime1.WordName); //+ "eklendi2");

        }
    }
}
