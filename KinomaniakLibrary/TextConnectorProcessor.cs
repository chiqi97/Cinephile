using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KinomaniakLibrary
{
    public static class TextConnectorProcessor
    {

        public static string FullFilePath(this string fileName) //Kinomaniak.csv nazwa pliku
        {
            // c:\data\Kinomaniak\DodaneFilmy.csv
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }
        public static List <string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }
        //Konwertuje z pliku txt do listy <FilmyModel>
        public static List <MovieModel> ConvertToMovieModel(this List<string> lines)
        {
            List<MovieModel> output = new List<MovieModel>();

            foreach (var line in lines)
            {
                string[] columns = line.Split('^');
                MovieModel film = new MovieModel();
               film.Id = int.Parse(columns[0]);
                film.NameOfMovie = columns[1];
                film.MovieGenre = columns[2];
                film.Director = columns[3];
                film.YearOfProduction = int.Parse(columns[4]);
                film.MovieRating = double.Parse(columns[5]);
                film.Counter = double.Parse(columns[6]);
                film.Total = double.Parse(columns[7]);

                output.Add(film);

            }
            

            return output;

        }

        public static void SaveToMoviesFile(this List<MovieModel> filmy, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (MovieModel film in filmy)
            {
                lines.Add($"{ film.Id}^" +
                    $"{ film.NameOfMovie}^" +
                    $"{ film.MovieGenre}^" +
                    $"{ film.Director}^" +
                    $"{ film.YearOfProduction}^" +
                    $"{ film.MovieRating}^" +
                    $"{film.Counter}^" +
                    $"{ film.Total }");

            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToUsersFile(this List<UserModel> users, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (UserModel user in users)
            {
                lines.Add($"{ user.Id }^" +
                    $"{ user.FirstName }^" +
                    $"{ user.LastName }^" +
                    $"{ user.UserName }^" +
                    $"{ user.Password }^" +
                    $"{ ConvertMoviesListTostring(user.WatchedMovie) }^" +
                    $"{ user.EmailAddress }^" +
                    $"{user.Akcja}^" +
                    $"{user.Animowany}^" +
                    $"{user.Biograficzny}^" +
                    $"{user.Dramat}^" +
                    $"{user.Familijny}^" +
                    $"{user.Fantasy}^" +
                    $"{user.Historyczny}^" +
                    $"{user.Horror}^" +
                    $"{user.Katastroficzny}^" +
                    $"{user.Komedia}^" +
                    $"{user.KomediaRomantyczna}^" +
                    $"{user.Kryminal}^" +
                    $"{user.Psychologiczny}^" +
                    $"{user.SciFi}^" +
                    $"{user.Sensacyjny}^" +
                    $"{user.Thriller}^" +
                    $"{user.Western}^" +
                    $"{user.Wojenny}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        private static string ConvertMoviesListTostring(List<MovieModel> movies)
        {
            string output = "";

            if (movies.Count == 0 || movies==null)
            {
                return "";
            }
            foreach (MovieModel movie in movies)
            {
                output += $"{ movie.Id }|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }

        public static List<QuestionModel> ConvertToQuestionModels(this List<string> lines)
        {
            List<QuestionModel> output = new List<QuestionModel>();

            foreach (string line in lines)
            {
                //Params are write down to file separated by ^, so reading is reverse operation. There are no option of adding new Questions by app, but logic is same.
                string[] cols = line.Split('^');

                QuestionModel question = new QuestionModel();

                question.Id = int.Parse(cols[0]);

                question.Question = cols[1];

                question = QuestionModelNullFix(question);


                //Get info about first anwswer from file .txt. [0] is text of answer, [1] is additional info (genre or number of pages, depends of answer)
                string[] firstAnswer = cols[2].Split('|');

                foreach (string sentence in firstAnswer)
                {
                    question.FirstAnswer.Add(sentence);
                }

                //Get info about second anwswer from file
                string[] secondAnswer = cols[3].Split('|');

                foreach (string sentence in secondAnswer)
                {
                    question.SecondAnswer.Add(sentence);
                }

                //Get info about third anwswer from file
                string[] thirdAnswer = cols[4].Split('|');

                foreach (string sentence in thirdAnswer)
                {
                    question.ThirdAnswer.Add(sentence);
                }

                //Get info about fourth anwswer from file
                string[] fourthAnswer = cols[5].Split('|');

                foreach (string sentence in fourthAnswer)
                {
                    question.FourthAnswer.Add(sentence);
                }

                output.Add(question);
            }

            return output;
        }



        public static QuestionModel QuestionModelNullFix(QuestionModel question)
        {
            //Function using where answers are nulls
            question.FirstAnswer = new List<string>();

            question.SecondAnswer = new List<string>();

            question.ThirdAnswer = new List<string>();

            question.FourthAnswer = new List<string>();

            return question;
        }

        //public static void OdczytajPlik(this List<MovieModel> filmy, string fileName)
        //{
        //    List<string> lines = new List<string>();
        //    foreach (MovieModel film in filmy)
        //    {
        //        lines.Add($"{ film.Id},{ film.NameOfMovie},{ film.MovieGenre},{ film.Director},{ film.YearOfProduction},{ film.MovieRating},{ film.Total }");

        //    }
        //    File.WriteAllLines(fileName.FullFilePath(), lines);
        //}

        //Ranking - liczenie oceny

        public static string ValidateSearching(string nameOfMovie, string movieGenre, string director)
        {
            string wybor = "";



            if(nameOfMovie.Length!=0 && movieGenre.Length==0 && director.Length ==0)
            {
                wybor = "name";
            }
            if (nameOfMovie.Length ==0 && movieGenre.Length != 0 && director.Length ==0)
            {
                wybor = "genre";
            }
            if (nameOfMovie.Length ==0 && movieGenre.Length ==0 && director.Length != 0)
            {
                wybor = "director";
            }
            if (nameOfMovie.Length != 0 && movieGenre.Length != 0 && director.Length ==0)
            {
                wybor ="name_genre";
            }
            if (nameOfMovie.Length != 0 && movieGenre.Length ==0 && director.Length != 0)
            {
                wybor ="name_director";
            }
            if (nameOfMovie.Length ==0 && movieGenre.Length != 0 && director.Length != 0)
            {
                wybor ="genre_director" ;
            }
            if (nameOfMovie.Length != 0 && movieGenre.Length != 0 && director.Length != 0)
            {
                wybor = "name_genre_director";
            }
            return wybor;



        }


        // Logowanie i rejestracja

        public static List<UserModel> ConvertToUserModel(this List<string> lines)
        {


            List<UserModel> output = new List<UserModel>();
            List<MovieModel> movies = GlobalConfig.MoviesFile.FullFilePath().LoadFile().ConvertToMovieModel();
            foreach (var line in lines)
            {
                string[] columns = line.Split('^');
                UserModel user = new UserModel();

                user.Id = int.Parse(columns[0]);
                user.FirstName = columns[1];
                user.LastName = columns[2];
                user.UserName = columns[3];
                user.Password = columns[4];


                string[] movieIds = columns[5].Split('|');
                foreach (string id in movieIds)
                {
                    if (id.Length > 0 )
                    {
                        user.WatchedMovie.Add(movies.Where(x => x.Id == int.Parse(id)).FirstOrDefault());
                    }

                }
                user.EmailAddress = columns[6];
                user.Akcja = float.Parse(columns[7]);
                user.Animowany = float.Parse(columns[8]);
                user.Biograficzny = float.Parse(columns[9]);
                user.Dramat = float.Parse(columns[10]);
                user.Familijny = float.Parse(columns[11]);
                user.Fantasy = float.Parse(columns[12]);
                user.Historyczny = float.Parse(columns[13]);
                user.Horror = float.Parse(columns[14]);
                user.Katastroficzny = float.Parse(columns[15]);
                user.Komedia = float.Parse(columns[16]);
                user.KomediaRomantyczna = float.Parse(columns[17]);
                user.Kryminal = float.Parse(columns[18]);
                user.Psychologiczny = float.Parse(columns[19]);
                user.SciFi = float.Parse(columns[20]);
                user.Sensacyjny = float.Parse(columns[21]);
                user.Thriller = float.Parse(columns[22]);
                user.Western = float.Parse(columns[23]);
                user.Wojenny = float.Parse(columns[24]);
                //  user.WatchedMovies = columns[6];
                output.Add(user);
            }
            return output;
        }


        public static bool ValidateRating(List<UserModel> users, MovieModel model, int loggedUser)
        {
            bool flaga = true;

            foreach (UserModel user in users)
            {

                if (user.Id == loggedUser)
                {

                    foreach (MovieModel m in user.WatchedMovie)
                    {
                        //flaga = 0;
                        if (m.Id == model.Id)
                        {
                            flaga = false;
                        }


                    }
                    //return user;
                }
            }

            return flaga;
        }










    }
}
