using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> sayilar = new List<int>();
            sayilar.Add(3);
            sayilar.Add(5);
            sayilar.Add(7);
            sayilar.Add(1);
            sayilar.Add(4);
            sayilar.Add(12);
            sayilar.Add(5);

            sayilar.Remove(3);

            /*
            
            Remove fonksiyonunu Remove(x) olarak düşünürsek eğer ;

                sayilar = [3,5,7]  olan bir listede 
                Remove(x) fonksiyonunda x yerine verdiğimiz değeri Liste içerisinnde bulup onu Listeden çıkartır

                Örneğin;
                sayilar.Remove(5) diye bir işlem gönderirsek sayilar array'i artık aşağıdaki gibi olur:
                
                sayilar = [3,7]
                
                
            

            RemoveAt fonksiyonunu RemoveAt(x) olarak düşünürsek eğer;
                
                sayilar = [3,5,7]  olan bir listede 
                RemoveAt(x) fonksiyonunda x yerine verdiğimiz değeri index olarak düşünür ve Liste içerisinde x indexindeki değeri listeden çıkartır.

                Örneğin;
                
                sayilar.RemoveAt(3) diye bir işlem gönderirsek;
                List index out of range hatası alırız çünkü sayilar listesinde 3. index bulunmamaktadır.
                
                fakat 
                
                sayilar.RemoveAt(0) diye bir işlem gönderirsek sayilar array'i artık aşağıdaki gibi olur:
                    sayilar = [5,7]

             */

            sayilar.RemoveAt(0);

            
            sayilar.Clear(); //listenin tüm elemanlarını temizler

            sayilar.Add(3);
            sayilar.Add(5);
            sayilar.Add(7);
            sayilar.Add(1);
            sayilar.Add(4);
            sayilar.Add(12);
            sayilar.Add(5);

            sayilar.Remove(5); //Remove(5) fonksiyonu Listede bulduğu ilk 5 değerini kaldırdı ve breakledi

            int listeuzunluk = sayilar.Count; //listenin uzunluğunu verir

            if ( sayilar.Contains(1) )
            {
                Console.WriteLine("Listem 1 içeriyor.");

                for (int i = 0; i < listeuzunluk ; i++)
                {

                    Console.WriteLine(sayilar[i]);

                }

            }


            
            




        }
    }
}
