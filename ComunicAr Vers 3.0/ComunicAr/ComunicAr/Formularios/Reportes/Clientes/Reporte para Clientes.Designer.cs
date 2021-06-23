
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_reporte_clienteXmodelo_cargar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_report_clienteXdispo_modeloDispo = new ComunicAr.Clases.ComboBox01();
            this.cmb_report_clienteXdispo_marcaDispo = new ComunicAr.Clases.ComboBox01();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_report_clienteXdispo_tipoDispo = new ComunicAr.Clases.ComboBox01();
            this.rv_cliente_clientesXtipoDispositivo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_cliente_clientes_03 = new System.Windows.Forms.RadioButton();
            this.rb_cliente_clientes_02 = new System.Windows.Forms.RadioButton();
            this.rb_cliente_clientes_01 = new System.Windows.Forms.RadioButton();
            this.txt_reporte_cliente_letras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reporte_cliente_cargar = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_calcular_prepago = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.rb_cantidad = new System.Windows.Forms.RadioButton();
            this.txt_cantidad = new ComunicAr.Clases.TextBox01();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rv_cliente_clientes
            // 
            this.rv_cliente_clientes.Location = new System.Drawing.Point(6, 101);
            this.rv_cliente_clientes.Name = "rv_cliente_clientes";
            this.rv_cliente_clientes.ServerReport.BearerToken = null;
            this.rv_cliente_clientes.Size = new System.Drawing.Size(755, 373);
            this.rv_cliente_clientes.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 506);
            this.tabControl1.TabIndex = 1;
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(767, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clientes por dispositivo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btn_reporte_clienteXmodelo_cargar
            // 
            this.btn_reporte_clienteXmodelo_cargar.Location = new System.Drawing.Point(673, 68);
            this.btn_reporte_clienteXmodelo_cargar.Name = "btn_reporte_clienteXmodelo_cargar";
            this.btn_reporte_clienteXmodelo_cargar.Size = new System.Drawing.Size(88, 23);
            this.btn_reporte_clienteXmodelo_cargar.TabIndex = 7;
            this.btn_reporte_clienteXmodelo_cargar.Text = "Cargar Lista";
            this.btn_reporte_clienteXmodelo_cargar.UseVisualStyleBackColor = true;
            this.btn_reporte_clienteXmodelo_cargar.Click += new System.EventHandler(this.btn_reporte_clienteXmodelo_cargar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Modelo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmb_report_clienteXdispo_modeloDispo
            // 
            this.cmb_report_clienteXdispo_modeloDispo.FormattingEnabled = true;
            this.cmb_report_clienteXdispo_modeloDispo.Location = new System.Drawing.Point(298, 68);
            this.cmb_report_clienteXdispo_modeloDispo.Name = "cmb_report_clienteXdispo_modeloDispo";
            this.cmb_report_clienteXdispo_modeloDispo.Pp_Conseleccion = false;
            this.cmb_report_clienteXdispo_modeloDispo.Pp_Descripcion = "modelo";
            this.cmb_report_clienteXdispo_modeloDispo.Pp_MensajeError = null;
            this.cmb_report_clienteXdispo_modeloDispo.Pp_NombreCampo = null;
            this.cmb_report_clienteXdispo_modeloDispo.Pp_NombreTabla = null;
            this.cmb_report_clienteXdispo_modeloDispo.Pp_PK = "id_dispositivo";
            this.cmb_report_clienteXdispo_modeloDispo.Pp_Tabla = "Dispositivos";
            this.cmb_report_clienteXdispo_modeloDispo.Pp_Validable = false;
            this.cmb_report_clienteXdispo_modeloDispo.Size = new System.Drawing.Size(159, 21);
            this.cmb_report_clienteXdispo_modeloDispo.TabIndex = 5;
            // 
            // cmb_report_clienteXdispo_marcaDispo
            // 
            this.cmb_report_clienteXdispo_marcaDispo.FormattingEnabled = true;
            this.cmb_report_clienteXdispo_marcaDispo.Location = new System.Drawing.Point(298, 43);
            this.cmb_report_clienteXdispo_marcaDispo.Name = "cmb_report_clienteXdispo_marcaDispo";
            this.cmb_report_clienteXdispo_marcaDispo.Pp_Conseleccion = false;
            this.cmb_report_clienteXdispo_marcaDispo.Pp_Descripcion = "marca";
            this.cmb_report_clienteXdispo_marcaDispo.Pp_MensajeError = null;
            this.cmb_report_clienteXdispo_marcaDispo.Pp_NombreCampo = null;
            this.cmb_report_clienteXdispo_marcaDispo.Pp_NombreTabla = null;
            this.cmb_report_clienteXdispo_marcaDispo.Pp_PK = "marca";
            this.cmb_report_clienteXdispo_marcaDispo.Pp_Tabla = "Dispositivos";
            this.cmb_report_clienteXdispo_marcaDispo.Pp_Validable = false;
            this.cmb_report_clienteXdispo_marcaDispo.Size = new System.Drawing.Size(159, 21);
            this.cmb_report_clienteXdispo_marcaDispo.TabIndex = 4;
            this.cmb_report_clienteXdispo_marcaDispo.SelectedIndexChanged += new System.EventHandler(this.cmb_report_clienteXdispo_marcaDispo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marca Dispositivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de Dispositivo";
            // 
            // cmb_report_clienteXdispo_tipoDispo
            // 
            this.cmb_report_clienteXdispo_tipoDispo.FormattingEnabled = true;
            this.cmb_report_clienteXdispo_tipoDispo.Location = new System.Drawing.Point(298, 18);
            this.cmb_report_clienteXdispo_tipoDispo.Name = "cmb_report_clienteXdispo_tipoDispo";
            this.cmb_report_clienteXdispo_tipoDispo.Pp_Conseleccion = false;
            this.cmb_report_clienteXdispo_tipoDispo.Pp_Descripcion = "nombre_tipo";
            this.cmb_report_clienteXdispo_tipoDispo.Pp_MensajeError = null;
            this.cmb_report_clienteXdispo_tipoDispo.Pp_NombreCampo = null;
            this.cmb_report_clienteXdispo_tipoDispo.Pp_NombreTabla = null;
            this.cmb_report_clienteXdispo_tipoDispo.Pp_PK = "id_tipo_dispositivo";
            this.cmb_report_clienteXdispo_tipoDispo.Pp_Tabla = "Tipo_dispositivo";
            this.cmb_report_clienteXdispo_tipoDispo.Pp_Validable = false;
            this.cmb_report_clienteXdispo_tipoDispo.Size = new System.Drawing.Size(159, 21);
            this.cmb_report_clienteXdispo_tipoDispo.TabIndex = 1;
            this.cmb_report_clienteXdispo_tipoDispo.SelectedIndexChanged += new System.EventHandler(this.cmb_report_clienteXdispo_tipoDispo_SelectedIndexChanged);
            // 
            // rv_cliente_clientesXtipoDispositivo
            // 
            this.rv_cliente_clientesXtipoDispositivo.Location = new System.Drawing.Point(6, 101);
            this.rv_cliente_clientesXtipoDispositivo.Name = "rv_cliente_clientesXtipoDispositivo";
            this.rv_cliente_clientesXtipoDispositivo.ServerReport.BearerToken = null;
            this.rv_cliente_clientesXtipoDispositivo.Size = new System.Drawing.Size(755, 373);
            this.rv_cliente_clientesXtipoDispositivo.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.txt_reporte_cliente_letras);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_reporte_cliente_cargar);
            this.tabPage1.Controls.Add(this.rv_cliente_clientes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(767, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado de Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_cliente_clientes_03);
            this.groupBox1.Controls.Add(this.rb_cliente_clientes_02);
            this.groupBox1.Controls.Add(this.rb_cliente_clientes_01);
            this.groupBox1.Location = new System.Drawing.Point(185, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 89);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Cálculo";
            // 
            // rb_cliente_clientes_03
            // 
            this.rb_cliente_clientes_03.AutoSize = true;
            this.rb_cliente_clientes_03.Location = new System.Drawing.Point(7, 65);
            this.rb_cliente_clientes_03.Name = "rb_cliente_clientes_03";
            this.rb_cliente_clientes_03.Size = new System.Drawing.Size(113, 17);
            this.rb_cliente_clientes_03.TabIndex = 1;
            this.rb_cliente_clientes_03.TabStop = true;
            this.rb_cliente_clientes_03.Text = "Todos los usuarios";
            this.rb_cliente_clientes_03.UseVisualStyleBackColor = true;
            // 
            // rb_cliente_clientes_02
            // 
            this.rb_cliente_clientes_02.AutoSize = true;
            this.rb_cliente_clientes_02.Location = new System.Drawing.Point(7, 42);
            this.rb_cliente_clientes_02.Name = "rb_cliente_clientes_02";
            this.rb_cliente_clientes_02.Size = new System.Drawing.Size(127, 17);
            this.rb_cliente_clientes_02.TabIndex = 1;
            this.rb_cliente_clientes_02.TabStop = true;
            this.rb_cliente_clientes_02.Text = "Que contenga la letra";
            this.rb_cliente_clientes_02.UseVisualStyleBackColor = true;
            // 
            // rb_cliente_clientes_01
            // 
            this.rb_cliente_clientes_01.AutoSize = true;
            this.rb_cliente_clientes_01.Location = new System.Drawing.Point(7, 19);
            this.rb_cliente_clientes_01.Name = "rb_cliente_clientes_01";
            this.rb_cliente_clientes_01.Size = new System.Drawing.Size(179, 17);
            this.rb_cliente_clientes_01.TabIndex = 0;
            this.rb_cliente_clientes_01.TabStop = true;
            this.rb_cliente_clientes_01.Text = "Que el nombre inicie con la letra:";
            this.rb_cliente_clientes_01.UseVisualStyleBackColor = true;
            // 
            // txt_reporte_cliente_letras
            // 
            this.txt_reporte_cliente_letras.Location = new System.Drawing.Point(413, 21);
            this.txt_reporte_cliente_letras.Name = "txt_reporte_cliente_letras";
            this.txt_reporte_cliente_letras.Size = new System.Drawing.Size(86, 20);
            this.txt_reporte_cliente_letras.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Letra/s";
            // 
            // btn_reporte_cliente_cargar
            // 
            this.btn_reporte_cliente_cargar.Location = new System.Drawing.Point(686, 68);
            this.btn_reporte_cliente_cargar.Name = "btn_reporte_cliente_cargar";
            this.btn_reporte_cliente_cargar.Size = new System.Drawing.Size(75, 23);
            this.btn_reporte_cliente_cargar.TabIndex = 2;
            this.btn_reporte_cliente_cargar.Text = "Cargar";
            this.btn_reporte_cliente_cargar.UseVisualStyleBackColor = true;
            this.btn_reporte_cliente_cargar.Click += new System.EventHandler(this.btn_reporte_cliente_cargar_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.pictureBox3);
            this.tabPage5.Controls.Add(this.reportViewer1);
            this.tabPage5.Controls.Add(this.btn_calcular_prepago);
            this.tabPage5.Controls.Add(this.groupBox2);
            this.tabPage5.Controls.Add(this.txt_cantidad);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage5.Size = new System.Drawing.Size(767, 480);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Clientes Prepago";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.ErrorImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(112, 83);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(4, 93);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(745, 376);
            this.reportViewer1.TabIndex = 12;
            // 
            // btn_calcular_prepago
            // 
            this.btn_calcular_prepago.Location = new System.Drawing.Point(671, 66);
            this.btn_calcular_prepago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_calcular_prepago.Name = "btn_calcular_prepago";
            this.btn_calcular_prepago.Size = new System.Drawing.Size(77, 22);
            this.btn_calcular_prepago.TabIndex = 11;
            this.btn_calcular_prepago.Text = "Calcular";
            this.btn_calcular_prepago.UseVisualStyleBackColor = true;
            this.btn_calcular_prepago.Click += new System.EventHandler(this.btn_calcular_prepago_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_todos);
            this.groupBox2.Controls.Add(this.rb_cantidad);
            this.groupBox2.Location = new System.Drawing.Point(190, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 77);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Location = new System.Drawing.Point(6, 46);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(58, 17);
            this.rb_todos.TabIndex = 2;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "Todos:";
            this.rb_todos.UseVisualStyleBackColor = true;
            this.rb_todos.CheckedChanged += new System.EventHandler(this.rb_todos_CheckedChanged);
            // 
            // rb_cantidad
            // 
            this.rb_cantidad.AutoSize = true;
            this.rb_cantidad.Location = new System.Drawing.Point(6, 19);
            this.rb_cantidad.Name = "rb_cantidad";
            this.rb_cantidad.Size = new System.Drawing.Size(194, 17);
            this.rb_cantidad.TabIndex = 1;
            this.rb_cantidad.TabStop = true;
            this.rb_cantidad.Text = "Cantidad de prepagos contratados: ";
            this.rb_cantidad.UseVisualStyleBackColor = true;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(402, 24);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Pp_Campo = null;
            this.txt_cantidad.Pp_MensajeError = null;
            this.txt_cantidad.Pp_Tabla = null;
            this.txt_cantidad.Pp_Validable = false;
            this.txt_cantidad.Size = new System.Drawing.Size(97, 20);
            this.txt_cantidad.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reporte_para_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 560);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Reporte_para_Clientes";
            this.Text = "Reporte_para_Clientes";
            this.Load += new System.EventHandler(this.Reporte_para_Clientes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button button1;
    }
}