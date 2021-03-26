using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinomaniakLibrary
{
    public static class GlobalConfig
    {

        public const string MoviesFile = "MoviesFile.csv";
        public const string UsersFile = "UsersFile.csv";
        public const string quizfile = "QuizFile.csv";

        public static IDataConnection Connection { get; private set; }

        public static void InitalizeConnections()
        {
            TextConnector text = new TextConnector();
            Connection = text;


        }
    }
}
