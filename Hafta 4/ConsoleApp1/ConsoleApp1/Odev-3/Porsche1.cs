using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Odev_3
{
    internal class Porsche1 : Arac
    {
        public String markaIsmi = "Porsche";
        public int yakılanLitre = 60;

        public void yakıtHesapla()
        {
            Console.WriteLine(this.markaIsmi + " -> " + this.yakılanLitre + "L");
        }
    }
}
