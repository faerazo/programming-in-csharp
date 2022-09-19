using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsFair
{
    class Album
    {
        private string albumName;
        private string artistName;
        private int numOfTracks;

        public void Start()
        {
            Console.WriteLine("**********************");
            Console.WriteLine("Music Album Register!*");
            Console.WriteLine("**********************");
            Console.WriteLine();

            // ask album's
            ReadAlbum();

            // ask artist's name
            ReadArtist();

            // ask number of tracks
            ReadTracks();

            // show music information
            ShowMusicInfo();
        }

        public void ReadAlbum()
        {
            Console.WriteLine("What is the name of your favorite music album? ");
            albumName = Console.ReadLine();
        }

        public void ReadArtist()
        {
            Console.WriteLine("What is the name of the artist or group band for " + albumName);
            artistName = Console.ReadLine();
        }

        public void ReadTracks()
        {
            Console.WriteLine("How many tracks does *" + albumName + "* have?");
            string textValue = Console.ReadLine();
            numOfTracks = int.Parse(textValue);
        }

        public void ShowMusicInfo()
        {

            Console.WriteLine();
            Console.WriteLine("The following information is available about your favorite music album:");
            string albumOut = "Music album name: " + albumName;
            string artistOut = "Artist/ Band: " + artistName;
            string tracksOut = "Number of tracks: " + numOfTracks;

            Console.WriteLine(albumOut);
            Console.WriteLine(artistOut);
            Console.WriteLine(tracksOut);

        }
    }
}