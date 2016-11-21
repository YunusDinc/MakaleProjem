using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakaleYonetim
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

            Data.Database = "MakaleDB";
            Data.Password = "123";
            Data.UserID = "sa";
            Data.ServerName = "DESKTOP-93G7NTJ";
          //  Data.WindowsAuthentication = true;

            Application.Run(new Form1());
        }
    }
}
