using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5.Odev1
{
    internal class Odev1
    {
        public void yasKontrol(int a)
        {
            if (a < 18)
            {
                Console.WriteLine("Küçüksünüz");
            }
            
            else if (a >= 18 && a < 35)
            {
                Console.WriteLine("Gençsiniz");
            }
            
            else if (a >= 35 && a < 55)
            {
                Console.WriteLine("Yetişkinsiniz");
            }
            
            else if (a >= 55 && a < 75)
            {
                Console.WriteLine("Yaşlısınız");
            }
            
            else if (a >= 75 && a < 99)
            {
                Console.WriteLine("Çok Yaşlısınız");
            }

            else 
            {
                Console.WriteLine("Ya hiç doğmadınız ya da çoktan öldünüz...");
            }
        }

    }
}
