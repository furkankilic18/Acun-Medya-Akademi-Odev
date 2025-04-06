using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Odev_3
{
    internal class Bmw1 : Arac
    {
        public String markaIsmi = "BMW";
        public int yakılanLitre = 80;

        public void yakıtHesapla()
        {
            Console.WriteLine(this.markaIsmi + " -> " + this.yakılanLitre + "L");
        }
    }
}
