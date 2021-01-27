using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OyunManager : IOyuncuService
    {

        List<ILoggerService> _loggerServices;
        

        public OyunManager(List<ILoggerService> loggerServices)
        {
            _loggerServices = loggerServices;
            
        }

        public void Ekle(IEntity game)
        {
            Console.WriteLine("Oyun Eklendi.");
        }

        public void Guncelle(IEntity game)
        {
            Console.WriteLine("Oyun Güncellendi.");

        }

        public void Sil(IEntity game)
        {
            Console.WriteLine("Oyun Silindi.");

        }

    }
}
