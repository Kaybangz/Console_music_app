using System;
using System.Collections.Generic;
using System.Threading;

namespace Music_player.utils
{
    public class MusicLibrary
    {
        static List<SongProperties> songs = new List<SongProperties>();


        MusicPlayerControl control = new MusicPlayerControl();


        //Method for displaying music library
        public void DisplayPlaylist()
        {
            if (songs.Count <= 0)
            {
                Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nSong library is currently empty, please add songs...\n");
                Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.White;
                return;
            }


            foreach (var song in songs)
            {
                Console.WriteLine($"{Environment.NewLine}{song._songTitle} by {song._songArtist} - mp3");
            }

            Console.WriteLine("\n\t1: Play Song\n\t2: Shuffle music library\n\t3: Display songs in alphabetical order");

            string? musicPlayerControlOption = Console.ReadLine();

            switch (musicPlayerControlOption)
            {
                case "1":
                    control.Play(songs);
                    break;
                case "2":
                    break;
                case "3":
                    control.SortMusicLibrary(songs);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInvalid choice\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }



        //Adding song to song list
        public void AddSongs()
        {
            try
            {
                Console.WriteLine("Enter name of song artist: ");
                string? songArtist = Console.ReadLine();

                Console.WriteLine("Enter song title: ");
                string? songTitle = Console.ReadLine();


                songs.Add(new SongProperties { _songArtist = songArtist, _songTitle = songTitle });

                Thread.Sleep(2000);

                Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n{songTitle} by {songArtist} has been added to music library\n");
                Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.White;

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        //Removing song from song list
        public void RemoveSongs()
        {
            try
            {
                if (songs.Count <= 0)
                {
                    Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nSong library is currently empty, please add songs...\n");
                    Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.White;
                    return;
                }


                Console.WriteLine("Enter the name of the artist: ");
                string? songArtist = Console.ReadLine().ToLower();


                Console.WriteLine("Enter song title to remove: ");
                string? songTitle = Console.ReadLine().ToLower();


                foreach (var song in songs)
                {
                    if (song._songArtist.ToLower() == songArtist && song._songTitle.ToLower() == songTitle)
                    {
                        songs.Remove(song);

                        Thread.Sleep(2000);

                        Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\n{songTitle} by {songArtist} removed from music library\n");
                        Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\n{songTitle} by {songArtist} does not exist in music library...\n");
                        Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.White;
                    }

                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        //Editing song in song list 
        public void EditSong()
        {
            try
            {

                int index = -1, count = 0;

                if (songs.Count <= 0)
                {
                    Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nSong library is currently empty, please add songs...\n");
                    Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.White;
                    return;
                }


                Console.WriteLine("\nEnter name of artist to edit: ");
                string? songArtist = Console.ReadLine().ToLower();


                Console.WriteLine("Enter song title to edit: ");
                string? songTitle = Console.ReadLine().ToLower();


                Console.WriteLine("\nChange artist name: ");
                string? artistNameChange = Console.ReadLine();

                Console.WriteLine("Change song title: ");
                string? songTitleChange = Console.ReadLine();



                foreach (SongProperties song in songs)
                {
                    if (song._songArtist.ToLower() == songArtist && song._songTitle.ToLower() == songTitle)
                    {
                        index = count;
                    }
                    count++;
                }

                songs.Remove(songs[index]);
                songs.Add(new SongProperties { _songArtist = artistNameChange, _songTitle = songTitleChange });

                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }


    }
}
