using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotiyCopy.Models
{
    public class Album
    {
        [DisplayName("Songs")]
        public List<Song> songs { get; set; }

        [DisplayName("Album")]
        public string albumName { get; set; }

        [DisplayName("Artist")]
        public string artistName { get; set; }

        [DisplayName("Genre")]
        public string Genre { get; set; }


    }
}
