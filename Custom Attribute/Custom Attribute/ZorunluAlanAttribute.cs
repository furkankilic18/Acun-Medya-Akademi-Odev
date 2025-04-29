using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Attribute
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
    internal class ZorunluAlanAttribute:Attribute
    {
        public string HataMesaji { get; }

        public ZorunluAlanAttribute(string hataMesaji)
        {
            this.HataMesaji = hataMesaji;
        }
    }
}
