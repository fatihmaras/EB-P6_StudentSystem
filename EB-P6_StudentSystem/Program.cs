using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OgrenciUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Kontrol = true;

            Ogrenci ogrenci1 = new Ogrenci(1, "Fatih", "Maraş", 50, 60, 70, "İTÜ");

            Console.WriteLine("Uygulamamıza Hoşgeldiniz... Yapmak İstediğiniz İşlemi Seçiniz ");


            while (Kontrol)
            {
                IslemleriGoster();
                string secim = Console.ReadLine();

                switch (secim)
                {

                    case "1":
                        ogrenci1.ogrenciBilgileriGoster();
                        break;


                    case "2":
                        double OgrenciOrtalama = ogrenci1.OgrenciNotubul();
                        Console.WriteLine("Öğrencinin Ortalaması : " + OgrenciOrtalama);
                        break;

                    case "3":
                        ogrenci1.Okulgetir();

                        break;



                    case "4":
                        Kontrol = false;
                        break;


                }



            }

        }
        static void IslemleriGoster()
        {
            Console.WriteLine("1-Öğrenci Bilgilierini Göster");
            Console.WriteLine("2- Öğrenci Ortalamasını Göster");
            Console.WriteLine("3-Öğrenci Okulunu Göster");
            Console.WriteLine("4-Çıkış Yap");
        }
    }
}
