using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun(); //Class ın örneği dir bu
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type safe- tip güvenli -- çalışılan veri tipinin bilinmesidir. var da yazılsa olur
            foreach (Urun urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------------");
            }

            Console.WriteLine("------------Metotlar-------------------");
            //instance - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Taze armut", 15, 10);
            sepetManager.Ekle2("Erik", "Yeşil Erik", 50, 3);

        }

    }
}



//metotlar tekrar tekrar kullanılabilirliği sağlayan ortam sunar
//Dont repeat yourself /DRY / Clean Code - Best Practice
