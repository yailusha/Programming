using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Song
    {
        private string NameSong { get; set; }
        private string NameArtist { get; set; }
        private int durationSong; //В секундах продолжительность песни

        public int DurationSong
        {
            get { return durationSong; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Длительность песни не может быть отрицательной");
                }
                durationSong = value;
            }
        }
        public Song(string nameSong, string nameArtist, int durationSong)
        {
            NameSong = nameSong;
            NameArtist = nameArtist;
            DurationSong = durationSong;
        }
        public Song()
        {

        }
    }
}
