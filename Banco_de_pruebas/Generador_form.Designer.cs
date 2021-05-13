
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
            this.lbl_title_gen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_title_gen
            // 
            this.lbl_title_gen.AutoSize = true;
            this.lbl_title_gen.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.75F, System.Drawing.FontStyle.Bold);
            this.lbl_title_gen.Location = new System.Drawing.Point(216, 9);
            this.lbl_title_gen.Name = "lbl_title_gen";
            this.lbl_title_gen.Size = new System.Drawing.Size(231, 31);
            this.lbl_title_gen.TabIndex = 0;
            this.lbl_title_gen.Text = "Modo Generador";
            // 
            // Generador_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.lbl_title_gen);
            this.Name = "Generador_form";
            this.Text = "Modo generador - Banco de pruebas de máquinas eléctricas CIATEQ Zapopan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Generador_form_FormClosing);
            this.Load += new System.EventHandler(this.Generador_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title_gen;
    }
}