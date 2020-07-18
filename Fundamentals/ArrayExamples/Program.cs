using System;

namespace ArrayExamples
{
    class Program
    {   
        

        


        static void Main()
        {
            //10 elemanlı bir diziye 1-200 arasında rastgele sayılar atayın
            //A- 100 den büyük sayıların sayısını bulun
            //B- 150 den küçük sayıların ortalamasını bulun
            //C- Çift sayıların sayısını bulun


            int[] sayilar = new int[10];
            Random rnd = new Random(); //Random sayı elde etme fonksiyonu başlangıcı fonksiyonun devamı

            //10 elemanlı diziye 1-200 arası rastgele sayılar atayacağız

            for (int i = 0; i < sayilar.Length; i++)
            {

                sayilar[i] = rnd.Next(1, 200);

            }

            int yuzdenBuyuk = 0, ortalama = 0, cift = 0, adet = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {

                if (sayilar[i] > 100)
                {
                    yuzdenBuyuk++;
                }

                if (sayilar[i] < 150)
                {
                    ortalama += sayilar[i];
                    adet++;

                }

                if (sayilar[i] % 2 == 0)
                {
                    cift++;
                }
            }

            Console.WriteLine("A- 100den büyük " + yuzdenBuyuk + " adet sayı var");
            Console.WriteLine("B- 150den küçük sayıların ortalaması : " + (float)(ortalama / cift));
            Console.WriteLine("C- Sayılar arrayinde " + cift + " tane çift sayı var");

        }

        public void example1()
        {
            //Bir dizideki en küçük ve en büyük sayıları bulan kodu yazınız


            int[] dizi = new int[] { 1, 5, 2, 6, 10, 222, 15232, 1123, 32, 232, 876, 99998 };

            int diziuzunluk = dizi.Length;
            int temp1 = dizi[0];
            int temp2 = dizi[0];
            Console.WriteLine(diziuzunluk);

            for (int i = 0; i < diziuzunluk; i++)
            {
                if (dizi[i] > temp1)
                {
                    temp1 = dizi[i];
                }

                if (dizi[i] < temp2)
                {
                    temp2 = dizi[i];
                }
            }

            Console.WriteLine("Dizideki en büyük sayı: " + temp1);
            Console.WriteLine("Dizideki en küçük sayı: " + temp2);
        }

        


    }
}
