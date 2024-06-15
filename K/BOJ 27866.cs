/*
 *      https://www.acmicpc.net/problem/27866
 *      BOJ 27866
 */

using System;
using System.Collections.Generic;

namespace CodingTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            int index = int.Parse(Console.ReadLine());

            List<string> strList = new List<string>();
            char[] charArr = inputStr.ToCharArray();

            Console.WriteLine(charArr[index - 1]);
        }

    }
}