using Library.Forms;
using Library.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class EditForm : Form
    {
        private Book currentBook;
        public EditForm(Book _currentBook)
        {
            InitializeComponent();
            this.currentBook = _currentBook;
            txtTitle.Text = currentBook.Title;
            txtAuthor.Text = currentBook.Author;
            txtDescription.Text = currentBook.Description;
            txtGenre.Text = currentBook.Genre;
            txtPublisher.Text = currentBook.Publisher;
            txtPublishedDate.Text = currentBook.PublishedDate;
        }

        private void btnApply_Click(object sender, EventArgs e)
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
                if (LibraryContext.Db.Books.FirstOrDefault(v => v.User.Id == User.CurrentUser.Id && v.Title == txtTitle.Text && currentBook.Id != v.Id) != null)
                    MessageBox.Show($"Book with name {txtTitle.Text} already exists!");
                else if(currentBook.Title == txtTitle.Text && currentBook.Author == txtAuthor.Text && currentBook.Genre == txtGenre.Text && currentBook.Description == txtDescription.Text && currentBook.Publisher == txtPublisher.Text && currentBook.PublishedDate == txtPublishedDate.Text)
                    MessageBox.Show("No changes were made. Please press the \"Discard\" button if you do not wish to make any changes.");
                else
                {
                    var newBook = new Book
                    {
                        Id = currentBook.Id,
                        User = currentBook.User,
                        Title = txtTitle.Text,
                        Author = txtAuthor.Text,
                        Genre = txtGenre.Text,
                        Description = txtDescription.Text,
                        Publisher = txtPublisher.Text,
                        PublishedDate = txtPublishedDate.Text
                    };
                    var origBook = LibraryContext.Db.Books.First(v => v.Id == currentBook.Id);
                    LibraryContext.Db.Entry(origBook).CurrentValues.SetValues(newBook);
                    LibraryContext.Db.SaveChanges();
                    MessageBox.Show($"Book \"{txtTitle.Text}\" successfully edited!");
                    Program.OpenNewForm(this, new BookListForm());
                }
            }
            else
                MessageBox.Show(errorMessage);
        }

        private void btnDiscard_Click(object sender, EventArgs e) => Program.OpenNewForm(this, new BookListForm());
        private void btnLogout_Click(object sender, EventArgs e) => Program.OpenNewForm(this, new LoginForm());
    }
}
