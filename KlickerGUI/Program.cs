using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlickerGUI
{
    static class Program
    {

        internal static Form mainUI;
        internal static Form settingsUI;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            mainUI = new MainUI { };
            settingsUI = new SettingsUI { };
            Application.Run(mainUI);
        }
    }
}
