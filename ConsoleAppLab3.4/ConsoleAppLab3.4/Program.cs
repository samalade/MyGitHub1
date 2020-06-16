using System;
using System.Text.RegularExpressions;
namespace ConsoleAppLab3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @" [d-e]";
            string input = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden
            base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies
            managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored
            space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister
            agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can
            save her people and restore freedom to the galaxy….";
            RegexOptions options = RegexOptions.Multiline;

            foreach (Match m in Regex.Matches(input, pattern, options))
            {
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            }

            string pattern2 = @" [d-e][*d]";
            string input2 = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden
            base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies
            managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored
            space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister
            agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can
            save her people and restore freedom to the galaxy….";
            RegexOptions options2 = RegexOptions.Multiline;

            foreach (Match m in Regex.Matches(input2, pattern2, options2))
            {
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            }

            string pattern3 = @"[a][a-z][a]";
            string input3 = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden
            base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies
            managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored
            space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister
            agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can
            save her people and restore freedom to the galaxy….";
            RegexOptions options3 = RegexOptions.Multiline;

            foreach (Match m in Regex.Matches(input3, pattern3, options3))
            {
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            }

            string pattern4 = @"[ ][p][a-z]*";
            string input4 = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden
            base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies
            managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored
            space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister
            agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can
            save her people and restore freedom to the galaxy….";
            RegexOptions options4 = RegexOptions.Multiline;

            foreach (Match m in Regex.Matches(input4, pattern4, options4))
            {
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            }

            string pattern5 = @"[a-z]*[e][ ]";
            string input5 = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden
            base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies
            managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored
            space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister
            agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can
            save her people and restore freedom to the galaxy….";
            RegexOptions options5 = RegexOptions.Multiline;

            foreach (Match m in Regex.Matches(input5, pattern5, options5))
            {
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            }

            string pattern6 = @"[A-Z]";
            string input6 = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden
            base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies
            managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored
            space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister
            agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can
            save her people and restore freedom to the galaxy….";
            RegexOptions options6 = RegexOptions.Multiline;

            foreach (Match m in Regex.Matches(input6, pattern6, options6))
            {
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);

            }
        }
    }
}
