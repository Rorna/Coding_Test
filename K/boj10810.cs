//https://www.acmicpc.net/problem/10810
//boj10810

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
            for (int i = 0; i < count; i++)
            {
                string[] acttionArr = Console.ReadLine().Split(' ');
                int from = int.Parse(acttionArr[0]) - 1;
                int to = int.Parse(acttionArr[1]) - 1;
                int num = int.Parse(acttionArr[2]);

                for (int j = from ; j <= to; j++)
                {
                    arr[j] = num;
                }
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


 