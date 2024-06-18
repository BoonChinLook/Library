﻿using System;
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
                var currentRowName = bookListGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                var currentRowAuthor = bookListGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                switch (e.ColumnIndex)
                {
                    case 3:
                        Program.OpenNewForm(this, new EditForm(books.First(v => v.Title == currentRowName && v.Author == currentRowAuthor)));
                        break;
                    case 4:
                        var currentBook = books.First(v => v.Title == currentRowName && v.Author == currentRowAuthor);
                        LibraryContext.Db.Books.Remove(currentBook);
                        LibraryContext.Db.SaveChanges();
                        books.Remove(currentBook);
                        bookListGridView.Rows.RemoveAt(e.RowIndex);
                        break;
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var fileChooser = new SaveFileDialog { Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*", RestoreDirectory = true };
            if (fileChooser.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fileChooser.FileName))
                {
                    MessageBox.Show("Invalid file name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    using (var csvOutput = new FileStream(fileChooser.FileName, FileMode.Create, FileAccess.Write))
                    using (var csvfileWriter = new StreamWriter(csvOutput))
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
        }

        private void btnAdd_Click(object sender, EventArgs e) => Program.OpenNewForm(this, new AddForm());
        private void btnHome_Click(object sender, EventArgs e) => Program.OpenNewForm(this, new WelcomeForm());
        private void btnLogout_Click(object sender, EventArgs e) => Program.OpenNewForm(this, new LoginForm());
        private void bookListGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e) => e.Cancel = true;

    }
}