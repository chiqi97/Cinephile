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
    public partial class LogginUc : UserControl
    {
        public LogginUc()
        {
            InitializeComponent();
        }
        private void logInLoginUCButton_Click(object sender, EventArgs e)
        {


            UserModel loggedUser = GlobalConfig.Connection.Login(usernameLogInUCValue.Text, passwordLogInUCValue.Text);


            if(Validate_login(loggedUser))
            {
                MainPageForm StronaGlownaForm = new MainPageForm(loggedUser);
                StronaGlownaForm.Show();
                ((RegistrationForm)this.TopLevelControl).Hide();
            }
            else
            {
                RefreshFields();
                SendMessageErrorLogin();

            }


        }

        private void showPasswordLoginUCCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordLoginUCCheckBox.Checked)
            {
                passwordLogInUCValue.UseSystemPasswordChar = false;
            }
            else
            {
                passwordLogInUCValue.UseSystemPasswordChar = true;
            }
        }
        private bool Validate_login(UserModel loggedUser)
        {
            bool output = true;
            if (usernameLogInUCValue.Text.Length == 0 || loggedUser.UserName != usernameLogInUCValue.Text)
            {
                output = false;

            }

            if (passwordLogInUCValue.Text.Length == 0 || loggedUser.Password != passwordLogInUCValue.Text)
            {
                output = false;
            }

            return output;

        }

        private void RefreshFields()
        {
            usernameLogInUCValue.Text = "";
            passwordLogInUCValue.Text = "";
        }
        private void SendMessageErrorLogin()
        {
            MessageBox.Show("There was a problem logging in. Check your username and password!", "Cinephile", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void LogginUc_Load(object sender, EventArgs e)
        {

        }
    }
}
