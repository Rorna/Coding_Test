//https://www.acmicpc.net/problem/5597
// boj5597

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            HashSet<int> h = new HashSet<int>();

            for (int i = 0; i < 28; i++)
            {
                int aNum = int.Parse(Console.ReadLine());
                h.Add(aNum);
            }

            List<int> resultList = new List<int>();

            for (int j = 1; j <= 30; j++)
            {
                if (h.TryGetValue(j, out int exist) == false)
                {
                    resultList.Add(j);
                }
            }
            
            int max = resultList.Max();
            int min = resultList.Min();

            Console.WriteLine(min);
            Console.WriteLine(max);
        }
    }
}


 