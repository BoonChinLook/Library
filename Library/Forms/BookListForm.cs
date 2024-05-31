using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Library.Forms;
using Library.Model;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.IO;
using static System.Net.WebRequestMethods;

namespace Library
{
    public partial class BookListForm : Form
    {
        private List<Book> books;
        private string fileDialogFilter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";

        public BookListForm() => InitializeComponent();

        private void BookListForm_Load(object sender, EventArgs e)
        {
            books = LibraryContext.Db.Books.Where(v => v.User.Id == User.CurrentUser.Id).ToList();
            var editButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Edit",
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            };
            var deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            bookListGridView.Columns.Add("Title", "Title");
            bookListGridView.Columns.Add("Author", "Author");
            bookListGridView.Columns.Add("Publisher", "Publisher");
            bookListGridView.Columns.Add(editButtonColumn);
            bookListGridView.Columns.Add(deleteButtonColumn);
            foreach (var item in books)
                bookListGridView.Rows.Add(item.Title, item.Author, item.Publisher);
        }

        private void bookListGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                switch (e.ColumnIndex)
                {
                    case 3:
                        var frm = new EditForm(books[e.RowIndex]);
                        frm.Closed += (s, args) => this.Close();
                        this.Hide();
                        frm.Show();
                        break;
                    case 4:
                        LibraryContext.Db.Books.Remove(books[e.RowIndex]);
                        LibraryContext.Db.SaveChanges();
                        books.RemoveAt(e.RowIndex);
                        bookListGridView.Rows.RemoveAt(e.RowIndex);
                        break;

                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new AddForm();
            frm.Closed += (s, args) => this.Close();
            this.Hide();
            frm.Show();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var fileChooser = new SaveFileDialog { Filter = fileDialogFilter, RestoreDirectory = true };
            if (fileChooser.ShowDialog() == DialogResult.OK)
                SaveCSVFile(fileChooser.FileName);
        }

        private void SaveCSVFile(string csvFileName)
        {
            if (string.IsNullOrEmpty(csvFileName))
            {
                MessageBox.Show("Invalid file name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (FileStream csvOutput = new FileStream(csvFileName, FileMode.Create, FileAccess.Write))
                using (StreamWriter csvfileWriter = new StreamWriter(csvOutput))
                {
                    csvfileWriter.WriteLine("Title;Author;Genre;Description;Published;Date;Publisher");
                    foreach (var book in books)
                        csvfileWriter.WriteLine($"{book.Title.Replace(';', ',')};{book.Author.Replace(';', ',')};{book.Genre.Replace(';', ',')};{book.Description.Replace(';', ',')};{book.PublishedDate.Replace(';', ',')};{book.Publisher.Replace(';', ',')}");
                }
                MessageBox.Show("File saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var frm = new WelcomeForm();
            frm.Closed += (s, args) => this.Close();
            this.Hide();
            frm.Show();
        }
    }
}