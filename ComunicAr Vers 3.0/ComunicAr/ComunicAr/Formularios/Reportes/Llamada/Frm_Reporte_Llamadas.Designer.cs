
namespace ComunicAr.Formularios.Reportes.Llamada
{
    partial class Frm_Reporte_Llamadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Reporte_Llamadas));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.textBox013 = new ComunicAr.Clases.TextBox01();
            this.textBox012 = new ComunicAr.Clases.TextBox01();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.textBox011 = new ComunicAr.Clases.TextBox01();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtn_Todos = new System.Windows.Forms.RadioButton();
            this.rdbtn_PorFecha = new System.Windows.Forms.RadioButton();
            this.rdbtn_Cliente = new System.Windows.Forms.RadioButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rBD2 = new System.Windows.Forms.RadioButton();
            this.rBD1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_duracion = new ComunicAr.Clases.TextBox01();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(404, 176);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(8, 8);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(0, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(0, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(12, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(762, 523);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.btn_Calcular);
            this.tabPage3.Controls.Add(this.textBox013);
            this.tabPage3.Controls.Add(this.textBox012);
            this.tabPage3.Controls.Add(this.btn_buscar);
            this.tabPage3.Controls.Add(this.textBox011);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.reportViewer1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(754, 497);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Llamadas por Fechas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Desde";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(661, 97);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 7;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // textBox013
            // 
            this.textBox013.Location = new System.Drawing.Point(552, 41);
            this.textBox013.Name = "textBox013";
            this.textBox013.Pp_Campo = null;
            this.textBox013.Pp_MensajeError = null;
            this.textBox013.Pp_Tabla = null;
            this.textBox013.Pp_Validable = false;
            this.textBox013.Size = new System.Drawing.Size(100, 20);
            this.textBox013.TabIndex = 6;
            // 
            // textBox012
            // 
            this.textBox012.Location = new System.Drawing.Point(405, 41);
            this.textBox012.Name = "textBox012";
            this.textBox012.Pp_Campo = null;
            this.textBox012.Pp_MensajeError = null;
            this.textBox012.Pp_Tabla = null;
            this.textBox012.Pp_Validable = false;
            this.textBox012.Size = new System.Drawing.Size(100, 20);
            this.textBox012.TabIndex = 5;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(550, 15);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(102, 23);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // textBox011
            // 
            this.textBox011.Location = new System.Drawing.Point(405, 15);
            this.textBox011.Name = "textBox011";
            this.textBox011.Pp_Campo = null;
            this.textBox011.Pp_MensajeError = null;
            this.textBox011.Pp_Tabla = null;
            this.textBox011.Pp_Validable = false;
            this.textBox011.Size = new System.Drawing.Size(100, 20);
            this.textBox011.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtn_Todos);
            this.groupBox1.Controls.Add(this.rdbtn_PorFecha);
            this.groupBox1.Controls.Add(this.rdbtn_Cliente);
            this.groupBox1.Location = new System.Drawing.Point(149, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 114);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // rdbtn_Todos
            // 
            this.rdbtn_Todos.AutoSize = true;
            this.rdbtn_Todos.Location = new System.Drawing.Point(22, 65);
            this.rdbtn_Todos.Name = "rdbtn_Todos";
            this.rdbtn_Todos.Size = new System.Drawing.Size(55, 17);
            this.rdbtn_Todos.TabIndex = 2;
            this.rdbtn_Todos.TabStop = true;
            this.rdbtn_Todos.Text = "Todos";
            this.rdbtn_Todos.UseVisualStyleBackColor = true;
            this.rdbtn_Todos.CheckedChanged += new System.EventHandler(this.rdbtn_Todos_CheckedChanged);
            // 
            // rdbtn_PorFecha
            // 
            this.rdbtn_PorFecha.AutoSize = true;
            this.rdbtn_PorFecha.Location = new System.Drawing.Point(22, 42);
            this.rdbtn_PorFecha.Name = "rdbtn_PorFecha";
            this.rdbtn_PorFecha.Size = new System.Drawing.Size(74, 17);
            this.rdbtn_PorFecha.TabIndex = 1;
            this.rdbtn_PorFecha.TabStop = true;
            this.rdbtn_PorFecha.Text = "Por Fecha";
            this.rdbtn_PorFecha.UseVisualStyleBackColor = true;
            this.rdbtn_PorFecha.CheckedChanged += new System.EventHandler(this.rdbtn_PorFecha_CheckedChanged);
            // 
            // rdbtn_Cliente
            // 
            this.rdbtn_Cliente.AutoSize = true;
            this.rdbtn_Cliente.Location = new System.Drawing.Point(22, 19);
            this.rdbtn_Cliente.Name = "rdbtn_Cliente";
            this.rdbtn_Cliente.Size = new System.Drawing.Size(76, 17);
            this.rdbtn_Cliente.TabIndex = 0;
            this.rdbtn_Cliente.TabStop = true;
            this.rdbtn_Cliente.Text = "Por Cliente";
            this.rdbtn_Cliente.UseVisualStyleBackColor = true;
            this.rdbtn_Cliente.CheckedChanged += new System.EventHandler(this.rdbtn_Cliente_CheckedChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(6, 142);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(730, 328);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pictureBox4);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.reportViewer2);
            this.tabPage4.Controls.Add(this.txt_duracion);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(754, 497);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Llamadas por Duración";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(31, 11);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(110, 110);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rBD2);
            this.groupBox3.Controls.Add(this.rBD1);
            this.groupBox3.Location = new System.Drawing.Point(178, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(192, 69);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtros";
            // 
            // rBD2
            // 
            this.rBD2.AutoSize = true;
            this.rBD2.Location = new System.Drawing.Point(18, 42);
            this.rBD2.Name = "rBD2";
            this.rBD2.Size = new System.Drawing.Size(50, 17);
            this.rBD2.TabIndex = 1;
            this.rBD2.TabStop = true;
            this.rBD2.Text = "Todo";
            this.rBD2.UseVisualStyleBackColor = true;
            this.rBD2.CheckedChanged += new System.EventHandler(this.rBD2_CheckedChanged);
            // 
            // rBD1
            // 
            this.rBD1.AutoSize = true;
            this.rBD1.Location = new System.Drawing.Point(18, 19);
            this.rBD1.Name = "rBD1";
            this.rBD1.Size = new System.Drawing.Size(90, 17);
            this.rBD1.TabIndex = 0;
            this.rBD1.TabStop = true;
            this.rBD1.Text = "Por Duracion:";
            this.rBD1.UseVisualStyleBackColor = true;
            this.rBD1.CheckedChanged += new System.EventHandler(this.rBD1_CheckedChanged_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(649, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // reportViewer2
            // 
            this.reportViewer2.Location = new System.Drawing.Point(31, 127);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(693, 344);
            this.reportViewer2.TabIndex = 4;
            // 
            // txt_duracion
            // 
            this.txt_duracion.Location = new System.Drawing.Point(376, 25);
            this.txt_duracion.Name = "txt_duracion";
            this.txt_duracion.Pp_Campo = null;
            this.txt_duracion.Pp_MensajeError = null;
            this.txt_duracion.Pp_Tabla = null;
            this.txt_duracion.Pp_Validable = false;
            this.txt_duracion.Size = new System.Drawing.Size(100, 20);
            this.txt_duracion.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(677, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(110, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Frm_Reporte_Llamadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 579);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_Reporte_Llamadas";
            this.Text = "Frm_Reporte_Llamadas";
            this.Load += new System.EventHandler(this.Frm_Reporte_Llamadas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private Clases.TextBox01 txt_duracion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rBD2;
        private System.Windows.Forms.RadioButton rBD1;
        private System.Windows.Forms.Button button2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btn_Calcular;
        private Clases.TextBox01 textBox013;
        private Clases.TextBox01 textBox012;
        private System.Windows.Forms.Button btn_buscar;
        private Clases.TextBox01 textBox011;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtn_Todos;
        private System.Windows.Forms.RadioButton rdbtn_PorFecha;
        private System.Windows.Forms.RadioButton rdbtn_Cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}