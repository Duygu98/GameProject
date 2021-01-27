using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoggerService fileLoggerService = new FilesLoggerService();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            IDogrulamaServisi kullaniciDogrulama = new KullaniciDogrulama();

            IOyuncuService oyuncuManager = new OyuncuManager
                (new List<ILoggerService> { databaseLoggerService,fileLoggerService},
                 new  List<IDogrulamaServisi>{kullaniciDogrulama });

            Kullanici oyuncu1 = new Oyuncu();
            oyuncu1.Adi = "Duygu"; oyuncu1.Soyadi = "Uğur"; oyuncu1.TcNo = "12345678910"; oyuncu1.DogunYili = 1999;
            Kullanici oyuncu2 = new Oyuncu();
            oyuncu1.Adi = "Engin"; oyuncu1.Soyadi = "Demirog"; oyuncu1.TcNo = "11115678910"; oyuncu1.DogunYili = 1985;
            Kullanici oyuncu3 = new Oyuncu();
            oyuncu1.Adi = "Melis"; oyuncu1.Soyadi = "Yavuz"; oyuncu1.TcNo = "22245678910"; oyuncu1.DogunYili = 1998;

            oyuncuManager.Ekle(oyuncu1);
            oyuncuManager.Ekle(oyuncu2);
            oyuncuManager.Ekle(oyuncu3);

            IKampanyaService yazKampanyası = new YazKampanyası();
            IKampanyaService haftasonuKampanyası = new HaftasonuKampanyasi();
            IKampanyaService yilbasiKampanyası = new YilbasiKampanyası();







        }
    }
}
