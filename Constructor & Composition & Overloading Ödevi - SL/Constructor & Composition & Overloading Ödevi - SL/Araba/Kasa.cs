using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor___Composition___Overloading_Ödevi___SL
{
    internal class Kasa
    {
        String kasa;
        public Kasa(string kasa)
        {
            this.kasa = kasa;
        }


        public override String ToString()
        {
            return kasa.ToString();
        }
    }
}
