
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Llamadas_Estadisticas));
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_sin = new System.Windows.Forms.RadioButton();
            this.rb_cliente = new System.Windows.Forms.RadioButton();
            this.rv_llamadas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Calcular_L = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rb_Mes_L = new System.Windows.Forms.RadioButton();
            this.rb_intervalo_L = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rv02_L = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_año = new ComunicAr.Clases.TextBox01();
            this.txt_mesHasta = new ComunicAr.Clases.TextBox01();
            this.txt_añoHasta = new ComunicAr.Clases.TextBox01();
            this.txt_añoDesde = new ComunicAr.Clases.TextBox01();
            this.txt_mesDesde = new ComunicAr.Clases.TextBox01();
            this.txt_mes = new ComunicAr.Clases.TextBox01();
            this.txt_año2 = new ComunicAr.Clases.TextBox01();
            this.txt_cliente2 = new ComunicAr.Clases.TextBox01();
            this.txt_year_L = new ComunicAr.Clases.TextBox01();
            this.txt_mes_L = new ComunicAr.Clases.TextBox01();
            this.txt_hasta_year_L = new ComunicAr.Clases.TextBox01();
            this.txt_desde_year_L = new ComunicAr.Clases.TextBox01();
            this.txt_hasta_mes_L = new ComunicAr.Clases.TextBox01();
            this.txt_desde_mes_L = new ComunicAr.Clases.TextBox01();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
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
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btn_buscar);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.rv_llamadas);
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
            this.Calcular2.Location = new System.Drawing.Point(593, 90);
            this.Calcular2.Name = "Calcular2";
            this.Calcular2.Size = new System.Drawing.Size(75, 23);
            this.Calcular2.TabIndex = 9;
            this.Calcular2.Text = "Calcular";
            this.Calcular2.UseVisualStyleBackColor = true;
            this.Calcular2.Click += new System.EventHandler(this.Calcular2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(298, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID Cliente ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(328, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Año";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(477, 48);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(67, 20);
            this.btn_buscar.TabIndex = 7;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Visible = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_sin);
            this.groupBox2.Controls.Add(this.rb_cliente);
            this.groupBox2.Location = new System.Drawing.Point(150, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 79);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // rb_sin
            // 
            this.rb_sin.AutoSize = true;
            this.rb_sin.Location = new System.Drawing.Point(8, 22);
            this.rb_sin.Name = "rb_sin";
            this.rb_sin.Size = new System.Drawing.Size(65, 17);
            this.rb_sin.TabIndex = 0;
            this.rb_sin.TabStop = true;
            this.rb_sin.Text = "Sin Filtro";
            this.rb_sin.UseVisualStyleBackColor = true;
            this.rb_sin.CheckedChanged += new System.EventHandler(this.rb_sin_CheckedChanged);
            // 
            // rb_cliente
            // 
            this.rb_cliente.AutoSize = true;
            this.rb_cliente.Location = new System.Drawing.Point(9, 45);
            this.rb_cliente.Name = "rb_cliente";
            this.rb_cliente.Size = new System.Drawing.Size(88, 17);
            this.rb_cliente.TabIndex = 0;
            this.rb_cliente.TabStop = true;
            this.rb_cliente.Text = "De un cliente";
            this.rb_cliente.UseVisualStyleBackColor = true;
            this.rb_cliente.CheckedChanged += new System.EventHandler(this.rb_cliente_CheckedChanged);
            // 
            // rv_llamadas
            // 
            this.rv_llamadas.Location = new System.Drawing.Point(0, 119);
            this.rv_llamadas.Name = "rv_llamadas";
            this.rv_llamadas.ServerReport.BearerToken = null;
            this.rv_llamadas.Size = new System.Drawing.Size(673, 331);
            this.rv_llamadas.TabIndex = 0;
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rv02_L);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(679, 450);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Llamadas por banda horaria";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.btn_Calcular_L);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(626, 149);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // btn_Calcular_L
            // 
            this.btn_Calcular_L.Location = new System.Drawing.Point(515, 115);
            this.btn_Calcular_L.Name = "btn_Calcular_L";
            this.btn_Calcular_L.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular_L.TabIndex = 31;
            this.btn_Calcular_L.Text = "Calcular";
            this.btn_Calcular_L.UseVisualStyleBackColor = true;
            this.btn_Calcular_L.Click += new System.EventHandler(this.btn_Calcular_L_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rb_Mes_L);
            this.groupBox6.Controls.Add(this.rb_intervalo_L);
            this.groupBox6.Location = new System.Drawing.Point(141, 40);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(126, 76);
            this.groupBox6.TabIndex = 30;
            this.groupBox6.TabStop = false;
            // 
            // rb_Mes_L
            // 
            this.rb_Mes_L.AutoSize = true;
            this.rb_Mes_L.Location = new System.Drawing.Point(6, 42);
            this.rb_Mes_L.Name = "rb_Mes_L";
            this.rb_Mes_L.Size = new System.Drawing.Size(97, 17);
            this.rb_Mes_L.TabIndex = 1;
            this.rb_Mes_L.Text = "Mes Especifico";
            this.rb_Mes_L.UseVisualStyleBackColor = true;
            this.rb_Mes_L.CheckedChanged += new System.EventHandler(this.rb_Mes_L_CheckedChanged);
            // 
            // rb_intervalo_L
            // 
            this.rb_intervalo_L.AutoSize = true;
            this.rb_intervalo_L.Location = new System.Drawing.Point(3, 16);
            this.rb_intervalo_L.Name = "rb_intervalo_L";
            this.rb_intervalo_L.Size = new System.Drawing.Size(114, 17);
            this.rb_intervalo_L.TabIndex = 0;
            this.rb_intervalo_L.Text = "Intervalo de meses";
            this.rb_intervalo_L.UseVisualStyleBackColor = true;
            this.rb_intervalo_L.CheckedChanged += new System.EventHandler(this.rb_intervalo_L_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_year_L);
            this.groupBox5.Controls.Add(this.txt_mes_L);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(291, 102);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 41);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
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
            this.groupBox4.Controls.Add(this.txt_hasta_year_L);
            this.groupBox4.Controls.Add(this.txt_desde_year_L);
            this.groupBox4.Controls.Add(this.txt_hasta_mes_L);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txt_desde_mes_L);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(291, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 71);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Hasta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Desde";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // rv02_L
            // 
            this.rv02_L.Location = new System.Drawing.Point(4, 159);
            this.rv02_L.Name = "rv02_L";
            this.rv02_L.ServerReport.BearerToken = null;
            this.rv02_L.Size = new System.Drawing.Size(672, 291);
            this.rv02_L.TabIndex = 2;
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
            // txt_año2
            // 
            this.txt_año2.Enabled = false;
            this.txt_año2.Location = new System.Drawing.Point(360, 21);
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
            this.txt_cliente2.Enabled = false;
            this.txt_cliente2.Location = new System.Drawing.Point(360, 48);
            this.txt_cliente2.Name = "txt_cliente2";
            this.txt_cliente2.Pp_Campo = null;
            this.txt_cliente2.Pp_MensajeError = null;
            this.txt_cliente2.Pp_Tabla = null;
            this.txt_cliente2.Pp_Validable = false;
            this.txt_cliente2.Size = new System.Drawing.Size(100, 20);
            this.txt_cliente2.TabIndex = 2;
            // 
            // txt_year_L
            // 
            this.txt_year_L.Location = new System.Drawing.Point(136, 15);
            this.txt_year_L.Name = "txt_year_L";
            this.txt_year_L.Pp_Campo = null;
            this.txt_year_L.Pp_MensajeError = null;
            this.txt_year_L.Pp_Tabla = null;
            this.txt_year_L.Pp_Validable = false;
            this.txt_year_L.Size = new System.Drawing.Size(58, 20);
            this.txt_year_L.TabIndex = 32;
            this.txt_year_L.Text = "AAAA";
            this.txt_year_L.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_year_L.Click += new System.EventHandler(this.txt_year_L_Click);
            // 
            // txt_mes_L
            // 
            this.txt_mes_L.Location = new System.Drawing.Point(87, 15);
            this.txt_mes_L.Name = "txt_mes_L";
            this.txt_mes_L.Pp_Campo = null;
            this.txt_mes_L.Pp_MensajeError = null;
            this.txt_mes_L.Pp_Tabla = null;
            this.txt_mes_L.Pp_Validable = false;
            this.txt_mes_L.Size = new System.Drawing.Size(43, 20);
            this.txt_mes_L.TabIndex = 31;
            this.txt_mes_L.Text = "MM";
            this.txt_mes_L.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_mes_L.Click += new System.EventHandler(this.txt_mes_L_Click);
            // 
            // txt_hasta_year_L
            // 
            this.txt_hasta_year_L.Location = new System.Drawing.Point(106, 40);
            this.txt_hasta_year_L.Name = "txt_hasta_year_L";
            this.txt_hasta_year_L.Pp_Campo = null;
            this.txt_hasta_year_L.Pp_MensajeError = null;
            this.txt_hasta_year_L.Pp_Tabla = null;
            this.txt_hasta_year_L.Pp_Validable = false;
            this.txt_hasta_year_L.Size = new System.Drawing.Size(58, 20);
            this.txt_hasta_year_L.TabIndex = 5;
            this.txt_hasta_year_L.Text = "AAAA";
            this.txt_hasta_year_L.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_hasta_year_L.Click += new System.EventHandler(this.txt_hasta_year_L_Click);
            // 
            // txt_desde_year_L
            // 
            this.txt_desde_year_L.Location = new System.Drawing.Point(106, 14);
            this.txt_desde_year_L.Name = "txt_desde_year_L";
            this.txt_desde_year_L.Pp_Campo = null;
            this.txt_desde_year_L.Pp_MensajeError = null;
            this.txt_desde_year_L.Pp_Tabla = null;
            this.txt_desde_year_L.Pp_Validable = false;
            this.txt_desde_year_L.Size = new System.Drawing.Size(58, 20);
            this.txt_desde_year_L.TabIndex = 3;
            this.txt_desde_year_L.Text = "AAAA";
            this.txt_desde_year_L.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_desde_year_L.Click += new System.EventHandler(this.txt_desde_year_L_Click);
            // 
            // txt_hasta_mes_L
            // 
            this.txt_hasta_mes_L.Location = new System.Drawing.Point(57, 40);
            this.txt_hasta_mes_L.Name = "txt_hasta_mes_L";
            this.txt_hasta_mes_L.Pp_Campo = null;
            this.txt_hasta_mes_L.Pp_MensajeError = null;
            this.txt_hasta_mes_L.Pp_Tabla = null;
            this.txt_hasta_mes_L.Pp_Validable = false;
            this.txt_hasta_mes_L.Size = new System.Drawing.Size(43, 20);
            this.txt_hasta_mes_L.TabIndex = 4;
            this.txt_hasta_mes_L.Text = "MM";
            this.txt_hasta_mes_L.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_hasta_mes_L.Click += new System.EventHandler(this.txt_hasta_mes_L_Click);
            this.txt_hasta_mes_L.TextChanged += new System.EventHandler(this.txt_hasta_mes_L_TextChanged);
            // 
            // txt_desde_mes_L
            // 
            this.txt_desde_mes_L.Location = new System.Drawing.Point(57, 14);
            this.txt_desde_mes_L.Name = "txt_desde_mes_L";
            this.txt_desde_mes_L.Pp_Campo = null;
            this.txt_desde_mes_L.Pp_MensajeError = null;
            this.txt_desde_mes_L.Pp_Tabla = null;
            this.txt_desde_mes_L.Pp_Validable = false;
            this.txt_desde_mes_L.Size = new System.Drawing.Size(43, 20);
            this.txt_desde_mes_L.TabIndex = 2;
            this.txt_desde_mes_L.Text = "MM";
            this.txt_desde_mes_L.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_desde_mes_L.Click += new System.EventHandler(this.txt_desde_mes_L_Click);
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
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private Microsoft.Reporting.WinForms.ReportViewer rv_llamadas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_cliente;
        private Clases.TextBox01 txt_cliente2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscar;
        private Clases.TextBox01 txt_año2;
        private System.Windows.Forms.Button Calcular2;
        private System.Windows.Forms.RadioButton rb_sin;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Calcular_L;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rb_Mes_L;
        private System.Windows.Forms.RadioButton rb_intervalo_L;
        private System.Windows.Forms.GroupBox groupBox5;
        private Clases.TextBox01 txt_year_L;
        private Clases.TextBox01 txt_mes_L;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private Clases.TextBox01 txt_hasta_year_L;
        private Clases.TextBox01 txt_desde_year_L;
        private Clases.TextBox01 txt_hasta_mes_L;
        private System.Windows.Forms.Label label4;
        private Clases.TextBox01 txt_desde_mes_L;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Microsoft.Reporting.WinForms.ReportViewer rv02_L;
    }
}