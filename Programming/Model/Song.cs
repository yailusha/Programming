using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Song
    {
        private string _nameSong;
        private string _artist;
        private int _durationSong; //В секундах продолжительность песни

        public int DurationSong
        {
            get { return _durationSong; }
            set
            {
                if (Validator.AssertOnPositiveValue(value))
                {
                    _durationSong = value;
                }
            }
        }
        private string NameSong { get; set; }
        private string Artist { get; set; }
        public Song(string nameSong, string nameArtist, int durationSong)
        {
            NameSong = nameSong;
            Artist = nameArtist;
            DurationSong = durationSong;
        }
        public Song()
        {

        }
    }
}
