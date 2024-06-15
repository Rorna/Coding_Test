//bj 2525.txt

using System;

namespace CodingTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string realTimeStr = Console.ReadLine();
            var realTimeArr = realTimeStr.Split(' ');

            int rh = int.Parse(realTimeArr[0]);
            int rm = int.Parse(realTimeArr[1]);
            int cookTime = int.Parse(Console.ReadLine());

            int h = cookTime / 60;
            int m = cookTime % 60;

            rh = h > 0 ? rh + h : rh;
            rm += m;

            if (rm / 60 > 0)
            {
                rh += rm / 60;
                rm = rm % 60;
            }

            rh = rh >= 24 ? rh - 24 : rh;
            Console.WriteLine($"{rh} {rm}");
        }
    }
}


 