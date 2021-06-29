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
    public partial class data_velocidad : Form
    {
        public data_velocidad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter strWri = new System.IO.StreamWriter(@"C:\Users\CONACYTSLP\Desktop\Myfile.csv");

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



        }
    }
    }

