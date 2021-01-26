using System;

namespace Oop2
{
    //Gerçek- Tüzel nesneler olur birbirine benzediği için yerlerine kullanılamazlar
            //SOLİD prensiplerinden 'L' birbiri yerine kullanma
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "123456";
            musteri1.Adi = "Aslı";
            musteri1.Soyadi = "Ergin";
            musteri1.TcNo = "789456123";

            //Kodlama.io 
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "456123";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "123456789";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


        }
    }
}
