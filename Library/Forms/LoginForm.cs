using Library.Forms;
using Library.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            lblTotalUsers.Text += LibraryContext.Db.Users.Count();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                MessageBox.Show("Enter Login & Password");
            else
            {
                var foundUser = LibraryContext.Db.Users.FirstOrDefault(v => v.Name == txtUsername.Text);
                if (foundUser == null)
                    MessageBox.Show("Login is not exists!");
                else
                {
                    if (foundUser.Password != txtPassword.Text)
                        MessageBox.Show("Wrong Password!");
                    else
                    {
                        User.CurrentUser = foundUser;
                        Program.OpenNewForm(this, new WelcomeForm());
                    }
                }
            }
        }
        private void btnRegister_Click(object sender, EventArgs e) => Program.OpenNewForm(this, new RegisterForm());
    }
}
