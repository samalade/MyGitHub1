using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLAB7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DatingProfile Samuel = new DatingProfile("Samuel", "Alade", 33, "Male");
            Samuel.WriteBio("I love sports, I love listening to music,");

            DatingProfile Vivian = new DatingProfile("Vivian", "Gordon", 27, "Female");
            Vivian.WriteBio("new to this site. Hoping to find new friends");


            Samuel.SendMessage("Hello, Vivian", "Want to go out to the park", Vivian);
            Vivian.ReadMessage();

            Vivian.SendMessage("Hey, Samuel", "Yes. I would like to go out to the park with you. what time?", Samuel);
            Samuel.ReadMessage();

            Samuel.SendMessage("Okay, Vivian", "Be there at 1 pm :)", Vivian);
            Vivian.ReadMessage();

            Vivian.SendMessage("Ok, Samuel", "I'll be there :)", Samuel);
            Samuel.ReadMessage();









        }
    }
}
