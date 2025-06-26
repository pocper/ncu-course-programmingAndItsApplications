using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Ex0_FileDialog
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormEx2());
        }
    }
}
