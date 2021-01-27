using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IOyuncuService
    {
        void Ekle(IEntity entity);
        void Sil(IEntity entity);
        void Guncelle(IEntity entity);

    }
}
