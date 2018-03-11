using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotiyCopy
{
    public class SongViewModel
    {
        private ObservableCollection<Song> _songs = new ObservableCollection<Song>();


        public ObservableCollection<Song> Songs
        {
            get { return _songs; }
            set { _songs = value; }

        }

        public SongViewModel()
        {
            //_songs.Add(new Song { songName = "Can't Stop", artistName = "Red Hot Chili Peppers" });
            //_songs.Add(new Song { songName = "Aeroplane", artistName = "Red Hot Chli Peppers" });
            //_songs.Add(new Song { songName = "Voices", artistName = "Saosin" });
            //_songs.Add(new Song { songName = "Pardon Me", artistName = "Incubus" });
            //_songs.Add(new Song { songName = "Deadbolt", artistName = "Thrice" });
            //_songs.Add(new Song { songName = "Saturnus", artistName = "The Receiving End of Sirens" });
            //_songs.Add(new Song { songName = "Where da Cash at", artistName = "Lil Wayne" });
            //_songs.Add(new Song { songName = "Man on the Moon", artistName = "Kid Cudi" });
            //_songs.Add(new Song { songName = "Sugar Magnolia", artistName = "Grateful Dead" });

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=[server_name];Database=[database_name];Trusted_Connection=true";
                conn.Open();
                // Create the command
                SqlCommand command = new SqlCommand(string.Format("SELECT * FROM Songs WHERE UserID={0}", userID), conn);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Song song = new Song((string)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (string)reader[4], (int)reader[5]);
                        _songs.Add(song);
                    }
                }
            }
        }
    }
}
