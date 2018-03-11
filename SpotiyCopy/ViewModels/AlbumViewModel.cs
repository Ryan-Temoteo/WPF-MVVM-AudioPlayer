using SpotiyCopy.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotiyCopy.ViewModels
{
    public class AlbumViewModel
    {
        private ObservableCollection<Album> _albums = new ObservableCollection<Album>();


        public ObservableCollection<Album> Albums
        {
            get { return _albums; }
            set { _albums = value; }

        }

        public AlbumViewModel()
        {
         
        }

    }
}
