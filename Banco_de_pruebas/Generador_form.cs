using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_de_pruebas
{
    public partial class Generador_form : Form
    {
        public Generador_form()
        {
            InitializeComponent();
             
        }

        private void Generador_form_Load(object sender, EventArgs e)
        {
            (this.Owner as Form_inicial).serialPort1.Write("B2$"); //comando para arduino, inicializar programa B2
            (this.Owner as Form_inicial).Enabled = false; 

        }

        private void Generador_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            (this.Owner as Form_inicial).serialPort1.Write("A2$");
            (this.Owner as Form_inicial).Enabled = true;

        }
    }


}
