using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            //başlangıç ; koşul ; attırma ya da azaltma işlemi

            Console.WriteLine("Lütfen bir sayı girin: ");
            int girdi = Convert.ToInt32(Console.ReadLine());
            


            for (int i = 1; i <= girdi; i++)
            {
                Console.WriteLine(i);
            }


        }
    }
}
