
namespace ComunicAr.Formularios.Estadisticas.Llamadas
{
    partial class Frm_Llamadas_Estadisticas
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
            this.btn_calcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.rb_rango = new System.Windows.Forms.RadioButton();
            this.rb_mes = new System.Windows.Forms.RadioButton();
            this.rv_tipoLlamadas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Calcular2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rb_rango2 = new System.Windows.Forms.RadioButton();
            this.rb_sin = new System.Windows.Forms.RadioButton();
            this.rb_cliente = new System.Windows.Forms.RadioButton();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_año = new ComunicAr.Clases.TextBox01();
            this.txt_mesHasta = new ComunicAr.Clases.TextBox01();
            this.txt_añoHasta = new ComunicAr.Clases.TextBox01();
            this.txt_añoDesde = new ComunicAr.Clases.TextBox01();
            this.txt_mesDesde = new ComunicAr.Clases.TextBox01();
            this.txt_mes = new ComunicAr.Clases.TextBox01();
            this.txt_mesHasta2 = new ComunicAr.Clases.TextBox01();
            this.txt_mesDesde2 = new ComunicAr.Clases.TextBox01();
            this.txt_año2 = new ComunicAr.Clases.TextBox01();
            this.txt_cliente2 = new ComunicAr.Clases.TextBox01();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(687, 476);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_calcular);
            this.tabPage1.Controls.Add(this.txt_año);
            this.tabPage1.Controls.Add(this.txt_mesHasta);
            this.tabPage1.Controls.Add(this.txt_añoHasta);
            this.tabPage1.Controls.Add(this.txt_añoDesde);
            this.tabPage1.Controls.Add(this.txt_mesDesde);
            this.tabPage1.Controls.Add(this.txt_mes);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.rv_tipoLlamadas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(679, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Llamadas por tipo de comunicacion";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Enabled = false;
            this.btn_calcular.Location = new System.Drawing.Point(583, 105);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(85, 23);
            this.btn_calcular.TabIndex = 3;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_todos);
            this.groupBox1.Controls.Add(this.rb_rango);
            this.groupBox1.Controls.Add(this.rb_mes);
            this.groupBox1.Location = new System.Drawing.Point(134, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Location = new System.Drawing.Point(6, 71);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(115, 17);
            this.rb_todos.TabIndex = 0;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "Todas las llamadas";
            this.rb_todos.UseVisualStyleBackColor = true;
            this.rb_todos.CheckedChanged += new System.EventHandler(this.rb_todos_CheckedChanged);
            // 
            // rb_rango
            // 
            this.rb_rango.AutoSize = true;
            this.rb_rango.Location = new System.Drawing.Point(7, 46);
            this.rb_rango.Name = "rb_rango";
            this.rb_rango.Size = new System.Drawing.Size(119, 17);
            this.rb_rango.TabIndex = 0;
            this.rb_rango.TabStop = true;
            this.rb_rango.Text = "Por rango de meses";
            this.rb_rango.UseVisualStyleBackColor = true;
            this.rb_rango.CheckedChanged += new System.EventHandler(this.rb_rango_CheckedChanged);
            // 
            // rb_mes
            // 
            this.rb_mes.AutoSize = true;
            this.rb_mes.Location = new System.Drawing.Point(7, 20);
            this.rb_mes.Name = "rb_mes";
            this.rb_mes.Size = new System.Drawing.Size(64, 17);
            this.rb_mes.TabIndex = 0;
            this.rb_mes.TabStop = true;
            this.rb_mes.Text = "Por Mes";
            this.rb_mes.UseVisualStyleBackColor = true;
            this.rb_mes.CheckedChanged += new System.EventHandler(this.rb_mes_CheckedChanged);
            // 
            // rv_tipoLlamadas
            // 
            this.rv_tipoLlamadas.Location = new System.Drawing.Point(0, 134);
            this.rv_tipoLlamadas.Name = "rv_tipoLlamadas";
            this.rv_tipoLlamadas.ServerReport.BearerToken = null;
            this.rv_tipoLlamadas.Size = new System.Drawing.Size(676, 320);
            this.rv_tipoLlamadas.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Calcular2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btn_buscar);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Controls.Add(this.txt_mesHasta2);
            this.tabPage2.Controls.Add(this.txt_mesDesde2);
            this.tabPage2.Controls.Add(this.txt_año2);
            this.tabPage2.Controls.Add(this.txt_cliente2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(679, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Llamadas por mes";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // Calcular2
            // 
            this.Calcular2.Location = new System.Drawing.Point(593, 103);
            this.Calcular2.Name = "Calcular2";
            this.Calcular2.Size = new System.Drawing.Size(75, 23);
            this.Calcular2.TabIndex = 9;
            this.Calcular2.Text = "Calcular";
            this.Calcular2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID Cliente ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Año";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(505, 33);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(67, 20);
            this.btn_buscar.TabIndex = 7;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.rb_rango2);
            this.groupBox2.Controls.Add(this.rb_sin);
            this.groupBox2.Controls.Add(this.rb_cliente);
            this.groupBox2.Location = new System.Drawing.Point(150, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 98);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Combinado";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rb_rango2
            // 
            this.rb_rango2.AutoSize = true;
            this.rb_rango2.Location = new System.Drawing.Point(7, 69);
            this.rb_rango2.Name = "rb_rango2";
            this.rb_rango2.Size = new System.Drawing.Size(119, 17);
            this.rb_rango2.TabIndex = 0;
            this.rb_rango2.TabStop = true;
            this.rb_rango2.Text = "Por rango de meses";
            this.rb_rango2.UseVisualStyleBackColor = true;
            this.rb_rango2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rb_sin
            // 
            this.rb_sin.AutoSize = true;
            this.rb_sin.Location = new System.Drawing.Point(6, 14);
            this.rb_sin.Name = "rb_sin";
            this.rb_sin.Size = new System.Drawing.Size(65, 17);
            this.rb_sin.TabIndex = 0;
            this.rb_sin.TabStop = true;
            this.rb_sin.Text = "Sin Filtro";
            this.rb_sin.UseVisualStyleBackColor = true;
            // 
            // rb_cliente
            // 
            this.rb_cliente.AutoSize = true;
            this.rb_cliente.Location = new System.Drawing.Point(7, 37);
            this.rb_cliente.Name = "rb_cliente";
            this.rb_cliente.Size = new System.Drawing.Size(88, 17);
            this.rb_cliente.TabIndex = 0;
            this.rb_cliente.TabStop = true;
            this.rb_cliente.Text = "De un cliente";
            this.rb_cliente.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Location = new System.Drawing.Point(0, 132);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(673, 318);
            this.reportViewer2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_año
            // 
            this.txt_año.Enabled = false;
            this.txt_año.Location = new System.Drawing.Point(393, 23);
            this.txt_año.Name = "txt_año";
            this.txt_año.Pp_Campo = null;
            this.txt_año.Pp_MensajeError = null;
            this.txt_año.Pp_Tabla = null;
            this.txt_año.Pp_Validable = false;
            this.txt_año.Size = new System.Drawing.Size(45, 20);
            this.txt_año.TabIndex = 2;
            this.txt_año.Text = "YYYY";
            // 
            // txt_mesHasta
            // 
            this.txt_mesHasta.Enabled = false;
            this.txt_mesHasta.Location = new System.Drawing.Point(456, 49);
            this.txt_mesHasta.Name = "txt_mesHasta";
            this.txt_mesHasta.Pp_Campo = null;
            this.txt_mesHasta.Pp_MensajeError = null;
            this.txt_mesHasta.Pp_Tabla = null;
            this.txt_mesHasta.Pp_Validable = false;
            this.txt_mesHasta.Size = new System.Drawing.Size(31, 20);
            this.txt_mesHasta.TabIndex = 2;
            this.txt_mesHasta.Text = "MM";
            // 
            // txt_añoHasta
            // 
            this.txt_añoHasta.Enabled = false;
            this.txt_añoHasta.Location = new System.Drawing.Point(493, 49);
            this.txt_añoHasta.Name = "txt_añoHasta";
            this.txt_añoHasta.Pp_Campo = null;
            this.txt_añoHasta.Pp_MensajeError = null;
            this.txt_añoHasta.Pp_Tabla = null;
            this.txt_añoHasta.Pp_Validable = false;
            this.txt_añoHasta.Size = new System.Drawing.Size(45, 20);
            this.txt_añoHasta.TabIndex = 2;
            this.txt_añoHasta.Text = "YYYY";
            // 
            // txt_añoDesde
            // 
            this.txt_añoDesde.Enabled = false;
            this.txt_añoDesde.Location = new System.Drawing.Point(393, 49);
            this.txt_añoDesde.Name = "txt_añoDesde";
            this.txt_añoDesde.Pp_Campo = null;
            this.txt_añoDesde.Pp_MensajeError = null;
            this.txt_añoDesde.Pp_Tabla = null;
            this.txt_añoDesde.Pp_Validable = false;
            this.txt_añoDesde.Size = new System.Drawing.Size(45, 20);
            this.txt_añoDesde.TabIndex = 2;
            this.txt_añoDesde.Text = "YYYY";
            // 
            // txt_mesDesde
            // 
            this.txt_mesDesde.Enabled = false;
            this.txt_mesDesde.Location = new System.Drawing.Point(356, 49);
            this.txt_mesDesde.Name = "txt_mesDesde";
            this.txt_mesDesde.Pp_Campo = null;
            this.txt_mesDesde.Pp_MensajeError = null;
            this.txt_mesDesde.Pp_Tabla = null;
            this.txt_mesDesde.Pp_Validable = false;
            this.txt_mesDesde.Size = new System.Drawing.Size(31, 20);
            this.txt_mesDesde.TabIndex = 2;
            this.txt_mesDesde.Text = "MM";
            // 
            // txt_mes
            // 
            this.txt_mes.Enabled = false;
            this.txt_mes.Location = new System.Drawing.Point(356, 23);
            this.txt_mes.Name = "txt_mes";
            this.txt_mes.Pp_Campo = null;
            this.txt_mes.Pp_MensajeError = null;
            this.txt_mes.Pp_Tabla = null;
            this.txt_mes.Pp_Validable = false;
            this.txt_mes.Size = new System.Drawing.Size(31, 20);
            this.txt_mes.TabIndex = 2;
            this.txt_mes.Text = "MM";
            // 
            // txt_mesHasta2
            // 
            this.txt_mesHasta2.Location = new System.Drawing.Point(457, 65);
            this.txt_mesHasta2.Name = "txt_mesHasta2";
            this.txt_mesHasta2.Pp_Campo = null;
            this.txt_mesHasta2.Pp_MensajeError = null;
            this.txt_mesHasta2.Pp_Tabla = null;
            this.txt_mesHasta2.Pp_Validable = false;
            this.txt_mesHasta2.Size = new System.Drawing.Size(31, 20);
            this.txt_mesHasta2.TabIndex = 3;
            this.txt_mesHasta2.Text = "MM";
            // 
            // txt_mesDesde2
            // 
            this.txt_mesDesde2.Location = new System.Drawing.Point(388, 65);
            this.txt_mesDesde2.Name = "txt_mesDesde2";
            this.txt_mesDesde2.Pp_Campo = null;
            this.txt_mesDesde2.Pp_MensajeError = null;
            this.txt_mesDesde2.Pp_Tabla = null;
            this.txt_mesDesde2.Pp_Validable = false;
            this.txt_mesDesde2.Size = new System.Drawing.Size(31, 20);
            this.txt_mesDesde2.TabIndex = 6;
            this.txt_mesDesde2.Text = "MM";
            // 
            // txt_año2
            // 
            this.txt_año2.Location = new System.Drawing.Point(388, 6);
            this.txt_año2.Name = "txt_año2";
            this.txt_año2.Pp_Campo = null;
            this.txt_año2.Pp_MensajeError = null;
            this.txt_año2.Pp_Tabla = null;
            this.txt_año2.Pp_Validable = false;
            this.txt_año2.Size = new System.Drawing.Size(100, 20);
            this.txt_año2.TabIndex = 2;
            // 
            // txt_cliente2
            // 
            this.txt_cliente2.Location = new System.Drawing.Point(388, 33);
            this.txt_cliente2.Name = "txt_cliente2";
            this.txt_cliente2.Pp_Campo = null;
            this.txt_cliente2.Pp_MensajeError = null;
            this.txt_cliente2.Pp_Tabla = null;
            this.txt_cliente2.Pp_Validable = false;
            this.txt_cliente2.Size = new System.Drawing.Size(100, 20);
            this.txt_cliente2.TabIndex = 2;
            // 
            // Frm_Llamadas_Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_Llamadas_Estadisticas";
            this.Text = "Frm_Llamadas_Estadisticas";
            this.Load += new System.EventHandler(this.Frm_Llamadas_Estadisticas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer rv_tipoLlamadas;
        private System.Windows.Forms.Button btn_calcular;
        private Clases.TextBox01 txt_año;
        private Clases.TextBox01 txt_mesHasta;
        private Clases.TextBox01 txt_añoHasta;
        private Clases.TextBox01 txt_añoDesde;
        private Clases.TextBox01 txt_mesDesde;
        private Clases.TextBox01 txt_mes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_todos;
        private System.Windows.Forms.RadioButton rb_rango;
        private System.Windows.Forms.RadioButton rb_mes;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_rango2;
        private System.Windows.Forms.RadioButton rb_cliente;
        private Clases.TextBox01 txt_mesHasta2;
        private Clases.TextBox01 txt_mesDesde2;
        private Clases.TextBox01 txt_cliente2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscar;
        private Clases.TextBox01 txt_año2;
        private System.Windows.Forms.Button Calcular2;
        private System.Windows.Forms.RadioButton rb_sin;
    }
}