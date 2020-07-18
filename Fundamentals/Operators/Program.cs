using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // + - * /
            // ++ -- 
            // "ali" + "veli"
            // = -= += 


            int number = 5, number2 = 11;

            int toplam = number + number2;
            int fark = number - number2;
            int carpim = number * number2;
           

            float bolum = number2 / number;



            //Console.WriteLine(toplam);
            //Console.WriteLine(fark);
            //Console.WriteLine(carpim);
            //Console.WriteLine(bolum);
            //Console.ReadLine();

            int sayi = 5; 
            long buyukSayi = 9;

            long sayi3 = sayi;

            int sayi5 = (int)buyukSayi;

            //String

            string a = "3";
            string b = "9";

            //Convert
            int toplam2 = Convert.ToInt32(a) + Convert.ToInt32(b);
            Console.WriteLine("String Toplaması --> " + a + b);
            Console.WriteLine("Matematiksel Toplama --> "+toplam2);
            Console.ReadLine();






        }
    }
}
