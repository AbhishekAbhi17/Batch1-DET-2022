using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class ParamsDemo
    {
        public static int sum(params int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
                sum += i;
            return sum;
        }
        public static void Main()
        {
            Console.WriteLine(sum(1, 2, 3));
            Console.WriteLine(sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));

            int[] a = { 1, 2, 3, 4, 5, 6, 7, 9, 10 };
            Console.WriteLine(sum(a));
        }
    }
}
