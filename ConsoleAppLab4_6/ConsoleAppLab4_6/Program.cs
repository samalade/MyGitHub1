using System;

namespace ConsoleAppLab4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] Days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            string[] Tasks = new string[7];


            for (int i = 0; i < Days.Length; i++)
            {

                Console.WriteLine("Type in a new Task for " + Days[i]);
                Tasks[i] = Days[i] + " : " + Console.ReadLine();

            }

            for (int i = 0; i < Days.Length; i++)
            {
                Console.WriteLine(Tasks[i]);
            }
        }
    }
}
