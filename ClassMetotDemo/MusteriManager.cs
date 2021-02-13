using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle (Musteri musteri, Musteri musteri1)
        {
            Console.WriteLine("Musteri Id: " + musteri.MusteriId + " eklendi!" + musteri1.MusteriId + " eklendi!");
            //Console.WriteLine("Musteri TcNo: " + musteri.MusteriTcNo);
            //Console.WriteLine("Musteri Adi: " + musteri.MusteriAdi);
            //Console.WriteLine("Musteri Soyadi: " + musteri.MusteriSoyadi);
        }

        public void Listele(Musteri musteri1, Musteri musteri2, Musteri musteri3)
        {
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            foreach (Musteri musteri in musteriler)
            {

                Console.WriteLine("Musteri Id: " + musteri.MusteriId);
                Console.WriteLine("Musteri TcNo: " + musteri.MusteriTcNo);
                Console.WriteLine("Musteri Adi: " + musteri.MusteriAdi);
                Console.WriteLine("Musteri Soyadi: " + musteri.MusteriSoyadi);
            }
        }

        public void Sil (Musteri musteri,Musteri musteri1)
        {
            Console.WriteLine(musteri.MusteriAdi + " silindi!"+ musteri1.MusteriAdi + " silindi!");
        }


    }
}
