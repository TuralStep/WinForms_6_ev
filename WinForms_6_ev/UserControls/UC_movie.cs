using System.Text;
using WinForms_6_ev.Forms;
using WinForms_6_ev.Models;


namespace WinForms_6_ev.UserControls;

public partial class UC_movie : UserControl
{

    private Movie _movie = null;

    public UC_movie(Movie movie)
    {
        InitializeComponent();

        _movie = movie;

        if (movie.Response != "True")
        {
            MessageBox.Show("Film tapilmadi...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        pBox_movieImage.LoadAsync(movie?.Poster);

        lbl_movieName.Parent = pBox_movieImage;
        lbl_movieType.Parent = pBox_movieImage;
        lbl_movieYear.Parent = pBox_movieImage;

        lbl_movieYear.Text = movie?.Year.ToString();
        lbl_movieName.Text = movie?.Title.ToString();

        StringBuilder sb = new(movie?.Genre.ToString());
        if (sb.Length > 20)
        {
            sb.Remove(18, sb.Length - 19);
            sb.Append("...");
        }
        lbl_movieType.Text = sb.ToString();

        lbl_rank.Text = movie?.imdbRating.ToString();

    }

    private void UC_movie_Click(object sender, EventArgs e)
    {
        MovieInformation mInfo = new(_movie!);
        mInfo.ShowDialog();
    }
}
