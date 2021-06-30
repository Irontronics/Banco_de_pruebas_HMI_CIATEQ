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

namespace Banco_de_pruebas
{
    public partial class data_velocidad : Form
    {
        string namefileDef = @"Datos_velocidad_"; //constante
        string namefile = "";
        int counterFilecreator = 0;
        
        
        public data_velocidad()
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
    }
    }

