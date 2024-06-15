//BOJ25304
//https://www.acmicpc.net/problem/25304

using System;

namespace CodingTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            long totalPrice = long.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            int sumPrice = 0;

            for (int i = 0; i < num; i++)
            {
                string[] strArr = Console.ReadLine().Split(' ');
                sumPrice += (int.Parse(strArr[0]) * int.Parse(strArr[1]));
            }

            string result = totalPrice == sumPrice ? "Yes" : "No";
            Console.WriteLine($"{result}");
        }
    }
}


 