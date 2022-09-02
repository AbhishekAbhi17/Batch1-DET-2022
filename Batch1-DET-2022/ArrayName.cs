using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class ArrayName
    {
        public static void Main()
        {
            string[] names = { "john", "peter", "jacob", "marry", "jackson" };
            var names1 = from n in names
                         where n.Contains("o")
                         select n;
            foreach (string n in names1)
                Console.WriteLine(n);
        }
    }
}
