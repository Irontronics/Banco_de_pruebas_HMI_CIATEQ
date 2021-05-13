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
    public partial class Motor_form : Form
    {
        public Motor_form()
        {
            InitializeComponent();
        }

        private void Motor_form_Load(object sender, EventArgs e)
        {
            (this.Owner as Form_inicial).serialPort1.Write("D2$");
            (this.Owner as Form_inicial).Enabled = false;
        }

        private void Motor_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            (this.Owner as Form_inicial).serialPort1.Write("A2$");
            (this.Owner as Form_inicial).Enabled = true;
        }
    }
}
