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
            this.cmb_numeros = new ComunicAr.Clases.ComboBox02();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Calcular_Fijos = new System.Windows.Forms.Button();
            this.gr_tipo = new System.Windows.Forms.GroupBox();
            this.rb03_Fijos = new System.Windows.Forms.RadioButton();
            this.rb02_Fijos = new System.Windows.Forms.RadioButton();
            this.rb01_Fijos = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumero_Fijo = new ComunicAr.Clases.TextBox01();
            this.rv01_Fijos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rb02_Prepagos_Tipo = new System.Windows.Forms.RadioButton();
            this.rb01_Prepagos_Tipo = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_calcular_prepago = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rb03_Prepagos = new System.Windows.Forms.RadioButton();
            this.rb02_Prepagos = new System.Windows.Forms.RadioButton();
            this.rb01_Prepagos = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_num_prepago = new ComunicAr.Clases.TextBox01();
            this.rv02 = new Microsoft.Reporting.WinForms.ReportViewer();
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
            this.tabPage1.Controls.Add(this.btn_calc);
            this.tabPage1.Controls.Add(this.btn_buscar);
            this.tabPage1.Controls.Add(this.rv_Fijos);
            this.tabPage1.Controls.Add(this.cmb_numeros);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
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
            this.btn_calc.Location = new System.Drawing.Point(685, 87);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_calc.TabIndex = 7;
            this.btn_calc.Text = "Calcular";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(584, 27);
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
            // cmb_numeros
            // 
            this.cmb_numeros.Enable = false;
            this.cmb_numeros.Enabled = false;
            this.cmb_numeros.FormattingEnabled = true;
            this.cmb_numeros.Location = new System.Drawing.Point(457, 66);
            this.cmb_numeros.Name = "cmb_numeros";
            this.cmb_numeros.Pp_Conseleccion = true;
            this.cmb_numeros.Pp_Descripcion1 = "cod_nacional";
            this.cmb_numeros.Pp_Descripcion2 = "cod_area";
            this.cmb_numeros.Pp_Descripcion3 = "nro_telefono";
            this.cmb_numeros.Pp_MensajeError = "No has seleccionado ningún teléfono emisor";
            this.cmb_numeros.Pp_NombreCampo = null;
            this.cmb_numeros.Pp_NombreTabla = null;
            this.cmb_numeros.Pp_PK1 = "id_numero";
            this.cmb_numeros.Pp_Tabla = "Numero";
            this.cmb_numeros.Pp_Validable = false;
            this.cmb_numeros.Size = new System.Drawing.Size(121, 21);
            this.cmb_numeros.TabIndex = 4;
            this.cmb_numeros.SelectedIndexChanged += new System.EventHandler(this.cmb_numeros_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID de Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero";
            // 
            // txt_cliente
            // 
            this.txt_cliente.Enabled = false;
            this.txt_cliente.Location = new System.Drawing.Point(457, 27);
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
            this.groupBox1.Size = new System.Drawing.Size(166, 90);
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
            this.rb_num.Size = new System.Drawing.Size(157, 17);
            this.rb_num.TabIndex = 0;
            this.rb_num.TabStop = true;
            this.rb_num.Text = "Servicios fijos de un numero";
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
            this.groupBox3.Controls.Add(this.btn_Calcular_Fijos);
            this.groupBox3.Controls.Add(this.gr_tipo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtNumero_Fijo);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(412, 129);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
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
            this.gr_tipo.Controls.Add(this.rb01_Fijos);
            this.gr_tipo.Location = new System.Drawing.Point(188, 11);
            this.gr_tipo.Name = "gr_tipo";
            this.gr_tipo.Size = new System.Drawing.Size(100, 100);
            this.gr_tipo.TabIndex = 2;
            this.gr_tipo.TabStop = false;
            this.gr_tipo.Text = "Tipo de Calculo";
            // 
            // rb03_Fijos
            // 
            this.rb03_Fijos.AutoSize = true;
            this.rb03_Fijos.Checked = true;
            this.rb03_Fijos.Location = new System.Drawing.Point(6, 77);
            this.rb03_Fijos.Name = "rb03_Fijos";
            this.rb03_Fijos.Size = new System.Drawing.Size(75, 17);
            this.rb03_Fijos.TabIndex = 2;
            this.rb03_Fijos.TabStop = true;
            this.rb03_Fijos.Text = "Indiferente";
            this.rb03_Fijos.UseVisualStyleBackColor = true;
            // 
            // rb02_Fijos
            // 
            this.rb02_Fijos.AutoSize = true;
            this.rb02_Fijos.Location = new System.Drawing.Point(6, 54);
            this.rb02_Fijos.Name = "rb02_Fijos";
            this.rb02_Fijos.Size = new System.Drawing.Size(66, 17);
            this.rb02_Fijos.TabIndex = 1;
            this.rb02_Fijos.Text = "Mayor a ";
            this.rb02_Fijos.UseVisualStyleBackColor = true;
            // 
            // rb01_Fijos
            // 
            this.rb01_Fijos.AutoSize = true;
            this.rb01_Fijos.Location = new System.Drawing.Point(6, 27);
            this.rb01_Fijos.Name = "rb01_Fijos";
            this.rb01_Fijos.Size = new System.Drawing.Size(67, 17);
            this.rb01_Fijos.TabIndex = 0;
            this.rb01_Fijos.Text = "Menor a ";
            this.rb01_Fijos.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Monto $";
            // 
            // txtNumero_Fijo
            // 
            this.txtNumero_Fijo.Location = new System.Drawing.Point(68, 19);
            this.txtNumero_Fijo.Name = "txtNumero_Fijo";
            this.txtNumero_Fijo.Pp_Campo = null;
            this.txtNumero_Fijo.Pp_MensajeError = null;
            this.txtNumero_Fijo.Pp_Tabla = null;
            this.txtNumero_Fijo.Pp_Validable = false;
            this.txtNumero_Fijo.Size = new System.Drawing.Size(100, 20);
            this.txtNumero_Fijo.TabIndex = 0;
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
            this.groupBox5.Controls.Add(this.btn_calcular_prepago);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txt_num_prepago);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(412, 144);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
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
            this.groupBox6.Controls.Add(this.rb01_Prepagos);
            this.groupBox6.Location = new System.Drawing.Point(184, 38);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(100, 100);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tipo de Calculo";
            // 
            // rb03_Prepagos
            // 
            this.rb03_Prepagos.AutoSize = true;
            this.rb03_Prepagos.Checked = true;
            this.rb03_Prepagos.Location = new System.Drawing.Point(6, 77);
            this.rb03_Prepagos.Name = "rb03_Prepagos";
            this.rb03_Prepagos.Size = new System.Drawing.Size(75, 17);
            this.rb03_Prepagos.TabIndex = 2;
            this.rb03_Prepagos.TabStop = true;
            this.rb03_Prepagos.Text = "Indiferente";
            this.rb03_Prepagos.UseVisualStyleBackColor = true;
            // 
            // rb02_Prepagos
            // 
            this.rb02_Prepagos.AutoSize = true;
            this.rb02_Prepagos.Location = new System.Drawing.Point(6, 54);
            this.rb02_Prepagos.Name = "rb02_Prepagos";
            this.rb02_Prepagos.Size = new System.Drawing.Size(66, 17);
            this.rb02_Prepagos.TabIndex = 1;
            this.rb02_Prepagos.Text = "Mayor a ";
            this.rb02_Prepagos.UseVisualStyleBackColor = true;
            // 
            // rb01_Prepagos
            // 
            this.rb01_Prepagos.AutoSize = true;
            this.rb01_Prepagos.Location = new System.Drawing.Point(6, 27);
            this.rb01_Prepagos.Name = "rb01_Prepagos";
            this.rb01_Prepagos.Size = new System.Drawing.Size(67, 17);
            this.rb01_Prepagos.TabIndex = 0;
            this.rb01_Prepagos.Text = "Menor a ";
            this.rb01_Prepagos.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Numero";
            // 
            // txt_num_prepago
            // 
            this.txt_num_prepago.Location = new System.Drawing.Point(68, 19);
            this.txt_num_prepago.Name = "txt_num_prepago";
            this.txt_num_prepago.Pp_Campo = null;
            this.txt_num_prepago.Pp_MensajeError = null;
            this.txt_num_prepago.Pp_Tabla = null;
            this.txt_num_prepago.Pp_Validable = false;
            this.txt_num_prepago.Size = new System.Drawing.Size(100, 20);
            this.txt_num_prepago.TabIndex = 0;
            // 
            // rv02
            // 
            this.rv02.Location = new System.Drawing.Point(0, 163);
            this.rv02.Name = "rv02";
            this.rv02.ServerReport.BearerToken = null;
            this.rv02.Size = new System.Drawing.Size(750, 257);
            this.rv02.TabIndex = 8;
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
        private Clases.ComboBox02 cmb_numeros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.RadioButton rb01_Fijos;
        private System.Windows.Forms.Label label5;
        private Clases.TextBox01 txtNumero_Fijo;
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
        private System.Windows.Forms.RadioButton rb01_Prepagos;
        private System.Windows.Forms.Label label6;
        private Clases.TextBox01 txt_num_prepago;
        private Microsoft.Reporting.WinForms.ReportViewer rv02;
    }
}