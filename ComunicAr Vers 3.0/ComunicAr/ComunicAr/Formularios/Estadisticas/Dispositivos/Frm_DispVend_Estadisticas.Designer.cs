
namespace ComunicAr.Formularios.Estadisticas.Dispositivos
{
    partial class Frm_DispVend_Estadisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DispVend_Estadisticas));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DispositivosVendidos = new System.Windows.Forms.TabPage();
            this.DispositivosPorServicios = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.txtYear = new ComunicAr.Clases.TextBox01();
            this.txtMes = new ComunicAr.Clases.TextBox01();
            this.cmb_Cliente = new ComunicAr.Clases.ComboBox01();
            this.cmb_CodNacional = new ComunicAr.Clases.ComboBox01();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.cmb_tipoDisp = new ComunicAr.Clases.ComboBox01();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.cmb_Marca = new ComunicAr.Clases.ComboBox01();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.DispositivosVendidos.SuspendLayout();
            this.DispositivosPorServicios.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(19, 128);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(603, 407);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(162, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 70);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(106, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Mes y año actual";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(158, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "En un mes y año especifico:";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DispositivosVendidos);
            this.tabControl1.Controls.Add(this.DispositivosPorServicios);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(684, 649);
            this.tabControl1.TabIndex = 6;
            // 
            // DispositivosVendidos
            // 
            this.DispositivosVendidos.Controls.Add(this.reportViewer1);
            this.DispositivosVendidos.Controls.Add(this.txtYear);
            this.DispositivosVendidos.Controls.Add(this.pictureBox1);
            this.DispositivosVendidos.Controls.Add(this.txtMes);
            this.DispositivosVendidos.Controls.Add(this.button1);
            this.DispositivosVendidos.Controls.Add(this.groupBox1);
            this.DispositivosVendidos.Location = new System.Drawing.Point(4, 22);
            this.DispositivosVendidos.Name = "DispositivosVendidos";
            this.DispositivosVendidos.Padding = new System.Windows.Forms.Padding(3);
            this.DispositivosVendidos.Size = new System.Drawing.Size(651, 563);
            this.DispositivosVendidos.TabIndex = 0;
            this.DispositivosVendidos.Text = "DispositivosVendidos";
            this.DispositivosVendidos.UseVisualStyleBackColor = true;
            this.DispositivosVendidos.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // DispositivosPorServicios
            // 
            this.DispositivosPorServicios.Controls.Add(this.cmb_Marca);
            this.DispositivosPorServicios.Controls.Add(this.cmb_tipoDisp);
            this.DispositivosPorServicios.Controls.Add(this.cmb_Cliente);
            this.DispositivosPorServicios.Controls.Add(this.cmb_CodNacional);
            this.DispositivosPorServicios.Controls.Add(this.groupBox2);
            this.DispositivosPorServicios.Controls.Add(this.reportViewer2);
            this.DispositivosPorServicios.Controls.Add(this.pictureBox2);
            this.DispositivosPorServicios.Controls.Add(this.button2);
            this.DispositivosPorServicios.Location = new System.Drawing.Point(4, 22);
            this.DispositivosPorServicios.Name = "DispositivosPorServicios";
            this.DispositivosPorServicios.Padding = new System.Windows.Forms.Padding(3);
            this.DispositivosPorServicios.Size = new System.Drawing.Size(676, 623);
            this.DispositivosPorServicios.TabIndex = 1;
            this.DispositivosPorServicios.Text = "DispositivosPorServicios";
            this.DispositivosPorServicios.UseVisualStyleBackColor = true;
            this.DispositivosPorServicios.Click += new System.EventHandler(this.DispositivosPorServicios_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton7);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Location = new System.Drawing.Point(162, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 135);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 112);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(55, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Todos";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(122, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Por codigo nacional:";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // reportViewer2
            // 
            this.reportViewer2.Location = new System.Drawing.Point(19, 206);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(626, 400);
            this.reportViewer2.TabIndex = 11;
            this.reportViewer2.Load += new System.EventHandler(this.reportViewer2_Load);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(19, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(550, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 42);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(78, 17);
            this.radioButton5.TabIndex = 3;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Por cliente:";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // txtYear
            // 
            this.txtYear.Enabled = false;
            this.txtYear.Location = new System.Drawing.Point(403, 38);
            this.txtYear.Name = "txtYear";
            this.txtYear.Pp_Campo = null;
            this.txtYear.Pp_MensajeError = null;
            this.txtYear.Pp_Tabla = null;
            this.txtYear.Pp_Validable = false;
            this.txtYear.Size = new System.Drawing.Size(57, 20);
            this.txtYear.TabIndex = 5;
            // 
            // txtMes
            // 
            this.txtMes.Enabled = false;
            this.txtMes.Location = new System.Drawing.Point(340, 38);
            this.txtMes.Name = "txtMes";
            this.txtMes.Pp_Campo = null;
            this.txtMes.Pp_MensajeError = null;
            this.txtMes.Pp_Tabla = null;
            this.txtMes.Pp_Validable = false;
            this.txtMes.Size = new System.Drawing.Size(57, 20);
            this.txtMes.TabIndex = 4;
            // 
            // cmb_Cliente
            // 
            this.cmb_Cliente.Enabled = false;
            this.cmb_Cliente.FormattingEnabled = true;
            this.cmb_Cliente.Location = new System.Drawing.Point(322, 61);
            this.cmb_Cliente.Name = "cmb_Cliente";
            this.cmb_Cliente.Pp_Conseleccion = false;
            this.cmb_Cliente.Pp_Descripcion = "nombre_razonSocial";
            this.cmb_Cliente.Pp_MensajeError = null;
            this.cmb_Cliente.Pp_NombreCampo = null;
            this.cmb_Cliente.Pp_NombreTabla = null;
            this.cmb_Cliente.Pp_PK = "nro_cliente";
            this.cmb_Cliente.Pp_Tabla = "Cliente";
            this.cmb_Cliente.Pp_Validable = false;
            this.cmb_Cliente.Size = new System.Drawing.Size(141, 21);
            this.cmb_Cliente.TabIndex = 14;
            // 
            // cmb_CodNacional
            // 
            this.cmb_CodNacional.Enabled = false;
            this.cmb_CodNacional.FormattingEnabled = true;
            this.cmb_CodNacional.Location = new System.Drawing.Point(322, 38);
            this.cmb_CodNacional.Name = "cmb_CodNacional";
            this.cmb_CodNacional.Pp_Conseleccion = false;
            this.cmb_CodNacional.Pp_Descripcion = "cod_nacional";
            this.cmb_CodNacional.Pp_MensajeError = null;
            this.cmb_CodNacional.Pp_NombreCampo = null;
            this.cmb_CodNacional.Pp_NombreTabla = null;
            this.cmb_CodNacional.Pp_PK = "id_numero";
            this.cmb_CodNacional.Pp_Tabla = "Numero";
            this.cmb_CodNacional.Pp_Validable = false;
            this.cmb_CodNacional.Size = new System.Drawing.Size(84, 21);
            this.cmb_CodNacional.TabIndex = 13;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 65);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(131, 17);
            this.radioButton6.TabIndex = 4;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Por tipo de dispositivo:";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // cmb_tipoDisp
            // 
            this.cmb_tipoDisp.Enabled = false;
            this.cmb_tipoDisp.FormattingEnabled = true;
            this.cmb_tipoDisp.Location = new System.Drawing.Point(322, 85);
            this.cmb_tipoDisp.Name = "cmb_tipoDisp";
            this.cmb_tipoDisp.Pp_Conseleccion = false;
            this.cmb_tipoDisp.Pp_Descripcion = "nombre_tipo";
            this.cmb_tipoDisp.Pp_MensajeError = null;
            this.cmb_tipoDisp.Pp_NombreCampo = null;
            this.cmb_tipoDisp.Pp_NombreTabla = null;
            this.cmb_tipoDisp.Pp_PK = "id_tipo_dispositivo";
            this.cmb_tipoDisp.Pp_Tabla = "Tipo_dispositivo";
            this.cmb_tipoDisp.Pp_Validable = false;
            this.cmb_tipoDisp.Size = new System.Drawing.Size(84, 21);
            this.cmb_tipoDisp.TabIndex = 15;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(6, 89);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(76, 17);
            this.radioButton7.TabIndex = 5;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Por marca:";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // cmb_Marca
            // 
            this.cmb_Marca.Enabled = false;
            this.cmb_Marca.FormattingEnabled = true;
            this.cmb_Marca.Location = new System.Drawing.Point(322, 109);
            this.cmb_Marca.Name = "cmb_Marca";
            this.cmb_Marca.Pp_Conseleccion = false;
            this.cmb_Marca.Pp_Descripcion = "marca";
            this.cmb_Marca.Pp_MensajeError = null;
            this.cmb_Marca.Pp_NombreCampo = null;
            this.cmb_Marca.Pp_NombreTabla = null;
            this.cmb_Marca.Pp_PK = "";
            this.cmb_Marca.Pp_Tabla = "Dispositivos";
            this.cmb_Marca.Pp_Validable = false;
            this.cmb_Marca.Size = new System.Drawing.Size(84, 21);
            this.cmb_Marca.TabIndex = 16;
            // 
            // Frm_DispVend_Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 673);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_DispVend_Estadisticas";
            this.Text = "Frm_DispVend_Estadisticas";
            this.Load += new System.EventHandler(this.Frm_DispVend_Estadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.DispositivosVendidos.ResumeLayout(false);
            this.DispositivosVendidos.PerformLayout();
            this.DispositivosPorServicios.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private Clases.TextBox01 txtMes;
        private Clases.TextBox01 txtYear;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DispositivosVendidos;
        private System.Windows.Forms.TabPage DispositivosPorServicios;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private Clases.ComboBox01 cmb_CodNacional;
        private Clases.ComboBox01 cmb_Cliente;
        private System.Windows.Forms.RadioButton radioButton5;
        private Clases.ComboBox01 cmb_tipoDisp;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private Clases.ComboBox01 cmb_Marca;
    }
}