using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EB_P6_StudentSystem
{
    internal class Ogrenci
    {
      
        
            private int ogrno;
            private string isim;
            private string soyisim;
            private int vize1;
            private int vize2;
            private int final;
            private string OkulIsmi;



            public Ogrenci(int Xogrno, string Xisim, string Xsoyisim, int Xvize1, int Xvize2, int Xfinal, string XokulIsmi)
            {
                ogrno = Xogrno;
                isim = Xisim;
                soyisim = Xsoyisim;
                vize1 = Xvize1;
                vize2 = Xvize2;
                final = Xfinal;
                OkulIsmi = XokulIsmi;

            }

            public void ogrenciBilgileriGoster()
            {
                Console.WriteLine("Öğrenci Numarası : " + ogrno);
                Console.WriteLine("Öğrenci İsmi : " + isim);
                Console.WriteLine("Öğrenci Soyismi: " + soyisim);
                Console.WriteLine("Vize 1: " + vize1);
                Console.WriteLine("Vize 2: " + vize2);
                Console.WriteLine("Final : " + final);
                Console.WriteLine("Okul İsmi : " + OkulIsmi);


            }

            public double OgrenciNotubul()
            {
                double ortalama = vize1 * 0.2 + vize2 * 0.2 + final * 0.6;
                return ortalama;

            }
            public void Okulgetir()
            {
                Console.WriteLine("Öğrencinin Okul İsmi : " + OkulIsmi);
            }

        }
    }




