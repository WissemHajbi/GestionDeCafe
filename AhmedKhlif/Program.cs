using AhmedKhlif.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhmedKhlif
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

                LogIn loginForm = new LogIn();
                Application.Run(loginForm);

                if (loginForm.UserSuccessfullyAuthenticated)
                {
                    Main main = new Main();
                    main.MainAccount = loginForm.Account;
                    Application.Run(main);
                }

        }
    }
}
