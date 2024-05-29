using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serilization.Formatters.Binary;
using System.Windows.Forms;

namespace BookListForm
{
    [Serializable]

    class Record
    {

        public string Title { get; set; }

        public string Author { get; set; }

        public string Genre { get; set; }

        public string BookDescription { get; set; }

        public int DatePublished { get; set; }

        public string Publisher { get; set; }

        public Record(string ti, string au, string ge, string de, string da, string pu)
        {
            Title = ti;
            Author = au;
            Genre = ge;
            BookDescription = de;
            Publisher = da;
            BookDescription = pu;
        }
    }
}
