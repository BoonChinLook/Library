using Library.Forms;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class LibraryContextInitializer : CreateDatabaseIfNotExists<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {
            var user1 = new User { Id = 1, Name = "User1", Password = "1" };

            context.Users.Add(user1);

            context.SaveChanges();
        }
    }
}
