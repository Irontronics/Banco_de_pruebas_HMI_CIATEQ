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
using System.Threading;

namespace Banco_de_pruebas
{
    public partial class Motor_form : Form
    {
        Data_collection f11 = new Data_collection();
        bool mem1 = false; //memoria freno 
        string pathdedault = "";
        string dato = "";
        string namefileDef = @"User_settings_motion_"; //constante
        string namefile;
        int counterFilecreator = 0;
        bool boton_start = false;
        //bool firstInit = false; //bandera de primer inicio 
        double prom = 0;
        double[] array = new double[5]; //array de 5 valores

        int num_flag = 0; 
        int contador_int = 0; //contador de las veces que entra a la funcion de proccess data 


        sbyte index0fZ, index0fY;
        String dataMod1, dataMod2;

        string nameImage_velocidad = "\\Velocidad_grafica_Motor_";
        string nameImage_torque = "\\Torque_grafica_Motor_";
        int counterImage_creator = 0;

        public Motor_form()
        {
            InitializeComponent();
        }

        private void Motor_form_Load(object sender, EventArgs e)
        {
            (this.Owner as Form_inicial).serialPort1.Write("D2$"); //inicio modo motor GUI arduino 
            (this.Owner as Form_inicial).Enabled = false;
            

            button2.Enabled = false;
            button4.Enabled = false; 
            button3.Enabled = false; 
            test_status_lbl.BackColor = Color.Red;
            radioButton1.PerformClick(); //asignar freno libre por default 
            mem1 = true; //recordar estado freno libre 
            Sett_brake.Enabled = false;

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
            if (boton_start == true)
            { //si la prueba esta activa no permitir salir del form 
                MessageBox.Show("¡No se permite salida hasta que se detenga la prueba!");
                e.Cancel = true;
            }
            else
            {
                (this.Owner as Form_inicial).serialPort1.Write("A2$");
                (this.Owner as Form_inicial).Enabled = true;
                Variables.SerialPresent = false;
                Variables.var = "";
                Variables.contador_serial_motor = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((radioButton1.Checked == true) && (mem1 == false))
            {

                radioButton2.Checked = true;
            }
            else if ((radioButton1.Checked == false) && (mem1 == true)) {

                radioButton1.Checked = true; 

            }
           


            //mandar puerto serie para inicio de datos 
            (this.Owner as Form_inicial).serialPort1.Write("K2$");
            boton_start = true; //inicio la prueba 
            button2.Enabled = true;
            button4.Enabled = true;
            test_status_lbl.BackColor = Color.Green;
            button3.Enabled = true;
            button1.Enabled = false; 
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (this.Owner as Form_inicial).serialPort1.Write("L2$");
            boton_start = false; //prueba terminada 
            test_status_lbl.BackColor = Color.Red;
            button1.Enabled = true;
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
       
        }

        private void Sett_brake_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) //freno libre 
            {
                (this.Owner as Form_inicial).serialPort1.Write("N2$"); //FRENO LIBRE
                mem1 = true;
                Sett_brake.Enabled = false; 
            }
            else
            {
                (this.Owner as Form_inicial).serialPort1.Write("M2$"); //Freno ajustado
                mem1 = false;
                Sett_brake.Enabled = false; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f11.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            String pathImage = Variables.path_gen_mode + nameImage_velocidad + counterImage_creator + ".png"; //ruta de carpeta para grafica velocidad
            String pathImage2 = Variables.path_gen_mode + nameImage_torque + counterImage_creator + ".png"; //ruta de carpeta para gráfica torque
            chart1.SaveImage(pathImage, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
            chart2.SaveImage(pathImage2, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
            counterImage_creator += 1;
            MessageBox.Show("Gráficas exportadas a carpeta");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (((mem1 == true) && (radioButton1.Checked == false)) || ((mem1 == false) && (radioButton1.Checked == true)))
            {  //si se cambio el estado inicial entonces 
                Sett_brake.Enabled = true; //habilita botón 
                                           // mem1 = false; 
            }
            else {
                Sett_brake.Enabled = false; 
            }


            if (boton_start == true) //inicio prueba 
            {
                groupBox1.Enabled = false; 
                dato = Variables.var; //tomamos datos provenientes del serial 
                label6.Text = dato;
                timer1.Interval = 350;
                this.BeginInvoke(new EventHandler(ProcessData));
            }
            else { //la prueba no esta activa 
                groupBox1.Enabled = true;
            }
        }

        private void ProcessData(object sender, EventArgs e)
        {
   

            try
           {
                
                
                int i;
                
               

                contador_int = contador_int + 1; 
                index0fZ = Convert.ToSByte(dato.IndexOf("%"));
                index0fY = Convert.ToSByte(dato.IndexOf("Y"));

                dataMod1 = dato.Substring(0, index0fZ); //%
                dataMod2 = dato.Substring(index0fZ + 1, (index0fY - index0fZ) - 1); //&




                double numero1 = Convert.ToDouble(dataMod1);
                numero1 = numero1 * 60.0; //velocidad RPM 
                Speed_label.Text = Convert.ToString(numero1); //mostrarlo 
                chart1.Series["Velocidad_c"].Points.Add(numero1);
                double numero3 = Math.Abs(numero1);
                aGauge1.Value = Convert.ToSingle(numero3);
                //añadir renglon
                int n = f11.dataGridView1.Rows.Add();
            //Colocamos información
            f11.dataGridView1.Rows[n].Cells[0].Value = n;
            f11.dataGridView1.Rows[n].Cells[1].Value = numero1;
            f11.dataGridView1.Rows[n].Cells[2].Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");



            double numero2 = Convert.ToDouble(dataMod2);
                label8.Text = Convert.ToString(numero2);
                
            


            if (Variables.contador_serial_motor <= 4)
            {
                array[Variables.contador_serial_motor] = numero2; //guarda un valor a cada vuelta 
            }
                
                // MessageBox.Show(Convert.ToString(array[Variables.contador_serial_motor]));

                //cuando se llene entonces: 
                              if (Variables.contador_serial_motor >= 5) {  //cuando se llene entonces, el filtrado

                              for (i =0; i <= 4; i++) { 
                                prom = prom + array[i];
                                    //MessageBox.Show("hols");
                               }

                prom = prom/5;
                prom = prom * 0.0078125;
                prom = Math.Round(prom, 3);
                label5.Text = Convert.ToString(prom);
                chart2.Series["Torque_c"].Points.Add(prom);
                int n2 = f11.dataGridView2.Rows.Add();
                //Colocamos información
                f11.dataGridView2.Rows[n2].Cells[0].Value = n2;
                f11.dataGridView2.Rows[n2].Cells[1].Value = prom;
                f11.dataGridView2.Rows[n2].Cells[2].Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                Variables.contador_serial_motor = 0;

                }

                //numero2 = numero2 * 0.0078125; //factor escala 
               // label5.Text = Convert.ToString(numero2); //ver si es necesario filtrado , si es necesario el filtro 
                label7.Text = Convert.ToString(Variables.contador_serial_motor);


            }
            catch (Exception) {
                dato = "0%0Y";
                //MessageBox.Show("Error en ejecución de prueba monitoreo");
            }
        }
    }
}
