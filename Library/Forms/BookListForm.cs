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

namespace Library
{
    public partial class BookListForm : Form
    {
        public BookListForm()
        {
            InitializeComponent();
        }

        private void BookListForm_Load(object sender, EventArgs e)
        {


            // Retrieve Books from Database
            var books = LibraryContext.Db.Books.Select(x => new { x.Title, x.Author, x.Publisher }).ToList();
            
            bookListGridView.DataSource = books;
            var editButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Edit",
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            };
            bookListGridView.Columns.Add(editButtonColumn);

            // Add Delete button
            var deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            bookListGridView.Columns.Add(deleteButtonColumn);


            // Bind data to datagrid view

        }
    }
}
