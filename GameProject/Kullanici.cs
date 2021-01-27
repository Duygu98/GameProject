using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Kullanici:IEntity
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int DogunYili { get; set; }
    }
}
