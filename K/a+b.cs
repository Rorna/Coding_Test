using System;
using System.Collections.Generic;

namespace CodingTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter: ");
            string input = Console.ReadLine();

            string[] num = input.Split(' ');

            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += int.Parse(num[i]);
                
            }
            Console.WriteLine(sum);
        }

        private static string[] GetStdin()
        {
            var list = new List<string>();
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                list.Add(line);
            }
            return list.ToArray();
        }

    }
}


 