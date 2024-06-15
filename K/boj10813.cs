// https://www.acmicpc.net/problem/10813
// boj10813

using System;

namespace CodingTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            (a, b) = (b,a);

            string[] inputArr = Console.ReadLine().Split(' ');
            int length = int.Parse(inputArr[0]);
            int count = int.Parse(inputArr[1]);

            //data
            int[] arr = new int[length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            for (int i = 0; i < count; i++)
            {
                string[] acttionArr = Console.ReadLine().Split(' ');
                int start = int.Parse(acttionArr[0]) - 1;
                int end = int.Parse(acttionArr[1]) - 1;

                (arr[start], arr[end]) = (arr[end], arr[start]);
            }

            string result = "";
            foreach (var n in arr)
            {
                result += $"{n} ";
            }

            Console.WriteLine(result);
        }
    }
}


 