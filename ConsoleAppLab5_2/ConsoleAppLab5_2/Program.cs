using System;
using System.Collections.Generic;



namespace ConsoleAppLab5_2
{
    class Program
    {


        enum Days
        {

            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            List<string> taskList = new List<string>();

            foreach (Days day in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine("Enter a new task for " + day);
                string task = day + " : " + Console.ReadLine();
                taskList.Add(task);

            }

            foreach(string task in taskList)
            {
                Console.WriteLine(task);
            }
        }
    }
}
