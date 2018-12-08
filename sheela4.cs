using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sheela4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int[,] Randomatrix =    FillRandom();
            
            for (int i =1 ; i < 11; i++)
            {
                CheckExist(Randomatrix);
            }
            
        }

        private static void CheckExist(int[,]arr)
        {
            Console.WriteLine("enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j]==number)
                    {
                        Console.WriteLine("exist");
                    }
                    else
                        sum = sum + 1;
                }
            }
            if (sum == 100)
                Console.WriteLine("missing");
        }

        private static int[,]FillRandom()
        {
            Random randomgenerator = new Random();
            int[,] arr = new int[10, 10];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = randomgenerator.Next(1, 1001);
                }
            }
            return arr;
        }
    }
}
