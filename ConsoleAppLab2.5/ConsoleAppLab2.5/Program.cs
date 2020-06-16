using System;

namespace ConsoleAppLab2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int num1;
            int num2;

            
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value for the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            
            int result = num1 + num2;
            Console.WriteLine("The answer is:");
            Console.WriteLine(result);
            
            result = num1 * num2;
            Console.WriteLine("The answer is:");
            Console.WriteLine(result);

            string username = "Samuel Aladegbemi";
            Console.WriteLine("Hello" + username);

            double results2 = (double)num1 / (double)num2; 
            double results3 = num1 % num2;  
            Console.WriteLine("The answer is:");
            Console.WriteLine(results2);  
            Console.WriteLine(results3);

            Console.WriteLine("Enter your age");
            Console.WriteLine("You look younger than" + num1);


        }
    }
}
