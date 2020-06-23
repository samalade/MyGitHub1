using System;

namespace ConsoleAppLAB5_4
{
    class Program
    {
        public struct Mario
        {
            public enum Size
            {
                small,
                medium,
                large
            }
            
            public int numberofLives;
            public string currentstage;
            public Size sizeOfMario;
            public bool shootfireballs;
            public bool Jumping;
            public int numberofCoins;

            static void Main(string[] args)
            {
                Mario mario = new Mario();
                mario.numberofLives = 5;
                mario.currentstage = "World 4 - level 3";
                mario.sizeOfMario = Mario.Size.medium;
                mario.shootfireballs = true;
                mario.Jumping = true;
                mario.numberofCoins = 50;


                Console.WriteLine("Mario is running through the level and meets a Gooba. Set Mario to jumping so he can kill it");
                mario.Jumping = true;


                Console.WriteLine("Mario squashes the Gooba. Now he needs to land!");
                mario.Jumping = true;

                Console.WriteLine("Mario hits a block and finds a 1UP. Increase Mario's life by one.");
                mario.numberofLives += 1;


                Console.WriteLine("Mario finds a secret Fire Flower and can now shoot fireballs. Change mario!");
                mario.shootfireballs = true;

                Console.WriteLine("Mario finds another power up mushroom and gets big. Change Mario");
                mario.sizeOfMario = Mario.Size.large;

                Console.WriteLine("Mario finds gold coins. Give Mario 50 coins.");
                mario.numberofCoins = 50;

                Console.WriteLine("Mario finshes the level! Change Mario's current level to World 4 - Level 4");
                mario.currentstage = "World 4 - level 4";
                

            }
        }
    }
}
