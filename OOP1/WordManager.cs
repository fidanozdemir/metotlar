using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class WordManager
    {
        public void Add(Word kelime)
        {
            Console.WriteLine(kelime.WordName + "eklendi.");
        }

        //public void Update(Word kelime)
        //{
        //    Console.WriteLine(kelime.WordName + "güncellendi.");
        //}
    }
}
