using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports; 
using System.Threading;
using System.IO;

namespace Banco_de_pruebas
{

    public partial class Form_inicial : Form
    {
        string dato = "";
        sbyte index0fZ;
        String dataMod1;
        string dir = @"C:\Datos_Pruebas"; //carpeta principal 

        public Form_inicial()
        {
            InitializeComponent();
        }

        private void Form_inicial_Load(object sender, EventArgs e) //al iniciar formulario tomamos puertos serie 
        {
            Baud_rate_cbox.Text = "9600"; // velocidad por default 
            string[] puertos = SerialPort.GetPortNames(); //obtener puertos PC
            comboBox1.Items.AddRange(puertos); //agrego todos los puertos al combobox

            //crear carpeta para logs 
            String Date_String = Convert.ToString(DateTime.Now.ToString("yyyy_MM_dd hh_mm_ss"));
            if (!(System.IO.File.Exists(dir))) { // si existe entonces 
                Directory.CreateDirectory(dir + "\\Sesion_" + Date_String);
                Variables.rootpath = (dir + "\\Sesion_" + Date_String); // para los demas forms 
            }
        }

        private void btn_cancel_init_Click(object sender, EventArgs e) //boton de cancelar 
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("C2$"); //apagar todo 
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
            else { //si no entra al if es que ya el serial port se ha cerrado manualmente por usuario 
                Close();
            }
        }

        private void button_open_comm_Click(object sender, EventArgs e) //intentar comunicacion con arduino, si falla entonces: 
        {
            try
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = Convert.ToInt32(Baud_rate_cbox.Text);
                serialPort1.Open();
                serialPort1.Write("Init$"); //Arduino is alive? 
                Thread.Sleep(850); // timeout
                 if (dato == "") { // if no communication to arduino then: 
                    label1.Visible = true;
                    label1.Size = new Size(333, 13);
                    label1.Location = new Point(6, 67);
                    label1.BackColor = Color.Red;
                    label1.Text = "                                        Arduino not found";
                    if (serialPort1.IsOpen) {
                        button_open_comm.Enabled = false;
                        comboBox1.Enabled = false;
                        Baud_rate_cbox.Enabled = false; 
                    }
                }
            }
            catch (Exception error) {
                MessageBox.Show(error.Message);
            }
        }

        private void btn_close_comm_Click(object sender, EventArgs e) //boton cerrar comunicaciones 
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                   
                        serialPort1.Write("C2$"); //apagar todo 
                        progressBar1.Value = 0;
                        dato = "";
                        label1.Visible = false;
                        Baud_rate_cbox.Enabled = true;
                        comboBox1.Enabled = true;
                        chk_bx_genera.Checked = false;
                        chk_bx_motor.Checked = false;
                        groupbx_modos.Enabled = false;
                        Btn_ok_init.Enabled = false;
                        comboBox1.Text = "";
                        serialPort1.Close();
                        comboBox1.Enabled = true;
                        Baud_rate_cbox.Enabled = true;
                        button_open_comm.Enabled = true;
                }
                catch (Exception error) {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void Form_inicial_FormClosing(object sender, FormClosingEventArgs e) //al cerrar formulario 
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("C2$"); //apagar todo 
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

        private void chk_bx_motor_CheckedChanged(object sender, EventArgs e) //validacion checkboxes 
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

        private void chk_bx_genera_CheckedChanged(object sender, EventArgs e) //validación checkboxes 2
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

        private void Btn_ok_init_Click(object sender, EventArgs e) //al presionar botón 'ok' determina cual formulario debe de abrir 
        {
            if (chk_bx_genera.Checked) { //si el modo generador ha sido seleccionado, entonces abrir form generador: 
                Generador_form F2 = new Generador_form();
                F2.Owner = this;
                F2.Show();
            }
            else { // de lo contrario abrir el form motor 
                Motor_form F3 = new Motor_form();
                F3.Owner = this;
                F3.Show();
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e) //si se recibe un dato de comunicación serial 
        {
            dato = serialPort1.ReadLine();
            if (dato == "") { 
               
            }
            else {
                this.BeginInvoke(new EventHandler(ProcessData));
            }
        }

        private void ProcessData(object sender, EventArgs e) //comunicación serial OK! ("Successfully connected!")
        {
            if (!(Application.OpenForms["Generador_form"] == null)) // si el formulario de generador esta activo y se reciben datos al serial: 
            {

                Variables.var = dato; //le paso el dato a var global
                
            }
            if (!(Application.OpenForms["Motor_form"] == null)) //si el formulario de modo motor esta activo y se reciben datos al serial:
            {

                Variables.var = dato; //le paso el dato 
                
                Variables.contador_serial_motor += 1; //contar las veces que se ingresa para realizar el filtro
            }
            else //de lo contrario apenas se va a iniciar comunicación entonces: 
            {
                try
                {
                    button_open_comm.Enabled = false;
                    comboBox1.Enabled = false;
                    Baud_rate_cbox.Enabled = false;
                    index0fZ = Convert.ToSByte(dato.IndexOf("Z"));
                    dataMod1 = dato.Substring(0, index0fZ);
                    if (dataMod1 == "123") //respuesta de arduino a la comunicación, comunicación exitosa! ("Successfully connected!")
                    {
                        progressBar1.Value = 100;
                        label1.Visible = true;
                        label1.Size = new Size(150, 13);
                        label1.Location = new Point(106, 67);
                        label1.Text = "Successfully connected!";
                        label1.BackColor = Color.FromArgb(0, 173, 0);
                        Baud_rate_cbox.Enabled = false;
                        comboBox1.Enabled = false;
                        groupbx_modos.Enabled = true;
                        serialPort1.Write("A2$"); //manda a meterse a primer programa A2$ StandBy

                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Error en com inicial");

                }
            }

        }
    }
}
