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
    public partial class SignUpUC : UserControl
    {
        public SignUpUC()
        {
            InitializeComponent();
        }

        private void zarejestrujRejestracjaUCButton_Click(object sender, EventArgs e)
        {
            List<MovieModel> movies = new List<MovieModel>();

            if (Validate_Registration())
            {
                UserModel model = new UserModel(firstNameSignUPValue.Text,
                                lastNameSignUPValue.Text,
                                usernameSignUPValue.Text,
                                passwordSignUPValue.Text,
                                emailSignUPValue.Text,
                                movies);

                GlobalConfig.Connection.AddUser(model);

                RefreshFields();

                SendMessageCorrectlyRegistred();


            }


               


        }


        private bool Validate_Registration()
        {
            bool output = true;

            List<UserModel> users = GlobalConfig.Connection.GetAllUsers();

            foreach (UserModel u in users)
            {
                if (usernameSignUPValue.Text == u.UserName)
                {
                    SendMessageUsernameAlreadyExists();
                    return false;
                }
            }

            if (firstNameSignUPValue.Text.Length < 1)
            {
                SendMessageErrorField(firstNameSignUpLabel.Text);
                return false;

            }

            if (lastNameSignUPValue.Text.Length < 1)
            {
                SendMessageErrorField(lastNameSignUPLabel.Text);
                return false;
            }

            if (usernameSignUPValue.Text.Length < 1)
            {
                SendMessageErrorField(userNameSignUPLabel.Text);
                return false;
            }

            if (passwordSignUPValue.Text.Length < 1)
            {
                SendMessageErrorField(passwordSignUPLabel.Text);
                return false;
            }

            if (emailSignUPValue.Text.Length < 1)
            {
                SendMessageErrorField(emailAddressSignUPLabel.Text);
                return false;
            }
            return output; 

        }


        private void SendMessageErrorField(string fieldName)
        {
            MessageBox.Show($"Invalid{fieldName.Substring(0,fieldName.Length-1)}!!", "Cinephile", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void SendMessageCorrectlyRegistred()
        {
            MessageBox.Show("Correctly Registred!", "Cinephile", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SendMessageUsernameAlreadyExists()
        {
            MessageBox.Show("This username already exists", "Cinephile", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RefreshFields()
        {
            firstNameSignUPValue.Text = "";
            lastNameSignUPValue.Text = "";
            usernameSignUPValue.Text = "";
            passwordSignUPValue.Text = "";
            emailSignUPValue.Text = "";
        }

        private void showPasswordSignUPCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordSignUPCheckBox.Checked)
            {
                passwordSignUPValue.UseSystemPasswordChar = false;
            }
            else
            {
                passwordSignUPValue.UseSystemPasswordChar = true;
            }
        }

    }
}
