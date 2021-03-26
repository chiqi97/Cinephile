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
    public partial class RegistrationForm : Form
    {
        int movX;
        int mov;
        int movY;

        public RegistrationForm()
        {
            InitializeComponent();
            logInUC1.BringToFront();
        }





        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;

        }



        private void logInButton_Click(object sender, EventArgs e)
        {
            logInUC1.BringToFront();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            signUpUC1.BringToFront();


        }

        private void exitRegistrationFormButton_Click(object sender, EventArgs e)
        {
            var output = MessageBox.Show("Do you really want to quit?", "Cinephile", MessageBoxButtons.YesNo);

            if (output == DialogResult.Yes) // jezeli wybierzesz tak, to aplikacja sie zamyka
            {
                Application.Exit();
            }
        }


    }
}
