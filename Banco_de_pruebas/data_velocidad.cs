using System;
using System.Windows.Forms;


namespace Banco_de_pruebas
{
    public partial class Data_collection : Form
    {
        string namefileDef = @"Datos_velocidad_"; //constante
        string namefile = "";
        int counterFilecreator = 0;

        string namefileDef2 = @"Datos_Torque_"; //constante
        string namefile2 = "";
        int counterFilecreator2 = 0;


        public Data_collection()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e) //exportación csv velocidad 
        {
            namefile = Variables.path_gen_mode + namefileDef + Convert.ToInt32(counterFilecreator) + ".csv";
            System.IO.StreamWriter strWri = new System.IO.StreamWriter(namefile);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string strRowVal = "";
                for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++)
                {
                    if (strRowVal == "")
                    {
                        strRowVal = Convert.ToString(dataGridView1.Rows[i].Cells[j].Value);
                    }
                    else
                    {
                        strRowVal = strRowVal + "," + dataGridView1.Rows[i].Cells[j].Value;
                    }
                }
                strWri.WriteLine(strRowVal);
            }
            strWri.Close();
            MessageBox.Show("¡Exportación exitosa!");
            namefile = "";
            counterFilecreator++;
        }

        private void button4_Click(object sender, EventArgs e) //exportación csv torque
        {
            namefile2 = Variables.path_gen_mode + namefileDef2 + Convert.ToInt32(counterFilecreator2) + ".csv";
            System.IO.StreamWriter strWri2 = new System.IO.StreamWriter(namefile2);

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                string strRowVal = "";
                for (int j = 0; j < dataGridView2.Rows[i].Cells.Count; j++)
                {
                    if (strRowVal == "")
                    {
                        strRowVal = Convert.ToString(dataGridView2.Rows[i].Cells[j].Value);
                    }
                    else
                    {
                        strRowVal = strRowVal + "," + dataGridView2.Rows[i].Cells[j].Value;
                    }
                }
                strWri2.WriteLine(strRowVal);
            }
            strWri2.Close();
            MessageBox.Show("¡Exportación exitosa!");
            namefile2 = "";
            counterFilecreator2++;

        }

        private void Data_collection_Load(object sender, EventArgs e)
        {

        }
    }
    }

