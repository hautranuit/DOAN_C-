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

namespace CinemaManagement_Project.Pay
{
    public partial class EditTrailer : Form
    {
        private int movieId;
        public EditTrailer(int selectedMovieId)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
                            tbx_Name.Text = reader["Name"].ToString();
                            tbx_Genre.Text = reader["Genre"].ToString();
                            tbx_Duration.Text = reader["Duration"].ToString();
                            tbx_Country.Text = reader["Country"].ToString();
                            tbx_SubtitleOrDubbing.Text = reader["SubtitleOrDubbing"].ToString();
                            tbx_Director.Text = reader["Director"].ToString();
                            tbx_Actors.Text = reader["Actors"].ToString();
                            tbx_ReleaseDate.Text = reader["ReleaseDate"].ToString();
                            tbx_Synopsis.Text = reader["Synopsis"].ToString();
                            tbx_URL.Text = reader["TrailerVideoPath"].ToString();
                            string videoPath = reader["TrailerVideoPath"].ToString();
                            axWindowsMediaPlayer1.URL = videoPath;
                        }
                    }

                }

            }
            pic_Movie.Image = picMovie.Image;
            axWindowsMediaPlayer1.stretchToFit = true;
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=Bai_Thuc_Hanh_01;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"UPDATE Trailer SET 
                                Name = @Name, 
                                Genre = @Genre, 
                                Duration = @Duration, 
                                Country = @Country, 
                                SubtitleOrDubbing = @SubtitleOrDubbing, 
                                Director = @Director, 
                                Actors = @Actors, 
                                ReleaseDate = @ReleaseDate, 
                                Synopsis = @Synopsis, 
                                TrailerVideoPath = @TrailerVideoPath 
                                WHERE MovieId = @MovieId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", tbx_Name.Text);
                    command.Parameters.AddWithValue("@Genre", tbx_Genre.Text);
                    command.Parameters.AddWithValue("@Duration", tbx_Duration.Text);
                    command.Parameters.AddWithValue("@Country", tbx_Country.Text);
                    command.Parameters.AddWithValue("@SubtitleOrDubbing", tbx_SubtitleOrDubbing.Text);
                    command.Parameters.AddWithValue("@Director", tbx_Director.Text);
                    command.Parameters.AddWithValue("@Actors", tbx_Actors.Text);
                    command.Parameters.AddWithValue("@ReleaseDate", tbx_ReleaseDate.Text);
                    command.Parameters.AddWithValue("@Synopsis", tbx_Synopsis.Text);
                    command.Parameters.AddWithValue("@TrailerVideoPath", tbx_URL.Text);
                    command.Parameters.AddWithValue("@MovieId", movieId);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Trailer information updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            SelectMovieState select = new SelectMovieState("admin");
            select.Show();
        }
    }
}
