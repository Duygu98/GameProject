using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veri Tabanı Loglandı.");   
        }
    }
}
