
namespace ComunicAr.Formularios.Reportes.Datos
{
    partial class Frm_Rep_Datos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Rep_Datos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_costofijo = new System.Windows.Forms.RadioButton();
            this.rb_limitedatos = new System.Windows.Forms.RadioButton();
            this.reportViewer_Datos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_todos2 = new System.Windows.Forms.RadioButton();
            this.rb_limite = new System.Windows.Forms.RadioButton();
            this.rb_Costo = new System.Windows.Forms.RadioButton();
            this.textBox011 = new ComunicAr.Clases.TextBox01();
            this.textBox012 = new ComunicAr.Clases.TextBox01();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_costofijo);
            this.groupBox1.Controls.Add(this.rb_limitedatos);
            this.groupBox1.Location = new System.Drawing.Point(209, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(181, 143);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // rb_costofijo
            // 
            this.rb_costofijo.AutoSize = true;
            this.rb_costofijo.Location = new System.Drawing.Point(9, 71);
            this.rb_costofijo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_costofijo.Name = "rb_costofijo";
            this.rb_costofijo.Size = new System.Drawing.Size(115, 17);
            this.rb_costofijo.TabIndex = 2;
            this.rb_costofijo.TabStop = true;
            this.rb_costofijo.Text = "Por costo fijo limite:";
            this.rb_costofijo.UseVisualStyleBackColor = true;
            // 
            // rb_limitedatos
            // 
            this.rb_limitedatos.AutoSize = true;
            this.rb_limitedatos.Location = new System.Drawing.Point(9, 29);
            this.rb_limitedatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_limitedatos.Name = "rb_limitedatos";
            this.rb_limitedatos.Size = new System.Drawing.Size(114, 17);
            this.rb_limitedatos.TabIndex = 1;
            this.rb_limitedatos.TabStop = true;
            this.rb_limitedatos.Text = "Por limite de datos:";
            this.rb_limitedatos.UseVisualStyleBackColor = true;
            // 
            // reportViewer_Datos
            // 
            this.reportViewer_Datos.Location = new System.Drawing.Point(12, 167);
            this.reportViewer_Datos.Name = "reportViewer_Datos";
            this.reportViewer_Datos.ServerReport.BearerToken = null;
            this.reportViewer_Datos.Size = new System.Drawing.Size(969, 384);
            this.reportViewer_Datos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(8, 107);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(647, 252);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_todos2);
            this.groupBox2.Controls.Add(this.rb_limite);
            this.groupBox2.Controls.Add(this.rb_Costo);
            this.groupBox2.Location = new System.Drawing.Point(9, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 93);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // rb_todos2
            // 
            this.rb_todos2.AutoSize = true;
            this.rb_todos2.Location = new System.Drawing.Point(6, 72);
            this.rb_todos2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_todos2.Name = "rb_todos2";
            this.rb_todos2.Size = new System.Drawing.Size(58, 17);
            this.rb_todos2.TabIndex = 3;
            this.rb_todos2.TabStop = true;
            this.rb_todos2.Text = "Todos ";
            this.rb_todos2.UseVisualStyleBackColor = true;
            this.rb_todos2.CheckedChanged += new System.EventHandler(this.rb_todos_CheckedChanged);
            // 
            // rb_limite
            // 
            this.rb_limite.AutoSize = true;
            this.rb_limite.Location = new System.Drawing.Point(6, 46);
            this.rb_limite.Name = "rb_limite";
            this.rb_limite.Size = new System.Drawing.Size(143, 17);
            this.rb_limite.TabIndex = 2;
            this.rb_limite.TabStop = true;
            this.rb_limite.Text = "Por limite de datos hasta:";
            this.rb_limite.UseVisualStyleBackColor = true;
            this.rb_limite.CheckedChanged += new System.EventHandler(this.rb_limite_CheckedChanged);
            // 
            // rb_Costo
            // 
            this.rb_Costo.AutoSize = true;
            this.rb_Costo.Location = new System.Drawing.Point(6, 19);
            this.rb_Costo.Name = "rb_Costo";
            this.rb_Costo.Size = new System.Drawing.Size(102, 17);
            this.rb_Costo.TabIndex = 1;
            this.rb_Costo.TabStop = true;
            this.rb_Costo.Text = "Por costo hasta:";
            this.rb_Costo.UseVisualStyleBackColor = true;
            this.rb_Costo.CheckedChanged += new System.EventHandler(this.rb_Costo_CheckedChanged);
            // 
            // textBox011
            // 
            this.textBox011.Location = new System.Drawing.Point(163, 28);
            this.textBox011.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox011.Name = "textBox011";
            this.textBox011.Pp_Campo = null;
            this.textBox011.Pp_MensajeError = null;
            this.textBox011.Pp_Tabla = null;
            this.textBox011.Pp_Validable = false;
            this.textBox011.Size = new System.Drawing.Size(83, 20);
            this.textBox011.TabIndex = 9;
            // 
            // textBox012
            // 
            this.textBox012.Location = new System.Drawing.Point(163, 55);
            this.textBox012.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox012.Name = "textBox012";
            this.textBox012.Pp_Campo = null;
            this.textBox012.Pp_MensajeError = null;
            this.textBox012.Pp_Tabla = null;
            this.textBox012.Pp_Validable = false;
            this.textBox012.Size = new System.Drawing.Size(83, 20);
            this.textBox012.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(573, 28);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 20);
            this.button2.TabIndex = 11;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Gb";
            // 
            // Frm_Rep_Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox012);
            this.Controls.Add(this.textBox011);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_Rep_Datos";
            this.Text = "Frm_Rep_Datos";
            this.Load += new System.EventHandler(this.Frm_Rep_Datos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_costofijo;
        private System.Windows.Forms.RadioButton rb_limitedatos;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_Datos;
        private Clases.TextBox01 txt_datos;
        private Clases.TextBox01 txt_costo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_limite;
        private System.Windows.Forms.RadioButton rb_Costo;
        private Clases.TextBox01 textBox011;
        private Clases.TextBox01 textBox012;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rb_todos2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}