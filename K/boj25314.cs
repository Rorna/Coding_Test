//https://www.acmicpc.net/problem/25314
//boj25314

using System;

namespace CodingTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int n4 = input / 4;
            string intStr = "int";

            string longStr = "";
            for (int i = 0; i < n4; i++)
            {
                longStr += "long ";
            }

            string resultStr = longStr + intStr;
            Console.WriteLine(resultStr);
        }
    }
}


 