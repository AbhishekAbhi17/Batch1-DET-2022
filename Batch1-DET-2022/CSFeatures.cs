using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class CSFeatures
    {
        public static void Main()
        {
            Action<string> action = (string name) => { Console.WriteLine($"Hai {name}"); };
            Action<string, string> action1 = (string s1, string s2) => { Console.WriteLine($"Hai {s1}," + $"you said {s2}"); };
            action.Invoke("abcd");
            action1.Invoke("abcd", "am in blr");
        }
    
    }

}
