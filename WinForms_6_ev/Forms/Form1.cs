using System.Text.Json;
using WinForms_6_ev.Forms;
using WinForms_6_ev.Models;
using WinForms_6_ev.UserControls;

namespace WinForms_6_ev
{
    public partial class Form1 : Form
    {

        const string _apiKey = "fa2d85d2";//"580270e";
        const string _url = $"http://www.omdbapi.com/?apikey={_apiKey}";
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            DirectoryInfo dir = new("Movies");

            if (!dir.Exists)
                Directory.CreateDirectory("Movies");

            if (dir.GetFiles().Length == 0)
            {
                List<Movie> movies = new();
                using HttpClient client = new();
                movies.Add(JsonSerializer.Deserialize<Movie>(await client.GetStringAsync($"{_url}&t=avengers"))!);
                movies.Add(JsonSerializer.Deserialize<Movie>(await client.GetStringAsync($"{_url}&t=salam"))!);
                movies.Add(JsonSerializer.Deserialize<Movie>(await client.GetStringAsync($"{_url}&t=lucifer"))!);
                movies.Add(JsonSerializer.Deserialize<Movie>(await client.GetStringAsync($"{_url}&t=sonic"))!);
                movies.Add(JsonSerializer.Deserialize<Movie>(await client.GetStringAsync($"{_url}&t=the tomorrow war"))!);
                movies.Add(JsonSerializer.Deserialize<Movie>(await client.GetStringAsync($"{_url}&t=justice league"))!);
                movies.Add(JsonSerializer.Deserialize<Movie>(await client.GetStringAsync($"{_url}&t=flash"))!);

                foreach (var movie in movies)
                {
                    File.WriteAllText($"Movies/{movie.Title}.json", JsonSerializer.Serialize<Movie>(movie));
                }
            }

            foreach (var file in dir.GetFiles())
            {
                UC_movie ucMovie = new UC_movie(JsonSerializer.Deserialize<Movie>(File.ReadAllText(file.FullName))!);
                pnl_movies.Controls.Add(ucMovie);
            }

        }

        private async void btn_search_Click(object sender, EventArgs e)
        {
            string search = $"{_url}&t={txt_movieName.Text}";


            using HttpClient client = new();
            string jsonStr = "";
            try
            {
                jsonStr = await client.GetStringAsync(search);
            }
            catch (Exception)
            {
                MessageBox.Show("Film tapilmadi...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var movie = JsonSerializer.Deserialize<Movie>(jsonStr);

            MovieInformation mInfo = new(movie!);
            mInfo.ShowDialog();

        }

    }
}