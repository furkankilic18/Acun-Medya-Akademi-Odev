
Console.WriteLine("1. Sayıyıyı giriniz");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2. Sayıyıyı giriniz");
int sayi2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("3. Sayıyıyı giriniz"); 
int sayi3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("4. Sayıyıyı giriniz"); 
int sayi4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("5. Sayıyıyı giriniz"); 
int sayi5 = Convert.ToInt32(Console.ReadLine());

int[] sayilar = {sayi1,sayi2,sayi3,sayi4,sayi5};
double toplam = 0;

foreach (int sayi in sayilar)
{
    toplam = toplam +sayi;
}


Console.WriteLine("Girilen 5 sayının ortalaması:"+toplam/5);