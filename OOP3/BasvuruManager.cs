using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {  
        // BURASI ÇOK ÖNEMLİ !!
        //Method injection
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices) //birden fazla logger yollayacağımızdan da List kullanıdk
        {
            //Başvuran bilgilerini değerlendirme
            //

            //Yukarıda BasvuruYap a gönderilen kredi tipine göre
            //aşağıda zaten referans bir referans tip olan krediManager dan istenilen
            //kredi seçeneğine göre hesapla yapacaktır
            //

            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        //List<> olmasının sebebi;
        //türü belli fakat kaç tane değer alacağı belli olmadığı için
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {     //listeden seçilenleri foreach e atıp işlemi yapıyor
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

    }
}
