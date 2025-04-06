using ConsoleApp1.Odev_1;
using ConsoleApp1.Odev_2;
using ConsoleApp1.Odev_3;

// ODEV-1
Bmw bmw = new Bmw();    
Mercedes mercedes = new Mercedes();
Porsche porsche = new Porsche();

Console.WriteLine(bmw.name + ": "+ bmw.hız() + " , " + bmw.yuz() + " , " + bmw.uc());
Console.WriteLine(mercedes.name + ": "+ mercedes.yuz()+ " , " + mercedes.uc());
Console.WriteLine(porsche.name + ": " + porsche.uc());

Console.WriteLine("----------------------------------");

//ODEV-2
GenelMudur genelmudur = new GenelMudur();
Mudur mudur = new Mudur();
Programcı programci = new Programcı();   
Stajyer stajyer = new Stajyer();

genelmudur.maasinNedir("Genel Müdür" , 80000);
mudur.maasinNedir("Müdür" , 60000);
programci.maasinNedir("Programcı" , 40000);
stajyer.maasinNedir("Stajyer" , 5000);
int toplamMaas = genelmudur.maas + mudur.maas + programci.maas + stajyer.maas;

Console.WriteLine("Toplam Maaş: "+toplamMaas);
Console.WriteLine("----------------------------------");

//ODEV-3
Bmw1 bmw1 = new Bmw1();
Mercedes1 mercedes1 = new Mercedes1();  
Porsche1 porsche1 = new Porsche1();

bmw1.yakıtHesapla();
mercedes1.yakıtHesapla();
porsche1.yakıtHesapla();

int toplamYakilanYakit = bmw1.yakılanLitre + mercedes1.yakılanLitre + porsche1.yakılanLitre;
Console.WriteLine("Toplam uakılan yakıt : "+toplamYakilanYakit+"L");

Console.WriteLine("----------------------------------");

//ODEV-3
Console.WriteLine("Odev4 ilgili klasördeki texte yazılmıştır");

