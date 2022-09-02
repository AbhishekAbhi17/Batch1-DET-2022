using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class LinqLearning
    {
        public static void Main()
        {
            Sample_OrderByDescending_Lambda();
            Sample_OrderBy_Lambda_Numbers();
            Sample_Reverse_Lambda();
            Sample_ThenBy_Lambda();
        }
        //public static void SampleIntList()
        //  {
        //      //The Three Parts of a LINQ Query deffered execution
        //      //1. Data source
        //      List<int> numbers = new List<int>();
        //      numbers.Add(110);
        //      numbers.Add(100);
        //      numbers.Add(105);
        //      numbers.Add(102);

        //      //2. Query creation. sql type
        //      //var numQuery = from num in numbers //select num from numbers

        //      //select num;

        //      //lambda exp
        //      //var numQuery = numbers.Select(x => x);
        //      //early execution
        //      var numQuery = (from num in numbers //select num from numbers
        //                   where num > 102
        //                   select num).ToList();

        //      //var numQuery = numbers.Where(x => x > 102);
        //      //3. Query execution
        //      foreach (int num in numQuery)
        //      {
        //          Console.Write("{0}", num);
        //          //num.Dump(); //this is for LINQpad not for VS
        //      }
        //      Console.ReadLine();
        //  }
        public static void Sample_OrderBy_Lambda_Numbers()
        {
            int[] numbers = { 7, 9, 5 };

            var result = numbers.OrderBy(n => n);

            Console.WriteLine("Ordered list of numbers:");
            foreach (int number in result)
                Console.WriteLine(number);
        }
        public static void Sample_OrderByDescending_Lambda()
        {
            string[] names = { "Ned", "Ben", "Susan","Abhi","Ram" };

            var result = names.OrderByDescending(n => n);

            Console.WriteLine("Descending ordered list of names:");
            foreach (string name in result)
                Console.WriteLine(name);
        }
        public static void Sample_Reverse_Lambda()
        {
            char[] characters = { 'a','b','h','i'};

            var result = characters.Reverse();

            Console.WriteLine("Characters in reverse order:");
            foreach (char character in result)
                Console.WriteLine(character);
        }
        static void Sample_ThenBy_Lambda()
        {
            string[] capitals = { "Berlin", "Paris", "Madrid", "Tokyo", "London",
                          "Athens", "Beijing", "Seoul" };

            var result = capitals.OrderBy(c => c.Length).ThenBy(c => c);

            Console.WriteLine("Ordered list of capitals, first by length and then alphabetical:");
            foreach (string capital in result)
                Console.WriteLine(capital);
        }

    }
}
