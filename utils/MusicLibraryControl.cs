using System;
using System.Collections.Generic;
using System.Threading;

namespace Music_player.utils
{
    public class MusicLibraryControl
    {
        //Dictionary<string,string> songs = new Dictionary<string, string>();
        static List<SongProperties> songs = new List<SongProperties>();


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

                Console.WriteLine($"\n{songTitle} by {songArtist} has been added to music library\n");

            }
            catch
            {
                Console.WriteLine("Please enter valid inputs");
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
            catch
            {
                Console.WriteLine("Please enter valid inputs");
            }
        }

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
                Console.WriteLine($"{song._songTitle} by {song._songArtist} - mp3\n");
            }
        }


        //Function for editing song
        public void EditSong()
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


                Console.WriteLine("\nEnter name of artist to edit: ");
                string? songArtist = Console.ReadLine().ToLower();


                Console.WriteLine("Enter song title to edit: ");
                string? songTitle = Console.ReadLine().ToLower();


                var songIndex = songs.FindIndex(song => song._songArtist == songArtist);

                Console.WriteLine("\nChange artist name: ");
                string? artistNameChange = Console.ReadLine();

                Console.WriteLine("\nChange song title: ");
                string? songTitleChange = Console.ReadLine();

                songs[songIndex] = new SongProperties { _songArtist = artistNameChange, _songTitle = songTitleChange };

                Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nSong updated...\n");
                Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.White;

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }


    }
}
