using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor___Composition___Overloading_Ödevi___SL
{
    internal class Marka
    {
        String maraka;
        public Marka(String marka) {
            this.maraka = marka;
        }

        public override string ToString()
        {
            return maraka.ToString();
        }
    }
}
