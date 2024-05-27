using Library.Forms;
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
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Comparing the entered information with the database will proceed once Reshma creates the users table.
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            var frm = new RegisterForm();
            frm.Closed += (s, args) => this.Close();
            this.Hide();
            frm.Show();
        }
    }
}
