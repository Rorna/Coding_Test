// https://www.acmicpc.net/problem/10811
// BOJ 10811

/*
 *
 *
 */

using System;

namespace CodingTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] inputArr = Console.ReadLine().Split(' ');
            int length = int.Parse(inputArr[0]);
            int count = int.Parse(inputArr[1]);

            int[] arr = new int[length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            for (int i = 0; i < count; i++)
            {
                string[] acttionArr = Console.ReadLine().Split(' ');
                int from = int.Parse(acttionArr[0]) - 1;
                int to = int.Parse(acttionArr[1]) - 1;

                Reverse(arr, from, to);
            }

            string result = "";
            foreach (var n in arr)
            {
                result += $"{n} ";
            }

            Console.WriteLine(result);
        }

        private static void Reverse(int[] arr, int from, int to)
        {
            //바꾸고 줄이고
            while (from < to)
            {
                (arr[from], arr[to]) = (arr[to], arr[from]);

                from++;
                to--;
            }
        }
    }
}