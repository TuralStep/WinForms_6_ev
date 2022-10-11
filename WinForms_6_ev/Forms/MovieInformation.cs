using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_6_ev.Models;

namespace WinForms_6_ev.Forms
{
    public partial class MovieInformation : Form
    {
        public MovieInformation(Movie movie)
        {
            InitializeComponent();

            pBox_moviePicture.LoadAsync(movie?.Poster);

            lbl_movieName.Text = movie?.Title.ToString();
            lbl_movieGenre.Text = movie?.Genre.ToString();
            lbl_movieDirector.Text = movie?.Director.ToString();
            lbl_movieWriter.Text = movie?.Writer.ToString();
            lbl_movieActors.Text = movie?.Actors.ToString();
            lbl_movieCountry.Text = movie?.Country.ToString();
            lbl_movieAwards.Text = movie?.Awards.ToString();
            lbl_movieRating.Text = movie?.imdbRating.ToString();
            lbl_movieRuntime.Text = movie?.Runtime.ToString();

        }

        private void btn_goBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
