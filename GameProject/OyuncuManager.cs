using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OyuncuManager : IOyuncuService
    {
        List<ILoggerService> _loggerServices;
        List<IDogrulamaServisi> _dogrulamaServisi;

        public OyuncuManager(List<ILoggerService> loggerServices, List<IDogrulamaServisi> dogrulamaServisi)
        {
            _loggerServices = loggerServices;
            _dogrulamaServisi = dogrulamaServisi;
        }

        public void Ekle(IEntity kullanici)
        {
            Console.WriteLine("Ekleme işlemi başarılı.");
        }

        public void Guncelle(IEntity kullanici)
        {
            Console.WriteLine("Güncelleme işlemi başarılı.");

        }

        public void Sil(IEntity kullanici)
        {
            Console.WriteLine("Silme işlemi başarılı.");

        }
    }
}
