using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5.Odev2
{
    internal class Odev2
    {
        public void arabaYasKontrol(int yas)
        {
            if (yas>0 && yas<10)
            {
                Console.WriteLine("Arabanız yeni");
            }

            else if (yas >= 10 && yas < 20)
            {
                Console.WriteLine("Servise götürmeniz gerekebilir");
            }

            else if (yas >= 20 && yas < 30)
            {
                Console.WriteLine("Arabanız hurdaya çıkabilir");
            }

            else
            {
                Console.WriteLine("Ya hiç üretilmedi ya da trafikten men edilmiştir");
            }
        }
    }
}
