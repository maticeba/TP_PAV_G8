
namespace ComunicAr.Formularios.Estadisticas.Numeros
{
    partial class Frm_Estadisticas_Numeros
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
            this.btn_estad_nro_baja_cargar = new System.Windows.Forms.Button();
            this.txt_estad_nro_baja_mes = new ComunicAr.Clases.TextBox01();
            this.txt_estad_nro_baja_año = new ComunicAr.Clases.TextBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBtn_estadistica_nro_bajas_mes = new System.Windows.Forms.RadioButton();
            this.rdBtn_estadistica_nro_bajas_año = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rv_estadistica_nros_baja = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(849, 490);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_estad_nro_baja_cargar);
            this.tabPage1.Controls.Add(this.txt_estad_nro_baja_mes);
            this.tabPage1.Controls.Add(this.txt_estad_nro_baja_año);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.rv_estadistica_nros_baja);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(841, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bajas por servicio";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_estad_nro_baja_cargar
            // 
            this.btn_estad_nro_baja_cargar.Location = new System.Drawing.Point(654, 38);
            this.btn_estad_nro_baja_cargar.Name = "btn_estad_nro_baja_cargar";
            this.btn_estad_nro_baja_cargar.Size = new System.Drawing.Size(75, 23);
            this.btn_estad_nro_baja_cargar.TabIndex = 4;
            this.btn_estad_nro_baja_cargar.Text = "Cargar";
            this.btn_estad_nro_baja_cargar.UseVisualStyleBackColor = true;
            this.btn_estad_nro_baja_cargar.Click += new System.EventHandler(this.btn_estad_nro_baja_cargar_Click);
            // 
            // txt_estad_nro_baja_mes
            // 
            this.txt_estad_nro_baja_mes.Location = new System.Drawing.Point(508, 40);
            this.txt_estad_nro_baja_mes.Name = "txt_estad_nro_baja_mes";
            this.txt_estad_nro_baja_mes.Pp_Campo = null;
            this.txt_estad_nro_baja_mes.Pp_MensajeError = null;
            this.txt_estad_nro_baja_mes.Pp_Tabla = null;
            this.txt_estad_nro_baja_mes.Pp_Validable = false;
            this.txt_estad_nro_baja_mes.Size = new System.Drawing.Size(100, 20);
            this.txt_estad_nro_baja_mes.TabIndex = 3;
            // 
            // txt_estad_nro_baja_año
            // 
            this.txt_estad_nro_baja_año.Location = new System.Drawing.Point(508, 18);
            this.txt_estad_nro_baja_año.Name = "txt_estad_nro_baja_año";
            this.txt_estad_nro_baja_año.Pp_Campo = null;
            this.txt_estad_nro_baja_año.Pp_MensajeError = null;
            this.txt_estad_nro_baja_año.Pp_Tabla = null;
            this.txt_estad_nro_baja_año.Pp_Validable = false;
            this.txt_estad_nro_baja_año.Size = new System.Drawing.Size(100, 20);
            this.txt_estad_nro_baja_año.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mes: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtn_estadistica_nro_bajas_mes);
            this.groupBox1.Controls.Add(this.rdBtn_estadistica_nro_bajas_año);
            this.groupBox1.Location = new System.Drawing.Point(283, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 64);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // rdBtn_estadistica_nro_bajas_mes
            // 
            this.rdBtn_estadistica_nro_bajas_mes.AutoSize = true;
            this.rdBtn_estadistica_nro_bajas_mes.Location = new System.Drawing.Point(6, 41);
            this.rdBtn_estadistica_nro_bajas_mes.Name = "rdBtn_estadistica_nro_bajas_mes";
            this.rdBtn_estadistica_nro_bajas_mes.Size = new System.Drawing.Size(128, 17);
            this.rdBtn_estadistica_nro_bajas_mes.TabIndex = 0;
            this.rdBtn_estadistica_nro_bajas_mes.TabStop = true;
            this.rdBtn_estadistica_nro_bajas_mes.Text = "En un mes específico";
            this.rdBtn_estadistica_nro_bajas_mes.UseVisualStyleBackColor = true;
            this.rdBtn_estadistica_nro_bajas_mes.CheckedChanged += new System.EventHandler(this.rdBtn_estadistica_nro_bajas_mes_CheckedChanged);
            // 
            // rdBtn_estadistica_nro_bajas_año
            // 
            this.rdBtn_estadistica_nro_bajas_año.AutoSize = true;
            this.rdBtn_estadistica_nro_bajas_año.Location = new System.Drawing.Point(6, 19);
            this.rdBtn_estadistica_nro_bajas_año.Name = "rdBtn_estadistica_nro_bajas_año";
            this.rdBtn_estadistica_nro_bajas_año.Size = new System.Drawing.Size(127, 17);
            this.rdBtn_estadistica_nro_bajas_año.TabIndex = 0;
            this.rdBtn_estadistica_nro_bajas_año.TabStop = true;
            this.rdBtn_estadistica_nro_bajas_año.Text = "En un año específico";
            this.rdBtn_estadistica_nro_bajas_año.UseVisualStyleBackColor = true;
            this.rdBtn_estadistica_nro_bajas_año.CheckedChanged += new System.EventHandler(this.rdBtn_estadistica_nro_bajas_año_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Año: ";
            // 
            // rv_estadistica_nros_baja
            // 
            this.rv_estadistica_nros_baja.Location = new System.Drawing.Point(0, 76);
            this.rv_estadistica_nros_baja.Name = "rv_estadistica_nros_baja";
            this.rv_estadistica_nros_baja.ServerReport.BearerToken = null;
            this.rv_estadistica_nros_baja.Size = new System.Drawing.Size(838, 385);
            this.rv_estadistica_nros_baja.TabIndex = 0;
            // 
            // Frm_Estadisticas_Numeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 493);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_Estadisticas_Numeros";
            this.Text = "Frm_Estadisticas_Numeros";
            this.Load += new System.EventHandler(this.Frm_Estadisticas_Numeros_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer rv_estadistica_nros_baja;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBtn_estadistica_nro_bajas_año;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdBtn_estadistica_nro_bajas_mes;
        private Clases.TextBox01 txt_estad_nro_baja_mes;
        private Clases.TextBox01 txt_estad_nro_baja_año;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_estad_nro_baja_cargar;
    }
}