using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class LinqLearning1
    {
        public static void Main()
        {
            Sample_Aggregate_Lambda_Simple();
            Sample_Average_Lambda();
            Sample_Count_Lambda();
            Sample_Max_Lambda();
            Sample_Min_Lambda();
            Sample_Sum_Lambda();
            Sample_Distinct_Lambda();
            Sample_Except_Lambda();
            Sample_Intersect_Lambda();
            Sample_Union_Lambda();
            String_Groupby();

            static void Sample_Aggregate_Lambda_Simple()
            {
                var numbers = new int[] { 1, 2, 3, 4, 5 };

                var result = numbers.Aggregate((a, b) => a * b);

                Console.WriteLine("Aggregated numbers by multiplication:");
                Console.WriteLine(result);
            }
            static void Sample_Average_Lambda()
            {
                int[] numbers = { 10, 10, 11, 11 };

                var result = numbers.Average();

                Console.WriteLine("Average is:");
                Console.WriteLine(result);
            }
            static void Sample_Count_Lambda()
            {
                string[] names = { "Abhi", "Ram", "Vinay", "Allen" };

                var result = names.Count();

                Console.WriteLine("Counting names gives:");
                Console.WriteLine(result);
            }
            static void Sample_Max_Lambda()
            {
                int[] numbers = { 2, 8, 5, 6, 1, 22 };

                var result = numbers.Max();

                Console.WriteLine("Highest number is:");
                Console.WriteLine(result);
            }
            static void Sample_Min_Lambda()
            {
                int[] numbers = { 6, 9, 3, 7, 5, 0 };

                var result = numbers.Min();

                Console.WriteLine("Lowest number is:");
                Console.WriteLine(result);
            }
            static void Sample_Sum_Lambda()
            {
                int[] numbers = { 2, 5, 10, 20 };

                var result = numbers.Sum();

                Console.WriteLine("Summing the numbers yields:");
                Console.WriteLine(result);
            }
            static void Sample_Distinct_Lambda()
            {
                int[] numbers = { 1, 2, 2, 3, 5, 6, 6, 6, 8, 9, 9, 10 };

                var result = numbers.Distinct();

                Console.WriteLine("Distinct removes duplicate elements:");
                foreach (int number in result)
                    Console.WriteLine(number);
            }
            static void Sample_Except_Lambda()
            {
                int[] numbers1 = { 1, 2, 3 };
                int[] numbers2 = { 3, 4, 5 };

                var result = numbers1.Except(numbers2);

                Console.WriteLine("Except creates a single sequence from numbers1 and removes the duplicates found in numbers2:");
                foreach (int number in result)
                    Console.WriteLine(number);
            }
            static void Sample_Intersect_Lambda()
            {
                int[] numbers1 = { 1, 2, 3 };
                int[] numbers2 = { 3, 4, 5 };

                var result = numbers1.Intersect(numbers2);

                Console.WriteLine("Intersect creates a single sequence with only the duplicates:");
                foreach (int number in result)
                    Console.WriteLine(number);
            }
            static void Sample_Union_Lambda()
            {
                int[] numbers1 = { 1, 2, 3 };
                int[] numbers2 = { 3, 4, 5 };

                var result = numbers1.Union(numbers2);

                Console.WriteLine("Union creates a single sequence and eliminates the duplicates:");
                foreach (int number in result)
                    Console.WriteLine(number);
            }
            static void String_Groupby()
            {
                List<string> words = new List<string> { "basket", "blueberry", "chimpanze", "abacus", "banana", "apple", "cheese" };
                var wordGroups = words.GroupBy(x => x.Length).Select
                    (y => new { FirstLetter = y.Key, words = y });
                foreach (var item in wordGroups)
                {
                    Console.WriteLine("words that start with the" + "letter'{0}':", item.FirstLetter);
                    foreach (var w in item.words)
                    {
                        Console.WriteLine(w);
                    }
                }
            }

        }
    }
}

