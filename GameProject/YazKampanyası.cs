using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class YazKampanyası : IKampanyaService
    {
        public void Kampanya(IEntity game)
        {
            Console.WriteLine(game.Adi+ " oyununa indirimi yapıldı.");
        }
    }
}
