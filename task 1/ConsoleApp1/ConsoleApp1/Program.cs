using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
              

            Console.WriteLine(natural(number:')'));

        }
        public static int natural(int number)
        {
            int count = 0;
            number = 777;

            while (number > 0)
            {
                //number = number % 10;
                number = number / 10;
                count++;
            }
            {
                Console.WriteLine(count);
            }
           
            {
                return number;
            }
        







        }
    }
}
