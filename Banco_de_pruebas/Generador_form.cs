using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;


namespace Banco_de_pruebas
{
    public partial class Generador_form : Form
    {
        Data_collection f11 = new Data_collection();
        string dato, palabraSettings;      //para los datos 
        sbyte index0fZ, index0fY, index0fX, index0fW;
        String dataMod1, dataMod2, dataMod3, dataMod4;
        string mem1, mem2, mem3, mem4, mem5, mem6, mem7, mem8;
        bool init_move = false; 


        int counter_time = 0;
        int counter_time2 = 0; 

        bool setting_F; //bandera para tab settings 
        bool test = false; //bandera para tab settings
        bool StatusButton_axis = true;
        bool StatusButton_start = true;
        bool error_data = false;
        //
        //variables de creación text file 
        //string pathdedault = @"C:\\Users\\CONACYTSLP\\Desktop\\Prueba logs\\";
        string pathdedault = ""; 

        string namefileDef = @"User_settings_motion_"; //constante
        string namefile;
        int counterFilecreator = 0;

        string nameImage_velocidad = "\\Velocidad_grafica_Generador_";
        string nameImage_torque = "\\Torque_grafica_Generador_";
        int counterImage_creator = 0; 

        private void button1_Click_1(object sender, EventArgs e)
        {
            String pathImage = Variables.path_gen_mode + nameImage_velocidad + counterImage_creator + ".png"; //ruta de carpeta para grafica velocidad
            String pathImage2 = Variables.path_gen_mode + nameImage_torque + counterImage_creator + ".png"; //ruta de carpeta para gráfica torque
            chart1.SaveImage(pathImage, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
            torque_graph.SaveImage(pathImage2, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
            counterImage_creator += 1;
            MessageBox.Show("Gráficas exportadas a carpeta");

        }

        public Generador_form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            f11.ShowDialog();
            
        }

        private void Generador_form_Load(object sender, EventArgs e) //se carga por primera vez form
        {
            Variables.initFirstGEN = true;  //en true por que se acaba de inicializar form 
            Save_UserSettings.Enabled = false; //botón de guardar parametros en false 
            
            //btn_En.Enabled = false;
           // btn_start.Enabled = false;
          
            setting_F = true; 
            timer1.Enabled = false; //deshabilitar timer1 
            timer2.Enabled = true;

            button4.Enabled = false;
            //btn_start.Enabled = false; 

            button3.Click += new EventHandler(MultiBtn_Click);
   //         btn_En.Click += new EventHandler(MultiBtn_Click);
            button4.Click += new EventHandler(MultiBtn_Click2);
//            btn_start.Click += new EventHandler(MultiBtn_Click2);


            (this.Owner as Form_inicial).serialPort1.Write("B2$"); //freno 

            //yo se que estan en blanco por lo tanto: 
            txt_box_vel1.Text = "100";
            txt_box_vel2.Text = "200";
            txtbx_acel.Text = "60";
            txtbx_decc.Text = "60";
            txt_box_t1.Text = "8000";
            txt_box_t2.Text = "8000";
            cbx_modes.SelectedIndex = 1;
            cbx_sentido.SelectedIndex = 1; 


            (this.Owner as Form_inicial).Enabled = false; //congelamos ventana principal 
            Tabs_generator.SelectedTab = Tabs_generator.TabPages["tabPage2"];

            //crear carpeta modo generador en root path 
            if (!(System.IO.File.Exists(Variables.rootpath)))
            { // si existe entonces 
                Directory.CreateDirectory(Variables.rootpath + "\\Modo Generador");
                pathdedault = Variables.rootpath + "\\Modo Generador\\"; 
                Variables.path_gen_mode = Variables.rootpath + "\\Modo Generador\\";

            }

        }

        private void Generador_form_FormClosing(object sender, FormClosingEventArgs e) // al cerrar formulario
        {
            if (Convert.ToString(dataMod2) == "1")
            {  //si el servomotor esta activo no permitir salida
                MessageBox.Show("¡No se permite salida hasta que se detenga la prueba!");
                e.Cancel = true;
            }
            else //de lo contrario, salida del form 
            {

                Variables.initFirstGEN = false; //en false por que se elimina form 
                (this.Owner as Form_inicial).serialPort1.Write("A2$"); //regresar al menu principal 
                (this.Owner as Form_inicial).Enabled = true;
                Variables.SerialPresent = false;
                Variables.var = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e) //refresco de variables monitoreo 
        {

            if ((init_move == true) && (cbx_modes.SelectedIndex == 0)){
                if (Speed_label.Text == "0") {
                    button4.PerformClick();
                    init_move = false; 
                }
            }


            if (Convert.ToString(dataMod2) == "1" && Tabs_generator.SelectedIndex == 1)
            { //si te vas a tab settings y esta activo driver, no dejar cambiar funciones hasta que lo desact

                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
            }
            else if (Tabs_generator.SelectedIndex == 1 && Convert.ToString(dataMod2) == "0")
            {
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;

            }

            if (Tabs_generator.SelectedIndex == 1) //si se va a tab2 detener timer1 y habilitar timer2 
            { 
                (this.Owner as Form_inicial).serialPort1.Write("E2$"); //Comando de detencción monitoreo MODBUS
                setting_F = true; //bandera de que ingreso a la tab de settings 
                timer1.Enabled = false; 
                timer2.Enabled = true;

         

            }
            else  //monitoreo normal 
            {

                    dato = Variables.var;
                    label6.Text = Variables.var;
                    timer1.Interval = 350;
                    this.BeginInvoke(new EventHandler(ProcessData));
            }
            
        }

        private void ProcessData(object sender, EventArgs e) //Parte de timer1_tick condicionando variables a mostrar
        {
            try
            {

                index0fZ = Convert.ToSByte(dato.IndexOf("Z"));
                index0fY = Convert.ToSByte(dato.IndexOf("Y"));
                index0fX = Convert.ToSByte(dato.IndexOf("X"));
                index0fW = Convert.ToSByte(dato.IndexOf("W")); 

                dataMod1 = dato.Substring(0, index0fZ); //Z
                dataMod2 = dato.Substring(index0fZ + 1, (index0fY - index0fZ) - 1); //Y
                dataMod3 = dato.Substring(index0fY + 1, (index0fX - index0fY) - 1); //X
                dataMod4 = dato.Substring(index0fX + 1, (index0fW - index0fX) - 1); //W

                double numero1 = Convert.ToDouble(dataMod1); //checar esa conversion
                double numero2 = Math.Round(((numero1 * 245735) / 4294967295), 2);
                if (numero2 > 10)
                {
                    if (cbx_modes.SelectedIndex == 0)
                    {
                        init_move = true; //inicio movimiento para el pulse
                    }
                    
                    aGauge1.Value = Convert.ToSingle(numero2);
                    Speed_label.Text = numero2.ToString();
                    chart1.Series["Velocidad_c"].Points.Add(numero2);

                //añadir renglon
                int n = f11.dataGridView1.Rows.Add();
                    //Colocamos información
                    f11.dataGridView1.Rows[n].Cells[0].Value = n;
                    f11.dataGridView1.Rows[n].Cells[1].Value = numero2;
                    f11.dataGridView1.Rows[n].Cells[2].Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                }

                else //si es menor a 0 
                {
                    counter_time = counter_time + 1; 
                    Speed_label.Text = "0";
                    aGauge1.Value = 0;

                    if (counter_time >= 25) //no graficar todos los ceros 
                    {
                        chart1.Series["Velocidad_c"].Points.Add(0);
                        counter_time = 0;

                        //añadir renglon
                        int n = f11.dataGridView1.Rows.Add();
                        //Colocamos información
                        f11.dataGridView1.Rows[n].Cells[0].Value = n;
                        f11.dataGridView1.Rows[n].Cells[1].Value = 0;
                        f11.dataGridView1.Rows[n].Cells[2].Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    }


                } //representación de velocidad

                if (Convert.ToString(dataMod2) == "1") { Drv_status_lab.BackColor = Color.Green; } else if (Convert.ToString(dataMod2) == "0") { Drv_status_lab.BackColor = Color.Red; }//DrvStatus
                if (Convert.ToString(dataMod3) == "1") { Stop_label.BackColor = Color.Green; } else if (Convert.ToString(dataMod3) == "0") { Stop_label.BackColor = Color.Red; }//paroStatus
                
                //graficar dato negativo y positivo de torque, por lo tanto es valido el dato tal cual como llega
                torque_label.Text = dataMod4;
                double numero4 = Convert.ToDouble(dataMod4);

                if (StatusButton_start == false)
                {  //si se inició un movimiento de servomotor entonces comienza a graficar  
                    torque_graph.Series["torque_c"].Points.Add(numero4);
                    int n2 = f11.dataGridView2.Rows.Add();
                    //Colocamos información
                    f11.dataGridView2.Rows[n2].Cells[0].Value = n2;
                    f11.dataGridView2.Rows[n2].Cells[1].Value = numero4;
                    f11.dataGridView2.Rows[n2].Cells[2].Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                }
                else { //de lo contrario, grafica pero en lapsos largos (testin sensor torque manual)
                    counter_time2 = counter_time2 + 1;
                   
                    if (counter_time2 >= 10)
                    {
                        torque_graph.Series["torque_c"].Points.Add(numero4);
                        counter_time2 = 0;
                        int n2 = f11.dataGridView2.Rows.Add();
                        //Colocamos información
                        f11.dataGridView2.Rows[n2].Cells[0].Value = n2;
                        f11.dataGridView2.Rows[n2].Cells[1].Value = numero4;
                        f11.dataGridView2.Rows[n2].Cells[2].Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    }
                }




            }
            catch (Exception)
            {
                MessageBox.Show("Error en monitor real time");
            }
        }

        private void timer2_Tick(object sender, EventArgs e) //Timer 2, accionamiento de monitoreo normal nuevamente
        {

            //aqui poner el de modificacion de valores en textbox: 



            if (mem1 != Convert.ToString(cbx_modes.SelectedIndex) || (mem2 != txt_box_vel1.Text) || (mem3 != txt_box_vel2.Text) || (mem4 != txtbx_acel.Text) ||
                (mem5 != txtbx_decc.Text) || (mem6 != txt_box_t1.Text) || (mem7 != txt_box_t2.Text) || (mem8 != Convert.ToString(cbx_sentido.SelectedIndex)))
            {
                Save_UserSettings.Enabled = false;
            }
            else {
                Save_UserSettings.Enabled = true; 
            }





            if ((Tabs_generator.SelectedIndex == 0) && ((test == false) || (error_data == true )))
            {
                
                Tabs_generator.SelectedTab = Tabs_generator.TabPages["tabPage2"];
                MessageBox.Show("Establezca parametros de prueba primero");
            }
            else if ((Tabs_generator.SelectedIndex == 0) && (setting_F == true)) {

                (this.Owner as Form_inicial).serialPort1.Write("F2$"); //reanuda monitoreo modbus a arduino 
                //label18.Text = "volvi"; //debug 
                setting_F = false;
                timer1.Interval = 2500; //para la primera vez
                timer2.Enabled = false;
                timer1.Enabled = true; //activo timer de monitoreo 



            }


            /*  if ((Tabs_generator.SelectedIndex == 0) && (setting_F == true))
          { //si se volvió al tab princial, y se habia ingresado a tab2 entonces 

              (this.Owner as Form_inicial).serialPort1.Write("F2$"); //reanuda monitoreo modbus a arduino 
              label18.Text = "volvi"; //debug 
              setting_F = false;
              timer1.Interval = 1500; //para la primera vez
              timer2.Enabled = false;
              timer1.Enabled = true; //activo timer de monitoreo 
          }*/
            
        }


        private void button5_Click(object sender, EventArgs e) //button set settings is clicked , validar datos de entrada 
        {
            try
            {
                //validar modo de operación
                if (cbx_modes.SelectedIndex == 0)
                {
                    palabraSettings = "0A";
                    label36.Text = "Pulse";
                    mem1 = Convert.ToString(cbx_modes.SelectedIndex);



                }
                else if (cbx_modes.SelectedIndex == 1)
                {
                    palabraSettings = "1A";
                    label36.Text = "Reversing";
                    mem1 = Convert.ToString(cbx_modes.SelectedIndex);
                }
                else if (cbx_modes.SelectedIndex == 2)
                { palabraSettings = "0A";
                    mem1 = Convert.ToString(cbx_modes.SelectedIndex);
                }
                else //default 
                {
                    cbx_modes.SelectedIndex = 1;
                    palabraSettings = "1A";
                    mem1 = Convert.ToString(cbx_modes.SelectedIndex);
                }

                //Validar velocidad1 
                if (Convert.ToInt32(txt_box_vel1.Text) >= 50 && Convert.ToInt32(txt_box_vel1.Text) <= 1000)
                {
                    double num1 = Convert.ToDouble(txt_box_vel1.Text);
                    num1 = Math.Round(num1);
                    num1 = (num1 * 27) / 101.276;
                    palabraSettings = palabraSettings + (int)num1 + "B";
                    label23.Text = txt_box_vel1.Text;
                    mem2 = txt_box_vel1.Text;
                }
                else
                {
                    txt_box_vel1.Text = "100";
                    double num1 = Convert.ToDouble(txt_box_vel1.Text);
                    num1 = Math.Round(num1);
                    num1 = (num1 * 27) / 101.276;
                    palabraSettings = palabraSettings + (int)num1 + "B";
                    label23.Text = txt_box_vel1.Text;
                    mem2 = txt_box_vel1.Text;

                }

                //Validar velocidad2

                if (Convert.ToInt32(txt_box_vel2.Text) >= 50 && Convert.ToInt32(txt_box_vel2.Text) <= 1000)
                {
                    double num1 = Convert.ToDouble(txt_box_vel2.Text);
                    num1 = Math.Round(num1);
                    num1 = (num1 * 27) / 101.276;
                    palabraSettings = palabraSettings + (int)num1 + "C";
                    label24.Text = txt_box_vel2.Text;
                    mem3 = txt_box_vel2.Text;
                }
                else
                {
                    txt_box_vel2.Text = "100";
                    double num1 = Convert.ToDouble(txt_box_vel2.Text);
                    num1 = Math.Round(num1);
                    num1 = (num1 * 27) / 101.276;
                    palabraSettings = palabraSettings + (int)num1 + "C";
                    label24.Text = txt_box_vel2.Text;
                    mem3 = txt_box_vel2.Text;

                }

                //Validar acceleración 

                if (Convert.ToInt32(txtbx_acel.Text) >= 20 && Convert.ToInt32(txtbx_acel.Text) <= 1100)
                {
                    double num1 = Convert.ToDouble(txtbx_acel.Text);
                    num1 = Math.Round(num1);
                    num1 = (num1 * 21.1) / 79.796;
                    palabraSettings = palabraSettings + (int)num1 + "D";
                    label25.Text = txtbx_acel.Text;
                    mem4 = txtbx_acel.Text;

                }
                else
                {
                    txtbx_acel.Text = "80";
                    double num1 = Convert.ToDouble(txtbx_acel.Text);
                    num1 = Math.Round(num1);
                    num1 = (num1 * 21.1) / 79.796;
                    palabraSettings = palabraSettings + (int)num1 + "D";
                    label25.Text = txtbx_acel.Text;
                    mem4 = txtbx_acel.Text;

                }

                //valididar desacceleración 
                if (Convert.ToInt32(txtbx_decc.Text) >= 20 && Convert.ToInt32(txtbx_decc.Text) <= 1100)
                {
                    double num1 = Convert.ToDouble(txtbx_decc.Text);
                    num1 = Math.Round(num1);
                    num1 = (num1 * 21.1) / 79.796;
                    palabraSettings = palabraSettings + (int)num1 + "E";
                    label26.Text = txtbx_decc.Text;
                    mem5 = txtbx_decc.Text;
                }
                else
                {
                    txtbx_decc.Text = "80";
                    double num1 = Convert.ToDouble(txtbx_decc.Text);
                    num1 = Math.Round(num1);
                    num1 = (num1 * 21.1) / 79.796;
                    palabraSettings = palabraSettings + (int)num1 + "E";
                    label26.Text = txtbx_decc.Text;
                    mem5 = txtbx_decc.Text;

                }

                //validación de valor de entrada Tiempo 1 

                if (cbx_modes.SelectedIndex == 2)
                {
                    txt_box_t1.Text = "0"; //poner timer en 0;
                    mem6 = "0";                       //
                    label36.Text = "Continous";
                    double num1 = Convert.ToDouble(txt_box_t1.Text);
                    num1 = Math.Round(num1);
                    palabraSettings = palabraSettings + (int)num1 + "F";
                    label30.Text = txt_box_t1.Text;
                    
                }

                else if (Convert.ToInt32(txt_box_t1.Text) >= 100 && Convert.ToInt32(txt_box_t1.Text) <= 60000)
                {
                    double num1 = Convert.ToDouble(txt_box_t1.Text);
                    num1 = Math.Round(num1);
                    // label36.Text = "Pulse454564";
                    palabraSettings = palabraSettings + (int)num1 + "F";
                    label30.Text = txt_box_t1.Text;
                    mem6 = txt_box_t1.Text;
                }
                else
                {
                    txt_box_t1.Text = "1000"; //poner timer en 0; 
                    double num1 = Convert.ToDouble(txt_box_t1.Text);
                    num1 = Math.Round(num1);
                    palabraSettings = palabraSettings + (int)num1 + "F";
                    label30.Text = txt_box_t1.Text;
                    mem6 = txt_box_t1.Text;

                }

                //validación de valor de entrada Tiempo 2 
                if (txt_box_t2.Text == "")
                {
                    txt_box_t2.Text = "1000"; //poner timer en 0; 
                    double num1 = Convert.ToDouble(txt_box_t2.Text);
                    num1 = Math.Round(num1);
                    palabraSettings = palabraSettings + (int)num1 + "G";
                    label32.Text = txt_box_t2.Text;
                    mem7 = txt_box_t2.Text;
                }

                else if (Convert.ToInt32(txt_box_t2.Text) >= 100 && Convert.ToInt32(txt_box_t2.Text) <= 60000)
                {
                    double num1 = Convert.ToDouble(txt_box_t2.Text);
                    num1 = Math.Round(num1);
                    palabraSettings = palabraSettings + (int)num1 + "G";
                    label32.Text = txt_box_t2.Text;
                    mem7 = txt_box_t2.Text;
                }
                else
                {
                    txt_box_t2.Text = "1000"; //poner timer en 0; 
                    double num1 = Convert.ToDouble(txt_box_t2.Text);
                    num1 = Math.Round(num1);
                    palabraSettings = palabraSettings + (int)num1 + "G";
                    label32.Text = txt_box_t2.Text;
                    mem7 = txt_box_t2.Text;

                }

                //validación de valor de entrada Giro 
                if (cbx_sentido.SelectedIndex == 0)
                {
                    palabraSettings = palabraSettings + '0' + 'H';
                    label34.Text = "Antihorario";
                    mem8 = Convert.ToString(cbx_sentido.SelectedIndex);
                }
                else if (cbx_sentido.SelectedIndex == 1)
                {
                    palabraSettings = palabraSettings + '1' + 'H';
                    label34.Text = "Horario";
                    mem8 = Convert.ToString(cbx_sentido.SelectedIndex);
                }
                else
                {
                    cbx_sentido.SelectedIndex = 1;
                    palabraSettings = palabraSettings + '1' + 'H';
                    label34.Text = "Horario";
                    mem8 = Convert.ToString(cbx_sentido.SelectedIndex);
                }



                //string a mandar 
                test = true; //ya mandó el usuario parametros ok para el servomotor
                //btn_En.Enabled = true;
                //btn_start.Enabled = true;

                label27.Text = palabraSettings;
                Save_UserSettings.Enabled = true; //habilita boton de guardar parametros ya que ya se validaron datos y son ok 
                palabraSettings = palabraSettings + "$";
                (this.Owner as Form_inicial).serialPort1.Write(palabraSettings); //hacia arduino 
                error_data = false; 

            }
            catch (Exception)
            {
                error_data = true;
                MessageBox.Show("Error en la entrada de datos");
                
            }

        } //botón de set settings 



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//validación del tipo de movimiento servomotor
        {
            if (cbx_modes.SelectedIndex == 2) //modo continous
            {
                txt_box_vel2.Enabled = false;
                txt_box_t1.Enabled = false;
                txt_box_t2.Enabled = false;
            }
            else if (cbx_modes.SelectedIndex == 1) //modo reversing
            {
                txt_box_vel2.Enabled = true;
                txt_box_t1.Enabled = true;
                txt_box_t2.Enabled = true;
            }
            else if (cbx_modes.SelectedIndex == 0) { //modo pulse 
                txt_box_t1.Enabled = true;
                txt_box_vel2.Enabled = false;
                txt_box_t2.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e) //Cargar ajustes 
        {
            int counter = 0;
            string line, nameFileToRead;
            openFileDialog1.Title = "Busca tu archivo";
            //openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) {
                return; 
            }
            nameFileToRead = openFileDialog1.FileName; //te da la ruta completa 


            System.IO.StreamReader file = new System.IO.StreamReader(nameFileToRead);

            while ((line = file.ReadLine()) != null)
            {
                if (counter == 0)
                {
                    cbx_modes.Text = line;
                }
                else if (counter == 1)
                {
                    txt_box_vel1.Text = line;
                }
                else if (counter == 2)
                {

                    txt_box_vel2.Text = line;
                }

                else if (counter == 3)
                {

                    txtbx_acel.Text = line;
                }

                else if (counter == 4)
                {

                    txtbx_decc.Text = line;
                }

                else if (counter == 5)
                {

                    txt_box_t1.Text = line;
                }
                else if (counter == 6)
                {

                    txt_box_t2.Text = line;
                }

                else if (counter == 7)
                {

                    cbx_sentido.Text = line;
                }

                counter++;

            }

        }

        private void button6_Click(object sender, EventArgs e) //Guardar ajustes en text file 
        {
            namefile = namefileDef + Convert.ToInt32(counterFilecreator) + ".txt";

            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(pathdedault + namefile))
            {

                writer.WriteLine(cbx_modes.Text);
                writer.WriteLine(txt_box_vel1.Text);
                writer.WriteLine(txt_box_vel2.Text);
                writer.WriteLine(txtbx_acel.Text);
                writer.WriteLine(txtbx_decc.Text);
                writer.WriteLine(txt_box_t1.Text);
                writer.WriteLine(txt_box_t2.Text);
                writer.WriteLine(cbx_sentido.Text);

            }

            namefile = "";
            counterFilecreator++;
            MessageBox.Show("¡Parametros guardados en text file!"); 
        }

        private void button1_Click(object sender, EventArgs e) //al presionar botton help debe de mostrar imagen de ayuda de modos de operacion 
        {
            Help_modes_form F5 = new Help_modes_form();
            F5.Owner = this;
            F5.Show();
         
        }

        

        void MultiBtn_Click(Object sender, EventArgs e) //vinculacion al boton axis 
        {
            try
            {
                if (StatusButton_axis)
                {
                    
                    
                    (this.Owner as Form_inicial).serialPort1.Write("G2$"); //actiVa la potencia
                    button4.Enabled = true;
                    //btn_start.Enabled = true;
                    button3.Text = "Axis Disable";
                    //btn_En.Text = "Axis Disable";
                    StatusButton_axis = false;


                }
                else
                {
                    (this.Owner as Form_inicial).serialPort1.Write("H2$");
                    button4.Enabled = false;
                    //btn_start.Enabled = false;
                    button3.Text = "Axis Enable";
                    //btn_En.Text = "Axis Enable";
                    StatusButton_axis = true;

                }

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        void MultiBtn_Click2(Object sender, EventArgs e) //vinculacion al boton axis 
        {
            try
            {
                if (StatusButton_start) //bandera de activación de movimiento 
                {


                    (this.Owner as Form_inicial).serialPort1.Write("I2$"); //actiVa la potencia
                    button4.Text = "Stop";
                    //btn_start.Text = "Stop";
                    StatusButton_start = false;


                }
                else
                {
                    (this.Owner as Form_inicial).serialPort1.Write("J2$");
                    button4.Text = "Start";
                    //btn_start.Text = "Start";
                    StatusButton_start = true;

                }

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

    }
}
