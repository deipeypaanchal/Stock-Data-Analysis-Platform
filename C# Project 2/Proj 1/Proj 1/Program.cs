/*
Name: Deepey Panchal
UNumber: U80305771
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Enable visual styles for the application, which affects the appearance of controls.
            Application.EnableVisualStyles();

            // Set the default text rendering to be compatible with visual styles.
            Application.SetCompatibleTextRenderingDefault(false);

            // Run the application by starting the main form, which is FormEntry in this case.
            Application.Run(new FormEntry());
        }
    }
}