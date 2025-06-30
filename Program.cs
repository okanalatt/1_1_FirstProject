using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_1_FirstProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); // Enable visual styles for the application
            Application.SetCompatibleTextRenderingDefault(false); // Set the default text rendering to be compatible with the current settings
            Application.Run(new Form1()); // Run the main form of the application
        }
    }
}
