using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Library.Model
{
    public class User
    {
        [NotMapped]
        public static User CurrentUser { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
