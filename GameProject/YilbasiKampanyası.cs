﻿using System;

namespace GameProject
{
    class YilbasiKampanyası : IKampanyaService
    {
        public void Kampanya(IEntity game)
        {
            Console.WriteLine(game.Adi + " oyununa indirimi yapıldı.");
        }
    }
}
