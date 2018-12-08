using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sheela_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] maarach1 = { 1, 3, 5, 10 };
            int[] maarach2 = { 2, 5, 8, 7 };
            WhichArrayIsBigger(maarach1, maarach2);
            Console.WriteLine(WhichArrayIsBigger(maarach1, maarach2));

        }
        private static int WhichArrayIsBigger(int[]arr1,int[]arr2)
        { 
                int sum1 = 0;
                int sum2 = 0;
                for (int i = 0; i < arr1.Length; i++)
                {
                    sum1 = sum1 + arr1[i];
                }
                for (int i = 0; i < arr2.Length; i++)
                {
                    sum1 = sum1 + arr2[i];
                }
                if (sum1 > sum2)
                    return 1;
                else if (sum2 > sum1)
                    return 2;
                else
                    return 0;
                
        
        }
    }
}
