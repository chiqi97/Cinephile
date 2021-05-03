using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KinomaniakLibrary
{
   public class TextConnector : IDataConnection
    {


        public MovieModel AddMovie(MovieModel model)
        {
            List<MovieModel> filmy = GlobalConfig.MoviesFile.FullFilePath().LoadFile().ConvertToMovieModel();
            int currentId = 1;
            if (filmy.Count() > 0)
            {
                currentId = filmy.Max(x => x.Id)+1;
                //currentId = filmy.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            //model.Counter = 0;

            filmy.Add(model);
            filmy.SaveToMoviesFile(GlobalConfig.MoviesFile);
            return model;
        }

        public UserModel AddUser(UserModel model)
        {
            List<UserModel> users = GlobalConfig.UsersFile.FullFilePath().LoadFile().ConvertToUserModel();
            int currentId = 1;
            if (users.Count() > 0)
            {
                currentId = users.Max(x => x.Id) + 1;
                //currentId = filmy.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            //model.Counter = 0;
           // model.WatchedMovie = new List<MovieModel>();
            users.Add(model);
            users.SaveToUsersFile(GlobalConfig.UsersFile);
            return model;
        }

        public List<MovieModel> GetAllMovies()
        {
            List<MovieModel> output = new List<MovieModel>();
            output = GlobalConfig.MoviesFile.FullFilePath().LoadFile().ConvertToMovieModel();
            if (output == null)
            {
                return new List<MovieModel>();
            }
            else
            {
                return output;
            }


        }

        public List<UserModel> GetAllUsers()
        {
            List<UserModel> output = new List<UserModel>();
            output = GlobalConfig.UsersFile.FullFilePath().LoadFile().ConvertToUserModel();
            if (output == null)
            {
                return new List<UserModel>();
            }
            else
            {
                return output;
            }


        }


        public UserModel Login(string login, string haslo)
        {
            string pustylogin = "";
            string pustehaslo = "";
        
            List<UserModel> allUsers = GlobalConfig.Connection.GetAllUsers();

            foreach (UserModel user in allUsers)
            {
                if (user.UserName == login && user.Password == haslo)
                {

                    return user;
                }


            }
            UserModel pusty = new UserModel(pustylogin, pustehaslo);
            return pusty;

        }


        public List<MovieModel> FoundMovies(Regex nameOfMovie,
                                                Regex movieOfGenre, 
                                                Regex director, 
                                                string name, 
                                                string genre, 
                                                string direct )
        {
            List<MovieModel> output = new List<MovieModel>();
            List<MovieModel> allMovies = GlobalConfig.Connection.GetAllMovies();
            string wybor;

            wybor = TextConnectorProcessor.ValidateSearching(name, genre, direct);

            switch (wybor)
            {

                case "name":
                    foreach (MovieModel movie in allMovies)
                    {
                          if (nameOfMovie.IsMatch(movie.NameOfMovie))
                         {
                          output.Add(movie);
                         }
                    }


                    break;

                case "genre":
                    foreach (MovieModel movie in allMovies)
                    {
                        if (movieOfGenre.IsMatch(movie.MovieGenre))
                        {
                            output.Add(movie);
                        }
                    }


                    break;

                case "director":
                    foreach (MovieModel movie in allMovies)
                    {
                        if (director.IsMatch(movie.Director))
                        {
                            output.Add(movie);
                        }
                    }


                    break;

                case "name_genre":
                    foreach (MovieModel movie in allMovies)
                    {
                        if (nameOfMovie.IsMatch(movie.NameOfMovie)
                            && movieOfGenre.IsMatch(movie.MovieGenre))
                        {
                            output.Add(movie);
                        }
                    }


                    break;


                case "name_director":
                    foreach (MovieModel movie in allMovies)
                    {
                        if (nameOfMovie.IsMatch(movie.NameOfMovie)
                            && director.IsMatch(movie.Director))
                        {
                            output.Add(movie);
                        }
                    }


                    break;

                case "genre_director":
                    foreach (MovieModel movie in allMovies)
                    {
                        if (movieOfGenre.IsMatch(movie.MovieGenre)
                            && director.IsMatch(movie.Director))
                        {
                            output.Add(movie);
                        }
                    }


                    break;


                case "name_genre_director":
                    foreach (MovieModel movie in allMovies)
                    {
                        if (movieOfGenre.IsMatch(movie.MovieGenre)
                            && director.IsMatch(movie.Director)
                            && nameOfMovie.IsMatch(movie.NameOfMovie))
                        {
                            output.Add(movie);
                        }
                    }


                    break;

            }

            return output;
        }




        public List<MovieModel> RatingMovie(MovieModel model, int ocena, List<MovieModel> list,int loggedUser)
        {
            bool flag= true;

            List<MovieModel> afterGrading = new List<MovieModel>();
            UserModel user = new UserModel();
            List<UserModel> users = GetAllUsers();

            flag = TextConnectorProcessor.ValidateRating(users, model,loggedUser);

            if (model != null && flag == true)
            {
                model.Counter += 1;
                model.Total += ocena;
                model.MovieRating = (model.Total) / (model.Counter);
                model.MovieRating = Math.Round(model.MovieRating, 2);
                foreach (MovieModel p in list)
                {
                    if(p.Id==model.Id)
                    {
                        p.Counter = model.Counter;
                        p.Total = model.Total;
                        p.MovieRating = model.MovieRating;

                    }

                    afterGrading.Add(p);

                }
                return afterGrading;
            }

                return list;
        }

        public List<UserModel> TakeMoviesToUsers (int loggedUser, MovieModel model, int ocena)
        {
            bool flag =true;

            List<UserModel> users = GetAllUsers();
            List<UserModel> usersSave = new List<UserModel>();
            if (model != null) 
            {
                flag = TextConnectorProcessor.ValidateRating(users, model, loggedUser);

                foreach (UserModel user in users)
                {
                    

                    if (flag && loggedUser==user.Id)
                    {


                        user.WatchedMovie.Add(model);
                        user.ocena = ocena;
                        usersSave.Add(AddGenrePoints(model, user, ocena));



                    }
                    
                    if(flag && loggedUser != user.Id)
                    {
                        usersSave.Add(user);

                    }

                    if (!flag)
                    {

                        return users;
                    }






                }
            }

            return usersSave;


        }


        public void SaveMovieToUser(List<UserModel> listOfAllUsers)
        {
            System.IO.File.WriteAllBytes(GlobalConfig.UsersFile.FullFilePath(), new byte[0]);
            if (listOfAllUsers != null)
            {

                foreach (UserModel m in listOfAllUsers)
                {
                    GlobalConfig.Connection.AddUser(m);
                }

            }

        }

        public void SaveRatedMovieToFile(List<MovieModel> listOfAllRatedMovies)
        {

            System.IO.File.WriteAllBytes(GlobalConfig.MoviesFile.FullFilePath(), new byte[0]);
            if (listOfAllRatedMovies != null)
            {

                foreach (MovieModel m in listOfAllRatedMovies)
                {
                    GlobalConfig.Connection.AddMovie(m);
                }

            }
        }

        public List<QuestionModel> RandomizeQuestion()
        {


            List<QuestionModel> pytania = GlobalConfig.quizfile.FullFilePath().LoadFile().ConvertToQuestionModels();

            //quiz = GlobalConfig.Connection.Losuj_Pytanie();

            List<QuestionModel> shuffledcards = pytania.OrderBy(a => Guid.NewGuid()).ToList();

            return shuffledcards;

        }

        //Sprawdz jaki film uzytkownik ocenial i zwieksz licznik
        public UserModel AddGenrePoints(MovieModel model, UserModel user, int ocena)
        {



            if (model.MovieGenre == "Akcja")
            {
                user.Akcja += ocena;
            }
            if (model.MovieGenre == "Animowany")
            {
                user.Animowany += ocena;

            }
            if (model.MovieGenre == "Biograficzny")
            {
                user.Biograficzny+= ocena;

            }
            if (model.MovieGenre == "Dramat")
            {
                user.Dramat += ocena;

            }
            if (model.MovieGenre == "Familijny")
            {
                user.Familijny += ocena;

            }
            if (model.MovieGenre == "Fantasy")
            {
                user.Fantasy += ocena;

            }
            if (model.MovieGenre == "Historyczny")
            {
                user.Historyczny += ocena;

            }
            if (model.MovieGenre == "Horror")
            {
                user.Horror += ocena;

            }
            if (model.MovieGenre == "Katastroficzny")
            {
                user.Katastroficzny += ocena;

            }
            if (model.MovieGenre == "Komedia")
            {
                user.Komedia += ocena;

            }
            if (model.MovieGenre == "KomediaRomantyczna")
            {
                user.KomediaRomantyczna += ocena;

            }
            if (model.MovieGenre == "Kryminal")
            {
                user.Kryminal += ocena;

            }
            if (model.MovieGenre == "Psychologiczny")
            {
                user.Psychologiczny += ocena;

            }
            if (model.MovieGenre == "SciFi")
            {
                user.SciFi += ocena;

            }
            if (model.MovieGenre == "Sensacyjny")
            {
                user.Sensacyjny += ocena;

            }
            if (model.MovieGenre == "Thriller")
            {
                user.Thriller += ocena;

            }
            if (model.MovieGenre == "Western")
            {
                user.Western += ocena;

            }
            if (model.MovieGenre == "Wojenny")
            {
                user.Wojenny += ocena;

            }



            return user;

        }



        public List<MovieModel> FoundGenre(int _id, List<UserModel> users, List<MovieModel> movies)
        {
            string max = "";
            string secondMax = "";
            float checkList = 0;
            float checkListAfterDelete=0;

            int counterList = 0;
            int counterListAfterDelete = 0;

            List<MovieModel> output = GetAllMovies();
            List<MovieModel> outputAfterDelete = GetAllMovies();
            
            foreach (UserModel u in users)
            {
                if (u.Id == _id)
                {
                    // Sprawdza ktory gatunek ma najwiecej punktow
                    var list = new[] {
                         Tuple.Create(u.Akcja, "Akcja"),
                         Tuple.Create(u.Animowany, "Animowany"),
                         Tuple.Create(u.Biograficzny, "Biograficzny"),
                         Tuple.Create(u.Dramat, "Dramat"),
                         Tuple.Create(u.Familijny, "Familijny"),
                         Tuple.Create(u.Fantasy, "Fantasy"),
                         Tuple.Create(u.Historyczny, "Historyczny"),
                         Tuple.Create(u.Horror, "Horror"),
                         Tuple.Create(u.Katastroficzny, "Katastroficzny"),
                         Tuple.Create(u.Komedia, "Komedia"),
                         Tuple.Create(u.KomediaRomantyczna, "KomediaRomantyczna"),
                         Tuple.Create(u.Kryminal, "Kryminal"),
                         Tuple.Create(u.Psychologiczny, "Psychologiczny"),
                         Tuple.Create(u.SciFi, "SciFi"),
                         Tuple.Create(u.Sensacyjny, "Sensacyjny"),
                         Tuple.Create(u.Thriller, "Thriller"),
                         Tuple.Create(u.Western, "Western"),
                         Tuple.Create(u.Wojenny, "Wojenny")
                            };

                    //Przypisz nazwe gatunku z najwieksza liczba
                    max = list.Max().Item2;
                    var listAfterDelete = list.Where(x => x.Item2 != max);
                    // Przypisz nazzwe gatunku z 2 najwieksza liczba
                    secondMax= listAfterDelete.Max().Item2;

                    //Sprawdz wartosci dwoch najwiekszych sum w poszczegolnych gatunkachh
                    checkList = list.Max().Item1;
                    checkListAfterDelete = listAfterDelete.Max().Item1;


                    //Usun filmy, ktore sa juz oberjzane
                    foreach (MovieModel m in u.WatchedMovie)
                    {
                        movies.RemoveAll(x => x.Id == m.Id);
                        output.RemoveAll(x => x.Id == m.Id);
                        outputAfterDelete.RemoveAll(x => x.Id == m.Id);

                    }

                    

                }

            }



            if (checkList != 0)
            {

                output = output.OrderByDescending(x => x.MovieRating).ThenByDescending(x => x.Counter).Where(x => x.MovieGenre == max).ToList();
                counterList = output.Count;
            }

            if (checkList != 0 && checkListAfterDelete != 0)
            {
                outputAfterDelete = outputAfterDelete.OrderBy(x => x.MovieRating).ThenBy(x => x.Counter).Where(x => x.MovieGenre == secondMax).ToList();
                counterListAfterDelete = outputAfterDelete.Count;
                output.AddRange(outputAfterDelete);

               
            }  
            // jesli nie ma zadnych ocen wyrzuc liste posegregowana ocenami, gdzie liczba ocen >5
             if (checkList == 0)
            {
                output = output.OrderBy(a => Guid.NewGuid()).ToList();
                return output;
            }


            output = output.OrderBy(a => Guid.NewGuid()).ToList();

            movies = movies.Where(x => x.MovieGenre != max).ToList();
            movies = movies.Where(x => x.MovieGenre != secondMax).ToList();
            movies = movies.OrderBy(a => Guid.NewGuid()).ToList();


            int licznik = 0;
            List<MovieModel> output1 = new List<MovieModel>();


            if ((counterList>5 && counterListAfterDelete>1) || 
                (counterListAfterDelete>1 && counterList>5))
            {

                foreach (MovieModel m in output)
                {
                    if (m.MovieGenre == max)
                    {
                        licznik++;
                        output1.Add(m);
                    }


                    if (licznik == 6)
                    {
                        break;
                    }

                }

                foreach (MovieModel movie in output.AsEnumerable().Reverse())
                {
                    if (movie.MovieGenre == secondMax)
                    {
                        licznik++;
                        output1.Add(movie);
                    }



                    if (licznik == 8)
                    {
                        break;
                    }

                }
                return output1;
            }



            if (counterListAfterDelete <2)
            {

                foreach (MovieModel movie in output.AsEnumerable().Reverse())
                {
                    if (movie.MovieGenre == secondMax)
                    {
                        licznik++;
                        output1.Add(movie);
                    }



                }

                foreach (MovieModel m in output)
                {
                    if (m.MovieGenre == max)
                    {
                        licznik++;
                        output1.Add(m);
                    }

                    if (licznik >= 8)
                    {
                        break;
                    }


                }



                foreach (MovieModel mo in movies)
                {


                    if (licznik >= 8)
                    {
                        break;
                    }
                    licznik++;
                    output1.Add(mo);
                }

                return output1;

            }

            if (counterList < 2)
            {

                foreach (MovieModel m in output)
                {
                    if (m.MovieGenre == max)
                    {
                        licznik++;
                        output1.Add(m);
                    }


                }

                foreach (MovieModel movie in output.AsEnumerable().Reverse())
                {
                    if (movie.MovieGenre == secondMax)
                    {
                        licznik++;
                        output1.Add(movie);
                    }

                    if (licznik >= 8)
                    {
                        break;
                    }

                }





                foreach (MovieModel mo in movies)
                {


                    if (licznik >= 8)
                    {
                        break;
                    }
                    licznik++;
                    output1.Add(mo);

                }

                return output1;

            }



            if (output.Count >8 && counterListAfterDelete>=counterList)
            {

                foreach (MovieModel m in output)
                {
                    if (m.MovieGenre == max)
                    {
                        licznik++;
                        output1.Add(m);
                    }


                }

                foreach (MovieModel movie in output.AsEnumerable().Reverse())
                {
                    if (movie.MovieGenre == secondMax)
                    {
                        licznik++;
                        output1.Add(movie);
                    }

                    if (licznik >= 8)
                    {
                        break;
                    }

                }





                foreach (MovieModel mo in movies)
                {


                    if (licznik >= 8)
                    {
                        break;
                    }
                    licznik++;
                    output1.Add(mo);

                }

                return output1;

            }

            if (output.Count > 8 && counterList>=counterListAfterDelete)
            {

                foreach (MovieModel movie in output.AsEnumerable().Reverse())
                {
                    if (movie.MovieGenre == secondMax)
                    {
                        licznik++;
                        output1.Add(movie);
                    }

                    if (licznik >= 8)
                    {
                        break;
                    }

                }

                foreach (MovieModel m in output)
                {
                    if (m.MovieGenre == max)
                    {
                        licznik++;
                        output1.Add(m);
                    }


                }







                foreach (MovieModel mo in movies)
                {


                    if (licznik >= 8)
                    {
                        break;
                    }
                    licznik++;
                    output1.Add(mo);

                }

                return output1;

            }


            if (output.Count < 8)
            {

                foreach (MovieModel m in output)
                {
                    if (m.MovieGenre == max)
                    {
                        licznik++;
                        output1.Add(m);
                    }


                }

                foreach (MovieModel movie in output.AsEnumerable().Reverse())
                {
                    if (movie.MovieGenre == secondMax)
                    {
                        licznik++;
                        output1.Add(movie);
                    }

                    if (licznik >= 8)
                    {
                        break;
                    }

                }





                foreach (MovieModel mo in movies)
                {


                    if (licznik >= 8)
                    {
                        break;
                    }
                    licznik++;
                    output1.Add(mo);

                }

                return output1;

            }




            return output;
        }



                
            











    }
}
