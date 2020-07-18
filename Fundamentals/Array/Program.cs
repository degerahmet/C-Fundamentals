using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi oluşturma
            int[] sayilar = new int[10];

            //Değer Verme
            sayilar[0] = 45;
            sayilar[1] = 15;
            sayilar[9] = 55;
            //Console.WriteLine(sayilar[0]);
            //Doldurulmayan kısımlar 0 olarak atanır

            //Aynı zamanda şu şekilde de Array oluştururken değer verebiliriz

            string[] isimler = { "Ayşe", "Ahmet", "Mehmet" };

            Console.WriteLine(isimler[1]);
            //array uzunluğunu görmek için .Length fonksiyonunu çağırıyoruz
            Console.WriteLine(isimler.Length);



        }
    }
}
