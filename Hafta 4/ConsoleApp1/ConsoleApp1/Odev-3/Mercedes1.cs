using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Odev_3
{
    internal class Mercedes1 : Arac
    {
        public String markaIsmi = "Mercedes";
        public int yakılanLitre = 70;

        public void yakıtHesapla()
        {
            Console.WriteLine(this.markaIsmi + " -> " + this.yakılanLitre + "L");
        }
    }
}
