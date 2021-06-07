
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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(774, 449);
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
            this.tabPage1.Size = new System.Drawing.Size(766, 423);
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
            this.tabPage2.Size = new System.Drawing.Size(766, 423);
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
    }
}