
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
            this.rv_cliente_clientesXtipoDispositivo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_report_clienteXdispo_modeloDispo = new ComunicAr.Clases.ComboBox01();
            this.cmb_report_clienteXdispo_marcaDispo = new ComunicAr.Clases.ComboBox01();
            this.cmb_report_clienteXdispo_tipoDispo = new ComunicAr.Clases.ComboBox01();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_reporte_clienteXmodelo_cargar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 506);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.txt_reporte_cliente_letras);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_reporte_cliente_cargar);
            this.tabPage1.Controls.Add(this.rv_cliente_clientes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado de Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_cliente_clientes_03);
            this.groupBox1.Controls.Add(this.rb_cliente_clientes_02);
            this.groupBox1.Controls.Add(this.rb_cliente_clientes_01);
            this.groupBox1.Location = new System.Drawing.Point(456, 6);
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
            this.rb_cliente_clientes_01.Size = new System.Drawing.Size(176, 17);
            this.rb_cliente_clientes_01.TabIndex = 0;
            this.rb_cliente_clientes_01.TabStop = true;
            this.rb_cliente_clientes_01.Text = "Que el nombre inicie con la letra";
            this.rb_cliente_clientes_01.UseVisualStyleBackColor = true;
            // 
            // txt_reporte_cliente_letras
            // 
            this.txt_reporte_cliente_letras.Location = new System.Drawing.Point(220, 24);
            this.txt_reporte_cliente_letras.Name = "txt_reporte_cliente_letras";
            this.txt_reporte_cliente_letras.Size = new System.Drawing.Size(86, 20);
            this.txt_reporte_cliente_letras.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Letra/s";
            // 
            // btn_reporte_cliente_cargar
            // 
            this.btn_reporte_cliente_cargar.Location = new System.Drawing.Point(655, 71);
            this.btn_reporte_cliente_cargar.Name = "btn_reporte_cliente_cargar";
            this.btn_reporte_cliente_cargar.Size = new System.Drawing.Size(75, 23);
            this.btn_reporte_cliente_cargar.TabIndex = 2;
            this.btn_reporte_cliente_cargar.Text = "Cargar";
            this.btn_reporte_cliente_cargar.UseVisualStyleBackColor = true;
            this.btn_reporte_cliente_cargar.Click += new System.EventHandler(this.btn_reporte_cliente_cargar_Click);
            // 
            // tabPage2
            // 
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
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clientes por dispositivo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rv_cliente_clientesXtipoDispositivo
            // 
            this.rv_cliente_clientesXtipoDispositivo.Location = new System.Drawing.Point(6, 101);
            this.rv_cliente_clientesXtipoDispositivo.Name = "rv_cliente_clientesXtipoDispositivo";
            this.rv_cliente_clientesXtipoDispositivo.ServerReport.BearerToken = null;
            this.rv_cliente_clientesXtipoDispositivo.Size = new System.Drawing.Size(755, 373);
            this.rv_cliente_clientesXtipoDispositivo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de Dispositivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marca Dispositivo";
            // 
            // cmb_report_clienteXdispo_modeloDispo
            // 
            this.cmb_report_clienteXdispo_modeloDispo.FormattingEnabled = true;
            this.cmb_report_clienteXdispo_modeloDispo.Location = new System.Drawing.Point(172, 71);
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
            this.cmb_report_clienteXdispo_marcaDispo.Location = new System.Drawing.Point(172, 44);
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
            // cmb_report_clienteXdispo_tipoDispo
            // 
            this.cmb_report_clienteXdispo_tipoDispo.FormattingEnabled = true;
            this.cmb_report_clienteXdispo_tipoDispo.Location = new System.Drawing.Point(172, 17);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Modelo";
            // 
            // btn_reporte_clienteXmodelo_cargar
            // 
            this.btn_reporte_clienteXmodelo_cargar.Location = new System.Drawing.Point(455, 42);
            this.btn_reporte_clienteXmodelo_cargar.Name = "btn_reporte_clienteXmodelo_cargar";
            this.btn_reporte_clienteXmodelo_cargar.Size = new System.Drawing.Size(88, 23);
            this.btn_reporte_clienteXmodelo_cargar.TabIndex = 7;
            this.btn_reporte_clienteXmodelo_cargar.Text = "Cargar Lista";
            this.btn_reporte_clienteXmodelo_cargar.UseVisualStyleBackColor = true;
            this.btn_reporte_clienteXmodelo_cargar.Click += new System.EventHandler(this.btn_reporte_clienteXmodelo_cargar_Click);
            // 
            // Reporte_para_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.tabControl1);
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
    }
}