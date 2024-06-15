/*
 *      https://www.acmicpc.net/problem/9086
 *      BOJ 9086
 */

using System;
using System.Collections.Generic;

namespace CodingTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<string> resultList = new List<string>();

            for (int i = 0; i < count; i++)
            {
                string text = Console.ReadLine();
                var textArr = text.ToCharArray();

                string resultText = $"{textArr[0]}{textArr[textArr.Length - 1]}";
                resultList.Add(resultText);
            }

            Console.WriteLine(string.Join("\n", resultList));
        }

    }
}