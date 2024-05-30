using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
        [Serializable]
        class Record
        {

            public string Title { get; set; }

            public string Author { get; set; }

            public string Genre { get; set; }

            public string BookDescription { get; set; }

            public string DatePublished { get; set; }

            public string Publisher { get; set; }

        }
    
}

