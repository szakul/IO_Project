using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportCenterManager
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
<<<<<<< HEAD
            LoginWindowController controller = new LoginWindowController();
=======
            CoachWindowController controller = new CoachWindowController();
>>>>>>> CoachWindow
            Application.Run(controller.View);
        }
    }
}
