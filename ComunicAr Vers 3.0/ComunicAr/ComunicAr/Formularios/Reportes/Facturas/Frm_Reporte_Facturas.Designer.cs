
namespace ComunicAr.Formularios
{
    partial class Frm_Reporte_Facturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Reporte_Facturas));
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Fact_Hasta = new ComunicAr.Clases.TextBox01();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Calcular_Fact = new System.Windows.Forms.Button();
            this.gr_tipo = new System.Windows.Forms.GroupBox();
            this.rb03_Fact = new System.Windows.Forms.RadioButton();
            this.rb02_Fact = new System.Windows.Forms.RadioButton();
            this.txt_Fact_Desde = new ComunicAr.Clases.TextBox01();
            this.rv01_Fact = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.gr_tipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(699, 459);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(10, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 449);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.rv01_Fact);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(756, 423);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Factura con Monto Especificado";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 90);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt_Fact_Hasta);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btn_Calcular_Fact);
            this.groupBox3.Controls.Add(this.gr_tipo);
            this.groupBox3.Controls.Add(this.txt_Fact_Desde);
            this.groupBox3.Location = new System.Drawing.Point(150, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 91);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Inferior a:";
            // 
            // txt_Fact_Hasta
            // 
            this.txt_Fact_Hasta.Location = new System.Drawing.Point(87, 51);
            this.txt_Fact_Hasta.Name = "txt_Fact_Hasta";
            this.txt_Fact_Hasta.Pp_Campo = null;
            this.txt_Fact_Hasta.Pp_MensajeError = null;
            this.txt_Fact_Hasta.Pp_Tabla = null;
            this.txt_Fact_Hasta.Pp_Validable = false;
            this.txt_Fact_Hasta.Size = new System.Drawing.Size(100, 20);
            this.txt_Fact_Hasta.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Superior a:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Calcular_Fact
            // 
            this.btn_Calcular_Fact.Location = new System.Drawing.Point(325, 51);
            this.btn_Calcular_Fact.Name = "btn_Calcular_Fact";
            this.btn_Calcular_Fact.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular_Fact.TabIndex = 3;
            this.btn_Calcular_Fact.Text = "Calcular";
            this.btn_Calcular_Fact.UseVisualStyleBackColor = true;
            this.btn_Calcular_Fact.Click += new System.EventHandler(this.btn_Calcular_Fact_Click);
            // 
            // gr_tipo
            // 
            this.gr_tipo.Controls.Add(this.rb03_Fact);
            this.gr_tipo.Controls.Add(this.rb02_Fact);
            this.gr_tipo.Location = new System.Drawing.Point(208, 14);
            this.gr_tipo.Name = "gr_tipo";
            this.gr_tipo.Size = new System.Drawing.Size(100, 71);
            this.gr_tipo.TabIndex = 2;
            this.gr_tipo.TabStop = false;
            this.gr_tipo.Text = "Tipo de Calculo";
            // 
            // rb03_Fact
            // 
            this.rb03_Fact.AutoSize = true;
            this.rb03_Fact.Location = new System.Drawing.Point(6, 48);
            this.rb03_Fact.Name = "rb03_Fact";
            this.rb03_Fact.Size = new System.Drawing.Size(50, 17);
            this.rb03_Fact.TabIndex = 2;
            this.rb03_Fact.Text = "Todo";
            this.rb03_Fact.UseVisualStyleBackColor = true;
            this.rb03_Fact.CheckedChanged += new System.EventHandler(this.rb03_Fact_CheckedChanged);
            // 
            // rb02_Fact
            // 
            this.rb02_Fact.AutoSize = true;
            this.rb02_Fact.Checked = true;
            this.rb02_Fact.Location = new System.Drawing.Point(6, 25);
            this.rb02_Fact.Name = "rb02_Fact";
            this.rb02_Fact.Size = new System.Drawing.Size(47, 17);
            this.rb02_Fact.TabIndex = 1;
            this.rb02_Fact.TabStop = true;
            this.rb02_Fact.Text = "Filtro";
            this.rb02_Fact.UseVisualStyleBackColor = true;
            this.rb02_Fact.CheckedChanged += new System.EventHandler(this.rb02_Fact_CheckedChanged);
            // 
            // txt_Fact_Desde
            // 
            this.txt_Fact_Desde.Location = new System.Drawing.Point(87, 25);
            this.txt_Fact_Desde.Name = "txt_Fact_Desde";
            this.txt_Fact_Desde.Pp_Campo = null;
            this.txt_Fact_Desde.Pp_MensajeError = null;
            this.txt_Fact_Desde.Pp_Tabla = null;
            this.txt_Fact_Desde.Pp_Validable = false;
            this.txt_Fact_Desde.Size = new System.Drawing.Size(100, 20);
            this.txt_Fact_Desde.TabIndex = 0;
            // 
            // rv01_Fact
            // 
            this.rv01_Fact.Location = new System.Drawing.Point(9, 113);
            this.rv01_Fact.Name = "rv01_Fact";
            this.rv01_Fact.ServerReport.BearerToken = null;
            this.rv01_Fact.Size = new System.Drawing.Size(739, 304);
            this.rv01_Fact.TabIndex = 4;
            // 
            // Frm_Reporte_Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 496);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_Reporte_Facturas";
            this.Text = "Frm_Reporte_Facturas";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gr_tipo.ResumeLayout(false);
            this.gr_tipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private Clases.TextBox01 txt_Fact_Hasta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Calcular_Fact;
        private System.Windows.Forms.GroupBox gr_tipo;
        private System.Windows.Forms.RadioButton rb03_Fact;
        private System.Windows.Forms.RadioButton rb02_Fact;
        private Clases.TextBox01 txt_Fact_Desde;
        private Microsoft.Reporting.WinForms.ReportViewer rv01_Fact;
    }
}