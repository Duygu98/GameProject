using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class KullaniciDogrulama : IDogrulamaServisi
    {
        public void Dogrulama(Kullanici kullanici)
        {
            if (kullanici.Adi.Length > 1 && kullanici.Soyadi.Length > 1 && kullanici.TcNo.Length == 1 && kullanici.DogunYili > 1900) 
            {
                Console.WriteLine(kullanici.Adi + " " + kullanici.Soyadi +" kullanıcının doğrulaması başarılırdır." );

            }
            else
            {
                Console.WriteLine(kullanici.Adi + " " + kullanici.Soyadi + " kullanıcının doğrulaması başarılı değildir.");

            }

        }
    }
}
