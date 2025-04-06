using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor___Composition___Overloading_Ödevi___SL
{
    internal class Araba
    {
        Marka marka;
        Kasa kasa;
        Pencere pencere;
        Kapı kapı;
        String model;
        double fiyat;

        public Araba(Marka marka,String model, Pencere pencere, Kapı kapı, Kasa kasa, double fiyat)
        {
            this.marka = marka;
            this.model = model;
            this.kasa = kasa;
            this.pencere = pencere;
            this.kapı = kapı;
            this.fiyat = fiyat;
        }

        public void arabaOzellikleri()
        {
            Console.WriteLine(
                "Arabanın markası: " + marka +
                "\nArabanın Modeli: " + model +
                "\nArabanın kapı sayısı: " + kapı +
                "\nArabanın pencere sayısı: " + pencere +
                "\nArabanın fiyatı: " + fiyat + "TL");
                
        }
    }
}
