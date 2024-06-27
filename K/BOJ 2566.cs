/*
 *      https://www.acmicpc.net/problem/2566
 *      BOJ 2566
 */

using System;
using System.Linq;

namespace CodingTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[,] arr = new int[9, 9]; // 9 * 9
            for (int i = 0; i < 9; i++)
            {
                string[] inputArr = Console.ReadLine().Split(' ');
                var intArr = inputArr.Select(int.Parse).ToArray(); //string[] to int[], 행 열
                for (int j = 0; j < 9; j++)
                {
                    arr[i, j] = intArr[j];
                }
            }

            int maxValue = int.MinValue;
            int row = -1;
            int cul = -1;


            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (arr[i, j] > maxValue)
                    {
                        maxValue = arr[i, j];
                        row = i;
                        cul = j;
                    }
                }
            }

            Console.WriteLine(maxValue);
            Console.WriteLine($"{row + 1} {cul + 1}");
        }
    }
}

///
///  C#에서 2차원 배열의 인덱스는 [row, column] 순서로 접근해야 합니다.
/// 