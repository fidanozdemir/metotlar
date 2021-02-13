using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriTcNo = "12345678901";
            musteri1.MusteriAdi = "Eva";
            musteri1.MusteriSoyadi = "Demir";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriTcNo = "12345678902";
            musteri2.MusteriAdi = "Mehmet";
            musteri2.MusteriSoyadi = "Yılmaz";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 3;
            musteri3.MusteriTcNo = "12345678903";
            musteri3.MusteriAdi = "Deniz";
            musteri3.MusteriSoyadi = "Kaya";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1,musteri2);
            musteriManager.Listele(musteri1, musteri2, musteri3);
            musteriManager.Sil(musteri2,musteri3);







        }
    }
}
