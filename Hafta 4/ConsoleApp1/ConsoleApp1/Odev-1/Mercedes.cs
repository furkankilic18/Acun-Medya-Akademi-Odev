using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Odev_1
{
    internal class Mercedes : IYuz,IUc
    {
        public String name = "Mercedes";
        public String yuz()
        {
            return"Denizde yüzer";
        }

        public String uc()
        {
           return"Havada uçar";

        }
    }
}
