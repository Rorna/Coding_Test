/*
 *      https://www.acmicpc.net/problem/2738
 *      BOJ 2738
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
            var intArr = inputArr.Select(int.Parse).ToArray(); //string[] to int[], 행 열

            int[,] A_arr = new int[intArr[0], intArr[1]];
            int[,] B_arr = new int[intArr[0], intArr[1]];

            //값 세팅
            for (int i = 0; i < intArr[0]; i++)
            {
                string[] valueArr = Console.ReadLine().Split(' ');
                for (int j = 0; j < intArr[1]; j++)
                {
                    A_arr[i, j] = int.Parse(valueArr[j]);
                }
            }

            for (int i = 0; i < intArr[0]; i++) 
            {
                string[] valueArr = Console.ReadLine().Split(' ');
                for (int j = 0; j < intArr[1]; j++)
                {
                    B_arr[i, j] = int.Parse(valueArr[j]);
                }
            }

            int[,] resultArr = new int[intArr[0], intArr[1]];
            for (int i = 0; i < intArr[0]; i++)
            {
                for (int j = 0; j < intArr[1]; j++)
                {
                    resultArr[i, j] = A_arr[i, j] + B_arr[i, j];
                }
            }

            //print
            for (int i = 0; i < resultArr.GetLength(0); i++)
            {
                for (int j = 0; j < resultArr.GetLength(1); j++)
                {
                    Console.Write($"{resultArr[i, j]} ");
                }

                Console.WriteLine();
            }
        }
    }
}