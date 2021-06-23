
namespace ComunicAr.Formularios.Estadisticas.Servicios
{
    partial class Frm_Servicios_Estadisiticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Servicios_Estadisiticas));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pack_vendidos = new System.Windows.Forms.TabPage();
            this.btn_calcular_serv = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rv01_Servicios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.packs_allS = new System.Windows.Forms.TabPage();
            this.rv02_Serv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Calcular_S = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rb_mes = new System.Windows.Forms.RadioButton();
            this.rb_intervalo = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_year = new ComunicAr.Clases.TextBox01();
            this.txt_mes = new ComunicAr.Clases.TextBox01();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_hasta_year = new ComunicAr.Clases.TextBox01();
            this.txt_desde_year = new ComunicAr.Clases.TextBox01();
            this.txt_hasta_mes = new ComunicAr.Clases.TextBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_desde_mes = new ComunicAr.Clases.TextBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_año = new System.Windows.Forms.Label();
            this.txt_year_S = new ComunicAr.Clases.TextBox01();
            this.tabControl1.SuspendLayout();
            this.pack_vendidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.packs_allS.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pack_vendidos);
            this.tabControl1.Controls.Add(this.packs_allS);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(745, 599);
            this.tabControl1.TabIndex = 0;
            // 
            // pack_vendidos
            // 
            this.pack_vendidos.Controls.Add(this.groupBox2);
            this.pack_vendidos.Controls.Add(this.btn_calcular_serv);
            this.pack_vendidos.Controls.Add(this.rv01_Servicios);
            this.pack_vendidos.Controls.Add(this.pictureBox1);
            this.pack_vendidos.Location = new System.Drawing.Point(4, 22);
            this.pack_vendidos.Name = "pack_vendidos";
            this.pack_vendidos.Padding = new System.Windows.Forms.Padding(3);
            this.pack_vendidos.Size = new System.Drawing.Size(750, 557);
            this.pack_vendidos.TabIndex = 0;
            this.pack_vendidos.Text = "Packs de datos vendidos";
            this.pack_vendidos.UseVisualStyleBackColor = true;
            // 
            // btn_calcular_serv
            // 
            this.btn_calcular_serv.Location = new System.Drawing.Point(656, 32);
            this.btn_calcular_serv.Name = "btn_calcular_serv";
            this.btn_calcular_serv.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular_serv.TabIndex = 1;
            this.btn_calcular_serv.Text = "Calcular";
            this.btn_calcular_serv.UseVisualStyleBackColor = true;
            this.btn_calcular_serv.Click += new System.EventHandler(this.btn_calcular_serv_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // rv01_Servicios
            // 
            this.rv01_Servicios.Location = new System.Drawing.Point(29, 128);
            this.rv01_Servicios.Name = "rv01_Servicios";
            this.rv01_Servicios.ServerReport.BearerToken = null;
            this.rv01_Servicios.Size = new System.Drawing.Size(678, 405);
            this.rv01_Servicios.TabIndex = 1;
            this.rv01_Servicios.Load += new System.EventHandler(this.rv01_Servicios_Load);
            // 
            // packs_allS
            // 
            this.packs_allS.Controls.Add(this.rv02_Serv);
            this.packs_allS.Controls.Add(this.groupBox3);
            this.packs_allS.Controls.Add(this.pictureBox2);
            this.packs_allS.Location = new System.Drawing.Point(4, 22);
            this.packs_allS.Name = "packs_allS";
            this.packs_allS.Size = new System.Drawing.Size(737, 573);
            this.packs_allS.TabIndex = 1;
            this.packs_allS.Text = "Pack vendidos por servicio";
            this.packs_allS.UseVisualStyleBackColor = true;
            // 
            // rv02_Serv
            // 
            this.rv02_Serv.Location = new System.Drawing.Point(21, 159);
            this.rv02_Serv.Name = "rv02_Serv";
            this.rv02_Serv.ServerReport.BearerToken = null;
            this.rv02_Serv.Size = new System.Drawing.Size(688, 386);
            this.rv02_Serv.TabIndex = 1;
            this.rv02_Serv.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Calcular_S);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(168, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(541, 149);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // btn_Calcular_S
            // 
            this.btn_Calcular_S.Location = new System.Drawing.Point(442, 104);
            this.btn_Calcular_S.Name = "btn_Calcular_S";
            this.btn_Calcular_S.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular_S.TabIndex = 31;
            this.btn_Calcular_S.Text = "Calcular";
            this.btn_Calcular_S.UseVisualStyleBackColor = true;
            this.btn_Calcular_S.Click += new System.EventHandler(this.btn_Calcular_S_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rb_mes);
            this.groupBox6.Controls.Add(this.rb_intervalo);
            this.groupBox6.Location = new System.Drawing.Point(37, 14);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(126, 76);
            this.groupBox6.TabIndex = 30;
            this.groupBox6.TabStop = false;
            // 
            // rb_mes
            // 
            this.rb_mes.AutoSize = true;
            this.rb_mes.Location = new System.Drawing.Point(6, 42);
            this.rb_mes.Name = "rb_mes";
            this.rb_mes.Size = new System.Drawing.Size(97, 17);
            this.rb_mes.TabIndex = 1;
            this.rb_mes.Text = "Mes Especifico";
            this.rb_mes.UseVisualStyleBackColor = true;
            this.rb_mes.CheckedChanged += new System.EventHandler(this.rb_mes_CheckedChanged);
            // 
            // rb_intervalo
            // 
            this.rb_intervalo.AutoSize = true;
            this.rb_intervalo.Location = new System.Drawing.Point(3, 16);
            this.rb_intervalo.Name = "rb_intervalo";
            this.rb_intervalo.Size = new System.Drawing.Size(114, 17);
            this.rb_intervalo.TabIndex = 0;
            this.rb_intervalo.Text = "Intervalo de meses";
            this.rb_intervalo.UseVisualStyleBackColor = true;
            this.rb_intervalo.CheckedChanged += new System.EventHandler(this.rb_intervalo_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_year);
            this.groupBox5.Controls.Add(this.txt_mes);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(184, 91);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 41);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(136, 15);
            this.txt_year.Name = "txt_year";
            this.txt_year.Pp_Campo = null;
            this.txt_year.Pp_MensajeError = null;
            this.txt_year.Pp_Tabla = null;
            this.txt_year.Pp_Validable = false;
            this.txt_year.Size = new System.Drawing.Size(58, 20);
            this.txt_year.TabIndex = 32;
            this.txt_year.Text = "AAAA";
            this.txt_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_year.Click += new System.EventHandler(this.txt_year_Click);
            // 
            // txt_mes
            // 
            this.txt_mes.Location = new System.Drawing.Point(87, 15);
            this.txt_mes.Name = "txt_mes";
            this.txt_mes.Pp_Campo = null;
            this.txt_mes.Pp_MensajeError = null;
            this.txt_mes.Pp_Tabla = null;
            this.txt_mes.Pp_Validable = false;
            this.txt_mes.Size = new System.Drawing.Size(43, 20);
            this.txt_mes.TabIndex = 31;
            this.txt_mes.Text = "MM";
            this.txt_mes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_mes.Click += new System.EventHandler(this.txt_mes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Ingrese el mes";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_hasta_year);
            this.groupBox4.Controls.Add(this.txt_desde_year);
            this.groupBox4.Controls.Add(this.txt_hasta_mes);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txt_desde_mes);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(184, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 71);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            // 
            // txt_hasta_year
            // 
            this.txt_hasta_year.Location = new System.Drawing.Point(106, 40);
            this.txt_hasta_year.Name = "txt_hasta_year";
            this.txt_hasta_year.Pp_Campo = null;
            this.txt_hasta_year.Pp_MensajeError = null;
            this.txt_hasta_year.Pp_Tabla = null;
            this.txt_hasta_year.Pp_Validable = false;
            this.txt_hasta_year.Size = new System.Drawing.Size(58, 20);
            this.txt_hasta_year.TabIndex = 5;
            this.txt_hasta_year.Text = "AAAA";
            this.txt_hasta_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_hasta_year.Click += new System.EventHandler(this.txt_hasta_year_Click);
            // 
            // txt_desde_year
            // 
            this.txt_desde_year.Location = new System.Drawing.Point(106, 14);
            this.txt_desde_year.Name = "txt_desde_year";
            this.txt_desde_year.Pp_Campo = null;
            this.txt_desde_year.Pp_MensajeError = null;
            this.txt_desde_year.Pp_Tabla = null;
            this.txt_desde_year.Pp_Validable = false;
            this.txt_desde_year.Size = new System.Drawing.Size(58, 20);
            this.txt_desde_year.TabIndex = 3;
            this.txt_desde_year.Text = "AAAA";
            this.txt_desde_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_desde_year.Click += new System.EventHandler(this.txt_desde_year_Click);
            // 
            // txt_hasta_mes
            // 
            this.txt_hasta_mes.Location = new System.Drawing.Point(57, 40);
            this.txt_hasta_mes.Name = "txt_hasta_mes";
            this.txt_hasta_mes.Pp_Campo = null;
            this.txt_hasta_mes.Pp_MensajeError = null;
            this.txt_hasta_mes.Pp_Tabla = null;
            this.txt_hasta_mes.Pp_Validable = false;
            this.txt_hasta_mes.Size = new System.Drawing.Size(43, 20);
            this.txt_hasta_mes.TabIndex = 4;
            this.txt_hasta_mes.Text = "MM";
            this.txt_hasta_mes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_hasta_mes.Click += new System.EventHandler(this.txt_Hasta_Mes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Hasta";
            // 
            // txt_desde_mes
            // 
            this.txt_desde_mes.Location = new System.Drawing.Point(57, 14);
            this.txt_desde_mes.Name = "txt_desde_mes";
            this.txt_desde_mes.Pp_Campo = null;
            this.txt_desde_mes.Pp_MensajeError = null;
            this.txt_desde_mes.Pp_Tabla = null;
            this.txt_desde_mes.Pp_Validable = false;
            this.txt_desde_mes.Size = new System.Drawing.Size(43, 20);
            this.txt_desde_mes.TabIndex = 2;
            this.txt_desde_mes.Text = "MM";
            this.txt_desde_mes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_desde_mes.Click += new System.EventHandler(this.txt_Desde_Mes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Desde";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_year_S);
            this.groupBox2.Controls.Add(this.txt_año);
            this.groupBox2.Location = new System.Drawing.Point(143, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 50);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // txt_año
            // 
            this.txt_año.AutoSize = true;
            this.txt_año.Location = new System.Drawing.Point(6, 18);
            this.txt_año.Name = "txt_año";
            this.txt_año.Size = new System.Drawing.Size(118, 13);
            this.txt_año.TabIndex = 25;
            this.txt_año.Text = "Ingrese el año a buscar";
            // 
            // txt_year_S
            // 
            this.txt_year_S.Location = new System.Drawing.Point(130, 18);
            this.txt_year_S.Name = "txt_year_S";
            this.txt_year_S.Pp_Campo = null;
            this.txt_year_S.Pp_MensajeError = null;
            this.txt_year_S.Pp_Tabla = null;
            this.txt_year_S.Pp_Validable = false;
            this.txt_year_S.Size = new System.Drawing.Size(60, 20);
            this.txt_year_S.TabIndex = 1;
            this.txt_year_S.Text = "AAAA";
            this.txt_year_S.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_year_S.Click += new System.EventHandler(this.txt_year_S_Click);
            // 
            // Frm_Servicios_Estadisiticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 624);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_Servicios_Estadisiticas";
            this.Text = "Estadisticas Servicios";
            this.Load += new System.EventHandler(this.Frm_Servicios_Estadisiticas_Load);
            this.tabControl1.ResumeLayout(false);
            this.pack_vendidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.packs_allS.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pack_vendidos;
        private Microsoft.Reporting.WinForms.ReportViewer rv01_Servicios;
        private System.Windows.Forms.Button btn_calcular_serv;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage packs_allS;
        private Microsoft.Reporting.WinForms.ReportViewer rv02_Serv;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private Clases.TextBox01 txt_hasta_mes;
        private System.Windows.Forms.Label label2;
        private Clases.TextBox01 txt_desde_mes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private Clases.TextBox01 txt_hasta_year;
        private Clases.TextBox01 txt_desde_year;
        private Clases.TextBox01 txt_year;
        private Clases.TextBox01 txt_mes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Calcular_S;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rb_mes;
        private System.Windows.Forms.RadioButton rb_intervalo;
        private System.Windows.Forms.GroupBox groupBox2;
        private Clases.TextBox01 txt_year_S;
        private System.Windows.Forms.Label txt_año;
    }
}