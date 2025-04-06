using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor___Composition___Overloading_Ödevi___SL
{
    internal class Kapı
    {
        int kapiSayisi;

        public Kapı(int kapiSayisi)
        {
            this.kapiSayisi = kapiSayisi;
        }


        public override string ToString()
        {
            return kapiSayisi.ToString();
        }
    }
}
