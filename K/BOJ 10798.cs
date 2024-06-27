/*
 *      https://www.acmicpc.net/problem/10798
 *      BOJ 10798
 */

using System;

namespace CodingTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //init
            char[,] arr = new char[15, 15];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = '-';
                }
            }

            for (int i = 0; i < 5; i++)
            {
                var inputArr = Console.ReadLine().ToCharArray();
                for (int j = 0; j < inputArr.Length; j++)
                {
                    arr[i, j] = inputArr[j];
                }
            }

            string result = string.Empty;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[j, i] != '-')
                        result += arr[j, i];
                }
            }

            Console.WriteLine(result);
        }
    }
}

///
///  C#에서 2차원 배열의 인덱스는 [row, column] 순서로 접근해야 합니다.
/// 