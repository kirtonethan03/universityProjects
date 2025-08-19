///Authors: Tom & Ethan
using System;
using System.Windows.Forms;


namespace ImageManipulatorView
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // run the view for user interaction 
            Application.Run(new GalleryView());
        }
    }
}
