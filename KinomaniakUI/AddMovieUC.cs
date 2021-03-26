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
    public partial class AddMovieUC : UserControl
    {
        public  AddMovieUC()
        {
            InitializeComponent();
        }

        private void addMovieButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                MovieModel m = new MovieModel(nameOfMovieAddMovieValue.Text,
                    movieGenreAddMovieValue.Text,
                    directorAddMovieValue.Text,
                    yearOfProductionAddMovieValue.Text);

                GlobalConfig.Connection.AddMovie(m);

                RefreshFields();

                SendMessageAddedMovie();

            }

        }

        private bool ValidateForm()
        {


            if (nameOfMovieAddMovieValue.Text.Length == 0)
            {
                SendMessageInvalidField(nameOfMovieAddMovieUCLabel.Text);
                return false;
            }
            if (movieGenreAddMovieValue.Text.Length == 0)
            {
                SendMessageInvalidField(movieGenreAddMovieLabel.Text);
                return false;
            }
            if (directorAddMovieValue.Text.Length == 0)
            {
                SendMessageInvalidField(directorAddMovieLabel.Text);
                return false;
            }

            int yearOfProductionValue=0;
            bool yearOfProductionBool = int.TryParse(yearOfProductionAddMovieValue.Text, out yearOfProductionValue);
            if (!yearOfProductionBool)
            {
                SendMessageInvalidField(yearOfProductionAddMovieLabel.Text);
                return false;
            }


            if (yearOfProductionAddMovieValue.Text.Length == 0)
            {
                SendMessageInvalidField(yearOfProductionAddMovieLabel.Text);
                return false;
            }
            if(yearOfProductionValue<1850 ||  yearOfProductionValue> 2021)
            {
                SendMessageInvalidField(yearOfProductionAddMovieLabel.Text);
                return false;
            }


            return true;

        }

        private void SendMessageAddedMovie()
        {

            MessageBox.Show("Your movie has been added!", "Cinephile", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void SendMessageInvalidField(string fieldName)
        {
            
            MessageBox.Show($"Invalid {fieldName.Substring(0, fieldName.Length - 1)}!!", "Cinephile", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void RefreshFields()
        {
            nameOfMovieAddMovieValue.Text = "";
            movieGenreAddMovieValue.Text = "";
            directorAddMovieValue.Text = "";
            yearOfProductionAddMovieValue.Text = "";

        }

        private void movieGenreAddMovieValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
