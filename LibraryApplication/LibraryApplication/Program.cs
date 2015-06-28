using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LibraryApplication.SqlLayer;

namespace LibraryApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataLayer dL = new DataLayer();
            dL.UpdateFines();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
}
