﻿
namespace ComunicAr.Formularios.Reportes.ServiciosFijos
{
    partial class ReporteServicios
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_calc = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.rv_Fijos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cliente = new ComunicAr.Clases.TextBox01();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.rb_num = new System.Windows.Forms.RadioButton();
            this.rb_cliente = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_Calcular_Datos = new System.Windows.Forms.Button();
            this.txt_limite = new ComunicAr.Clases.TextBox01();
            this.txt_costo = new ComunicAr.Clases.TextBox01();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_todos1 = new System.Windows.Forms.RadioButton();
            this.rb_limite = new System.Windows.Forms.RadioButton();
            this.rb_Costo = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_SF_Hasta = new ComunicAr.Clases.TextBox01();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Calcular_Fijos = new System.Windows.Forms.Button();
            this.gr_tipo = new System.Windows.Forms.GroupBox();
            this.rb03_Fijos = new System.Windows.Forms.RadioButton();
            this.rb02_Fijos = new System.Windows.Forms.RadioButton();
            this.txt_SF_Desde = new ComunicAr.Clases.TextBox01();
            this.rv01_Fijos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rb02_Prepagos_Tipo = new System.Windows.Forms.RadioButton();
            this.rb01_Prepagos_Tipo = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SP_hasta = new ComunicAr.Clases.TextBox01();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_SP_desde = new ComunicAr.Clases.TextBox01();
            this.btn_calcular_prepago = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rb03_Prepagos = new System.Windows.Forms.RadioButton();
            this.rb02_Prepagos = new System.Windows.Forms.RadioButton();
            this.rv02 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_desde = new ComunicAr.Clases.TextBox01();
            this.txt_hasta = new ComunicAr.Clases.TextBox01();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gr_tipo.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_hasta);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txt_desde);
            this.tabPage1.Controls.Add(this.btn_calc);
            this.tabPage1.Controls.Add(this.btn_buscar);
            this.tabPage1.Controls.Add(this.rv_Fijos);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_cliente);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(756, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Servicios Fijos";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_calc
            // 
            this.btn_calc.Enabled = false;
            this.btn_calc.Location = new System.Drawing.Point(676, 87);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_calc.TabIndex = 7;
            this.btn_calc.Text = "Calcular";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(603, 17);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(66, 21);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Visible = false;
            this.btn_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // rv_Fijos
            // 
            this.rv_Fijos.Location = new System.Drawing.Point(7, 116);
            this.rv_Fijos.Name = "rv_Fijos";
            this.rv_Fijos.ServerReport.BearerToken = null;
            this.rv_Fijos.Size = new System.Drawing.Size(753, 300);
            this.rv_Fijos.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID de Cliente";
            // 
            // txt_cliente
            // 
            this.txt_cliente.Enabled = false;
            this.txt_cliente.Location = new System.Drawing.Point(476, 17);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Pp_Campo = null;
            this.txt_cliente.Pp_MensajeError = null;
            this.txt_cliente.Pp_Tabla = null;
            this.txt_cliente.Pp_Validable = false;
            this.txt_cliente.Size = new System.Drawing.Size(121, 20);
            this.txt_cliente.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_todos);
            this.groupBox1.Controls.Add(this.rb_num);
            this.groupBox1.Controls.Add(this.rb_cliente);
            this.groupBox1.Location = new System.Drawing.Point(169, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 90);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Location = new System.Drawing.Point(7, 63);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(136, 17);
            this.rb_todos.TabIndex = 0;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "Todos los servicios fijos";
            this.rb_todos.UseVisualStyleBackColor = true;
            this.rb_todos.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rb_num
            // 
            this.rb_num.AutoSize = true;
            this.rb_num.Location = new System.Drawing.Point(7, 40);
            this.rb_num.Name = "rb_num";
            this.rb_num.Size = new System.Drawing.Size(189, 17);
            this.rb_num.TabIndex = 0;
            this.rb_num.TabStop = true;
            this.rb_num.Text = "Servicios fijos por rango de precios";
            this.rb_num.UseVisualStyleBackColor = true;
            this.rb_num.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rb_cliente
            // 
            this.rb_cliente.AutoSize = true;
            this.rb_cliente.Location = new System.Drawing.Point(7, 17);
            this.rb_cliente.Name = "rb_cliente";
            this.rb_cliente.Size = new System.Drawing.Size(153, 17);
            this.rb_cliente.TabIndex = 0;
            this.rb_cliente.TabStop = true;
            this.rb_cliente.Text = "Servicios fijos de un cliente";
            this.rb_cliente.UseVisualStyleBackColor = true;
            this.rb_cliente.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ComunicAr.Properties.Resources.kisspng_wireless_telecommunications_tower_cell_site_mobile_antenna_5aba4dff02eb99_778486621522159103012;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 90);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer1);
            this.tabPage2.Controls.Add(this.btn_Calcular_Datos);
            this.tabPage2.Controls.Add(this.txt_limite);
            this.tabPage2.Controls.Add(this.txt_costo);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(756, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Servicios Datos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(15, 118);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(745, 276);
            this.reportViewer1.TabIndex = 27;
            // 
            // btn_Calcular_Datos
            // 
            this.btn_Calcular_Datos.Location = new System.Drawing.Point(334, 54);
            this.btn_Calcular_Datos.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Calcular_Datos.Name = "btn_Calcular_Datos";
            this.btn_Calcular_Datos.Size = new System.Drawing.Size(55, 18);
            this.btn_Calcular_Datos.TabIndex = 26;
            this.btn_Calcular_Datos.Text = "Calcular";
            this.btn_Calcular_Datos.UseVisualStyleBackColor = true;
            this.btn_Calcular_Datos.Click += new System.EventHandler(this.btn_Calcular_Datos_Click);
            // 
            // txt_limite
            // 
            this.txt_limite.Location = new System.Drawing.Point(184, 52);
            this.txt_limite.Margin = new System.Windows.Forms.Padding(2);
            this.txt_limite.Name = "txt_limite";
            this.txt_limite.Pp_Campo = null;
            this.txt_limite.Pp_MensajeError = null;
            this.txt_limite.Pp_Tabla = null;
            this.txt_limite.Pp_Validable = false;
            this.txt_limite.Size = new System.Drawing.Size(84, 20);
            this.txt_limite.TabIndex = 25;
            // 
            // txt_costo
            // 
            this.txt_costo.Location = new System.Drawing.Point(184, 24);
            this.txt_costo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Pp_Campo = null;
            this.txt_costo.Pp_MensajeError = null;
            this.txt_costo.Pp_Tabla = null;
            this.txt_costo.Pp_Validable = false;
            this.txt_costo.Size = new System.Drawing.Size(85, 20);
            this.txt_costo.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Gb";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "$";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_todos1);
            this.groupBox2.Controls.Add(this.rb_limite);
            this.groupBox2.Controls.Add(this.rb_Costo);
            this.groupBox2.Location = new System.Drawing.Point(15, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 93);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // rb_todos1
            // 
            this.rb_todos1.AutoSize = true;
            this.rb_todos1.Location = new System.Drawing.Point(6, 72);
            this.rb_todos1.Margin = new System.Windows.Forms.Padding(2);
            this.rb_todos1.Name = "rb_todos1";
            this.rb_todos1.Size = new System.Drawing.Size(58, 17);
            this.rb_todos1.TabIndex = 3;
            this.rb_todos1.TabStop = true;
            this.rb_todos1.Text = "Todos ";
            this.rb_todos1.UseVisualStyleBackColor = true;
            this.rb_todos1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
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
            this.rb_Costo.Location = new System.Drawing.Point(6, 18);
            this.rb_Costo.Name = "rb_Costo";
            this.rb_Costo.Size = new System.Drawing.Size(102, 17);
            this.rb_Costo.TabIndex = 1;
            this.rb_Costo.TabStop = true;
            this.rb_Costo.Text = "Por costo hasta:";
            this.rb_Costo.UseVisualStyleBackColor = true;
            this.rb_Costo.CheckedChanged += new System.EventHandler(this.rb_Costo_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.rv01_Fijos);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(756, 423);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Servicios Fijos Ofrecidos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt_SF_Hasta);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btn_Calcular_Fijos);
            this.groupBox3.Controls.Add(this.gr_tipo);
            this.groupBox3.Controls.Add(this.txt_SF_Desde);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(412, 129);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hasta";
            // 
            // txt_SF_Hasta
            // 
            this.txt_SF_Hasta.Location = new System.Drawing.Point(68, 45);
            this.txt_SF_Hasta.Name = "txt_SF_Hasta";
            this.txt_SF_Hasta.Pp_Campo = null;
            this.txt_SF_Hasta.Pp_MensajeError = null;
            this.txt_SF_Hasta.Pp_Tabla = null;
            this.txt_SF_Hasta.Pp_Validable = false;
            this.txt_SF_Hasta.Size = new System.Drawing.Size(100, 20);
            this.txt_SF_Hasta.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Desde";
            // 
            // btn_Calcular_Fijos
            // 
            this.btn_Calcular_Fijos.Location = new System.Drawing.Point(318, 59);
            this.btn_Calcular_Fijos.Name = "btn_Calcular_Fijos";
            this.btn_Calcular_Fijos.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular_Fijos.TabIndex = 3;
            this.btn_Calcular_Fijos.Text = "Calcular";
            this.btn_Calcular_Fijos.UseVisualStyleBackColor = true;
            this.btn_Calcular_Fijos.Click += new System.EventHandler(this.btn_Calcular_Fijos_Click);
            // 
            // gr_tipo
            // 
            this.gr_tipo.Controls.Add(this.rb03_Fijos);
            this.gr_tipo.Controls.Add(this.rb02_Fijos);
            this.gr_tipo.Location = new System.Drawing.Point(188, 11);
            this.gr_tipo.Name = "gr_tipo";
            this.gr_tipo.Size = new System.Drawing.Size(100, 71);
            this.gr_tipo.TabIndex = 2;
            this.gr_tipo.TabStop = false;
            this.gr_tipo.Text = "Tipo de Calculo";
            // 
            // rb03_Fijos
            // 
            this.rb03_Fijos.AutoSize = true;
            this.rb03_Fijos.Checked = true;
            this.rb03_Fijos.Location = new System.Drawing.Point(6, 48);
            this.rb03_Fijos.Name = "rb03_Fijos";
            this.rb03_Fijos.Size = new System.Drawing.Size(50, 17);
            this.rb03_Fijos.TabIndex = 2;
            this.rb03_Fijos.TabStop = true;
            this.rb03_Fijos.Text = "Todo";
            this.rb03_Fijos.UseVisualStyleBackColor = true;
            // 
            // rb02_Fijos
            // 
            this.rb02_Fijos.AutoSize = true;
            this.rb02_Fijos.Location = new System.Drawing.Point(6, 25);
            this.rb02_Fijos.Name = "rb02_Fijos";
            this.rb02_Fijos.Size = new System.Drawing.Size(47, 17);
            this.rb02_Fijos.TabIndex = 1;
            this.rb02_Fijos.Text = "Filtro";
            this.rb02_Fijos.UseVisualStyleBackColor = true;
            // 
            // txt_SF_Desde
            // 
            this.txt_SF_Desde.Location = new System.Drawing.Point(68, 19);
            this.txt_SF_Desde.Name = "txt_SF_Desde";
            this.txt_SF_Desde.Pp_Campo = null;
            this.txt_SF_Desde.Pp_MensajeError = null;
            this.txt_SF_Desde.Pp_Tabla = null;
            this.txt_SF_Desde.Pp_Validable = false;
            this.txt_SF_Desde.Size = new System.Drawing.Size(100, 20);
            this.txt_SF_Desde.TabIndex = 0;
            // 
            // rv01_Fijos
            // 
            this.rv01_Fijos.Location = new System.Drawing.Point(-5, 152);
            this.rv01_Fijos.Name = "rv01_Fijos";
            this.rv01_Fijos.ServerReport.BearerToken = null;
            this.rv01_Fijos.Size = new System.Drawing.Size(776, 265);
            this.rv01_Fijos.TabIndex = 4;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Controls.Add(this.rv02);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(756, 423);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Servicios Prepagos Ofrecidos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rb02_Prepagos_Tipo);
            this.groupBox4.Controls.Add(this.rb01_Prepagos_Tipo);
            this.groupBox4.Location = new System.Drawing.Point(453, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(112, 77);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tipo de filtro";
            // 
            // rb02_Prepagos_Tipo
            // 
            this.rb02_Prepagos_Tipo.AutoSize = true;
            this.rb02_Prepagos_Tipo.Location = new System.Drawing.Point(6, 43);
            this.rb02_Prepagos_Tipo.Name = "rb02_Prepagos_Tipo";
            this.rb02_Prepagos_Tipo.Size = new System.Drawing.Size(109, 17);
            this.rb02_Prepagos_Tipo.TabIndex = 1;
            this.rb02_Prepagos_Tipo.Text = "Filtro por duracion";
            this.rb02_Prepagos_Tipo.UseVisualStyleBackColor = true;
            // 
            // rb01_Prepagos_Tipo
            // 
            this.rb01_Prepagos_Tipo.AutoSize = true;
            this.rb01_Prepagos_Tipo.Checked = true;
            this.rb01_Prepagos_Tipo.Location = new System.Drawing.Point(7, 20);
            this.rb01_Prepagos_Tipo.Name = "rb01_Prepagos_Tipo";
            this.rb01_Prepagos_Tipo.Size = new System.Drawing.Size(97, 17);
            this.rb01_Prepagos_Tipo.TabIndex = 0;
            this.rb01_Prepagos_Tipo.TabStop = true;
            this.rb01_Prepagos_Tipo.Text = "Filtro por precio";
            this.rb01_Prepagos_Tipo.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txt_SP_hasta);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txt_SP_desde);
            this.groupBox5.Controls.Add(this.btn_calcular_prepago);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(412, 144);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hasta";
            // 
            // txt_SP_hasta
            // 
            this.txt_SP_hasta.Location = new System.Drawing.Point(51, 58);
            this.txt_SP_hasta.Name = "txt_SP_hasta";
            this.txt_SP_hasta.Pp_Campo = null;
            this.txt_SP_hasta.Pp_MensajeError = null;
            this.txt_SP_hasta.Pp_Tabla = null;
            this.txt_SP_hasta.Pp_Validable = false;
            this.txt_SP_hasta.Size = new System.Drawing.Size(100, 20);
            this.txt_SP_hasta.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Desde";
            // 
            // txt_SP_desde
            // 
            this.txt_SP_desde.Location = new System.Drawing.Point(51, 32);
            this.txt_SP_desde.Name = "txt_SP_desde";
            this.txt_SP_desde.Pp_Campo = null;
            this.txt_SP_desde.Pp_MensajeError = null;
            this.txt_SP_desde.Pp_Tabla = null;
            this.txt_SP_desde.Pp_Validable = false;
            this.txt_SP_desde.Size = new System.Drawing.Size(100, 20);
            this.txt_SP_desde.TabIndex = 7;
            // 
            // btn_calcular_prepago
            // 
            this.btn_calcular_prepago.Location = new System.Drawing.Point(318, 96);
            this.btn_calcular_prepago.Name = "btn_calcular_prepago";
            this.btn_calcular_prepago.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular_prepago.TabIndex = 3;
            this.btn_calcular_prepago.Text = "Calcular";
            this.btn_calcular_prepago.UseVisualStyleBackColor = true;
            this.btn_calcular_prepago.Click += new System.EventHandler(this.btn_calcular_prepago_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rb03_Prepagos);
            this.groupBox6.Controls.Add(this.rb02_Prepagos);
            this.groupBox6.Location = new System.Drawing.Point(183, 32);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(100, 87);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tipo de Calculo";
            // 
            // rb03_Prepagos
            // 
            this.rb03_Prepagos.AutoSize = true;
            this.rb03_Prepagos.Checked = true;
            this.rb03_Prepagos.Location = new System.Drawing.Point(6, 55);
            this.rb03_Prepagos.Name = "rb03_Prepagos";
            this.rb03_Prepagos.Size = new System.Drawing.Size(55, 17);
            this.rb03_Prepagos.TabIndex = 2;
            this.rb03_Prepagos.TabStop = true;
            this.rb03_Prepagos.Text = "Todos";
            this.rb03_Prepagos.UseVisualStyleBackColor = true;
            // 
            // rb02_Prepagos
            // 
            this.rb02_Prepagos.AutoSize = true;
            this.rb02_Prepagos.Location = new System.Drawing.Point(6, 32);
            this.rb02_Prepagos.Name = "rb02_Prepagos";
            this.rb02_Prepagos.Size = new System.Drawing.Size(47, 17);
            this.rb02_Prepagos.TabIndex = 1;
            this.rb02_Prepagos.Text = "Filtro";
            this.rb02_Prepagos.UseVisualStyleBackColor = true;
            // 
            // rv02
            // 
            this.rv02.Location = new System.Drawing.Point(0, 163);
            this.rv02.Name = "rv02";
            this.rv02.ServerReport.BearerToken = null;
            this.rv02.Size = new System.Drawing.Size(750, 257);
            this.rv02.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(692, 458);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_desde
            // 
            this.txt_desde.Enabled = false;
            this.txt_desde.Location = new System.Drawing.Point(476, 47);
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Pp_Campo = null;
            this.txt_desde.Pp_MensajeError = null;
            this.txt_desde.Pp_Tabla = null;
            this.txt_desde.Pp_Validable = false;
            this.txt_desde.Size = new System.Drawing.Size(50, 20);
            this.txt_desde.TabIndex = 9;
            // 
            // txt_hasta
            // 
            this.txt_hasta.Enabled = false;
            this.txt_hasta.Location = new System.Drawing.Point(547, 47);
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Pp_Campo = null;
            this.txt_hasta.Pp_MensajeError = null;
            this.txt_hasta.Pp_Tabla = null;
            this.txt_hasta.Pp_Validable = false;
            this.txt_hasta.Size = new System.Drawing.Size(50, 20);
            this.txt_hasta.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(373, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Rango de precios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(532, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "/";
            // 
            // ReporteServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 493);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tabControl1);
            this.Name = "ReporteServicios";
            this.Text = "ReporteServicios";
            this.Load += new System.EventHandler(this.ReporteServicios_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gr_tipo.ResumeLayout(false);
            this.gr_tipo.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer rv_Fijos;
        private System.Windows.Forms.Label label2;
        private Clases.TextBox01 txt_cliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_todos;
        private System.Windows.Forms.RadioButton rb_num;
        private System.Windows.Forms.RadioButton rb_cliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btn_Calcular_Datos;
        private Clases.TextBox01 txt_limite;
        private Clases.TextBox01 txt_costo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_todos1;
        private System.Windows.Forms.RadioButton rb_limite;
        private System.Windows.Forms.RadioButton rb_Costo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Calcular_Fijos;
        private System.Windows.Forms.GroupBox gr_tipo;
        private System.Windows.Forms.RadioButton rb03_Fijos;
        private System.Windows.Forms.RadioButton rb02_Fijos;
        private Microsoft.Reporting.WinForms.ReportViewer rv01_Fijos;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rb02_Prepagos_Tipo;
        private System.Windows.Forms.RadioButton rb01_Prepagos_Tipo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_calcular_prepago;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rb03_Prepagos;
        private System.Windows.Forms.RadioButton rb02_Prepagos;
        private Microsoft.Reporting.WinForms.ReportViewer rv02;
        private System.Windows.Forms.Label label7;
        private Clases.TextBox01 txt_SF_Hasta;
        private System.Windows.Forms.Label label5;
        private Clases.TextBox01 txt_SF_Desde;
        private System.Windows.Forms.Label label6;
        private Clases.TextBox01 txt_SP_hasta;
        private System.Windows.Forms.Label label8;
        private Clases.TextBox01 txt_SP_desde;
        private Clases.TextBox01 txt_hasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private Clases.TextBox01 txt_desde;
    }
}