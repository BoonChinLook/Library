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
            // Bind data to datagrid view

        }
    }
}
