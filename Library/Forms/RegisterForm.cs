using Library.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegisterAndLogin_Click(object sender, EventArgs e)
        {

            var loginCheck = Regex.IsMatch(txtUserName.Text, @"(?=.*\d)(?=.*[A-Z]).{3,16}", RegexOptions.None);
            var pwCheck = Regex.IsMatch(txtPassword.Text, @"(?=.*\d)(?=.*[A-Z]).{8,16}", RegexOptions.None);
            var pwReCheck = txtPassword.Text == txtRepeatPassword.Text;
            if (!loginCheck)
            {
                MessageBox.Show("The username must contain only letters or digits and be at least 3 characters long");
            }
            if (!pwCheck)
            {
                MessageBox.Show("The password must contain at least one capital letter and one digit, and be at least 8 characters long");
            }
            if (!pwReCheck)
            {
                MessageBox.Show("The password and the confirmation password must match");
            }
            if (loginCheck && pwCheck && pwReCheck) 
            { 
                var newUser = new User(txtUserName.Text, txtPassword.Text);
                //Adding a new user to the database will continue once Reshma creates the users table
            }
        }

    }
}
