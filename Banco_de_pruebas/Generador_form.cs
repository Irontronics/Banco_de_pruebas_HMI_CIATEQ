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
        string dato, palabraSettings;      //para los datos 
        sbyte index0fZ, index0fY, index0fX, index0fW, index0fV, index0fN, index0fM, index0fL, index0fK;
        String dataMod1, dataMod2, dataMod3, dataMod4, dataMod5, dataMod6,dataMod7, dataMod8,dataMod9;

        private void button5_Click(object sender, EventArgs e) //button set settings is clicked , validar datos de entrada 
        {
            //validar modo de operación
            if (cbx_modes.SelectedIndex == 0) { palabraSettings = "0A"; }
                else if (cbx_modes.SelectedIndex == 1) { palabraSettings = "1A"; }
                    else if (cbx_modes.SelectedIndex == 2) { palabraSettings = "2A"; }

            //Validar velocidad1 
            if (Convert.ToInt32(txt_box_vel1.Text) >= 50 && Convert.ToInt32(txt_box_vel1.Text) <= 1000)
            {
                double num1 = Convert.ToDouble(txt_box_vel1.Text);
                num1 = Math.Round(num1);
                num1 = (num1 * 1747625) / 100;
                palabraSettings = palabraSettings + (int)num1 + "B";
            }
            else {
                txt_box_vel1.Text = "100";
                double num1 = Convert.ToDouble(txt_box_vel1.Text);
                num1 = Math.Round(num1);
                num1 = (num1 * 1747625) / 100;
                palabraSettings = palabraSettings + (int)num1 + "B";

            }

            //Validar velocidad2
            if (Convert.ToInt32(txt_box_vel2.Text) >= 50 && Convert.ToInt32(txt_box_vel2.Text) <= 1000)
            {
                double num1 = Convert.ToDouble(txt_box_vel2.Text);
                num1 = Math.Round(num1);
                num1 = (num1 * 1747625) / 100;
                palabraSettings = palabraSettings + (int)num1 + "C";
            }
            else
            {
                txt_box_vel2.Text = "100";
                double num1 = Convert.ToDouble(txt_box_vel2.Text);
                num1 = Math.Round(num1);
                num1 = (num1 * 1747625) / 100;
                palabraSettings = palabraSettings + (int)num1 + "C";

            }


            if (Convert.ToInt32(txtbx_acel.Text) >= 20 && Convert.ToInt32(txtbx_acel.Text) <= 1100)
            {
                double num1 = Convert.ToDouble(txtbx_acel.Text);
                num1 = Math.Round(num1);
                num1 = (num1 * 1398437) / 80;
                palabraSettings = palabraSettings + (int)num1 + "D";

            }
            else
            {
                txtbx_acel.Text = "80";
                double num1 = Convert.ToDouble(txtbx_acel.Text);
                num1 = Math.Round(num1);
                num1 = (num1 * 1747625) / 100;
                palabraSettings = palabraSettings + (int)num1 + "D";

            }


            if (Convert.ToInt32(txtbx_decc.Text) >= 20 && Convert.ToInt32(txtbx_decc.Text) <= 1100)
            {
                double num1 = Convert.ToDouble(txtbx_decc.Text);
                num1 = Math.Round(num1);
                num1 = (num1 * 1398437) / 80;
                palabraSettings = palabraSettings + (int)num1 + "E";
            }
            else
            {
                txtbx_decc.Text = "80";
                double num1 = Convert.ToDouble(txtbx_decc.Text);
                num1 = Math.Round(num1);
                num1 = (num1 * 1747625) / 100;
                palabraSettings = palabraSettings + (int)num1 + "E";

            }

            //validación de valor de entrada Tiempo 1 
            if (cbx_modes.SelectedIndex == 2)
            {
                txt_box_t1.Text = "0"; //poner timer en 0; 
                double num1 = Convert.ToDouble(txt_box_t1.Text);
                num1 = Math.Round(num1);
                palabraSettings = palabraSettings + (int)num1 + "F";
            }

            else if (Convert.ToInt32(txt_box_t1.Text) >= 100 && Convert.ToInt32(txt_box_t1.Text) <= 60000)
            {
                double num1 = Convert.ToDouble(txt_box_t1.Text);
                num1 = Math.Round(num1);
                palabraSettings = palabraSettings + (int)num1 + "F";
            }
            else {
                txt_box_t1.Text = "1000"; //poner timer en 0; 
                double num1 = Convert.ToDouble(txt_box_t1.Text);
                num1 = Math.Round(num1);
                palabraSettings = palabraSettings + (int)num1 + "F";

            }

            if (txt_box_t2.Text == "")
            {
                txt_box_t2.Text = "1000"; //poner timer en 0; 
                double num1 = Convert.ToDouble(txt_box_t2.Text);
                num1 = Math.Round(num1);
                palabraSettings = palabraSettings + (int)num1 + "G";
            }

            else if (Convert.ToInt32(txt_box_t2.Text) >= 100 && Convert.ToInt32(txt_box_t2.Text) <= 60000)
            {
                double num1 = Convert.ToDouble(txt_box_t2.Text);
                num1 = Math.Round(num1);
                palabraSettings = palabraSettings + (int)num1 + "G";
            }
            else
            {
                txt_box_t2.Text = "1000"; //poner timer en 0; 
                double num1 = Convert.ToDouble(txt_box_t2.Text);
                num1 = Math.Round(num1);
                palabraSettings = palabraSettings + (int)num1 + "G";

            }

            //string a mandar 
            label27.Text = palabraSettings; 
        
        }

        bool setting_F;

  
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_modes.SelectedIndex == 2)
            {
                txt_box_vel2.Enabled = false;               
                txt_box_t1.Enabled = false;
                txt_box_t2.Enabled = false;
            }
            else if (cbx_modes.SelectedIndex == 1)
            {
                txt_box_vel2.Enabled = true;
                txt_box_t1.Enabled = true;
                txt_box_t2.Enabled = true;
            }
            else if (cbx_modes.SelectedIndex == 0) { 
                txt_box_t1.Enabled = true;
                txt_box_vel2.Enabled = false;
                txt_box_t2.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e) //Timer 2, accionamiento de función
        {
            if ((Tabs_generator.SelectedIndex == 0) && (setting_F == true)) { //si se volvió al tab princial, y se habia ingresado a tab2 entonces 

                timer1.Enabled= true; //activo timer de monitoreo 
                label18.Text = "volvi"; //debug 
                
            }
        }

        public Generador_form() 
        {
            InitializeComponent();

        }

        private void Generador_form_Load(object sender, EventArgs e) //se carga por primera vez 
        {
            Variables.initFirstGEN = true;  //en true por que se acaba de inicializar form 
            timer1.Interval = 2200;
            (this.Owner as Form_inicial).serialPort1.Write("B2$"); //comando para arduino, inicializar programa B2
            (this.Owner as Form_inicial).Enabled = false;
            
           

        }

        private void Generador_form_FormClosing(object sender, FormClosingEventArgs e) 
        {
            Variables.initFirstGEN = false; //en false por que se elimina form 
            (this.Owner as Form_inicial).serialPort1.Write("A2$");
            (this.Owner as Form_inicial).Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e) //refresco de variables 
        {

            if (Convert.ToString(dataMod2) == "1" && Tabs_generator.SelectedIndex == 1)
            { //si te vas a tab settings y esta activo driver, no dejar cambiar funciones hasta que lo desact
                
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
            }
            else if (Tabs_generator.SelectedIndex == 1 && Convert.ToString(dataMod2) == "0") { 
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;

            }

            if (Tabs_generator.SelectedIndex == 1) { //si se va a tab2
                (this.Owner as Form_inicial).serialPort1.Write("E2$"); //Comando de detencción monitoreo MODBUS
                cbx_modes.SelectedIndex = 2; 
                setting_F = true; //bandera de que ingreso a la tab de settings 
                timer1.Enabled = false;
            }
            else  //monitoreo normal 
            {
                if (Variables.initFirstGEN )
                { //si es primera vez de inicio, primera vez serial manda basura en blanco, checar eso 

                    dato = Variables.var; 
                    //label23.Text = Convert.ToString(Variables.var);
                    timer1.Interval = 450; 
                    Variables.initFirstGEN = false;
                    Variables.SerialPresent = false;
                    //this.BeginInvoke(new EventHandler(ProcessData2));
                    try
                    {
                        index0fM = Convert.ToSByte(dato.IndexOf("M"));
                        index0fN = Convert.ToSByte(dato.IndexOf("N"));
                        index0fL = Convert.ToSByte(dato.IndexOf("L"));
                        index0fK = Convert.ToSByte(dato.IndexOf("K"));

                        dataMod6 = dato.Substring(0, index0fM);
                        dataMod7 = dato.Substring(index0fM + 1, (index0fN - index0fM) - 1);
                        dataMod8 = dato.Substring(index0fN + 1, (index0fL - index0fN) - 1);
                        dataMod9 = dato.Substring(index0fL + 1, (index0fK - index0fL) - 1);

                        double numero1 = Convert.ToDouble(dataMod6);
                        double numero2 = Math.Round((numero1 * 100) / (1747625), 2);
                        label23.Text = Convert.ToString(numero2); //velocidad2 
                        txt_box_vel1.Text = Convert.ToString(numero2); //velocidad2 
                        double numero3 = Convert.ToDouble(dataMod7);
                        double numero4 = Math.Round((numero3 * 100) / (1747625), 2);
                        label24.Text = Convert.ToString(numero4);
                        txt_box_vel2.Text = Convert.ToString(numero4);

                        double numero5 = Convert.ToDouble(dataMod8);
                        double numero6 = Math.Round((numero5 * 80) / (1398437), 2);
                        label25.Text = Convert.ToString(numero6); //velocidad2 
                        txtbx_acel.Text = label25.Text;
                        double numero7 = Convert.ToDouble(dataMod9);
                        double numero8 = Math.Round((numero7 * 80) / (1398437), 2);
                        label26.Text = Convert.ToString(numero8);
                        txtbx_decc.Text = label26.Text; 


                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }



                }
                else {
                    // label18.Text = "holaaaaaa";
                    dato = Variables.var;
                    label6.Text = Variables.var;
                    int A = Tabs_generator.SelectedIndex;
                    // label18.Text = Convert.ToString(A);
                    this.BeginInvoke(new EventHandler(ProcessData));

                }
                
                
                
                


            }

        }

        private void ProcessData2(object sender, EventArgs e)
        {
            try
            {
                index0fM = Convert.ToSByte(dato.IndexOf("M"));
                index0fN = Convert.ToSByte(dato.IndexOf("N"));
                index0fL = Convert.ToSByte(dato.IndexOf("L"));
                index0fK = Convert.ToSByte(dato.IndexOf("K"));

                dataMod6 = dato.Substring(0, index0fM);
                dataMod7 = dato.Substring(index0fM + 1, (index0fN - index0fM) - 1);
                dataMod8 = dato.Substring(index0fN + 1, (index0fL - index0fN) - 1);
                dataMod9 = dato.Substring(index0fL + 1, (index0fK - index0fL) - 1);

                double numero1 = Convert.ToDouble(dataMod6);
                double numero2 = Math.Round((numero1 * 100) / (1747625), 2);  
                label23.Text = Convert.ToString(numero2); //velocidad2 
                double numero3 = Convert.ToDouble(dataMod7);
                double numero4 = Math.Round((numero3 * 100) / (1747625), 2);
                label24.Text = Convert.ToString(numero4);

                double numero5 = Convert.ToDouble(dataMod8);
                double numero6 = Math.Round((numero5 * 80) / (1398437), 2);
                label25.Text = Convert.ToString(numero6); //velocidad2 
                double numero7 = Convert.ToDouble(dataMod9);
                double numero8 = Math.Round((numero7 * 80) / (1398437), 2);
                label26.Text = Convert.ToString(numero8);


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
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
                if (numero2 > 10)
                {
                    aGauge1.Value = Convert.ToSingle(numero2);
                    Speed_label.Text = numero2.ToString();
                    chart1.Series["Velocidad_c"].Points.Add(numero2);


                }

                else
                {
                    Speed_label.Text = "0";
                    aGauge1.Value = 0;
                    chart1.Series["Velocidad_c"].Points.Add(0);
                } //representación de velocidad


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
