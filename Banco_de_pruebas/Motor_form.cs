using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Banco_de_pruebas
{
    public partial class Motor_form : Form
    {
        Data_collection f11 = new Data_collection(); //para abrir form registro de 
        
        bool mem1 = false; //memoria freno 
        
        string pathdedault = "";
        string dato = "";

        bool boton_start = false;
        
        //filtro para señal
        double prom = 0; 
        double[] array = new double[5]; //array de 5 valores
        int contador_int = 0; //contador de las veces que entra a la funcion de proccess data 

        //datos a recibir 
        sbyte index0fZ, index0fY;
        String dataMod1, dataMod2;

        //exportar gráfica 
        string nameImage_velocidad = "\\Velocidad_grafica_Motor_";
        string nameImage_torque = "\\Torque_grafica_Motor_";
        int counterImage_creator = 0;

        public Motor_form()
        {
            InitializeComponent();
        }

        private void Motor_form_Load(object sender, EventArgs e)
        {
            (this.Owner as Form_inicial).serialPort1.Write("D2$"); //cambiar a modo motor arduino 
            (this.Owner as Form_inicial).Enabled = false; //congelar ventana principal 
            

            btn_reg_datos.Enabled = false;
            bn_guardar_graficas.Enabled = false; 
            stop_btn.Enabled = false; 
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
                (this.Owner as Form_inicial).serialPort1.Write("A2$"); //volver al menú principal 
                (this.Owner as Form_inicial).Enabled = true; //habilitar ventana principal 
               
                Variables.var = "";
                Variables.contador_serial_motor = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e) //al presionar boton iniciar prueba 
        {
            //regresar al estado original  radiobutton freno 
            if ((radioButton1.Checked == true) && (mem1 == false))
            {

                radioButton2.Checked = true;
            }
            else if ((radioButton1.Checked == false) && (mem1 == true)) {

                radioButton1.Checked = true; 

            }
         
            (this.Owner as Form_inicial).serialPort1.Write("K2$"); //empezar lectura de datos 
            boton_start = true; //inicio de prueba 
            btn_reg_datos.Enabled = true;
            bn_guardar_graficas.Enabled = true;
            test_status_lbl.BackColor = Color.Green;
            stop_btn.Enabled = true;
            init_test_btn.Enabled = false; 
        
        }

        private void button3_Click(object sender, EventArgs e) //al presionar botón parar prueba 
        {
            (this.Owner as Form_inicial).serialPort1.Write("L2$"); //detener lectura de datos 
            boton_start = false; //prueba terminada 
            test_status_lbl.BackColor = Color.Red;
            init_test_btn.Enabled = true;
            stop_btn.Enabled = false;
        }


        private void Sett_brake_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) 
            {
                (this.Owner as Form_inicial).serialPort1.Write("N2$"); //Freno libre 
                mem1 = true; //recordar estado 
                Sett_brake.Enabled = false; 
            }
            else
            {
                (this.Owner as Form_inicial).serialPort1.Write("M2$"); //Freno ajustado
                mem1 = false; //recordar estado 
                Sett_brake.Enabled = false; 
            }
        }//botón set freno 

        private void button2_Click(object sender, EventArgs e) //Botón registro de datos 
        {
            f11.ShowDialog(); //abrir formulario 
        }

        private void button4_Click_1(object sender, EventArgs e) //botón exportar gráficos 
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
            //monitoreo del estado de radialbutton 
            if (((mem1 == true) && (radioButton1.Checked == false)) || ((mem1 == false) && (radioButton1.Checked == true)))
            { 
                Sett_brake.Enabled = true; //habilita botón 
                                           
            }
            else {
                Sett_brake.Enabled = false; 
            }


            if (boton_start == true) //inicio prueba 
            {
                if (Variables.initFirstGEN == true)
                {
                    //Esta parte esta bajo depuración, Si se entra a modo generador y se corre una prueba, se detiene prueba, se sale de modo generador ,
                    //y depues se entra a modo motor y empieza la prueba ahora en este modo  
                    // A veces se observa un dato de velocidad y torque presente, un valor fijo (dato basura) de la anterior prueba
                    // , se cree que es por que se necesita borrar buffer serial y variables, si se sale del modo motor y se vuelve a entrar se limpia el dato  
                    // A veces se borra por si solo, a veces queda presente y se necesita salir del formulario motor y volver a entrar para que se borre....  

                    dato = "0%0Y";
                    Variables.var = "0%0Y";
                   // MessageBox.Show("entre a limpiar buffer");
                    (this.Owner as Form_inicial).serialPort1.DiscardInBuffer();
                    (this.Owner as Form_inicial).serialPort1.DiscardOutBuffer(); //limpiar buffer serial 
                    Variables.initFirstGEN = false; 
                }
                else {
                    dato = Variables.var; //tomamos datos provenientes del serial 
                }

                groupBox1.Enabled = false; //deshabilitar ajuste de freno 
               
                label6.Text = dato; //debug 
                timer1.Interval = 350;
                this.BeginInvoke(new EventHandler(ProcessData));
            }
            else { //la prueba no esta activa 
                groupBox1.Enabled = true; //habilitar ajuste freno 
            }
        } //timer formulario 

        private void ProcessData(object sender, EventArgs e) //acondicionar datos recibidos por serial 
        {
   
            try
           {
                int i;
                contador_int = contador_int + 1; 
                index0fZ = Convert.ToSByte(dato.IndexOf("%"));
                index0fY = Convert.ToSByte(dato.IndexOf("Y"));

                dataMod1 = dato.Substring(0, index0fZ); //%
                dataMod2 = dato.Substring(index0fZ + 1, (index0fY - index0fZ) - 1); //Y

                double numero1 = Convert.ToDouble(dataMod1);
                numero1 = numero1 * 60.0; //velocidad RPM 

                Speed_label.Text = Convert.ToString(numero1); //mostrar velcidad
                chart1.Series["Velocidad_c"].Points.Add(numero1); //gráficar 
                
                double numero3 = Math.Abs(numero1); //no negative values for aGauge  
                aGauge1.Value = Convert.ToSingle(numero3);
                
                //Registrar dato en dataGrid
                int n = f11.dataGridView1.Rows.Add();
                f11.dataGridView1.Rows[n].Cells[0].Value = n; //numero
                f11.dataGridView1.Rows[n].Cells[1].Value = numero1; //dato 
                f11.dataGridView1.Rows[n].Cells[2].Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"); //tiempo / fecha 

                double numero2 = Convert.ToDouble(dataMod2); //voltaje  negativo torque 
                label8.Text = Convert.ToString(numero2); //debug 
                
                  if (Variables.contador_serial_motor <= 4) //tomar muestras para filtro 
                    {
                        array[Variables.contador_serial_motor] = numero2; //guarda un valor a cada vuelta 
                    }
          
                  if (Variables.contador_serial_motor >= 5) {  //cuando se llene entonces, el filtrado

                        for (i =0; i <= 4; i++) { 
                            prom = prom + array[i]; //sumar todos los valores     
                               }

                        prom = prom/5; //promediar
                        prom = prom * 0.0078125; //multiplicar por factor de escala de ADS1115 modulo arduino 
                        prom = Math.Round(prom, 3); //redondear 
                        
                        label5.Text = Convert.ToString(prom); //mostrar dato
                        chart2.Series["Torque_c"].Points.Add(prom); //gráficar
                        
                        //Registrar dato
                        int n2 = f11.dataGridView2.Rows.Add(); 
                        f11.dataGridView2.Rows[n2].Cells[0].Value = n2; //numero
                        f11.dataGridView2.Rows[n2].Cells[1].Value = prom; //dato 
                        f11.dataGridView2.Rows[n2].Cells[2].Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"); //tiempo /fecha 
                        
                        Variables.contador_serial_motor = 0; //volvar a tomar lecturas 

                     }
 
                label7.Text = Convert.ToString(Variables.contador_serial_motor); //debug 


            }
            catch (Exception) {
                dato = "0%0Y"; // prevenir datos basura 
            }
        }
    }
}
