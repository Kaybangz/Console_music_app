using Music_player.utils;
using System;
using System.Collections.Generic;

namespace Music_player
{
    //A music player console application that allows a user to:
    //Add songs
    //remove songs
    //edit songs
    //create named playlist
    //access previous or next song
    //shuffle all songs in the music player or playlist
    //play songs in exact order they were added
    //play songs in alphabetical order


    //LOOK INTO:
    //Sorted dictionaries
    //priority queue
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            ExecuteMusicPlayer execute = new();

            execute.startMusicPlayer();
        }
    }
}