using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinomaniakLibrary
{
    public class UserModel
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public List<MovieModel> WatchedMovie = new List<MovieModel>();
        public int ocena { get; set; }

        public float Akcja { get; set; }
        public float Animowany { get; set; }
        public float Biograficzny { get; set; }
        public float Dramat { get; set; }
        public float Familijny { get; set; }
        public float Fantasy{ get; set; }
        public float Historyczny { get; set; }
        public float Horror { get; set; }
        public float Katastroficzny { get; set; }
        public float Komedia { get; set; }
        public float KomediaRomantyczna { get; set; }
        public float Kryminal { get; set; }
        public float Psychologiczny { get; set; }
        public float SciFi { get; set; }
        public float Sensacyjny { get; set; }
        public float Thriller { get; set; }
        public float Western { get; set; }
        public float Wojenny { get; set; }




        public UserModel(string firstName, string lastName, string userName, string password, string emailAddress, List<MovieModel> models)
        {
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;
            EmailAddress = emailAddress;
            WatchedMovie = models;

        }

        public UserModel()
        {
                
        }
        public UserModel(string login, string haslo)
        {
            UserName = login;
            Password = haslo;

        }
    }
}
