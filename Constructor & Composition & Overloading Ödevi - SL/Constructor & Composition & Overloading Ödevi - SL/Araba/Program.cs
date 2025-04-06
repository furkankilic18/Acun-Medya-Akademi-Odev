
using Constructor___Composition___Overloading_Ödevi___SL;

Marka marka = new Marka("BMW");
Kasa kasa = new Kasa("Sedan");
Kapı kapı = new Kapı(4);
Pencere pencere = new Pencere(4);
Araba araba = new Araba(marka,"X5",pencere,kapı,kasa,2000000.0);

araba.arabaOzellikleri();

