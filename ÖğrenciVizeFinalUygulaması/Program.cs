using System;

namespace ÖğrenciVizeFinalUygulaması
{
    class Program
    {

        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci(1, "Berkay", "Ağçay", 45, 70, "Ankara Üniversitesi");

            Console.WriteLine("Uygulamamıza hoşgeldiniz... Lütfen yapmak istediğiniz işlemi seçiniz .");
            Console.WriteLine("-----------------------------------------------------------------------");

            bool kontrol = true;


            while (kontrol)
            {
                isimleriGöster();
                Console.WriteLine("-----------------------------------------------------------------------");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        ogrenci1.ogrenciBilgieriGöster();
                        break;


                    case "2":

                        double ogrenciOrtalama = ogrenci1.ogrenciOrtalaması();
                        Console.WriteLine("Öğrencinin Ortalaması :" + ogrenciOrtalama);
                        break;

                    case "3":
                        ogrenci1.okulGetir();
                        break;

                    case "4":
                        kontrol = false;
                        break;



                }


            }


            static void isimleriGöster()
            {

                Console.WriteLine("1- Öğrenci Bilgileri");
                Console.WriteLine("2- Öğrenci Ortalaması");
                Console.WriteLine("3- Öğrenci Okul İsmi");
                Console.WriteLine("4- Çıkış Yap");
            }
        }
    }
}
