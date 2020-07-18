using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string giris;
            string kullaniciAdi = "admin";
            do
            {
                Console.Clear(); //Konsolu temizler
                Console.WriteLine("Kullanıcı adınızı giriniz: ");
                giris = Console.ReadLine();
            } while (giris!= kullaniciAdi);
            Console.WriteLine("Giriş Başarılı");

            //Kullanıcı klavyeden -1 yazana kadar sayı al ve ortalamasını göster

            int toplam = 0, ortalama = 0, sayac = 0,giris2=0;
            do
            {
                Console.WriteLine("Sayı giriniz ya da çıkmak için -1 e basınız");
                giris2 = Convert.ToInt32(Console.ReadLine());
                if (giris2 != -1)
                {
                    toplam += giris2;
                    sayac++;
                }


            } while (giris2 != -1);

            ortalama = toplam / sayac;
            Console.WriteLine("Ortalamanız: " + ortalama);
            Console.ReadLine();
        }
    }
}
