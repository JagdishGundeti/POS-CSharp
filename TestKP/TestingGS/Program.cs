using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KPSonar
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
            //Application.Run(new Form1());
            //Application.Run(new CustomerDetails());
            Application.Run(new MDISonar());
            
        }
    }
}