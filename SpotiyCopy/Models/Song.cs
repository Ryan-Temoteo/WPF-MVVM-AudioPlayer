using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotiyCopy
{
    public class Song
    {
        private object v1;
        private object v2;
        private object v3;
        private object v4;
        private object v5;
        private object ;

        public Song(string SongName, string AlbumName, string Artist, string Genre, string FileLocation, int UserID)
        {
            this.songName = SongName;
            this.albumName = AlbumName;
            this.artistName = Artist;
            this.genre = Genre;
            this.fileLocation = FileLocation;
            this.userID = UserID;
        }

        [DisplayName("Songs")]
        public string songName { get; set; }

        [DisplayName("Album")]
        public string albumName { get; set; }

        [DisplayName("Artist")]
        public string artistName { get; set; }

        [DisplayName("Genre")]
        public string genre { get; set; }

        public string fileLocation { get; set; }

        public int userID { get; set; }
    };
}
