/*
 *      https://www.acmicpc.net/problem/2563
 *      BOJ 2563
 */

using System;

namespace CodingTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /// 아이디어: 색칠을 bool 값으로 처리함. 차지하는 영역을 true, false
            const int paperSize = 100;
            const int colorPaperSize = 10;

            //background
            bool[,] background = new bool[paperSize, paperSize];

            int colorPaperNum = int.Parse(Console.ReadLine());
            for (int i = 0; i < colorPaperNum; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int x = int.Parse(input[0]);
                int y = int.Parse(input[1]);

                for (int j = x; j < x + colorPaperSize; j++)
                {
                    for (int k = y; k < y + colorPaperSize; k++)
                    {
                        background[j, k] = true;
                    }
                }
            }

            //calculate color
            int coloredArea = 0;
            for (int i = 0; i < background.GetLength(0); i++)
            {
                for (int j = 0; j < background.GetLength(1); j++)
                {
                    if (background[i, j])
                    {
                        coloredArea++;
                    }
                }
            }

            Console.WriteLine(coloredArea);
        }
    }
}
