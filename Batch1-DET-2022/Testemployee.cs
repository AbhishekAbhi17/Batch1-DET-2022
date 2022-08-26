using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Testemployee
    {
        public static void Main()
        {
            Employee e = new Employee(1, "ram", "asddf", 8888, 4567899, 760000, 7500);
            float NET = e.GetNetSalary();
            string GRADE = e.GetGrade();
            Console.WriteLine($"nET SALARY ={NET}, Grade = {GRADE}");
        }
    }
}
