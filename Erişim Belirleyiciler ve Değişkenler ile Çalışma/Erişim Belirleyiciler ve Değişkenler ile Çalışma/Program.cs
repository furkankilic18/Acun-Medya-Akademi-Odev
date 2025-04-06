// See https://aka.ms/new-console-template for more information
using Erişim_Belirleyiciler_ve_Değişkenler_ile_Çalışma;

Console.WriteLine("Hello, World!");

// User nesnesi oluştur
User kullanici = new User();

// Setter metodları ile değerleri ayarla
kullanici.SetAdSoyad("Furkan KILIÇ");
kullanici.SetYas(22);
kullanici.Email = "furkankilic911@gmail.com.com";

// Bilgileri göster
kullanici.BilgileriGoster();