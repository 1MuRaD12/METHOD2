using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 5, 7, 3, 9, 10, 20,50 };

            Console.WriteLine(big(arr, num: arr.Length));
        }

        public static int big(int[] arr, int num)
        {
            int biggest = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] > biggest)
                {
                    biggest = arr[i];
                }
            {
                return biggest;
            }
            
        }
    }
}
