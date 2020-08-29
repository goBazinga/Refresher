using System;
using System.Collections.Generic;
using System.Text;

namespace RefresherConsole
{
    class Song
    {
        private string name;
        public Song NextSong { get; set; }

        public Song(string name)
        {
            this.name = name;
        }

        public bool IsRepeatingPlaylist()
        {
            Song currentSong = this;
            Song nextSong = currentSong.NextSong;

            while (currentSong != null && nextSong != null)
            {
                if (ReferenceEquals(currentSong, nextSong))
                    return true;

                currentSong = currentSong.NextSong;
                nextSong = nextSong.NextSong?.NextSong;

            }

            return false;



        }
    }
}
