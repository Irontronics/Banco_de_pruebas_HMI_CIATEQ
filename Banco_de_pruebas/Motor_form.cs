using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Banco_de_pruebas
{
    public partial class Motor_form : Form
    {
        string pathdedault = "";

        string namefileDef = @"User_settings_motion_"; //constante
        string namefile;
        int counterFilecreator = 0;

        public Motor_form()
        {
            InitializeComponent();
        }

        private void Motor_form_Load(object sender, EventArgs e)
        {
            (this.Owner as Form_inicial).serialPort1.Write("D2$");
            (this.Owner as Form_inicial).Enabled = false;

            //crear carpeta modo motor en root path 
            if (!(System.IO.File.Exists(Variables.rootpath)))
            { // si existe entonces 
                Directory.CreateDirectory(Variables.rootpath + "\\Modo Motor");
                pathdedault = Variables.rootpath + "\\Modo Motor\\";
                Variables.path_gen_mode = Variables.rootpath + "\\Modo Motor\\";

            }

        }

        private void Motor_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            (this.Owner as Form_inicial).serialPort1.Write("A2$");
            (this.Owner as Form_inicial).Enabled = true;
        }
    }
}
