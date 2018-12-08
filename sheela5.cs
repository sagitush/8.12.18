using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sheela5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] maarach = { -5, -10, 15, 2, 5, 100 };
            SortArray(maarach);
            PrintArray(maarach);
        }

        private static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        private static void SortArray(int[]arr)
        {
            int b = 0;
            int a = 0;
            int c=-1;
            
            for (int i = 0; i < arr.Length; i++)
            {
                int d = int.MaxValue;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j]<d)
                    {
                        c = j;
                        d = arr[j];
                    }
                   
                    
                }
                a = arr[i];
                b = arr[c];
                arr[i] = b;
                arr[c] = a;

            }
        }
    }
}
