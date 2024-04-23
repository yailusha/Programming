using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о песне.
    /// </summary>
    internal class Song
    {
        /// <summary>
        /// Название песни.
        /// </summary>
        private string _nameSong;
        /// <summary>
        /// Псевдоним исполнителя.
        /// </summary>
        private string _artist;
        /// <summary>
        /// Длительность песни (в секундах).
        /// </summary>
        private int _durationSong;
        /// <summary>
        /// Возвращает и задает длительность песни в секундах. Не может быть отрицательным.
        /// </summary>
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
        /// <summary>
        /// Возвращает и задает название песни. Не может быть пустым.
        /// </summary>
        private string NameSong
        {
            get { return _nameSong; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Value can not be empty");
                }
                _nameSong = value;
            }
        }
        /// <summary>
        /// Возвращает и задает псевдоним исполнителя. Не может быть отрицательным.
        /// </summary>
        private string Artist
        {
            get { return _artist; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Value can not be empty");
                }
                _artist = value;
            }
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="Song"/>
        /// </summary>
        /// <param name="nameSong">Название песни. Не может быть пустым.</param>
        /// <param name="nameArtist">Псевдоним исполнителя. Не может быть пустым.</param>
        /// <param name="durationSong">Длительность песни. Не может быть отрицательным.</param>
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
