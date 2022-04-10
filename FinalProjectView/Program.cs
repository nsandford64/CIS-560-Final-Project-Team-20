using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectView
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


            ViewController vc = new ViewController();
            AdminView av = new AdminView(vc);
            ClientView cv = new ClientView(vc);
            vc.SetViews(cv, av);

            Application.Run(cv);
        }
    }
}
