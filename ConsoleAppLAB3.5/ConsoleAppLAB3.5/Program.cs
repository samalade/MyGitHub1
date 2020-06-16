using System;

namespace ConsoleAppLAB3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string Fire1 = "bomb";

            bool isSpam = false;
            string message = Console.ReadLine();
            if (message.Contains(Fire1))
            {
                isSpam = true;
                Console.WriteLine("This message is spam. Create a new message");
            }
            else
            {
                isSpam = false;
                Console.WriteLine("This message is not spam. This message is accepted");
            }


        }
    }
}
