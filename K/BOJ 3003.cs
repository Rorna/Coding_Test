/*
 *      https://www.acmicpc.net/problem/3003
 *      BOJ 3003
 */

using System;
using System.Linq;

namespace CodingTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] inputArr = Console.ReadLine().Split(' ');
            var intArr = inputArr.Select(int.Parse).ToArray(); //string[] to int[]

            int needK = 1, needQ = 1, needL = 2, needB = 2, needN = 2, needP = 8;

            intArr[0] = needK - intArr[0];
            intArr[1] = needQ - intArr[1];
            intArr[2] = needL - intArr[2];
            intArr[3] = needB - intArr[3];
            intArr[4] = needN - intArr[4];
            intArr[5] = needP - intArr[5];

            string result = String.Empty;
            for (int i = 0; i < intArr.Length; i++)
            {
                result += $"{intArr[i]} ";
            }

            Console.WriteLine(result);
        }
    }
}