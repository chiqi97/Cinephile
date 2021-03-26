using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinomaniakLibrary
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string NameOfMovie { get; set; }
        public string MovieGenre { get; set; }
        public string Director { get; set; }
        public int YearOfProduction { get; set; }
        public double MovieRating { get; set; }
        public double Counter { get; set; }
        public  double Total { get; set; }


        public string FullInfo
        {
            get
            {
                // wyrzuca iNazwe filmu, gatunek i ocene

               return $"{NameOfMovie} - {MovieGenre } - {MovieRating} (ocena)";
            }

        }

        public string FullInfoWyszukaj
        {
            get
            {
                // wyrzuca iNazwe filmu, gatunek i ocene

                return $"{NameOfMovie} - {MovieGenre } - {YearOfProduction} - {Director} - {MovieRating} (ocena) - {Counter} (liczba ocen)";
            }

        }

        public string FullInfoNajczesciej
        {
            get
            {
                // wyrzuca iNazwe filmu, gatunek i ocene

                return $"{NameOfMovie} - {MovieGenre } - {MovieRating} - {Counter} (liczba ocen)";
            }

        }

        public MovieModel(string nameOfMovie, string movieGenre, string director, string yearOfProduction)
        {
            NameOfMovie = nameOfMovie;
            MovieGenre = movieGenre;
            Director = director;

            int yearOfProductionValue = 0;
            int.TryParse(yearOfProduction, out yearOfProductionValue);
            YearOfProduction = yearOfProductionValue;



        }



        public MovieModel()
        {

        }
    }
}
