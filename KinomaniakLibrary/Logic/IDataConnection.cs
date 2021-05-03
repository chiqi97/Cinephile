using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KinomaniakLibrary
{
    public interface IDataConnection
    {
        MovieModel AddMovie (MovieModel model);
        List<MovieModel> FoundMovies( Regex nameOfMovie,
                                        Regex movieGenre,
                                        Regex director, 
                                        string name, 
                                        string genre, 
                                        string direct);
        List<UserModel> GetAllUsers();
        UserModel Login(string login, string haslo);
        List<MovieModel> GetAllMovies();

        List<MovieModel> RatingMovie(MovieModel model, int ocena, List<MovieModel> list, int loggedUser);

        UserModel AddUser(UserModel model);
        void SaveRatedMovieToFile(List<MovieModel> listOfAllRatedMovies);
        List<UserModel> TakeMoviesToUsers(int loggedUser, MovieModel model, int ocena);
       void SaveMovieToUser(List<UserModel> listOfAllUsers);

        List<QuestionModel> RandomizeQuestion();

        UserModel AddGenrePoints(MovieModel model, UserModel user, int ocena);

        List<MovieModel> FoundGenre(int _id, List<UserModel> users, List<MovieModel> movies);

    }
}
