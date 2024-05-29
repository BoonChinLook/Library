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

        private void btnSubmit_Click(object sender, EventArgs e)
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
            if (titleCheck && authorCheck && genreCheck)
            {
                if (LibraryContext.Db.Books.FirstOrDefault(v => v.Title == txtTitle.Text) != null)
                    MessageBox.Show($"Book with name {txtTitle.Text} already exists!");
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
                    MessageBox.Show($"Book {txtTitle.Text} successfully edited!");
                    var frm = new BookListForm();
                    frm.Closed += (s, args) => this.Close();
                    this.Hide();
                    frm.Show();
                }
            }
        }
    }
}
