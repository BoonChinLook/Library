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
    public partial class AddForm : Form
    {
        
        public AddForm() => InitializeComponent();
        
        private void btnAddbook_Click(object sender, EventArgs e)
        {
            var errorMessage = "";
            var titleCheck = string.IsNullOrEmpty(txtTitle.Text);
            var authorCheck = string.IsNullOrEmpty(txtAuthor.Text);
            var genreCheck = string.IsNullOrEmpty(txtGenre.Text);
            if (titleCheck)
                errorMessage += "Enter Title.\r\n";
            if (authorCheck)
                errorMessage += "Enter Author.\r\n";
            if (genreCheck)
                errorMessage += "Enter Genre.\r\n";
            if (!titleCheck && !authorCheck && !genreCheck)
            {
                if (LibraryContext.Db.Books.FirstOrDefault(v => v.User.Id == User.CurrentUser.Id && v.Title == txtTitle.Text) != null)
                    MessageBox.Show($"Book with name {txtTitle.Text} already exists!");
                else
                {
                    var newBook = new Book
                    {
                        User = User.CurrentUser,
                        Title = txtTitle.Text,
                        Author = txtAuthor.Text,
                        Genre = txtGenre.Text,
                        Description = txtDescription.Text,
                        Publisher = txtPublisher.Text,
                        PublishedDate = txtPublishedDate.Text
                    };
                    LibraryContext.Db.Books.Add(newBook);
                    LibraryContext.Db.SaveChanges();
                    MessageBox.Show($"Book {txtTitle.Text} successfully added!");
                    var frm = new BookListForm();
                    frm.Closed += (s, args) => this.Close();
                    this.Hide();
                    frm.Show();
                }
            }
            else
                MessageBox.Show(errorMessage);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var frm = new LoginForm();
            frm.Closed += (s, args) => this.Close();
            this.Hide();
            frm.Show();
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            var frm = new BookListForm();
            frm.Closed += (s, args) => this.Close();
            this.Hide();
            frm.Show();
        }
    }
}
