﻿using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string urunAdi = "Elma";
            double fiyatı = 15;
            String acikmala = "Amasya elması";
            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elma";
            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            Urun[] urunler = new Urun[] { urun1, urun2 };
            foreach (Urun urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);





            }
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("Armut", "Yeşil", 12);
            sepetManager.Ekle2("elma", "Yeşil elma", 40);
            sepetManager.Ekle2("hıyar", "Yeşil hıyar", 126);

        }
    }
}




//dont repeat yourself - DRY- clean code- best practic3