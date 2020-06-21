using System;
using System.Collections.Generic;

namespace ConsoleAppLab4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> scores = new List<int>();
            scores.Add(1200);
            scores.Add(4400);
            scores.Add(3700);
            scores.Add(8900);
            scores.Add(7200);

            scores.Sort();
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }

            scores.Reverse();

            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }


            scores.Add(2400);
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }



            scores.Remove(4400);
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }

        }
    }
}
