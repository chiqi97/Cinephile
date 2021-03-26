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
    public partial class MainPageForm : Form
    {

        public UserModel loggedUser = new UserModel();

        // Zmiene uzywane do przesuwania aplikacji
        int mov;
        int movX;
        int movY;


        public MainPageForm(UserModel model)
        {
            InitializeComponent();
            loggedUser = model;
            menuSkokPanel.Height = mainPageButton.Height;
            mainPageUC.Id = loggedUser.Id;
            userNameLabel.Text = model.UserName;
            mainPageUC.WireUpLists();
            mainPageUC.BringToFront();
        }

        
        /// <summary>
        /// Jesli nacisniesz przycisk "strona glowna" to pojawi się UC dla strony glownej
        /// oraz panel odpowiedzialny za podkreślanie pojawi się przy stronie glownej
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stronaGlownaButton_Click(object sender, EventArgs e)
        {
            menuSkokPanel.Height = mainPageButton.Height; // panel przyjmuje wysokosc buttona strona Glowna
            menuSkokPanel.Top = mainPageButton.Top; // przeskocz do buttona strona Glowna
            mainPageUC.Id = loggedUser.Id;
            mainPageUC.WireUpLists();
            mainPageUC.BringToFront(); // przeniesc stonaglownaUC na wierzch
        }


        /// <summary>
        /// Jesli nacisniesz przycisk "ranking" to pojawi się UC dla rankingu
        /// oraz panel odpowiedzialny za podkreślanie pojawi się przy rankingu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void topRatedButton_Click(object sender, EventArgs e)
        {
            menuSkokPanel.Height = topRatedButton.Height;
            menuSkokPanel.Top = topRatedButton.Top;
             topRatedUC.BringToFront();
            topRatedUC.WireUpLists();
        }

        /// <summary>
        /// Jesli nacisniesz przycisk "quiz" to pojawi się UC dla quizu
        /// oraz panel odpowiedzialny za podkreślanie pojawi się przy quizie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quizButton_Click(object sender, EventArgs e)
        {
            menuSkokPanel.Height = quizButton.Height;
            menuSkokPanel.Top = quizButton.Top;
            quizUC.GenerateQuestion();
            quizUC.Id = loggedUser.Id;
            quizUC.BringToFront();

        }


        /// <summary>
        /// Jesli nacisniesz przycisk "wyszukaj" to pojawi się UC dla wyszukaj
        /// oraz panel odpowiedzialny za podkreślanie pojawi się przy wyszukaniu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchRateUCButton_Click(object sender, EventArgs e)
        {
            menuSkokPanel.Height = searchRateButton.Height;
            menuSkokPanel.Top = searchRateButton.Top;
            searchRateUC.Id = loggedUser.Id;
            searchRateUC.BringToFront();
        }


        /// <summary>
        /// Jesli nacisniesz przycisk "dodaj film" to pojawi się UC dla dodaj film
        /// oraz panel odpowiedzialny za podkreślanie pojawi się przy dodaj film
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addMovieButton_Click(object sender, EventArgs e)
        {
            menuSkokPanel.Height = addMovieButton.Height;
            menuSkokPanel.Top = addMovieButton.Top;
            addMovieUC.BringToFront();
        }



        /// <summary>
        /// Wiadomosc, potwierdzenie wyjscia.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            var output = MessageBox.Show("Do you really want to quit?", "Cinephile", MessageBoxButtons.YesNo);

            if (output== DialogResult.Yes) // jezeli wybierzesz tak, to aplikacja sie zamyka
            {
                Application.Exit();
            }
            

        }


    // Tu zaczynaja sie metody odpowiedzialne za przesuwanie 
        private void MainPageForm_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;

        }



        private void logOutButton_Click(object sender, EventArgs e)
        {

            var output = MessageBox.Show("Do you really want to log out?", "Cinephile", MessageBoxButtons.YesNo);

            if (output == DialogResult.Yes) // jezeli wybierzesz tak, to aplikacja sie zamyka
            {
                RegistrationForm registrationForm = new RegistrationForm();
                registrationForm.Show();
                this.Close();
            }

        }


        // Koniec metod odpowiedzialnych za przesuwanie aplikacji

    }
}
