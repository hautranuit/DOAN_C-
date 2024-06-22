using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CinemaManagement_Project.SelectMovieState;

namespace CinemaManagement_Project.BuyTickets
{
    public partial class Trailer : Form
    {
        private int movieId;
        public Trailer(int selectedMovieId)
        {  
            InitializeComponent();
            movieId = selectedMovieId;
            LoadTrailerInfo();            
        }
        private void LoadTrailerInfo()
        {
            string connectionString = "Data Source=.;Initial Catalog=Bai_Thuc_Hanh_01;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Name, Genre, Duration, Country, SubtitleOrDubbing, Director, Actors, ReleaseDate, Synopsis, TrailerVideoPath FROM Trailer WHERE MovieId = @MovieId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MovieId", movieId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lb_Name.Text = reader["Name"].ToString();
                            lb_Genre.Text = reader["Genre"].ToString();
                            lb_Duration.Text = reader["Duration"].ToString();
                            lb_Country.Text = reader["Country"].ToString();
                            lb_SubtitleOrDubbing.Text = reader["SubtitleOrDubbing"].ToString();
                            lb_Director.Text = reader["Director"].ToString();
                            lb_Actors.Text = reader["Actors"].ToString();
                            lb_ReleaseDate.Text = reader["ReleaseDate"].ToString();
                            lb_Synopsis.Text = reader["Synopsis"].ToString();
                            string videoPath = reader["TrailerVideoPath"].ToString();
                            axWindowsMediaPlayer1.URL = videoPath;
                        }
                    }

                }

            }
        }

        private void Trailer_Load(object sender, EventArgs e)
        {            
            pic_Movie.Image = picMovie.Image;
            axWindowsMediaPlayer1.stretchToFit = true;
        }

        private void pic_return_Click(object sender, EventArgs e)
        {
            SelectMovieState selectMovieState = new SelectMovieState("guest");
            selectMovieState.Show();
            this.Close();
        }
    }
}
