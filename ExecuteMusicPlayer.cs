using Music_player.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_player
{
    public class ExecuteMusicPlayer
    {
       public void startMusicPlayer()
        {
            MusicLibrary mlc = new MusicLibrary();

            bool musicPlayingRunning = true;

            while (musicPlayingRunning)
            {
                Console.WriteLine("🎧🎧🎧🎧MUSIC PLAYER APP 🎧🎧🎧🎧🎧\n1. View Music library\n2. Add song to music library\n3. Remove song from music library\n4. Edit song in music library\n5. Create playlist\n");


                string? optionSelect = Console.ReadLine();

                switch (optionSelect)
                {
                    case "1":
                        Console.WriteLine("============================================\n\n🎧YOUR MUSIC LIRARY 🎧");
                        mlc.DisplayPlaylist();
                        Console.WriteLine("\n============================================\n");
                        continue;
                    case "2":
                        mlc.AddSongs();
                        continue;
                    case "3":
                        mlc.RemoveSongs();
                        continue;
                    case "4":
                        mlc.EditSong();
                        continue;
                    default:
                        Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nPlease select an option from the prompt...\n");
                        Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.White;
                        break;
                }


            }

        }

        

    }
}
