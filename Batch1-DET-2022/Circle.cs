using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Circle
    {
        double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double area()
        {
            return Math.PI * radius * radius; 
        }
    }
}
