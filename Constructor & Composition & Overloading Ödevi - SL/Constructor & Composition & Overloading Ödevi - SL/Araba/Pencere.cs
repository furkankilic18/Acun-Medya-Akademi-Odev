using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor___Composition___Overloading_Ödevi___SL
{
    internal class Pencere
    {
        int pencereSayisi;
        public Pencere(int pencereSayisi)
        {
            this.pencereSayisi = pencereSayisi;
        }

        public override String ToString()
        {
            return this.pencereSayisi.ToString();
        }
    }
}
