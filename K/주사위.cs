주사위


using System;
using System.Linq;

namespace CodingTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
            int c = int.Parse(inputs[2]);

            int prize = CalculatePrize(a, b, c);
            Console.WriteLine(prize);

        }


        static int CalculatePrize(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                // 같은 눈이 3개가 나오는 경우
                return 10000 + a * 1000;
            }
            else if (a == b || a == c)
            {
                // 같은 눈이 2개만 나오는 경우 (a가 b 또는 c와 같은 경우)
                return 1000 + a * 100;
            }
            else if (b == c)
            {
                // 같은 눈이 2개만 나오는 경우 (b와 c가 같은 경우)
                return 1000 + b * 100;
            }
            else
            {
                // 모두 다른 눈이 나오는 경우
                int max = Math.Max(a, Math.Max(b, c));
                return max * 100;
            }
        }
    }
}


 