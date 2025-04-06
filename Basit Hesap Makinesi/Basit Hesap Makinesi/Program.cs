

using Basit_Hesap_Makinesi;

Console.WriteLine("1. Sayıyı giriniz");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2. Sayıyı giriniz");
int secondNumber = Convert.ToInt32(Console.ReadLine());

HesapMakinasi hesapMakinasi = new HesapMakinasi();
Console.WriteLine(firstNumber+"+"+ secondNumber+ "= " +hesapMakinasi.topla(firstNumber , secondNumber));
Console.WriteLine(firstNumber + "-" + secondNumber + "= " + hesapMakinasi.cikar(firstNumber, secondNumber));
Console.WriteLine(firstNumber + "/" + secondNumber + "= " + hesapMakinasi.bolme(firstNumber, secondNumber));
Console.WriteLine(firstNumber + "*" + secondNumber + "= " + hesapMakinasi.carpma(firstNumber, secondNumber));
