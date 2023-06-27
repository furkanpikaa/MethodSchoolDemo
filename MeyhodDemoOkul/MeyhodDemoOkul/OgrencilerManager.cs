using System;
using System.Collections.Generic;
using System.Text;

namespace MeyhodDemoOkul
{
    class OgrencilerManager
    {
        public void Ekle(Ogrenciler ogrenciler)
        {
            Console.WriteLine("Yeni Öğrenci Kaydı Başarıyla Gerçekleşti. " + ogrenciler.OgrenciAdi + " " + ogrenciler.OgrenciSoyadi);
            Console.WriteLine("---------------------");
        }

        public void Liste(Ogrenciler ogrenciler)
        {
            Console.WriteLine(ogrenciler.OgrenciAdi + " " + ogrenciler.OgrenciSoyadi + " " + ogrenciler.OgrNo + " " + ogrenciler.Sinifi);
        }

        public void Delete(Ogrenciler ogrenciler)
        {
            Console.WriteLine(ogrenciler.OgrNo + " Nolu öğrencinin kaydı silinmiştir.");
        }

    }
}
