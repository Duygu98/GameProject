using System;

namespace GameProject
{
    class HaftasonuKampanyasi : IKampanyaService
    {
        public void Kampanya(IEntity game)
        {
            Console.WriteLine(game.Adi + " oyununa indirimi yapıldı.");
        }
    }
}
