using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erişim_Belirleyiciler_ve_Değişkenler_ile_Çalışma
{
    internal class User
    {
        // private değişkenler (sadece bu sınıf içinde erişilebilir)
        private string adSoyad;
        private int yas;

        // public değişken (her yerden erişilebilir)
        public string Email { get; set; }

        // Getter ve Setter metodları
        public string GetAdSoyad()
        {
            return adSoyad;
        }

        public void SetAdSoyad(string ad)
        {
            adSoyad = ad;
        }

        public int GetYas()
        {
            return yas;
        }

        public void SetYas(int y)
        {
            if (y > 0)  // Yaşın negatif olmamasını sağlıyoruz
                yas = y;
            else
                Console.WriteLine("Geçersiz yaş!");
        }

        // Bilgileri gösteren metot
        public void BilgileriGoster()
        {
            Console.WriteLine($"Ad Soyad: {adSoyad}, Yaş: {yas}, Email: {Email}");
        }
    }
}

