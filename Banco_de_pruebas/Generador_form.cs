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
        string dato;      //para los datos 
        sbyte index0fZ, index0fY, index0fX, index0fW, index0fV;
        String dataMod1, dataMod2, dataMod3, dataMod4, dataMod5;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false; 
        }

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

        private void timer1_Tick(object sender, EventArgs e) //refresco de variables 
        {
            dato = Variables.var;
            label6.Text = Variables.var;
            this.BeginInvoke(new EventHandler(ProcessData));
        }

        private void ProcessData(object sender, EventArgs e)
        {
            try
            {

                index0fZ = Convert.ToSByte(dato.IndexOf("Z"));
                index0fY = Convert.ToSByte(dato.IndexOf("Y"));
                index0fX = Convert.ToSByte(dato.IndexOf("X"));
                index0fW = Convert.ToSByte(dato.IndexOf("W"));
                index0fV = Convert.ToSByte(dato.IndexOf("V"));

                dataMod1 = dato.Substring(0, index0fZ);
                dataMod2 = dato.Substring(index0fZ + 1, (index0fY - index0fZ) - 1);
                dataMod3 = dato.Substring(index0fY + 1, (index0fX - index0fY) - 1);
                dataMod4 = dato.Substring(index0fX + 1, (index0fW - index0fX) - 1);
                dataMod5 = dato.Substring(index0fW + 1, (index0fV - index0fW) - 1);

                double numero1 = Convert.ToDouble(dataMod1);
                double numero2 = Math.Round(((numero1 * 245735) / 4294967295), 2);
                if (numero2 > 10) { Speed_label.Text = numero2.ToString(); } else { Speed_label.Text = "0"; } //representación de velocidad

                if (Convert.ToString(dataMod2) == "1") { Drv_status_lab.BackColor = Color.Green; } else if (Convert.ToString(dataMod2) == "0") { Drv_status_lab.BackColor = Color.Red; }//DrvStatus
                if (Convert.ToString(dataMod3) == "1") { Stop_label.BackColor = Color.Green; } else if (Convert.ToString(dataMod3) == "0") { Stop_label.BackColor = Color.Red; }//paroStatus

                double numero3 = Convert.ToDouble(dataMod4);
                double numero4 = numero3 / 1000;
                numero4 = Math.Round(numero4, 2);
                Volt_label.Text = numero4.ToString(); // representación de voltaje 

                Temp_label.Text = Convert.ToString(dataMod5); //representación_temperatura
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

    }
}
