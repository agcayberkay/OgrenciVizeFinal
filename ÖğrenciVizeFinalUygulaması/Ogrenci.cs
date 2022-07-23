using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖğrenciVizeFinalUygulaması
{
    public class Ogrenci
    {
        private int OgrenciNo;

        private string OgrenciAdı;

        private string OgrenciSoyad;

        private int Vize;

        private int Final;

        private string OkulIsmi;




        public Ogrenci(int _OgrenciNo, string _OgrenciAdı, string _OgrenciSoyad, int _Vize, int _Final, string _OkulIsmi)
        {
            OgrenciNo = _OgrenciNo;
            OgrenciAdı = _OgrenciAdı;
            OgrenciSoyad = _OgrenciSoyad;
            Vize = _Vize;
            Final = _Final;
            OkulIsmi = _OkulIsmi;
        }




        public  void ogrenciBilgieriGöster()
        {

            Console.WriteLine("Ögrenci Numarası:" + OgrenciNo);
            Console.WriteLine("Ögrenci Adı:" + OgrenciAdı);
            Console.WriteLine("Ögrenci Soyadı:" + OgrenciSoyad);
            Console.WriteLine("Ögrenci Vize:" + Vize);
            Console.WriteLine("Ögrenci Final:" + Final);
            Console.WriteLine("Okul:" + OkulIsmi);
            Console.WriteLine("-----------------------------------------------------------------------");


        }

        public double ogrenciOrtalaması()
        {
            double ortalama = (Vize * 30 / 100) + (Final * 70 / 100);
            return ortalama;
            Console.WriteLine("-----------------------------------------------------------------------");

        }

        public void okulGetir()
        {

            Console.WriteLine("Öğrenci Okul İsmi:" + OkulIsmi);
            Console.WriteLine("-----------------------------------------------------------------------");

        }


    }
}
