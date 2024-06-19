using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library.Model
{
    public static class Extension
    {
        public static void StartAndSavePosition(this Form currentForm, Form newForm)
        {
            newForm.Closed += (s, args) => currentForm.Close();
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = currentForm.Location;
            currentForm.Hide();
            newForm.Show();
        }
    }
}