
namespace ComunicAr.Formularios.Reportes.Dispositivos
{
    partial class Frm_Reporte_Disp
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Reporte_Disp));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RepDisp02BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_ReportDisp = new ComunicAr.Formularios.Reportes.Dispositivos.DS_ReportDisp();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rB2 = new System.Windows.Forms.RadioButton();
            this.rB1 = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox011 = new ComunicAr.Clases.ComboBox01();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox01 = new ComunicAr.Clases.TextBox01();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.textBox03 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox07 = new System.Windows.Forms.TextBox();
            this.textBox05 = new System.Windows.Forms.TextBox();
            this.textBox06 = new System.Windows.Forms.TextBox();
            this.textBox04 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rB5 = new System.Windows.Forms.RadioButton();
            this.rB4 = new System.Windows.Forms.RadioButton();
            this.rB3 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_xmarca = new System.Windows.Forms.RadioButton();
            this.cmb_xmarca = new ComunicAr.Clases.ComboBox01();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_xprecio = new System.Windows.Forms.RadioButton();
            this.txt_Disp_Hasta = new ComunicAr.Clases.TextBox01();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Disp_Desde = new ComunicAr.Clases.TextBox01();
            this.btn_Calcular_DH = new System.Windows.Forms.Button();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gr_tipo = new System.Windows.Forms.GroupBox();
            this.rb03_Dispo = new System.Windows.Forms.RadioButton();
            this.rb02_Dispo = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RepDisp02BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_ReportDisp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gr_tipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // RepDisp02BindingSource
            // 
            this.RepDisp02BindingSource.DataMember = "RepDisp02";
            this.RepDisp02BindingSource.DataSource = this.DS_ReportDisp;
            // 
            // DS_ReportDisp
            // 
            this.DS_ReportDisp.DataSetName = "DS_ReportDisp";
            this.DS_ReportDisp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.RepDisp02BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.Dispositivos.Reporte_Disp.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(26, 135);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(666, 321);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rB2);
            this.groupBox1.Controls.Add(this.rB1);
            this.groupBox1.Location = new System.Drawing.Point(179, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 93);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // rB2
            // 
            this.rB2.AutoSize = true;
            this.rB2.Location = new System.Drawing.Point(6, 46);
            this.rB2.Name = "rB2";
            this.rB2.Size = new System.Drawing.Size(77, 17);
            this.rB2.TabIndex = 2;
            this.rB2.TabStop = true;
            this.rB2.Text = "Por Marca:";
            this.rB2.UseVisualStyleBackColor = true;
            this.rB2.CheckedChanged += new System.EventHandler(this.rB2_CheckedChanged);
            // 
            // rB1
            // 
            this.rB1.AutoSize = true;
            this.rB1.Location = new System.Drawing.Point(6, 19);
            this.rB1.Name = "rB1";
            this.rB1.Size = new System.Drawing.Size(125, 17);
            this.rB1.TabIndex = 1;
            this.rB1.TabStop = true;
            this.rB1.Text = "Por Fecha Anterior a:";
            this.rB1.UseVisualStyleBackColor = true;
            this.rB1.CheckedChanged += new System.EventHandler(this.rB1_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(729, 533);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox011);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.textBox01);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(721, 507);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dispositivos";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // comboBox011
            // 
            this.comboBox011.Enabled = false;
            this.comboBox011.FormattingEnabled = true;
            this.comboBox011.Location = new System.Drawing.Point(334, 60);
            this.comboBox011.Name = "comboBox011";
            this.comboBox011.Pp_Conseleccion = false;
            this.comboBox011.Pp_Descripcion = "marca";
            this.comboBox011.Pp_MensajeError = null;
            this.comboBox011.Pp_NombreCampo = null;
            this.comboBox011.Pp_NombreTabla = null;
            this.comboBox011.Pp_PK = "NULL";
            this.comboBox011.Pp_Tabla = "Dispositivos";
            this.comboBox011.Pp_Validable = false;
            this.comboBox011.Size = new System.Drawing.Size(121, 21);
            this.comboBox011.TabIndex = 8;
            this.comboBox011.SelectedIndexChanged += new System.EventHandler(this.comboBox011_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // textBox01
            // 
            this.textBox01.Enabled = false;
            this.textBox01.Location = new System.Drawing.Point(334, 32);
            this.textBox01.Name = "textBox01";
            this.textBox01.Pp_Campo = null;
            this.textBox01.Pp_MensajeError = null;
            this.textBox01.Pp_Tabla = null;
            this.textBox01.Pp_Validable = false;
            this.textBox01.Size = new System.Drawing.Size(121, 20);
            this.textBox01.TabIndex = 2;
            this.textBox01.TextChanged += new System.EventHandler(this.textBox01_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Controls.Add(this.textBox03);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.textBox07);
            this.tabPage2.Controls.Add(this.textBox05);
            this.tabPage2.Controls.Add(this.textBox06);
            this.tabPage2.Controls.Add(this.textBox04);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(721, 507);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dispositivos Vendidos";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.RepDisp02BindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.Dispositivos.Reporte_Disp.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(24, 126);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(661, 346);
            this.reportViewer2.TabIndex = 21;
            // 
            // textBox03
            // 
            this.textBox03.Enabled = false;
            this.textBox03.Location = new System.Drawing.Point(406, 25);
            this.textBox03.Name = "textBox03";
            this.textBox03.Size = new System.Drawing.Size(100, 20);
            this.textBox03.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(610, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Calcular";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox07
            // 
            this.textBox07.Enabled = false;
            this.textBox07.Location = new System.Drawing.Point(444, 78);
            this.textBox07.Name = "textBox07";
            this.textBox07.Size = new System.Drawing.Size(62, 20);
            this.textBox07.TabIndex = 18;
            // 
            // textBox05
            // 
            this.textBox05.Enabled = false;
            this.textBox05.Location = new System.Drawing.Point(512, 51);
            this.textBox05.Name = "textBox05";
            this.textBox05.Size = new System.Drawing.Size(100, 20);
            this.textBox05.TabIndex = 17;
            // 
            // textBox06
            // 
            this.textBox06.Enabled = false;
            this.textBox06.Location = new System.Drawing.Point(406, 78);
            this.textBox06.Name = "textBox06";
            this.textBox06.Size = new System.Drawing.Size(32, 20);
            this.textBox06.TabIndex = 16;
            // 
            // textBox04
            // 
            this.textBox04.Enabled = false;
            this.textBox04.Location = new System.Drawing.Point(406, 51);
            this.textBox04.Name = "textBox04";
            this.textBox04.Size = new System.Drawing.Size(100, 20);
            this.textBox04.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(409, -24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rB5);
            this.groupBox2.Controls.Add(this.rB4);
            this.groupBox2.Controls.Add(this.rB3);
            this.groupBox2.Location = new System.Drawing.Point(201, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // rB5
            // 
            this.rB5.AutoSize = true;
            this.rB5.Location = new System.Drawing.Point(6, 69);
            this.rB5.Name = "rB5";
            this.rB5.Size = new System.Drawing.Size(149, 17);
            this.rB5.TabIndex = 2;
            this.rB5.TabStop = true;
            this.rB5.Text = "Por Mes y Año Especifico:";
            this.rB5.UseVisualStyleBackColor = true;
            this.rB5.CheckedChanged += new System.EventHandler(this.rB5_CheckedChanged);
            // 
            // rB4
            // 
            this.rB4.AutoSize = true;
            this.rB4.Location = new System.Drawing.Point(6, 43);
            this.rB4.Name = "rB4";
            this.rB4.Size = new System.Drawing.Size(127, 17);
            this.rB4.TabIndex = 1;
            this.rB4.TabStop = true;
            this.rB4.Text = "Por Rango de Precio:";
            this.rB4.UseVisualStyleBackColor = true;
            this.rB4.CheckedChanged += new System.EventHandler(this.rB4_CheckedChanged);
            // 
            // rB3
            // 
            this.rB3.AutoSize = true;
            this.rB3.Location = new System.Drawing.Point(6, 17);
            this.rB3.Name = "rB3";
            this.rB3.Size = new System.Drawing.Size(77, 17);
            this.rB3.TabIndex = 0;
            this.rB3.TabStop = true;
            this.rB3.Text = "Por Precio:";
            this.rB3.UseVisualStyleBackColor = true;
            this.rB3.CheckedChanged += new System.EventHandler(this.rB3_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(610, -40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.btn_Calcular_DH);
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Controls.Add(this.gr_tipo);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(721, 507);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dispositivos en Venta";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_xmarca);
            this.groupBox4.Controls.Add(this.cmb_xmarca);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btn_xprecio);
            this.groupBox4.Controls.Add(this.txt_Disp_Hasta);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txt_Disp_Desde);
            this.groupBox4.Location = new System.Drawing.Point(290, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(328, 91);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            // 
            // btn_xmarca
            // 
            this.btn_xmarca.AutoSize = true;
            this.btn_xmarca.Enabled = false;
            this.btn_xmarca.Location = new System.Drawing.Point(191, 13);
            this.btn_xmarca.Name = "btn_xmarca";
            this.btn_xmarca.Size = new System.Drawing.Size(77, 17);
            this.btn_xmarca.TabIndex = 15;
            this.btn_xmarca.TabStop = true;
            this.btn_xmarca.Text = "Por Marca:";
            this.btn_xmarca.UseVisualStyleBackColor = true;
            this.btn_xmarca.CheckedChanged += new System.EventHandler(this.btn_xmarca_CheckedChanged);
            // 
            // cmb_xmarca
            // 
            this.cmb_xmarca.Enabled = false;
            this.cmb_xmarca.FormattingEnabled = true;
            this.cmb_xmarca.Location = new System.Drawing.Point(191, 36);
            this.cmb_xmarca.Name = "cmb_xmarca";
            this.cmb_xmarca.Pp_Conseleccion = false;
            this.cmb_xmarca.Pp_Descripcion = "marca";
            this.cmb_xmarca.Pp_MensajeError = null;
            this.cmb_xmarca.Pp_NombreCampo = null;
            this.cmb_xmarca.Pp_NombreTabla = null;
            this.cmb_xmarca.Pp_PK = "NULL";
            this.cmb_xmarca.Pp_Tabla = "Dispositivos";
            this.cmb_xmarca.Pp_Validable = false;
            this.cmb_xmarca.Size = new System.Drawing.Size(121, 21);
            this.cmb_xmarca.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hasta";
            // 
            // btn_xprecio
            // 
            this.btn_xprecio.AutoSize = true;
            this.btn_xprecio.Enabled = false;
            this.btn_xprecio.Location = new System.Drawing.Point(15, 13);
            this.btn_xprecio.Name = "btn_xprecio";
            this.btn_xprecio.Size = new System.Drawing.Size(77, 17);
            this.btn_xprecio.TabIndex = 1;
            this.btn_xprecio.TabStop = true;
            this.btn_xprecio.Text = "Por Precio:";
            this.btn_xprecio.UseVisualStyleBackColor = true;
            this.btn_xprecio.CheckedChanged += new System.EventHandler(this.btn_xprecio_CheckedChanged);
            // 
            // txt_Disp_Hasta
            // 
            this.txt_Disp_Hasta.Enabled = false;
            this.txt_Disp_Hasta.Location = new System.Drawing.Point(55, 62);
            this.txt_Disp_Hasta.Name = "txt_Disp_Hasta";
            this.txt_Disp_Hasta.Pp_Campo = null;
            this.txt_Disp_Hasta.Pp_MensajeError = null;
            this.txt_Disp_Hasta.Pp_Tabla = null;
            this.txt_Disp_Hasta.Pp_Validable = false;
            this.txt_Disp_Hasta.Size = new System.Drawing.Size(100, 20);
            this.txt_Disp_Hasta.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Desde";
            // 
            // txt_Disp_Desde
            // 
            this.txt_Disp_Desde.Enabled = false;
            this.txt_Disp_Desde.Location = new System.Drawing.Point(55, 36);
            this.txt_Disp_Desde.Name = "txt_Disp_Desde";
            this.txt_Disp_Desde.Pp_Campo = null;
            this.txt_Disp_Desde.Pp_MensajeError = null;
            this.txt_Disp_Desde.Pp_Tabla = null;
            this.txt_Disp_Desde.Pp_Validable = false;
            this.txt_Disp_Desde.Size = new System.Drawing.Size(100, 20);
            this.txt_Disp_Desde.TabIndex = 0;
            // 
            // btn_Calcular_DH
            // 
            this.btn_Calcular_DH.Location = new System.Drawing.Point(626, 120);
            this.btn_Calcular_DH.Name = "btn_Calcular_DH";
            this.btn_Calcular_DH.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular_DH.TabIndex = 3;
            this.btn_Calcular_DH.Text = "Calcular";
            this.btn_Calcular_DH.UseVisualStyleBackColor = true;
            this.btn_Calcular_DH.Click += new System.EventHandler(this.btn_Calcular_DH_Click);
            // 
            // reportViewer3
            // 
            reportDataSource3.Name = "DataSet2";
            reportDataSource3.Value = this.RepDisp02BindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.Dispositivos.Reporte_Disp.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(24, 155);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(677, 346);
            this.reportViewer3.TabIndex = 9;
            this.reportViewer3.Load += new System.EventHandler(this.reportViewer3_Load);
            // 
            // gr_tipo
            // 
            this.gr_tipo.Controls.Add(this.rb03_Dispo);
            this.gr_tipo.Controls.Add(this.rb02_Dispo);
            this.gr_tipo.Location = new System.Drawing.Point(165, 23);
            this.gr_tipo.Name = "gr_tipo";
            this.gr_tipo.Size = new System.Drawing.Size(100, 62);
            this.gr_tipo.TabIndex = 2;
            this.gr_tipo.TabStop = false;
            this.gr_tipo.Text = "Tipo de Calculo";
            // 
            // rb03_Dispo
            // 
            this.rb03_Dispo.AutoSize = true;
            this.rb03_Dispo.Location = new System.Drawing.Point(6, 42);
            this.rb03_Dispo.Name = "rb03_Dispo";
            this.rb03_Dispo.Size = new System.Drawing.Size(50, 17);
            this.rb03_Dispo.TabIndex = 2;
            this.rb03_Dispo.Text = "Todo";
            this.rb03_Dispo.UseVisualStyleBackColor = true;
            this.rb03_Dispo.CheckedChanged += new System.EventHandler(this.rb03_Dispo_CheckedChanged);
            // 
            // rb02_Dispo
            // 
            this.rb02_Dispo.AutoSize = true;
            this.rb02_Dispo.Location = new System.Drawing.Point(6, 19);
            this.rb02_Dispo.Name = "rb02_Dispo";
            this.rb02_Dispo.Size = new System.Drawing.Size(47, 17);
            this.rb02_Dispo.TabIndex = 1;
            this.rb02_Dispo.Text = "Filtro";
            this.rb02_Dispo.UseVisualStyleBackColor = true;
            this.rb02_Dispo.CheckedChanged += new System.EventHandler(this.rb02_Dispo_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(642, 563);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.ErrorImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(24, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(126, 94);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // Frm_Reporte_Disp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 598);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_Reporte_Disp";
            this.Text = "Frm_Reporte_Disp";
            this.Load += new System.EventHandler(this.Frm_Reporte_Disp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RepDisp02BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_ReportDisp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gr_tipo.ResumeLayout(false);
            this.gr_tipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RepDisp02BindingSource;
        private DS_ReportDisp DS_ReportDisp;
        private System.Windows.Forms.Button button1;
        private Clases.TextBox01 textBox01;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rB1;
        private System.Windows.Forms.RadioButton rB2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox07;
        private System.Windows.Forms.TextBox textBox05;
        private System.Windows.Forms.TextBox textBox06;
        private System.Windows.Forms.TextBox textBox04;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rB5;
        private System.Windows.Forms.RadioButton rB4;
        private System.Windows.Forms.RadioButton rB3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox03;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Clases.ComboBox01 comboBox011;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton btn_xprecio;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private Clases.TextBox01 txt_Disp_Hasta;
        private System.Windows.Forms.Label label5;
        private Clases.TextBox01 txt_Disp_Desde;
        private System.Windows.Forms.Button btn_Calcular_DH;
        private System.Windows.Forms.GroupBox gr_tipo;
        private System.Windows.Forms.RadioButton rb03_Dispo;
        private System.Windows.Forms.RadioButton rb02_Dispo;
        private System.Windows.Forms.RadioButton btn_xmarca;
        private Clases.ComboBox01 cmb_xmarca;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}