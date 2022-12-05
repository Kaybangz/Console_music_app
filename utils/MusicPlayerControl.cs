using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_player.utils
{
    public class MusicPlayerControl
    {
        public void Play(List<SongProperties> songs)
        {
            Console.Write("\nSelect song to play: ");
            string? songToPlay = Console.ReadLine();
            
            foreach(var song in songs)
            {
                if(songToPlay != song._songTitle)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n{songToPlay} does not exist in music library");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }

                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n{song._songTitle} by {song._songArtist} now playing...\n");
                Console.BackgroundColor = ConsoleColor.Black;
            }

            Console.Write("\n\t1: Play next song\n\t2: Play previous song");

            string? skip = Console.ReadLine();

            switch (skip)
            {
                case "1":
                    break;
                case "2":
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInvalid choice\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }



        //Arrange songs in alphabetical order
        public void SortMusicLibrary(List<SongProperties> songs)
        {
            songs.Sort();
        }
    }
}
