using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_de_pruebas
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();// se comenta esta linea 
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_inicial());
        }
    }
}
