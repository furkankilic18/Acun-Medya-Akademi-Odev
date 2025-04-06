using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Odev_2
{
    abstract class Calisan
    {
        public int maas;
        public String unvan;

        public void maasinNedir(String unvan , int maas)
        {
            this.unvan=unvan;
            this.maas=maas;
            Console.WriteLine(unvan +" maaşı "+maas+"TL dir");
        }

    }

}
