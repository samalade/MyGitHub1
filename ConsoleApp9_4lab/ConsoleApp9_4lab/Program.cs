using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp9_4lab
{
    class FileWriter
    {
        public void CreateHTML(StringBuilder htmlText)
        {
            File.WriteAllText("C:\\weblogs\\myHTML.html", htmlText.ToString());
        }

    }



    class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");

                StringBuilder htmlText = new StringBuilder();
                FileWriter mywriter = new FileWriter();
                string bodyOpen = "<body>";
                string bodyClose = "</body>";
                string headingopen = "<h1>";
                string headingclose = "</h1>";
                string ul1Open = "<ul>";
                string ul1Close = "</ul>";
                string ul2Open = "<ul>";
                string ul2Close = "</ul>";
                string ul3Open = "<ul>";
                string ul3Close = "</ul>";
                Console.WriteLine("Enter some text for your heading");
                string headingHTML = Console.ReadLine();
                Console.WriteLine("Enter some text for your first listed item");
                string ul1HTML = Console.ReadLine();
                Console.WriteLine("Enter some text for your second listed item");
                string ul2HTML = Console.ReadLine();
                Console.WriteLine("Enter some text for your third listed item");
                string ul3HTML = Console.ReadLine();



                htmlText.Append(bodyOpen);
                htmlText.Append(headingopen);
                htmlText.Append(headingHTML);
                htmlText.Append(headingclose);
                htmlText.Append(ul1Open);
                htmlText.Append(ul1HTML);
                htmlText.Append(ul1Close);
                htmlText.Append(ul2Open);
                htmlText.Append(ul2HTML);
                htmlText.Append(ul2Close);
                htmlText.Append(ul3Open);
                htmlText.Append(ul3HTML);
                htmlText.Append(ul3Close);
                htmlText.Append(bodyClose);
                mywriter.CreateHTML(htmlText);
            }
      
    }
}
    