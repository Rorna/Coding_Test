/*
 *      https://www.acmicpc.net/problem/5622
 *      BOJ 5622
 */

using System;

namespace CodingTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] arr = { 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 8, 9, 9, 9, 10, 10, 10, 10 };

            string inputText = Console.ReadLine();
            var inputArr = inputText.ToCharArray();

            int sum = 0;
            for (int i = 0; i < inputArr.Length; i++)
            {
                int index = inputArr[i] - 65;
                sum += arr[index];
            }

            Console.WriteLine(sum);
        }

    }
}