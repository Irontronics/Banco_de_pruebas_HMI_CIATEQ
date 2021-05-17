
namespace Banco_de_pruebas
{
    partial class Generador_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Tabs_generator = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Temp_label = new System.Windows.Forms.Label();
            this.Volt_label = new System.Windows.Forms.Label();
            this.Stop_label = new System.Windows.Forms.Label();
            this.Drv_status_lab = new System.Windows.Forms.Label();
            this.Speed_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_title_gen = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Tabs_generator.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM6";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Tabs_generator
            // 
            this.Tabs_generator.Controls.Add(this.tabPage1);
            this.Tabs_generator.Controls.Add(this.tabPage2);
            this.Tabs_generator.Location = new System.Drawing.Point(-2, 1);
            this.Tabs_generator.Name = "Tabs_generator";
            this.Tabs_generator.SelectedIndex = 0;
            this.Tabs_generator.Size = new System.Drawing.Size(785, 452);
            this.Tabs_generator.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.lbl_title_gen);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Monitor Modbus";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Service Motion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Temp_label);
            this.groupBox1.Controls.Add(this.Volt_label);
            this.groupBox1.Controls.Add(this.Stop_label);
            this.groupBox1.Controls.Add(this.Drv_status_lab);
            this.groupBox1.Controls.Add(this.Speed_label);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 209);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Monitor Señales Modbus ";
            // 
            // Temp_label
            // 
            this.Temp_label.AutoSize = true;
            this.Temp_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temp_label.Location = new System.Drawing.Point(178, 175);
            this.Temp_label.Name = "Temp_label";
            this.Temp_label.Size = new System.Drawing.Size(0, 20);
            this.Temp_label.TabIndex = 9;
            // 
            // Volt_label
            // 
            this.Volt_label.AutoSize = true;
            this.Volt_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volt_label.Location = new System.Drawing.Point(178, 140);
            this.Volt_label.Name = "Volt_label";
            this.Volt_label.Size = new System.Drawing.Size(0, 20);
            this.Volt_label.TabIndex = 8;
            // 
            // Stop_label
            // 
            this.Stop_label.Location = new System.Drawing.Point(178, 103);
            this.Stop_label.Name = "Stop_label";
            this.Stop_label.Size = new System.Drawing.Size(17, 16);
            this.Stop_label.TabIndex = 7;
            // 
            // Drv_status_lab
            // 
            this.Drv_status_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drv_status_lab.Location = new System.Drawing.Point(177, 68);
            this.Drv_status_lab.Name = "Drv_status_lab";
            this.Drv_status_lab.Size = new System.Drawing.Size(17, 16);
            this.Drv_status_lab.TabIndex = 6;
            // 
            // Speed_label
            // 
            this.Speed_label.AutoSize = true;
            this.Speed_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speed_label.Location = new System.Drawing.Point(178, 35);
            this.Speed_label.Name = "Speed_label";
            this.Speed_label.Size = new System.Drawing.Size(0, 20);
            this.Speed_label.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Temperatura ( °C )";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Voltaje de potencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Paro de emergencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Driver En/Dis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Velocidad (RPM)";
            // 
            // lbl_title_gen
            // 
            this.lbl_title_gen.AutoSize = true;
            this.lbl_title_gen.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.75F, System.Drawing.FontStyle.Bold);
            this.lbl_title_gen.Location = new System.Drawing.Point(134, 17);
            this.lbl_title_gen.Name = "lbl_title_gen";
            this.lbl_title_gen.Size = new System.Drawing.Size(526, 31);
            this.lbl_title_gen.TabIndex = 3;
            this.lbl_title_gen.Text = "Modo Generador: Monitoreo de señales";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(134, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(533, 31);
            this.label7.TabIndex = 4;
            this.label7.Text = "Modo Generador: Panel de movimientos";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(10, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 348);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manual";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(430, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 348);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recetario de movimientos";
            // 
            // Generador_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 450);
            this.Controls.Add(this.Tabs_generator);
            this.Name = "Generador_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modo generador - Banco de pruebas de máquinas eléctricas CIATEQ Zapopan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Generador_form_FormClosing);
            this.Load += new System.EventHandler(this.Generador_form_Load);
            this.Tabs_generator.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl Tabs_generator;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Temp_label;
        private System.Windows.Forms.Label Volt_label;
        private System.Windows.Forms.Label Stop_label;
        private System.Windows.Forms.Label Drv_status_lab;
        public System.Windows.Forms.Label Speed_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_title_gen;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}