using System;

namespace Application1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ekrandan kullanıcının girdisini alma  
            // string girdi = Console.ReadLine();
            // Ekrandan kullanıcının girdisini alma  

            /*
            
            1- Kullanıcıdan alınan sayının karesini hesaplayan uygulama
            2- Toplama Uygulaması
            3- Tasarruf Hesaplayıcısı
            

             */

            //1- Kullanıcıdan alınan sayının karesini hesaplayan uygulama

            /*
            Console.WriteLine("Karesini almak istediğiniz sayıyı girin: ");
            string userInput = Console.ReadLine();
            int sayi = Convert.ToInt32(userInput);
            int kare = sayi * sayi;
            Console.WriteLine(sayi+"in Karesi : "+kare);
            Console.ReadLine();
            */


            //2- Ekrandan girilen 2 sayıyı toplayan uygulama

            /* 
            
            int s1, s2,toplam;
            Console.WriteLine("1. Sayıyı Girin: ");
            string giris1 = Console.ReadLine();
            Console.WriteLine("2. Sayıyı Girin: ");
            string giris2 = Console.ReadLine();

            s1 = Convert.ToInt32(giris1);
            s2 = Convert.ToInt32(giris2);

            toplam = s1 + s2;

            Console.WriteLine(s1+" + "+s2+" = "+toplam);
            Console.ReadLine();
            */

            //3- Tasarruf Hesaplayıcısı
            //Kaç Ampul ? Kaç Saat ? 
            // Normal Ampul saatte 2 TL
            // Tasarruflu Ampul ise %20

            //Çıktı olarak: Normal ampul faturası, Tasarruflu ampul faturası
            int fiyat = 2;
            Console.WriteLine("Evde kaç adet ampulünüz var : ");
            int ampulAdet =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Evde kaç saat ampul kullanıyorsunuz : ");
            int saat = Convert.ToInt32(Console.ReadLine());

            float faturaTutari = ampulAdet*saat*fiyat;
            float tasarrufluMaaliyet = faturaTutari * 80/100;

            Console.WriteLine("Tasarruflu Maliyeti " + tasarrufluMaaliyet);
            Console.WriteLine("Normalin Maliyeti "   + faturaTutari);






        }
    }
}
