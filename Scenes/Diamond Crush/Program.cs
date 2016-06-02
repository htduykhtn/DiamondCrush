using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace Diamond_Crush
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        private static bool _isEmty = true;
        static void Main()
        {
            var mutex = new Mutex(false, "Diamond Crush", out _isEmty);
            if (!_isEmty)
            {
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SignIn context = SignIn.Instance();
            Application.Run(context);
            GC.KeepAlive(mutex);
        }
    }
}
