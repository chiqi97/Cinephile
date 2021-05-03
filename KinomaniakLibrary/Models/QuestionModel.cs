using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinomaniakLibrary
{
    public class QuestionModel
    {
        public int Id { get; set; }
        public string Question { get; set; }

        public List<string> FirstAnswer { get; set; }

        public List<string> SecondAnswer { get; set; }

        public List<string> ThirdAnswer { get; set; }

        public List<string> FourthAnswer { get; set; }

        public QuestionModel()
        {

        }

    }
}