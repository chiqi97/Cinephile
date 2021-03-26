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
    public partial class LogowanieUC : UserControl
    {
        public LogowanieUC()
        {
            InitializeComponent();
        }
        private void zalogujLogowanieUCButton_Click(object sender, EventArgs e)
        {


            UserModel loggedUser = GlobalConfig.Connection.Login(loginLogowaniueUCValue.Text, hasloLogowanieUCValue.Text);

            //if (Validate_login() && 
            //    loggedUser.Password==hasloLogowanieUCValue.Text && 
            //    loggedUser.UserName==loginLogowaniueUCValue.Text)

            if(Validate_login(loggedUser))
            {
                StronaGlownaForm StronaGlownaForm = new StronaGlownaForm(loggedUser);
                StronaGlownaForm.Show();
                ((RegistrationForm)this.TopLevelControl).Hide();
            }
            else
            {
                ErrorLogin();

            }


        }

        private void pokazHasloLogowanieCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pokazHasloLogowanieCheckBox.Checked)
            {
                hasloLogowanieUCValue.UseSystemPasswordChar = false;
            }
            else
            {
                hasloLogowanieUCValue.UseSystemPasswordChar = true;
            }
        }
        private bool Validate_login(UserModel loggedUser)
        {
            bool output = true;
            if (loginLogowaniueUCValue.Text.Length == 0 || loggedUser.UserName != loginLogowaniueUCValue.Text)
            {
                output = false;

            }

            if (hasloLogowanieUCValue.Text.Length == 0 || loggedUser.Password != hasloLogowanieUCValue.Text)
            {
                output = false;
            }

            return output;

        }

        private void ErrorLogin()
        {
            loginLogowaniueUCValue.Text = "";
            hasloLogowanieUCValue.Text = "";
            MessageBox.Show("Podałeś zły login lub hasło!", "Kinomaniak", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void LogowanieUC_Load(object sender, EventArgs e)
        {

        }
    }
}
