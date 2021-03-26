using KinomaniakLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrongaGlownaUI
{
    public partial class MainPageUC : UserControl
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value;  }
        }


        public MainPageUC()
        {
            InitializeComponent();
           

        }


        //odswiez Strona Glowna UC
        public void WireUpLists()
        {

            // Stworz nowa liste
            List<MovieModel> availableModels = new List<MovieModel>();
            List<MovieModel> topPicksModels = new List<MovieModel>();
            List<MovieModel> newRealeaseModels = new List<MovieModel>();
            List<UserModel> users = new List<UserModel>();
            // przypisz do niej dane z pliku *.csv
            users= GlobalConfig.Connection.GetAllUsers();
            availableModels = GlobalConfig.Connection.GetAllMovies();
            topPicksModels = GlobalConfig.Connection.GetAllMovies();
            newRealeaseModels = GlobalConfig.Connection.GetAllMovies();


            // Sortuj od najwiekszej liczby ocen
            availableModels = availableModels.OrderByDescending(x => x.Counter).ThenByDescending(x=>x.MovieRating).ToList();
            //Wyswietlanie filmow z liczba ocen wieksza niz 0

            availableModels = availableModels.Where(x => x.Counter > 2).ToList();

            availableModels = SelectMovies(availableModels);





            trendingNowListBox.DataSource = null;
            trendingNowListBox.DataSource = availableModels; // dane z listy available..
            trendingNowListBox.DisplayMember = "FullInfoNajczesciej"; // drukuj imie i nazwisko


            topPicksModels = GlobalConfig.Connection.FoundGenre(_id, users,topPicksModels);
            topPicksModels = SelectMovies(topPicksModels);

            // losowanie filmow z listy filmow 



            topPicksListBox.DataSource = null;
            topPicksListBox.DataSource = topPicksModels; // Zrodlo danych
            topPicksListBox.DisplayMember = "FullInfo";


            //polecaneModels = polecaneModels.Where(x => x. > 5).ToList();

            // rankingListBox.DisplayMember = "FullInfo"; // drukuj wszystko do rankingu

            //Najmniejsza liczba glosow
            newRealeaseModels = newRealeaseModels.OrderByDescending(x => x.Id).ToList();
            //Wyswietlanie filmow z liczba ocen wieksza niz 0
            newRealeaseModels = SelectMovies(newRealeaseModels);


            newRealeasesListBox.DataSource = null;
            newRealeasesListBox.DataSource = newRealeaseModels; // Zrodlo danych
            newRealeasesListBox.DisplayMember = "FullInfo";

        }


        private List<MovieModel> SelectMovies(List<MovieModel> movies)
        {
            int k = movies.Count;
            int licznik = 0;
            List<MovieModel> output = new List<MovieModel>();

            if (k > 8)
            {
                foreach (MovieModel m in movies)
                {
                    licznik++;
                    output.Add(m);

                    if (licznik == 8)
                    {
                        break;
                    }

                }

                return output;
            }
            return movies;

        }


        private List<MovieModel> SelectMoviesTopPicks(List<MovieModel> movies)
        {
            int k = movies.Count;
            int licznik = 0;
            List<MovieModel> output = new List<MovieModel>();

            if (k > 8)
            {
                foreach (MovieModel m in movies)
                {
                    licznik++;
                    output.Add(m);

                    if (licznik == 6)
                    {
                        break;
                    }

                }
                foreach (MovieModel movie in movies.AsEnumerable().Reverse())
                {
                    licznik++;
                    output.Add(movie);
                    if (licznik == 8)
                    {
                        break;
                    }

                }
                return output;
            }
            return movies;

        }

        private void MainPageUC_Load(object sender, EventArgs e)
        {

        }

        private void trendingNowListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void topPicksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
