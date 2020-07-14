using System;

namespace ConsoleApp10_4lab
{

    class Program
    {
        static void Main(string[] args)
        {
            Artist kendrick = new Artist("Kendrick Lamar");
            kendrick.AddToPlaylist("ADHD");
            kendrick.AddToPlaylist("Alright");
            kendrick.AddToPlaylist("Sing About Me");
            kendrick.AddToPlaylist("Rigamortis");

            MediaPlayer player = new MediaPlayer();
            player.PlayMedia(kendrick);

            AudioBook howto = new AudioBook("The Achelmist", "Paulo Coelho");
            player.PlayMedia(howto);

            MovieSoundTrack Inception = new MovieSoundTrack("Inception");
            Inception.SelectTrack("Opening theme : Time");
            player.PlayMedia(Inception);
        }
    }
}


