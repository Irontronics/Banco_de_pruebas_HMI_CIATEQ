
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Tabs_generator = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.aGauge1 = new System.Windows.Forms.AGauge();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Stop_label = new System.Windows.Forms.Label();
            this.Drv_status_lab = new System.Windows.Forms.Label();
            this.Speed_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_title_gen = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.Save_UserSettings = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_box_t2 = new System.Windows.Forms.TextBox();
            this.txt_box_t1 = new System.Windows.Forms.TextBox();
            this.txtbx_decc = new System.Windows.Forms.TextBox();
            this.txtbx_acel = new System.Windows.Forms.TextBox();
            this.txt_box_vel2 = new System.Windows.Forms.TextBox();
            this.txt_box_vel1 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.cbx_sentido = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbx_modes = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_En = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Tabs_generator.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM6";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1750;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Tabs_generator
            // 
            this.Tabs_generator.Controls.Add(this.tabPage1);
            this.Tabs_generator.Controls.Add(this.tabPage2);
            this.Tabs_generator.Location = new System.Drawing.Point(-2, -3);
            this.Tabs_generator.Name = "Tabs_generator";
            this.Tabs_generator.SelectedIndex = 0;
            this.Tabs_generator.Size = new System.Drawing.Size(1095, 576);
            this.Tabs_generator.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.aGauge1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.lbl_title_gen);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1087, 550);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Monitor Modbus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "label4";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label36);
            this.groupBox7.Controls.Add(this.label35);
            this.groupBox7.Controls.Add(this.label34);
            this.groupBox7.Controls.Add(this.label33);
            this.groupBox7.Controls.Add(this.label32);
            this.groupBox7.Controls.Add(this.label31);
            this.groupBox7.Controls.Add(this.label30);
            this.groupBox7.Controls.Add(this.label29);
            this.groupBox7.Controls.Add(this.label26);
            this.groupBox7.Controls.Add(this.label25);
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.label22);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Location = new System.Drawing.Point(870, 40);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(201, 290);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Valores setteados";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(94, 45);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(41, 13);
            this.label36.TabIndex = 15;
            this.label36.Text = "label36";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(6, 45);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(40, 13);
            this.label35.TabIndex = 14;
            this.label35.Text = "Modo: ";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(97, 267);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(41, 13);
            this.label34.TabIndex = 13;
            this.label34.Text = "label34";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(6, 267);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(84, 13);
            this.label33.TabIndex = 12;
            this.label33.Text = "Sentido de giro: ";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(97, 239);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(41, 13);
            this.label32.TabIndex = 11;
            this.label32.Text = "label32";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 239);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(57, 13);
            this.label31.TabIndex = 10;
            this.label31.Text = "Tiempo 2: ";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(97, 206);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(41, 13);
            this.label30.TabIndex = 9;
            this.label30.Text = "label30";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 206);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(57, 13);
            this.label29.TabIndex = 8;
            this.label29.Text = "Tiempo 1: ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(94, 175);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 13);
            this.label26.TabIndex = 7;
            this.label26.Text = "label26";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(94, 139);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(41, 13);
            this.label25.TabIndex = 6;
            this.label25.Text = "label25";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(94, 105);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 13);
            this.label24.TabIndex = 5;
            this.label24.Text = "label24";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(94, 69);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 13);
            this.label23.TabIndex = 4;
            this.label23.Text = "label23";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 175);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(84, 13);
            this.label22.TabIndex = 3;
            this.label22.Text = "Desaceleración:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 140);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "Aceleración:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 105);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "Velocidad 2:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 69);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Velocidad 1:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(870, 346);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "label18";
            // 
            // groupBox6
            // 
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.groupBox6.Location = new System.Drawing.Point(257, 442);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(359, 69);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Torque Futek Analog";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.groupBox5.Location = new System.Drawing.Point(622, 442);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(239, 69);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Control";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(134, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Stop";
            this.button4.UseMnemonic = false;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(19, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Start ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.chart1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.groupBox4.Location = new System.Drawing.Point(257, 40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(607, 396);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gráfica";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(463, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "Exportación Excel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(10, 19);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Velocidad_c";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(594, 336);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            title1.Name = "Velocidad_chart";
            title1.Text = "Velocidad (RPM): ";
            this.chart1.Titles.Add(title1);
            // 
            // aGauge1
            // 
            this.aGauge1.BaseArcColor = System.Drawing.Color.DarkGray;
            this.aGauge1.BaseArcRadius = 80;
            this.aGauge1.BaseArcStart = 135;
            this.aGauge1.BaseArcSweep = 270;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.GaugeAutoSize = false;
            this.aGauge1.Location = new System.Drawing.Point(20, 196);
            this.aGauge1.MaxValue = 1000F;
            this.aGauge1.MinValue = 0F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Red;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge1.NeedleRadius = 80;
            this.aGauge1.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge1.NeedleWidth = 2;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesInterInnerRadius = 73;
            this.aGauge1.ScaleLinesInterOuterRadius = 80;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMajorInnerRadius = 70;
            this.aGauge1.ScaleLinesMajorOuterRadius = 80;
            this.aGauge1.ScaleLinesMajorStepValue = 100F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge1.ScaleLinesMinorInnerRadius = 75;
            this.aGauge1.ScaleLinesMinorOuterRadius = 80;
            this.aGauge1.ScaleLinesMinorTicks = 9;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 95;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 0;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(212, 199);
            this.aGauge1.TabIndex = 7;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 0F;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 498);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Stop_label);
            this.groupBox1.Controls.Add(this.Drv_status_lab);
            this.groupBox1.Controls.Add(this.Speed_label);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 131);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Monitor Señales Modbus ";
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
            this.label2.Location = new System.Drawing.Point(6, 64);
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
            this.lbl_title_gen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_title_gen.Location = new System.Drawing.Point(314, 3);
            this.lbl_title_gen.Name = "lbl_title_gen";
            this.lbl_title_gen.Size = new System.Drawing.Size(429, 25);
            this.lbl_title_gen.TabIndex = 3;
            this.lbl_title_gen.Text = "Modo Generador: Monitoreo de señales";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label27);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1087, 550);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Service Motion";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(359, 202);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(82, 25);
            this.label27.TabIndex = 7;
            this.label27.Text = "label27";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.Save_UserSettings);
            this.groupBox3.Location = new System.Drawing.Point(358, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 152);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recetario de movimientos";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 89);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(131, 23);
            this.button7.TabIndex = 1;
            this.button7.Text = "Cargar Ajustes";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Save_UserSettings
            // 
            this.Save_UserSettings.Location = new System.Drawing.Point(6, 45);
            this.Save_UserSettings.Name = "Save_UserSettings";
            this.Save_UserSettings.Size = new System.Drawing.Size(131, 23);
            this.Save_UserSettings.TabIndex = 0;
            this.Save_UserSettings.Text = "Guardar Ajustes";
            this.Save_UserSettings.UseVisualStyleBackColor = true;
            this.Save_UserSettings.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_box_t2);
            this.groupBox2.Controls.Add(this.txt_box_t1);
            this.groupBox2.Controls.Add(this.txtbx_decc);
            this.groupBox2.Controls.Add(this.txtbx_acel);
            this.groupBox2.Controls.Add(this.txt_box_vel2);
            this.groupBox2.Controls.Add(this.txt_box_vel1);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.cbx_sentido);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.cbx_modes);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btn_start);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btn_En);
            this.groupBox2.Location = new System.Drawing.Point(10, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 508);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manual";
            // 
            // txt_box_t2
            // 
            this.txt_box_t2.Location = new System.Drawing.Point(6, 391);
            this.txt_box_t2.MaxLength = 5;
            this.txt_box_t2.Name = "txt_box_t2";
            this.txt_box_t2.Size = new System.Drawing.Size(116, 20);
            this.txt_box_t2.TabIndex = 38;
            // 
            // txt_box_t1
            // 
            this.txt_box_t1.Location = new System.Drawing.Point(6, 341);
            this.txt_box_t1.MaxLength = 5;
            this.txt_box_t1.Name = "txt_box_t1";
            this.txt_box_t1.Size = new System.Drawing.Size(116, 20);
            this.txt_box_t1.TabIndex = 37;
            // 
            // txtbx_decc
            // 
            this.txtbx_decc.Location = new System.Drawing.Point(6, 302);
            this.txtbx_decc.MaxLength = 4;
            this.txtbx_decc.Name = "txtbx_decc";
            this.txtbx_decc.Size = new System.Drawing.Size(116, 20);
            this.txtbx_decc.TabIndex = 36;
            // 
            // txtbx_acel
            // 
            this.txtbx_acel.Location = new System.Drawing.Point(6, 255);
            this.txtbx_acel.MaxLength = 4;
            this.txtbx_acel.Name = "txtbx_acel";
            this.txtbx_acel.Size = new System.Drawing.Size(116, 20);
            this.txtbx_acel.TabIndex = 35;
            // 
            // txt_box_vel2
            // 
            this.txt_box_vel2.Location = new System.Drawing.Point(6, 211);
            this.txt_box_vel2.MaxLength = 4;
            this.txt_box_vel2.Name = "txt_box_vel2";
            this.txt_box_vel2.Size = new System.Drawing.Size(116, 20);
            this.txt_box_vel2.TabIndex = 34;
            // 
            // txt_box_vel1
            // 
            this.txt_box_vel1.Location = new System.Drawing.Point(6, 167);
            this.txt_box_vel1.MaxLength = 4;
            this.txt_box_vel1.Name = "txt_box_vel1";
            this.txt_box_vel1.Size = new System.Drawing.Size(116, 20);
            this.txt_box_vel1.TabIndex = 33;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic);
            this.label28.Location = new System.Drawing.Point(4, 419);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(78, 13);
            this.label28.TabIndex = 28;
            this.label28.Text = "Sentido de giro";
            // 
            // cbx_sentido
            // 
            this.cbx_sentido.FormattingEnabled = true;
            this.cbx_sentido.Items.AddRange(new object[] {
            "Antihorario",
            "Horario"});
            this.cbx_sentido.Location = new System.Drawing.Point(6, 435);
            this.cbx_sentido.Name = "cbx_sentido";
            this.cbx_sentido.Size = new System.Drawing.Size(116, 21);
            this.cbx_sentido.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 479);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Set Settings ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 27;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic);
            this.label14.Location = new System.Drawing.Point(3, 369);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Time2: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic);
            this.label17.Location = new System.Drawing.Point(7, 325);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "Time1: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic);
            this.label16.Location = new System.Drawing.Point(7, 190);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(144, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Límite de velocidad 2 (RPM): ";
            // 
            // cbx_modes
            // 
            this.cbx_modes.FormattingEnabled = true;
            this.cbx_modes.Items.AddRange(new object[] {
            "Pulse",
            "Reversing",
            "Continous"});
            this.cbx_modes.Location = new System.Drawing.Point(6, 120);
            this.cbx_modes.Name = "cbx_modes";
            this.cbx_modes.Size = new System.Drawing.Size(121, 21);
            this.cbx_modes.TabIndex = 17;
            this.cbx_modes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic);
            this.label15.Location = new System.Drawing.Point(9, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Tipo de movimiento: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic);
            this.label13.Location = new System.Drawing.Point(3, 278);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(184, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Ajuste de desaceleración (RPM/s^2):: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic);
            this.label12.Location = new System.Drawing.Point(7, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Límite de aceleración (RPM/s^2): ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic);
            this.label11.Location = new System.Drawing.Point(9, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Límite de velocidad 1 (RPM): ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic);
            this.label10.Location = new System.Drawing.Point(6, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Inicia movimiento de Servomotor";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(6, 76);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic);
            this.label9.Location = new System.Drawing.Point(6, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Habilita potencia de Sevomotor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 1;
            // 
            // btn_En
            // 
            this.btn_En.Location = new System.Drawing.Point(6, 31);
            this.btn_En.Name = "btn_En";
            this.btn_En.Size = new System.Drawing.Size(75, 23);
            this.btn_En.TabIndex = 0;
            this.btn_En.Text = "Axis En";
            this.btn_En.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(181, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(433, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Modo Generador: Panel de movimientos";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Generador_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 576);
            this.Controls.Add(this.Tabs_generator);
            this.Name = "Generador_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modo generador - Banco de pruebas de máquinas eléctricas CIATEQ Zapopan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Generador_form_FormClosing);
            this.Load += new System.EventHandler(this.Generador_form_Load);
            this.Tabs_generator.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl Tabs_generator;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Stop_label;
        private System.Windows.Forms.Label Drv_status_lab;
        public System.Windows.Forms.Label Speed_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_title_gen;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_En;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbx_modes;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.AGauge aGauge1;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label18;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cbx_sentido;
        private System.Windows.Forms.TextBox txt_box_vel1;
        private System.Windows.Forms.TextBox txt_box_vel2;
        private System.Windows.Forms.TextBox txtbx_acel;
        private System.Windows.Forms.TextBox txtbx_decc;
        private System.Windows.Forms.TextBox txt_box_t1;
        private System.Windows.Forms.TextBox txt_box_t2;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Save_UserSettings;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
    }
}