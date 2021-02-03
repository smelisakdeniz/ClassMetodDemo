using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.musteriNo = 1;
            musteri1.musteriAdi = "Hilal";
            musteri1.musteriSoyadi = "DÖNMEZ";
            musteri1.musteriCinsiyeti = "Kadın";

            Musteri musteri2 = new Musteri();
            musteri2.musteriNo = 2;
            musteri2.musteriAdi = "Mümin";
            musteri2.musteriSoyadi = "KAYAR";
            musteri2.musteriCinsiyeti = "Erkek";

            Musteri musteri3 = new Musteri();
            musteri3.musteriNo= 3;
            musteri3.musteriAdi = "Ayşe";
            musteri3.musteriSoyadi = "AKDENİZ";
            musteri3.musteriCinsiyeti = "Kadın";

            Musteri musteri4 = new Musteri();
            musteri4.musteriNo = 4;
            musteri4.musteriAdi = "Selçuk";
            musteri4.musteriSoyadi = "GENÇ";
            musteri4.musteriCinsiyeti = "Erkek";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.musteriNo + " " + musteri.musteriAdi + " " + musteri.musteriSoyadi + " " + musteri.musteriCinsiyeti);
               
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.List(musteri3);
            musteriManager.Delete(musteri4);

        }
    }
}
