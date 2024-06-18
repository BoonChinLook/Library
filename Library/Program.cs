using Library.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LibraryContext.Db = new LibraryContext();
            Application.Run(new LoginForm());
        }

        public static void OpenNewForm (Form currentForm, Form newForm)
        {
            newForm.Closed += (s, args) => currentForm.Close();
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = currentForm.Location;
            currentForm.Hide();
            newForm.Show();
        }
    }
}
