﻿using System;

namespace MyNamespace
{
    class Program
    {
        public static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan("Halil", "Özcan", 200905050, "Yazılım");

            calisan1.CalisanBilgileri();


            Calisan calisan2 = new Calisan("Hakan", "Söylemez", 200905055, "Yönetici");

            calisan2.CalisanBilgileri();

            Calisan calisan3 = new Calisan("Hasan", "Yılmaz");

            calisan3.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string ad;
        public string soyad;

        public int no;
        public string departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.no = no;
            this.departman = departman;
        }
        public Calisan(string ad, string soyad)
        {
            this.ad = ad;
            this.soyad = soyad;
        }

        public Calisan(){}
        public void CalisanBilgileri()
        {
            Console.WriteLine("Calışanın Adi: {0}" , ad);
            Console.WriteLine("Calışanın SoyAdi: {0}" , soyad);
            Console.WriteLine("Calışanın No: {0}" , no);
            Console.WriteLine("Calışanın Departmanı: {0}" , departman);
        }
    }
}