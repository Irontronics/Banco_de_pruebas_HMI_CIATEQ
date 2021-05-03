using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports; //include this library 
using System.Threading;

namespace Banco_de_pruebas
{
    public partial class Form_inicial : Form
    {


    public Form_inicial()
        {

            InitializeComponent(); //función inicialización formulario 

        }

        private void Form_inicial_Load(object sender, EventArgs e) //al iniciar formulario 
        {
            Baud_rate_cbox.Text = "9600"; // velocidad por default 
            string[] puertos = SerialPort.GetPortNames(); //obtener puertos PC
            comboBox1.Items.AddRange(puertos); //agrego todos los puertos al combobox
        }

        private void btn_cancel_init_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                    Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else { //si no entra al if es que ya el serial port se ha cerrado 
                Close();
            
            }
           
        }

        private void button_open_comm_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = Convert.ToInt32(Baud_rate_cbox.Text);
                serialPort1.Open();
                progressBar1.ForeColor = Color.Red; //cambio de color a progress bar 
                progressBar1.Value = 100;
                label1.Visible = true;
                Baud_rate_cbox.Enabled = false;
                comboBox1.Enabled = false;
                groupbx_modos.Enabled = true; 
            }
            catch (Exception error) {
                MessageBox.Show(error.Message);
            }
        }

        private void btn_close_comm_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                    progressBar1.Value = 0;
                    label1.Visible = false;
                    Baud_rate_cbox.Enabled = true;
                    comboBox1.Enabled = true;
                    chk_bx_genera.Checked = false;
                    chk_bx_motor.Checked = false;
                    groupbx_modos.Enabled = false;
                    Btn_ok_init.Enabled = false;

                }
                catch (Exception error) {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void Form_inicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void chk_bx_motor_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_bx_motor.Checked)
            {
                chk_bx_genera.Enabled = false;
                Btn_ok_init.Enabled = true;
            }
            else { chk_bx_genera.Enabled = true;
                   Btn_ok_init.Enabled = false;
            }
        }

        private void chk_bx_genera_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_bx_genera.Checked)
            {
                chk_bx_motor.Enabled = false;
                Btn_ok_init.Enabled = true;
            }
            else
            {
                chk_bx_motor.Enabled = true;
                Btn_ok_init.Enabled = false;
            }
        }
    }
}
