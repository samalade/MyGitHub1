using System;

namespace ConsoleApp8_5LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            DreamHouseHunters hhContestant = new DreamHouseHunters("Full Stack Web Developer", 100000, 6, 3, 2, "Omar", "Smith", "2/4/1975",
                "111 Bravo Way", "Los Angeles", "California", 90001, "888-233-1234", "omar.smith@hotmail.com");

            ParadiseIsland piContestant = new ParadiseIsland("Female", "Sidney", 2, "Levi", "Washington", "5/4/1994", "211 MLK Rd", "Queens",
                "New York", 11367, "347-444-1234", "Sidney.wash@gmail.com");

            AboveDeck adContestant = new AboveDeck(26, "American", "Darren", "Lee", "7/12/1964", "311 Kew Gargen Hills", "Flushing",
            "New York", 11360, "347-333-1234", "D.Lee@gmail.com");

            hhContestant.Submit();
            hhContestant.Accept();

            piContestant.Submit();
            piContestant.Accept();

            adContestant.Submit();
            adContestant.Accept();
        }
    }
}
