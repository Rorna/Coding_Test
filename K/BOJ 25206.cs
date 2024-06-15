/*
 *      https://www.acmicpc.net/problem/25206
 *      BOJ 25206
 */

using System;

namespace CodingTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            float totalGrade = 0;
            float sumScore = 0;
            float sumMajorGrade = 0;

            for (int i = 0; i < 20; i++)
            {
                string[] inputArr = Console.ReadLine().Split(' ');
                float score = float.Parse(inputArr[1]);
                float majorScore = 0;
                string alphabet = inputArr[2];
                float subjectGrade = 0;

                if(alphabet == "P")
                    continue;

                sumScore += score;

                switch (alphabet)
                {
                    case "A+":
                        subjectGrade = 4.5f;
                        break;

                    case "A0":
                        subjectGrade = 4.0f;
                        break;

                    case "B+":
                        subjectGrade = 3.5f;
                        break;

                    case "B0":
                        subjectGrade = 3.0f;
                        break;

                    case "C+":
                        subjectGrade = 2.5f;
                        break;
                    case "C0":
                        subjectGrade = 2.0f;
                        break;
                    case "D+":
                        subjectGrade = 1.5f;
                        break;
                    case "D0":
                        subjectGrade = 1.0f;
                        break;
                    case "F":
                        subjectGrade = 0f;
                        break;
                }

                majorScore = subjectGrade * score;
                sumMajorGrade += majorScore;
            }

            totalGrade = sumMajorGrade / sumScore;
            Console.WriteLine(totalGrade);
        }

    }
}