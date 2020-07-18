using System;


    class Program
{
    static void Main(string[] args)
    {
        int[] sayilar = new int[] { 1, 2, 5, 10, 33, 64, 62, 32, 54 };
        foreach (double sayi in sayilar)
        {
            Console.WriteLine(sayi);
        }
    }
}

