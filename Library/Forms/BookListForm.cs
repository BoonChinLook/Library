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

namespace Library
{
    public partial class BookListForm : Form
    {
        private List<Book> books;
        private string fileDialogFilter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
        private List<Record> recordsList = new List<Record>();

        public BookListForm() => InitializeComponent();

        private void BookListForm_Load(object sender, EventArgs e)
        {
            books = LibraryContext.Db.Books.Where(v => v.User.Id == User.CurrentUser.Id).ToList();
            bookListGridView.DataSource = books.Select(x => new { x.Title, x.Author, x.Publisher }).ToList();
            var editButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Edit",
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            };
            bookListGridView.Columns.Add(editButtonColumn);
            var deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            bookListGridView.Columns.Add(deleteButtonColumn);
        }

        private void bookListGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 3 || e.ColumnIndex == 0)
                {
                    var frm = new EditForm(books[e.RowIndex]);
                    frm.Closed += (s, args) => this.Close();
                    this.Hide();
                    frm.Show();
                }
                else if(e.ColumnIndex == 4 || e.ColumnIndex == 1)
                {
                    LibraryContext.Db.Books.Remove(books[e.RowIndex]);
                    LibraryContext.Db.SaveChanges();
                    books.RemoveAt(e.RowIndex);
                    bookListGridView.DataSource = books.Select(x => new { x.Title, x.Author, x.Publisher }).ToList();
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
            var fileChooser = new SaveFileDialog();
            fileChooser.Filter = fileDialogFilter;
            fileChooser.RestoreDirectory = true;
            var result = fileChooser.ShowDialog();
            if(result == DialogResult.OK)
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
                    csvfileWriter.WriteLine("Title,Author,Genre,Description,Published Date,Publisher");
                    foreach (var book in books)
                        csvfileWriter.WriteLine($"{book.Title},{book.Author},{book.Genre},{book.Description},{book.PublishedDate},{book.Publisher}");
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
       