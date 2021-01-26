using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();
            ////IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //// ihtiyacKrediManager.Hesapla();
            ////Aynı sonucu verir. interface lerde aynı sonucu verir.

            //IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();
            ////TasitKrediManager tasitKrediManager = new TasitKrediManager();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };


            BasvuruManager basvuruManager = new BasvuruManager(); //referans alındı
            // basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService);
            basvuruManager.BasvuruYap(new EsnafKredisiManager(),loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };

            // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
