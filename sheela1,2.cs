using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            IsPrime(number);
            Console.WriteLine(IsPrime(number));
            int[] maarach = { 2, 4, 9, 13, 17 };
            CheckArrayForPrimeNumbers(maarach);
        }
        private static void CheckArrayForPrimeNumbers(int[]arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int m = 2;
                while (arr[i] % m != 0 && m < arr[i])
                {
                    m++;
                }
                if (m < arr[i])
                    Console.WriteLine($"{arr[i]} is not prime");
                else
                    Console.WriteLine($"{arr[i]} is prime");

            }

        }

        private static int IsPrime(int number)
        {
            int m = 2;
            while (number % m != 0 && m < number)
            {
                m++;
            }
            if (m < number)
                return 0;
            else
                return 1;
        }
    }
}
