using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    class MusteriManager
    {
        public void Add (Musteri musteri)
        {
            Console.WriteLine("      ");
            Console.WriteLine("Tebrikler ! Müşteri Başarıyla Eklendi");
            Console.WriteLine(musteri.musteriNo);
            Console.WriteLine(musteri.musteriAdi + " " + musteri.musteriSoyadi);

        }

        public void List (Musteri musteri)
        {
            Console.WriteLine("      ");
            Console.WriteLine("Müşteri No : " + " " + musteri.musteriNo);
            Console.WriteLine("Müşteri Adı : " + " " + musteri.musteriAdi);
            Console.WriteLine("Müşteri Soyadı : "  + "  " + musteri.musteriSoyadi);
            Console.WriteLine("Müşteri Cinsiyeti : " + " " + musteri.musteriCinsiyeti);
        }

        public void Delete (Musteri musteri)
        {
            Console.WriteLine("      ");
            Console.WriteLine("Müşteri Başarıyla Silindi");
            Console.WriteLine("Müşteri No  : " + " " + musteri.musteriNo);
            Console.WriteLine("Müşteri Adı ve Soyadı : " + " " + musteri.musteriAdi + " " + musteri.musteriSoyadi);
            Console.WriteLine("Müşteri Cinsyeti : " + " " + musteri.musteriCinsiyeti);
        }
    }
}
