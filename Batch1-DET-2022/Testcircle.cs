using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Testcircle
    {
        public static void Main()
        {
            Circle c = new Circle(10);

            Console.WriteLine($"area of circle is{c.area()}");
        }
    }
}
