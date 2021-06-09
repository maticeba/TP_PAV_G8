
namespace ComunicAr.Formularios.Reportes.Clientes

{
    partial class Reporte_para_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte_para_Clientes));
            this.rv_cliente_clientes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_cliente_clientes_03 = new System.Windows.Forms.RadioButton();
            this.rb_cliente_clientes_02 = new System.Windows.Forms.RadioButton();
            this.rb_cliente_clientes_01 = new System.Windows.Forms.RadioButton();
            this.txt_reporte_cliente_letras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reporte_cliente_cargar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_reporte_clienteXmodelo_cargar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rv_cliente_clientesXtipoDispositivo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_calcular_prepago = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.rb_cantidad = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cmb_report_clienteXdispo_modeloDispo = new ComunicAr.Clases.ComboBox01();
            this.cmb_report_clienteXdispo_marcaDispo = new ComunicAr.Clases.ComboBox01();
            this.cmb_report_clienteXdispo_tipoDispo = new ComunicAr.Clases.ComboBox01();
            this.txt_cantidad = new ComunicAr.Clases.TextBox01();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // rv_cliente_clientes
            // 
            this.rv_cliente_clientes.Location = new System.Drawing.Point(9, 155);
            this.rv_cliente_clientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rv_cliente_clientes.Name = "rv_cliente_clientes";
            this.rv_cliente_clientes.ServerReport.BearerToken = null;
            this.rv_cliente_clientes.Size = new System.Drawing.Size(1132, 573);
            this.rv_cliente_clientes.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(20, 20);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1162, 778);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.txt_reporte_cliente_letras);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_reporte_cliente_cargar);
            this.tabPage1.Controls.Add(this.rv_cliente_clientes);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1154, 745);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado de Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_cliente_clientes_03);
            this.groupBox1.Controls.Add(this.rb_cliente_clientes_02);
            this.groupBox1.Controls.Add(this.rb_cliente_clientes_01);
            this.groupBox1.Location = new System.Drawing.Point(185, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(290, 137);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Cálculo";
            // 
            // rb_cliente_clientes_03
            // 
            this.rb_cliente_clientes_03.AutoSize = true;
            this.rb_cliente_clientes_03.Location = new System.Drawing.Point(10, 100);
            this.rb_cliente_clientes_03.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_cliente_clientes_03.Name = "rb_cliente_clientes_03";
            this.rb_cliente_clientes_03.Size = new System.Drawing.Size(166, 24);
            this.rb_cliente_clientes_03.TabIndex = 1;
            this.rb_cliente_clientes_03.TabStop = true;
            this.rb_cliente_clientes_03.Text = "Todos los usuarios";
            this.rb_cliente_clientes_03.UseVisualStyleBackColor = true;
            // 
            // rb_cliente_clientes_02
            // 
            this.rb_cliente_clientes_02.AutoSize = true;
            this.rb_cliente_clientes_02.Location = new System.Drawing.Point(10, 65);
            this.rb_cliente_clientes_02.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_cliente_clientes_02.Name = "rb_cliente_clientes_02";
            this.rb_cliente_clientes_02.Size = new System.Drawing.Size(186, 24);
            this.rb_cliente_clientes_02.TabIndex = 1;
            this.rb_cliente_clientes_02.TabStop = true;
            this.rb_cliente_clientes_02.Text = "Que contenga la letra";
            this.rb_cliente_clientes_02.UseVisualStyleBackColor = true;
            // 
            // rb_cliente_clientes_01
            // 
            this.rb_cliente_clientes_01.AutoSize = true;
            this.rb_cliente_clientes_01.Location = new System.Drawing.Point(10, 29);
            this.rb_cliente_clientes_01.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_cliente_clientes_01.Name = "rb_cliente_clientes_01";
            this.rb_cliente_clientes_01.Size = new System.Drawing.Size(262, 24);
            this.rb_cliente_clientes_01.TabIndex = 0;
            this.rb_cliente_clientes_01.TabStop = true;
            this.rb_cliente_clientes_01.Text = "Que el nombre inicie con la letra:";
            this.rb_cliente_clientes_01.UseVisualStyleBackColor = true;
            // 
            // txt_reporte_cliente_letras
            // 
            this.txt_reporte_cliente_letras.Location = new System.Drawing.Point(527, 37);
            this.txt_reporte_cliente_letras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_reporte_cliente_letras.Name = "txt_reporte_cliente_letras";
            this.txt_reporte_cliente_letras.Size = new System.Drawing.Size(127, 26);
            this.txt_reporte_cliente_letras.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(662, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Letra/s";
            // 
            // btn_reporte_cliente_cargar
            // 
            this.btn_reporte_cliente_cargar.Location = new System.Drawing.Point(1029, 105);
            this.btn_reporte_cliente_cargar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_reporte_cliente_cargar.Name = "btn_reporte_cliente_cargar";
            this.btn_reporte_cliente_cargar.Size = new System.Drawing.Size(112, 35);
            this.btn_reporte_cliente_cargar.TabIndex = 2;
            this.btn_reporte_cliente_cargar.Text = "Cargar";
            this.btn_reporte_cliente_cargar.UseVisualStyleBackColor = true;
            this.btn_reporte_cliente_cargar.Click += new System.EventHandler(this.btn_reporte_cliente_cargar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.btn_reporte_clienteXmodelo_cargar);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cmb_report_clienteXdispo_modeloDispo);
            this.tabPage2.Controls.Add(this.cmb_report_clienteXdispo_marcaDispo);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cmb_report_clienteXdispo_tipoDispo);
            this.tabPage2.Controls.Add(this.rv_cliente_clientesXtipoDispositivo);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1154, 745);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clientes por dispositivo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_reporte_clienteXmodelo_cargar
            // 
            this.btn_reporte_clienteXmodelo_cargar.Location = new System.Drawing.Point(1009, 104);
            this.btn_reporte_clienteXmodelo_cargar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_reporte_clienteXmodelo_cargar.Name = "btn_reporte_clienteXmodelo_cargar";
            this.btn_reporte_clienteXmodelo_cargar.Size = new System.Drawing.Size(132, 35);
            this.btn_reporte_clienteXmodelo_cargar.TabIndex = 7;
            this.btn_reporte_clienteXmodelo_cargar.Text = "Cargar Lista";
            this.btn_reporte_clienteXmodelo_cargar.UseVisualStyleBackColor = true;
            this.btn_reporte_clienteXmodelo_cargar.Click += new System.EventHandler(this.btn_reporte_clienteXmodelo_cargar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Modelo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marca Dispositivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de Dispositivo";
            // 
            // rv_cliente_clientesXtipoDispositivo
            // 
            this.rv_cliente_clientesXtipoDispositivo.Location = new System.Drawing.Point(9, 155);
            this.rv_cliente_clientesXtipoDispositivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rv_cliente_clientesXtipoDispositivo.Name = "rv_cliente_clientesXtipoDispositivo";
            this.rv_cliente_clientesXtipoDispositivo.ServerReport.BearerToken = null;
            this.rv_cliente_clientesXtipoDispositivo.Size = new System.Drawing.Size(1132, 573);
            this.rv_cliente_clientesXtipoDispositivo.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.pictureBox3);
            this.tabPage5.Controls.Add(this.reportViewer1);
            this.tabPage5.Controls.Add(this.btn_calcular_prepago);
            this.tabPage5.Controls.Add(this.groupBox2);
            this.tabPage5.Controls.Add(this.txt_cantidad);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1154, 745);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Clientes Prepago";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(6, 143);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1116, 577);
            this.reportViewer1.TabIndex = 12;
            // 
            // btn_calcular_prepago
            // 
            this.btn_calcular_prepago.Location = new System.Drawing.Point(1007, 101);
            this.btn_calcular_prepago.Name = "btn_calcular_prepago";
            this.btn_calcular_prepago.Size = new System.Drawing.Size(115, 34);
            this.btn_calcular_prepago.TabIndex = 11;
            this.btn_calcular_prepago.Text = "Calcular";
            this.btn_calcular_prepago.UseVisualStyleBackColor = true;
            this.btn_calcular_prepago.Click += new System.EventHandler(this.btn_calcular_prepago_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_todos);
            this.groupBox2.Controls.Add(this.rb_cantidad);
            this.groupBox2.Location = new System.Drawing.Point(183, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(311, 118);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Location = new System.Drawing.Point(9, 71);
            this.rb_todos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(82, 24);
            this.rb_todos.TabIndex = 2;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "Todos:";
            this.rb_todos.UseVisualStyleBackColor = true;
            this.rb_todos.CheckedChanged += new System.EventHandler(this.rb_todos_CheckedChanged);
            // 
            // rb_cantidad
            // 
            this.rb_cantidad.AutoSize = true;
            this.rb_cantidad.Location = new System.Drawing.Point(9, 29);
            this.rb_cantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_cantidad.Name = "rb_cantidad";
            this.rb_cantidad.Size = new System.Drawing.Size(288, 24);
            this.rb_cantidad.TabIndex = 1;
            this.rb_cantidad.TabStop = true;
            this.rb_cantidad.Text = "Cantidad de prepagos contratados: ";
            this.rb_cantidad.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 127);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.ErrorImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(7, 8);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(168, 127);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // cmb_report_clienteXdispo_modeloDispo
            // 
            this.cmb_report_clienteXdispo_modeloDispo.FormattingEnabled = true;
            this.cmb_report_clienteXdispo_modeloDispo.Location = new System.Drawing.Point(359, 104);
            this.cmb_report_clienteXdispo_modeloDispo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_report_clienteXdispo_modeloDispo.Name = "cmb_report_clienteXdispo_modeloDispo";
            this.cmb_report_clienteXdispo_modeloDispo.Pp_Conseleccion = false;
            this.cmb_report_clienteXdispo_modeloDispo.Pp_Descripcion = "modelo";
            this.cmb_report_clienteXdispo_modeloDispo.Pp_MensajeError = null;
            this.cmb_report_clienteXdispo_modeloDispo.Pp_NombreCampo = null;
            this.cmb_report_clienteXdispo_modeloDispo.Pp_NombreTabla = null;
            this.cmb_report_clienteXdispo_modeloDispo.Pp_PK = "id_dispositivo";
            this.cmb_report_clienteXdispo_modeloDispo.Pp_Tabla = "Dispositivos";
            this.cmb_report_clienteXdispo_modeloDispo.Pp_Validable = false;
            this.cmb_report_clienteXdispo_modeloDispo.Size = new System.Drawing.Size(236, 28);
            this.cmb_report_clienteXdispo_modeloDispo.TabIndex = 5;
            // 
            // cmb_report_clienteXdispo_marcaDispo
            // 
            this.cmb_report_clienteXdispo_marcaDispo.FormattingEnabled = true;
            this.cmb_report_clienteXdispo_marcaDispo.Location = new System.Drawing.Point(359, 66);
            this.cmb_report_clienteXdispo_marcaDispo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_report_clienteXdispo_marcaDispo.Name = "cmb_report_clienteXdispo_marcaDispo";
            this.cmb_report_clienteXdispo_marcaDispo.Pp_Conseleccion = false;
            this.cmb_report_clienteXdispo_marcaDispo.Pp_Descripcion = "marca";
            this.cmb_report_clienteXdispo_marcaDispo.Pp_MensajeError = null;
            this.cmb_report_clienteXdispo_marcaDispo.Pp_NombreCampo = null;
            this.cmb_report_clienteXdispo_marcaDispo.Pp_NombreTabla = null;
            this.cmb_report_clienteXdispo_marcaDispo.Pp_PK = "marca";
            this.cmb_report_clienteXdispo_marcaDispo.Pp_Tabla = "Dispositivos";
            this.cmb_report_clienteXdispo_marcaDispo.Pp_Validable = false;
            this.cmb_report_clienteXdispo_marcaDispo.Size = new System.Drawing.Size(236, 28);
            this.cmb_report_clienteXdispo_marcaDispo.TabIndex = 4;
            this.cmb_report_clienteXdispo_marcaDispo.SelectedIndexChanged += new System.EventHandler(this.cmb_report_clienteXdispo_marcaDispo_SelectedIndexChanged);
            // 
            // cmb_report_clienteXdispo_tipoDispo
            // 
            this.cmb_report_clienteXdispo_tipoDispo.FormattingEnabled = true;
            this.cmb_report_clienteXdispo_tipoDispo.Location = new System.Drawing.Point(359, 28);
            this.cmb_report_clienteXdispo_tipoDispo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_report_clienteXdispo_tipoDispo.Name = "cmb_report_clienteXdispo_tipoDispo";
            this.cmb_report_clienteXdispo_tipoDispo.Pp_Conseleccion = false;
            this.cmb_report_clienteXdispo_tipoDispo.Pp_Descripcion = "nombre_tipo";
            this.cmb_report_clienteXdispo_tipoDispo.Pp_MensajeError = null;
            this.cmb_report_clienteXdispo_tipoDispo.Pp_NombreCampo = null;
            this.cmb_report_clienteXdispo_tipoDispo.Pp_NombreTabla = null;
            this.cmb_report_clienteXdispo_tipoDispo.Pp_PK = "id_tipo_dispositivo";
            this.cmb_report_clienteXdispo_tipoDispo.Pp_Tabla = "Tipo_dispositivo";
            this.cmb_report_clienteXdispo_tipoDispo.Pp_Validable = false;
            this.cmb_report_clienteXdispo_tipoDispo.Size = new System.Drawing.Size(236, 28);
            this.cmb_report_clienteXdispo_tipoDispo.TabIndex = 1;
            this.cmb_report_clienteXdispo_tipoDispo.SelectedIndexChanged += new System.EventHandler(this.cmb_report_clienteXdispo_tipoDispo_SelectedIndexChanged);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(501, 37);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Pp_Campo = null;
            this.txt_cantidad.Pp_MensajeError = null;
            this.txt_cantidad.Pp_Tabla = null;
            this.txt_cantidad.Pp_Validable = false;
            this.txt_cantidad.Size = new System.Drawing.Size(144, 26);
            this.txt_cantidad.TabIndex = 10;
            // 
            // Reporte_para_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 817);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Reporte_para_Clientes";
            this.Text = "Reporte_para_Clientes";
            this.Load += new System.EventHandler(this.Reporte_para_Clientes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_cliente_clientes;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_reporte_cliente_cargar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_cliente_clientes_03;
        private System.Windows.Forms.RadioButton rb_cliente_clientes_02;
        private System.Windows.Forms.RadioButton rb_cliente_clientes_01;
        private System.Windows.Forms.TextBox txt_reporte_cliente_letras;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer rv_cliente_clientesXtipoDispositivo;
        private System.Windows.Forms.Label label2;
        private Clases.ComboBox01 cmb_report_clienteXdispo_tipoDispo;
        private Clases.ComboBox01 cmb_report_clienteXdispo_marcaDispo;
        private System.Windows.Forms.Label label3;
        private Clases.ComboBox01 cmb_report_clienteXdispo_modeloDispo;
        private System.Windows.Forms.Button btn_reporte_clienteXmodelo_cargar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_todos;
        private System.Windows.Forms.RadioButton rb_cantidad;
        private Clases.TextBox01 txt_cantidad;
        private System.Windows.Forms.Button btn_calcular_prepago;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}