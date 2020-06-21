using System;

namespace ConsoleAppLab4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] Blacklist = {"buy", "viagra", "XXX", "free money", "lifetime offer", "send money", "bank account", "nigeria", "online",
            "pharmacy", "h8te", "meet girls"};

            string message = Console.ReadLine();
            bool isSpam = false;
            message = message.ToLower();
            for (int i = 0; i < Blacklist.Length; i++)
            {
                if (message.Contains(Blacklist[i]))
                {
                    isSpam = true;
                }
            }


            if (isSpam == true)
            {
                Console.WriteLine("The message contains spam. Write another one.");
            }
            else
            {
                Console.WriteLine("The message is accepted");
            }
        }
    }
}
