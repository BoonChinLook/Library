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
    public partial class Form1 : Form
    {
        private BookRepository _bookRepository;
        public Form1()
        {
            InitializeComponent();
            _bookRepository = new BookRepository();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void btnAddbook_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string author = txtAuthor.Text;

            Book book = new Book
            { 
                Title = title,
                Author = author,
            };
            _bookRepository.AddBook(book);

            // Optionally, show a confirmation message
            MessageBox.Show("Book added successfully!");

        }

        private void Updatebook_Click(object sender, EventArgs e)
        {

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
