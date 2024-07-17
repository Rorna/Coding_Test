/* https://www.acmicpc.net/problem/2745
 * BOJ2745
 */

using System;

namespace CodingTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 입력 받기
            string[] inputArr = Console.ReadLine().Split(' ');
            string bInput = inputArr[0];
            int baseInput = int.Parse(inputArr[1]);

            // 10진법 결과를 저장할 변수
            int result = 0;

            // 입력된 진법 수의 각 자리 처리
            for (int i = 0; i < bInput.Length; i++)
            {
                // 현재 자리의 문자
                char c = bInput[i];

                // 문자를 숫자로 변환
                int value;
                if (char.IsDigit(c))
                {
                    value = c - '0'; // '0'~'9' -> 0~9
                }
                else
                {
                    value = c - 'A' + 10; // 'A'~'Z' -> 10~35
                }

                // 결과에 더하기 (기존 결과를 baseInput으로 곱하고 현재 값을 더함)
                result = result * baseInput + value;
            }

            // 결과 출력
            Console.WriteLine(result);
        }
    }
}


/*
 * 다른 방법
 * private static void Main(string[] args)
        {
            // 입력 받기
            string[] inputArr = Console.ReadLine().Split(' ');
            string bInput = inputArr[0];
            int baseInput = int.Parse(inputArr[1]);

            // Convert.ToInt32 메서드를 이용하여 B진법 수를 10진법으로 변환
            int result = Convert.ToInt32(bInput, baseInput);

            // 결과 출력
            Console.WriteLine(result);
        }
 */