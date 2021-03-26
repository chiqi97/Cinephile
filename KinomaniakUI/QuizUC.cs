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
    public partial class QuizUC : UserControl
    {

       private QuestionModel quizResult = new QuestionModel();

        private int _id;
        public int Id
        {
            get { return _id;  }
            set { _id = value; }
        }
        public QuizUC()
        {
            InitializeComponent();
        }


        private void drawQuiz_Click(object sender, EventArgs e)
        {
            GenerateQuestion();

        }

        
        private void drawMovieButton_Click(object sender, EventArgs e)
        {
            List<MovieModel> movies = new List<MovieModel>();
            movies = GlobalConfig.Connection.GetAllMovies();

            MovieModel randBook = new MovieModel();

            ChooseBook(movies, randBook);

        }


        public void GenerateQuestion()
        {
            List<QuestionModel> shuffledcards = GlobalConfig.Connection.RandomizeQuestion();
            foreach (QuestionModel q in shuffledcards)
            {
                question.Text = q.Question;

                answer1.Text = q.FirstAnswer[0];
                answer2.Text = q.SecondAnswer[0];
                answer3.Text = q.ThirdAnswer[0];
                answer4.Text = q.FourthAnswer[0];



                answer1.Checked = false;
                answer2.Checked = false;
                answer3.Checked = false;
                answer4.Checked = false;

                quizResult = q;
            }
        }
        private void ChooseBook(List<MovieModel> movies, MovieModel randBook)
        {
            if (answer1.Checked == true )
            {

                randBook = RandomizeMovie(movies, quizResult.FirstAnswer[1]);
                quizResultLabel.Text = randBook.NameOfMovie;
                RefreshButtons();

            }

            if (answer2.Checked == true )
            {
                randBook = RandomizeMovie(movies, quizResult.SecondAnswer[1]);
                quizResultLabel.Text = randBook.NameOfMovie;
                RefreshButtons();
            }

            if (answer3.Checked == true )
            {

                randBook = RandomizeMovie(movies, quizResult.ThirdAnswer[1]);
                quizResultLabel.Text = randBook.NameOfMovie;
                RefreshButtons();
            }

            if (answer4.Checked == true)
            {

                randBook = RandomizeMovie(movies, quizResult.FourthAnswer[1]);
                quizResultLabel.Text = randBook.NameOfMovie;
                RefreshButtons();
            }
        }
        private MovieModel RandomizeMovie(List<MovieModel> movies, string movieGenre)
        {
            List<MovieModel> output = new List<MovieModel>();
            MovieModel randomizeBook = new MovieModel();
            Random rnd = new Random();
            
            foreach (MovieModel m in movies)
            {
                if (m.MovieGenre == movieGenre)
                {
                    output.Add(m);

                }
            }

            if (output.Count==0 || movieGenre=="losowo")
            {
                int s = rnd.Next(movies.Count);

                var randBook1 = movies[s];

                return randBook1;
            }

            int r = rnd.Next(output.Count);

            var randBook = output[r];

            return randBook;

        }
        public void RefreshButtons()
        {

            answer1.Checked = false;
            answer2.Checked = false;
            answer3.Checked = false;
            answer4.Checked = false;
        }



    }
}
