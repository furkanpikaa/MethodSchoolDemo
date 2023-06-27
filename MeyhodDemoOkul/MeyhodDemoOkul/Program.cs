using System;
using System.Collections.Generic;
using System.Text;

namespace MeyhodDemoOkul
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenciler ogrenci1 = new Ogrenciler();
            ogrenci1.OgrenciAdi = "Furkan";
            ogrenci1.OgrenciSoyadi = "Sırdaş";
            ogrenci1.Sinifi = "11/A";
            ogrenci1.OgrNo = 7045;

            Ogrenciler ogrenci2 = new Ogrenciler();
            ogrenci2.OgrenciAdi = "Burak";
            ogrenci2.OgrenciSoyadi = "Kılıç";
            ogrenci2.Sinifi = "11/B";
            ogrenci2.OgrNo = 5602;

            Ogrenciler ogrenci3 = new Ogrenciler();
            ogrenci3.OgrenciAdi = "Beyza";
            ogrenci3.OgrenciSoyadi = "Bensen";
            ogrenci3.Sinifi = "11/C";
            ogrenci3.OgrNo = 9236;

            Ogrenciler[] ogrenciler = new Ogrenciler[] {ogrenci1,ogrenci2,ogrenci3};

            foreach (Ogrenciler x in ogrenciler)
            {
                Console.WriteLine(x.OgrenciAdi + " " + x.OgrenciSoyadi + " " + x.Sinifi + " " + x.OgrNo);
                Console.WriteLine("---------------------");
            }

            OgrencilerManager ogrencilerManager = new OgrencilerManager();
            ogrencilerManager.Ekle(ogrenci1);
            //------------------------------
            ogrencilerManager.Liste(ogrenci1);
            ogrencilerManager.Liste(ogrenci2);
            ogrencilerManager.Liste(ogrenci3);
            Console.WriteLine("---------------------");
            //------------------------------
            ogrencilerManager.Delete(ogrenci2);

            Console.ReadLine();
        }
    }
}
