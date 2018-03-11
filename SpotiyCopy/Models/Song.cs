﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotiyCopy
{
    public class Song
    {
        [DisplayName("Songs")]
        public string songName { get; set; }

        [DisplayName("Album")]
        public string albumName { get; set; }

        [DisplayName("Artist")]
        public string artistName { get; set; }

        [DisplayName("Genre")]
        public string Genre { get; set; }
    };
}
