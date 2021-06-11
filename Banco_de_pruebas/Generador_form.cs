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
        sbyte index0fZ, index0fY, index0fX, index0fW, index0fV, index0fN, index0fM, index0fL, index0fK, index0fJ, index0fI, index0fH, index0fG;
        String dataMod1, dataMod2, dataMod3, dataMod4, dataMod5, dataMod6, dataMod7, dataMod8, dataMod9, dataMod10, dataMod11, dataMod12, dataMod13;
        bool setting_F;

        string pathdedault = @"C:\\Users\\CONACYTSLP\\Desktop\\Prueba logs\\";
        string namefileDef = @"Log_"; //constante
        string namefile;
        int counterFilecreator = 0;

        private void button7_Click(object sender, EventArgs e) //Cargar ajustes 
        {
            int counter = 0;
            string line, nameFileToRead;
            openFileDialog1.Title = "Busca tu archivo";
            openFileDialog1.ShowDialog();

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

            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(pathdedault + namefile)) {

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

        }



        private void button1_Click(object sender, EventArgs e) //al presionar botton help debe de mostrar imagen de ayuda de modos de operacion 
        {
            Help_modes_form F5 = new Help_modes_form();
            F5.Owner = this;
            //this.Enabled = false;
            F5.Show();
        }


        public Generador_form()
        {
            InitializeComponent();
        }

        private void Generador_form_Load(object sender, EventArgs e) //se carga por primera vez form
        {
            Variables.initFirstGEN = true;  //en true por que se acaba de inicializar form 
            Save_UserSettings.Enabled = false;
            timer1.Interval = 3500;
            (this.Owner as Form_inicial).serialPort1.Write("B2$"); //comando para arduino, inicializar programa B2
            (this.Owner as Form_inicial).Enabled = false;
        }

        private void Generador_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Variables.initFirstGEN = false; //en false por que se elimina form 
            (this.Owner as Form_inicial).serialPort1.Write("A2$");
            (this.Owner as Form_inicial).Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e) //refresco de variables monitoreo normal 
        {

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

            if (Tabs_generator.SelectedIndex == 1) //si se va a tab2
            { 
                (this.Owner as Form_inicial).serialPort1.Write("E2$"); //Comando de detencción monitoreo MODBUS
                //cbx_modes.SelectedIndex = 2; //selección automática 
                setting_F = true; //bandera de que ingreso a la tab de settings 
                timer1.Enabled = false; //detengo el timer 
                timer2.Enabled = true;
            }
            else  //monitoreo normal 
            {
                if (Variables.initFirstGEN)
                { //si es primera vez de inicio, primera vez serial manda basura en blanco, checar eso , tomar valores setteados por default primera vez 

                    dato = Variables.var;
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
                        index0fJ = Convert.ToSByte(dato.IndexOf("J"));
                        index0fI = Convert.ToSByte(dato.IndexOf("I"));
                        index0fH = Convert.ToSByte(dato.IndexOf("H"));
                        index0fG = Convert.ToSByte(dato.IndexOf("G"));

                        dataMod6 = dato.Substring(0, index0fM); //M
                        dataMod7 = dato.Substring(index0fM + 1, (index0fN - index0fM) - 1); //N
                        dataMod8 = dato.Substring(index0fN + 1, (index0fL - index0fN) - 1); //L
                        dataMod9 = dato.Substring(index0fL + 1, (index0fK - index0fL) - 1); //K
                        dataMod10 = dato.Substring(index0fK + 1, (index0fJ - index0fK) - 1); //J
                        dataMod11 = dato.Substring(index0fJ + 1, (index0fI - index0fJ) - 1); //I
                        dataMod12 = dato.Substring(index0fI + 1, (index0fH - index0fI) - 1); //H
                        dataMod13 = dato.Substring(index0fH + 1, (index0fG - index0fH) - 1); //G

                        double numero1 = Convert.ToDouble(dataMod6);
                        double numero2 = Math.Round((numero1 * 100) / (1747625), 2);
                        label23.Text = Convert.ToString(numero2); //velocidad1 modbus set
                        numero2 = Math.Round(numero2, 0);
                        txt_box_vel1.Text = Convert.ToString(numero2); 
                        
                        double numero3 = Convert.ToDouble(dataMod7);
                        double numero4 = Math.Round((numero3 * 100) / (1747625), 2);
                        label24.Text = Convert.ToString(numero4); //velocidad2 modbus set 
                        numero4 = Math.Round(numero4, 0);
                        txt_box_vel2.Text = Convert.ToString(numero4); ;

                        double numero5 = Convert.ToDouble(dataMod8);
                        double numero6 = Math.Round((numero5 * 80) / (1398437), 2);
                        label25.Text = Convert.ToString(numero6); //ACC modbus set 
                        numero6 = Math.Round(numero6, 0);
                        txtbx_acel.Text = Convert.ToString(numero6);

                        double numero7 = Convert.ToDouble(dataMod9);
                        double numero8 = Math.Round((numero7 * 80) / (1398437), 2);
                        label26.Text = Convert.ToString(numero8); //Decc modbus set
                        numero8 = Math.Round(numero8, 0);
                        txtbx_decc.Text = Convert.ToString(numero8);

                        label30.Text = dataMod10;
                        txt_box_t1.Text = dataMod10;

                        label32.Text = dataMod11;
                        txt_box_t2.Text = dataMod11;

                        if (dataMod12 == "0")
                        {
                            label34.Text = "Antihorario";
                            cbx_sentido.SelectedIndex = 0;
                        }
                        else if (dataMod12 == "1") {
                            label34.Text = "Horario";
                            cbx_sentido.SelectedIndex = 1;
                        }

                        if (dataMod13 == "0" && dataMod10 == "0")
                        { //si el modo operación modbus esta en 0, y el timer1  en 0, entonces
                            label36.Text = "Continous";
                            cbx_modes.SelectedIndex = 2;
                        }
                        else if (dataMod13 == "0" && dataMod10 != "0")
                        {
                            label36.Text = "Pulse";
                            cbx_modes.SelectedIndex = 0;

                        }
                        else {
                            label36.Text = "Reversing";
                            cbx_modes.SelectedIndex = 1;
                        }


                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }

                }
                else
                {
                    // label18.Text = "holaaaaaa";
                    dato = Variables.var;
                    label6.Text = Variables.var;
                    int A = Tabs_generator.SelectedIndex;
                    // label18.Text = Convert.ToString(A);
                    this.BeginInvoke(new EventHandler(ProcessData));

                }
            }
        }

        private void ProcessData(object sender, EventArgs e)
        {
            try
            {

                index0fZ = Convert.ToSByte(dato.IndexOf("Z"));
                index0fY = Convert.ToSByte(dato.IndexOf("Y"));
                index0fX = Convert.ToSByte(dato.IndexOf("X"));
                //index0fW = Convert.ToSByte(dato.IndexOf("W"));
                //index0fV = Convert.ToSByte(dato.IndexOf("V"));

                dataMod1 = dato.Substring(0, index0fZ); //Z
                dataMod2 = dato.Substring(index0fZ + 1, (index0fY - index0fZ) - 1); //Y
                dataMod3 = dato.Substring(index0fY + 1, (index0fX - index0fY) - 1); //X
               // dataMod4 = dato.Substring(index0fX + 1, (index0fW - index0fX) - 1);
               // dataMod5 = dato.Substring(index0fW + 1, (index0fV - index0fW) - 1);

                double numero1 = Convert.ToDouble(dataMod1); //checar esa conversion
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

               // double numero3 = Convert.ToDouble(dataMod4);
               // double numero4 = numero3 / 1000;
               // numero4 = Math.Round(numero4, 2);
                //Volt_label.Text = numero4.ToString(); // representación de voltaje 

                //Temp_label.Text = Convert.ToString(dataMod5); //representación_temperatura
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


        private void button5_Click(object sender, EventArgs e) //button set settings is clicked , validar datos de entrada 
        {
            //validar modo de operación
            if (cbx_modes.SelectedIndex == 0) { palabraSettings = "0A"; }
            else if (cbx_modes.SelectedIndex == 1) { palabraSettings = "1A"; }
            else if (cbx_modes.SelectedIndex == 2) { palabraSettings = "2A"; }
            else
            {
                cbx_modes.SelectedIndex = 1;
                palabraSettings = "2A";
            }

                //Validar velocidad1 
                if (Convert.ToInt32(txt_box_vel1.Text) >= 50 && Convert.ToInt32(txt_box_vel1.Text) <= 1000)
            {
                double num1 = Convert.ToDouble(txt_box_vel1.Text);
                num1 = Math.Round(num1);
                num1 = (num1 * 27) / 101.276;
                palabraSettings = palabraSettings + (int)num1 + "B";
                label23.Text = txt_box_vel1.Text; 
            }
            else {
                txt_box_vel1.Text = "100";
                double num1 = Convert.ToDouble(txt_box_vel1.Text);
                num1 = Math.Round(num1);
                num1 = (num1 * 27) / 101.276;
                palabraSettings = palabraSettings + (int)num1 + "B";
                label23.Text = txt_box_vel1.Text;

            }

            //Validar velocidad2
            if (Convert.ToInt32(txt_box_vel2.Text) >= 50 && Convert.ToInt32(txt_box_vel2.Text) <= 1000)
            {
                double num1 = Convert.ToDouble(txt_box_vel2.Text);
                num1 = Math.Round(num1);
                num1 = (num1 * 27) / 101.276;
                palabraSettings = palabraSettings + (int)num1 + "C";
                label24.Text = txt_box_vel2.Text;
            }
            else
            {
                txt_box_vel2.Text = "100";
                double num1 = Convert.ToDouble(txt_box_vel2.Text);
                num1 = Math.Round(num1);
                num1 = (num1 * 27) / 101.276;
                palabraSettings = palabraSettings + (int)num1 + "C";
                label24.Text = txt_box_vel2.Text;

            }

            //Validar acceleración 
            if (Convert.ToInt32(txtbx_acel.Text) >= 20 && Convert.ToInt32(txtbx_acel.Text) <= 1100)
            {
                double num1 = Convert.ToDouble(txtbx_acel.Text);
                num1 = Math.Round(num1);
                num1 = (num1 * 21.1) / 79.796;
                palabraSettings = palabraSettings + (int)num1 + "D";
                label25.Text = txtbx_acel.Text;

            }
            else
            {
                txtbx_acel.Text = "80";
                double num1 = Convert.ToDouble(txtbx_acel.Text);
                num1 = Math.Round(num1);
                num1 = (num1 * 21.1) / 79.796;
                palabraSettings = palabraSettings + (int)num1 + "D";
                label25.Text = txtbx_acel.Text;

            }

            //valididar desacceleración 
            if (Convert.ToInt32(txtbx_decc.Text) >= 20 && Convert.ToInt32(txtbx_decc.Text) <= 1100)
            {
                double num1 = Convert.ToDouble(txtbx_decc.Text);
                num1 = Math.Round(num1);
                num1 = (num1 * 21.1) / 79.796;
                palabraSettings = palabraSettings + (int)num1 + "E";
                label26.Text = txtbx_decc.Text;
            }
            else
            {
                txtbx_decc.Text = "80";
                double num1 = Convert.ToDouble(txtbx_decc.Text);
                num1 = Math.Round(num1);
                num1 = (num1 * 21.1) / 79.796;
                palabraSettings = palabraSettings + (int)num1 + "E";
                label26.Text = txtbx_decc.Text;

            }

            //validación de valor de entrada Tiempo 1 
            if (cbx_modes.SelectedIndex == 2)
            {
                txt_box_t1.Text = "0"; //poner timer en 0; 
                double num1 = Convert.ToDouble(txt_box_t1.Text);
                num1 = Math.Round(num1);
                palabraSettings = palabraSettings + (int)num1 + "F";
                label30.Text = txt_box_t1.Text;
            }

            else if (Convert.ToInt32(txt_box_t1.Text) >= 100 && Convert.ToInt32(txt_box_t1.Text) <= 60000)
            {
                double num1 = Convert.ToDouble(txt_box_t1.Text);
                num1 = Math.Round(num1);
                palabraSettings = palabraSettings + (int)num1 + "F";
                label30.Text = txt_box_t1.Text;
            }
            else {
                txt_box_t1.Text = "1000"; //poner timer en 0; 
                double num1 = Convert.ToDouble(txt_box_t1.Text);
                num1 = Math.Round(num1);
                palabraSettings = palabraSettings + (int)num1 + "F";
                label30.Text = txt_box_t1.Text;

            }

            //validación de valor de entrada Tiempo 2 
            if (txt_box_t2.Text == "")
            {
                txt_box_t2.Text = "1000"; //poner timer en 0; 
                double num1 = Convert.ToDouble(txt_box_t2.Text);
                num1 = Math.Round(num1);
                palabraSettings = palabraSettings + (int)num1 + "G";
                label32.Text = txt_box_t2.Text;
            }

            else if (Convert.ToInt32(txt_box_t2.Text) >= 100 && Convert.ToInt32(txt_box_t2.Text) <= 60000)
            {
                double num1 = Convert.ToDouble(txt_box_t2.Text);
                num1 = Math.Round(num1);
                palabraSettings = palabraSettings + (int)num1 + "G";
                label32.Text = txt_box_t2.Text;
            }
            else
            {
                txt_box_t2.Text = "1000"; //poner timer en 0; 
                double num1 = Convert.ToDouble(txt_box_t2.Text);
                num1 = Math.Round(num1);
                palabraSettings = palabraSettings + (int)num1 + "G";
                label32.Text = txt_box_t2.Text;

            }

            //validación de valor de entrada Giro 
            if (cbx_sentido.SelectedIndex == 0)
            {
                palabraSettings = palabraSettings + '0' + 'H';
                label34.Text = "Horario";
            }
            else if (cbx_sentido.SelectedIndex == 1)
            {
                palabraSettings = palabraSettings + '1' + 'H';
                label34.Text = "Antihorario";
            }
            else {
                cbx_sentido.SelectedIndex = 0;
                palabraSettings = palabraSettings + '0' + 'H';
                label34.Text = "Horario";
            }



            //string a mandar 
            label27.Text = palabraSettings; //todo es ok, entonces 
            Save_UserSettings.Enabled = true; 
            palabraSettings = palabraSettings + "$";
            (this.Owner as Form_inicial).serialPort1.Write(palabraSettings);


        } //botón de set settings 

  
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

                (this.Owner as Form_inicial).serialPort1.Write("F2$");
                label18.Text = "volvi"; //debug 
                setting_F = false;
                timer2.Enabled = false;
                timer1.Enabled = true; //activo timer de monitoreo 
            }
        }

        


        /*
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

        */

    }
}
