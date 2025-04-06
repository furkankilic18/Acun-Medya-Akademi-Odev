// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//ARRAY
//Bilmem depolama aynı tür değişkenlere orijinalini bir isim altında tutulmuş sağlar 

String[] gunler = new String[7];
gunler[0] = "Pazartesi";
gunler[1] = "Salı";
gunler[2] = "Çarşamba";
gunler[3] = "Perşembe";
gunler[4] = "Cuma";
gunler[5] = "Cumartesi";
gunler[6] = "Pazar";

// İF - ELSE
int yas = 17;

if (yas > 18) //ilk koşul 18 den buyukse alttakı metnı yazdır
{
    Console.WriteLine("Sisteme giriş yapabişlirsiniz");
}

else if(yas<30 && yas > 19) //ilk koşul olmadıysa bu kosuldakı 19 den buyukse ve 30 dam kucukse alttakı metnı yazdır
{
    Console.WriteLine("Aman hocam yanarrrrr");
} 

else  // hiçbir koşul sağlamıyorsa alttakı metını yazdır 
{
    Console.WriteLine("Sisteme giriş yapamassın");
}


// odev 1
if (yas < 0)
{
    Console.WriteLine("Geçersiz Yaş!!");
}
else if (yas > 0 && yas < 18)
{
    Console.WriteLine("Küçüksünüz");
}
else if (yas >= 18 && yas < 35)
{
    Console.WriteLine("Gençsiniz");
}
else if (yas >= 35 && yas < 55)
{
    Console.WriteLine("Yetişkinsiniz");
}
else if (yas >= 55 && yas < 75)
{
    Console.WriteLine("Yaşlısınız");
}
else if (yas >= 75 && yas < 99)
{
    Console.WriteLine("Çok yaşlısınız");
}
else
{
    Console.WriteLine("Geçerli bir yaş giriniz!");
}

//FOR

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}