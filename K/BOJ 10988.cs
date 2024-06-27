/*
 *      https://www.acmicpc.net/problem/10988
 *      BOJ 10988
 */

using System;

namespace CodingTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var inputArr = input.ToCharArray();

            int frontIndex = 0;
            int endIndex = inputArr.Length - 1;

            while (frontIndex <= endIndex)
            {
                if (inputArr[frontIndex] != inputArr[endIndex])
                {
                    Console.WriteLine(0);
                    return;
                }

                frontIndex++;
                endIndex--;
            }

            Console.WriteLine(1);
        }
    }
}