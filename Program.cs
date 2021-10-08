using System;
using System.Windows.Forms;

namespace KassaSystem
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
            Filhantering fh = new Filhantering();
            Controller co = new Controller(fh);
            Application.Run(new View(co, fh));
        }
    }
}
    