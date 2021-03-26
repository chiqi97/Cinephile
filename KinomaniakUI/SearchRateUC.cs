using KinomaniakLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrongaGlownaUI
{

    public partial class SearchRateUC : UserControl
    {

        private int _id;
            public int Id 
            {
                get { return _id; }
                 set { _id = value;  }
            }

        public SearchRateUC()
        {
            InitializeComponent();



        }



       
        private void findSearchRateUCButton_Click(object sender, EventArgs e)
        {
            List<MovieModel> foundMovies = new List<MovieModel>();

            foundMovies = FindMovies();
            WireUpLists(foundMovies);
        }

        private void rateSearchRateUCButton_Click_1(object sender, EventArgs e)
        {


            if (ValidateRateValue())
            {
                int ocena;
                ocena = int.Parse(rateSearchRateUCValue.Text);

                List<MovieModel> foundMovies = new List<MovieModel>();

                foundMovies = FindMovies();

                MovieModel modelFound = (MovieModel)resultsSearchRateUCListBox.SelectedItem;
                MovieModel modelAll = SaveModel(modelFound);

                List<MovieModel> listOfAllRatedMovies = new List<MovieModel>();
                List<MovieModel> listOfFoundRatedMovies = new List<MovieModel>();

                List<MovieModel> allMovies = GlobalConfig.Connection.GetAllMovies();

                listOfAllRatedMovies = GlobalConfig.Connection.RatingMovie(modelAll, ocena, allMovies, _id);

                listOfFoundRatedMovies = GlobalConfig.Connection.RatingMovie(modelFound, ocena, foundMovies, _id);



                List<UserModel> userMovies = new List<UserModel>();
                userMovies = GlobalConfig.Connection.GetAllUsers();

                bool check = ValidateRating(_id, modelFound, userMovies);
                userMovies = GlobalConfig.Connection.TakeMoviesToUsers(_id, modelFound, ocena);

                WireUpLists(listOfFoundRatedMovies);


                if (check)
                {
                    SendMessageCorrectMovieRated();
                }


                GlobalConfig.Connection.SaveRatedMovieToFile(listOfAllRatedMovies);
                GlobalConfig.Connection.SaveMovieToUser(userMovies);


            }

        }


        public void WireUpLists(List<MovieModel> foundMovies)
        {
            foundMovies= foundMovies.OrderBy(x => x.NameOfMovie).ToList();

            resultsSearchRateUCListBox.DataSource = null;

            resultsSearchRateUCListBox.DataSource = foundMovies; // dane z listy available..
            resultsSearchRateUCListBox.DisplayMember= "FullInfoWyszukaj"; // drukuj wszystko do rankingu

        }
        /// <summary>
        /// Find Movies by searching.
        /// </summary>
        private List<MovieModel> FindMovies()
        {
            Regex nameOfMovie = new Regex(titleSearchRateUCValue.Text, RegexOptions.IgnoreCase);
            Regex genreofMovie = new Regex(movieGenreSearchRateUCValue.Text, RegexOptions.IgnoreCase);
            Regex directorOfMovie = new Regex(directorSearchRateUCValue.Text, RegexOptions.IgnoreCase);
            List<MovieModel> foundMovies = GlobalConfig.Connection.FoundMovies(nameOfMovie,
                                                                                genreofMovie,
                                                                                directorOfMovie,
                                                                                titleSearchRateUCValue.Text,
                                                                                movieGenreSearchRateUCValue.Text,
                                                                                directorSearchRateUCValue.Text);
            return foundMovies;
        }
        private bool ValidateRating(int loggedUser,MovieModel modelSelected, List<UserModel> users)
        {
            bool output = true;
            foreach (UserModel u in users)
            {
                if(loggedUser==u.Id)
                foreach ( MovieModel m in u.WatchedMovie)
                {
                        if (modelSelected.Id == m.Id)
                        {
                            output = false;
                            SendMessageYouHaveAlreadyRatedThisMovie();
                        }

                }

            }
            return output;

        }


        private void SendMessageYouHaveAlreadyRatedThisMovie()
        {
            MessageBox.Show("You have already rated this movie!", "Cinephile", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void SendMessageCorrectMovieRated()
        {
            MessageBox.Show("Rated correctly!", "Cinephile", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void SendMessageInvalidField()
        {
            MessageBox.Show("Invalid input data!", "Cinephile", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private bool ValidateRateValue()
        {


            int movieRatingValue = 0;
            bool movieRatingBool;
            movieRatingBool = int.TryParse(rateSearchRateUCValue.Text, out movieRatingValue);

            if (!movieRatingBool)
            {
                SendMessageInvalidField();
                return false;
            }

            if(movieRatingValue<1 || movieRatingValue > 10)
            {
                SendMessageInvalidField();
                return false;
            }

            if (rateSearchRateUCValue.Text.Length == 0)
            {
                SendMessageInvalidField();
                return false;
            }

            return true;

        }

       private MovieModel SaveModel(MovieModel model)
        {
            MovieModel output = new MovieModel();

            output.Id = model.Id;
            output.NameOfMovie = model.NameOfMovie;
            output.MovieGenre = model.MovieGenre;
            output.Director = model.Director;
            output.YearOfProduction = model.YearOfProduction;
            output.MovieRating = model.MovieRating;
            output.Counter = model.Counter;
            output.Total = model.Total;

            return output;

        }

        private void WyszukajUC_Load(object sender, EventArgs e)
        {

        }

        
    }
}
