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
        public RegisterForm() => InitializeComponent();

        private void btnRegisterAndLogin_Click(object sender, EventArgs e)
        {
            var loginCheck = Regex.IsMatch(txtUserName.Text, @"^[a-zA-Z][a-zA-Z0-9]{3,16}$", RegexOptions.None);
            var pwCheck = Regex.IsMatch(txtPassword.Text, @"(?=.*\d)(?=.*[A-Z]).{8,16}", RegexOptions.None);
            var pwReCheck = txtPassword.Text == txtRepeatPassword.Text;
            var errorMessage = "";
            if (!loginCheck)
                errorMessage += "The username must contain only letters or digits and be at least 3 characters long.\r\n";
            if (!pwCheck)
                errorMessage += "The password must contain at least one capital letter and one digit, and be at least 8 characters long.\r\n";
            if (!pwReCheck)
                errorMessage += "The password and the confirmation password must match.";
            if (loginCheck && pwCheck && pwReCheck) 
            {
                if (LibraryContext.Db.Users.FirstOrDefault(v => v.Name == txtUserName.Text) != null)
                    MessageBox.Show($"User with name {txtUserName.Text} already exists!");
                else
                {
                    var newUser = new User { Name = txtUserName.Text, Password = txtPassword.Text };
                    LibraryContext.Db.Users.Add(newUser);
                    LibraryContext.Db.SaveChanges();
                    MessageBox.Show($"User with name {txtUserName.Text} registered successfully!");
                    var frm = new LoginForm();
                    frm.Closed += (s, args) => this.Close();
                    this.Hide();
                    frm.Show();
                }
            }
            else
                MessageBox.Show(errorMessage);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var frm = new LoginForm();
            frm.Closed += (s, args) => this.Close();
            this.Hide();
            frm.Show();
        }
    }
}
