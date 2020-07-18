using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*

                int        - whole numbers
                long       - whole numbers (bigger range)
                float      - floating-point numbers
                double     - double precision
                decimal    - monetary values
                char       - single character
                bool       - Boolean 
                DateTime   - moments in time
                string     - sequence of characters


                 */

            int number = 3;
            long number2 = 95;
            float fnumber = 3.4f; //You have to write "f" end of the number (for float data type)
            double fnumber2 = 5.23;
            decimal money = 2.2222M;
            char character = 'a';
            bool isDead = true;
            DateTime date = DateTime.Now;


            Console.WriteLine(date);
            Console.WriteLine(money);
            Console.WriteLine(character);
            Console.WriteLine(isDead);
            Console.ReadLine();


        }
    }
}
