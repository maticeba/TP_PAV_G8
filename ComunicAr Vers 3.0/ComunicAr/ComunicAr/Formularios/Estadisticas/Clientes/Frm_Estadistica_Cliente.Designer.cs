
namespace ComunicAr.Formularios.Estadisticas.Clientes
{
    partial class Frm_Estadistica_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Estadistica_Cliente));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_estadistica_cliente_baja_calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_estadistica_cliente_baja_año = new ComunicAr.Clases.TextBox01();
            this.rv_estadistica_cliente_baja = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClientXServ = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_year_C = new ComunicAr.Clases.TextBox01();
            this.txt_año = new System.Windows.Forms.Label();
            this.btn_calcular_C = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rv_Clien_Serv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ClientXServ.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.ClientXServ);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(862, 537);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_estadistica_cliente_baja_calcular);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_estadistica_cliente_baja_año);
            this.tabPage1.Controls.Add(this.rv_estadistica_cliente_baja);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(854, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes dados de baja";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_estadistica_cliente_baja_calcular
            // 
            this.btn_estadistica_cliente_baja_calcular.Location = new System.Drawing.Point(260, 18);
            this.btn_estadistica_cliente_baja_calcular.Name = "btn_estadistica_cliente_baja_calcular";
            this.btn_estadistica_cliente_baja_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_estadistica_cliente_baja_calcular.TabIndex = 3;
            this.btn_estadistica_cliente_baja_calcular.Text = "Calcular";
            this.btn_estadistica_cliente_baja_calcular.UseVisualStyleBackColor = true;
            this.btn_estadistica_cliente_baja_calcular.Click += new System.EventHandler(this.btn_estadistica_cliente_baja_calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Año";
            // 
            // txt_estadistica_cliente_baja_año
            // 
            this.txt_estadistica_cliente_baja_año.Location = new System.Drawing.Point(106, 20);
            this.txt_estadistica_cliente_baja_año.Name = "txt_estadistica_cliente_baja_año";
            this.txt_estadistica_cliente_baja_año.Pp_Campo = null;
            this.txt_estadistica_cliente_baja_año.Pp_MensajeError = null;
            this.txt_estadistica_cliente_baja_año.Pp_Tabla = null;
            this.txt_estadistica_cliente_baja_año.Pp_Validable = false;
            this.txt_estadistica_cliente_baja_año.Size = new System.Drawing.Size(100, 20);
            this.txt_estadistica_cliente_baja_año.TabIndex = 1;
            // 
            // rv_estadistica_cliente_baja
            // 
            this.rv_estadistica_cliente_baja.Location = new System.Drawing.Point(3, 69);
            this.rv_estadistica_cliente_baja.Name = "rv_estadistica_cliente_baja";
            this.rv_estadistica_cliente_baja.ServerReport.BearerToken = null;
            this.rv_estadistica_cliente_baja.Size = new System.Drawing.Size(845, 436);
            this.rv_estadistica_cliente_baja.TabIndex = 0;
            // 
            // ClientXServ
            // 
            this.ClientXServ.Controls.Add(this.rv_Clien_Serv);
            this.ClientXServ.Controls.Add(this.groupBox1);
            this.ClientXServ.Location = new System.Drawing.Point(4, 22);
            this.ClientXServ.Name = "ClientXServ";
            this.ClientXServ.Size = new System.Drawing.Size(854, 511);
            this.ClientXServ.TabIndex = 1;
            this.ClientXServ.Text = "Cliente por Servicio Usado";
            this.ClientXServ.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btn_calcular_C);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 103);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_year_C);
            this.groupBox2.Controls.Add(this.txt_año);
            this.groupBox2.Location = new System.Drawing.Point(116, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 50);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // txt_year_C
            // 
            this.txt_year_C.Location = new System.Drawing.Point(130, 18);
            this.txt_year_C.Name = "txt_year_C";
            this.txt_year_C.Pp_Campo = null;
            this.txt_year_C.Pp_MensajeError = null;
            this.txt_year_C.Pp_Tabla = null;
            this.txt_year_C.Pp_Validable = false;
            this.txt_year_C.Size = new System.Drawing.Size(60, 20);
            this.txt_year_C.TabIndex = 1;
            this.txt_year_C.Text = "AAAA";
            this.txt_year_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_year_C.Click += new System.EventHandler(this.txt_year_C_Click);
            // 
            // txt_año
            // 
            this.txt_año.AutoSize = true;
            this.txt_año.Location = new System.Drawing.Point(6, 18);
            this.txt_año.Name = "txt_año";
            this.txt_año.Size = new System.Drawing.Size(118, 13);
            this.txt_año.TabIndex = 25;
            this.txt_año.Text = "Ingrese el año a buscar";
            // 
            // btn_calcular_C
            // 
            this.btn_calcular_C.Location = new System.Drawing.Point(238, 75);
            this.btn_calcular_C.Name = "btn_calcular_C";
            this.btn_calcular_C.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular_C.TabIndex = 1;
            this.btn_calcular_C.Text = "Calcular";
            this.btn_calcular_C.UseVisualStyleBackColor = true;
            this.btn_calcular_C.Click += new System.EventHandler(this.btn_calcular_C_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(99, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // rv_Clien_Serv
            // 
            this.rv_Clien_Serv.Location = new System.Drawing.Point(4, 113);
            this.rv_Clien_Serv.Name = "rv_Clien_Serv";
            this.rv_Clien_Serv.ServerReport.BearerToken = null;
            this.rv_Clien_Serv.Size = new System.Drawing.Size(844, 393);
            this.rv_Clien_Serv.TabIndex = 4;
            // 
            // Frm_Estadistica_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 542);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_Estadistica_Cliente";
            this.Text = "Estadísticas del Cliente";
            this.Load += new System.EventHandler(this.Frm_Estadistica_Cliente_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ClientXServ.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer rv_estadistica_cliente_baja;
        private System.Windows.Forms.Button btn_estadistica_cliente_baja_calcular;
        private System.Windows.Forms.Label label1;
        private Clases.TextBox01 txt_estadistica_cliente_baja_año;
        private System.Windows.Forms.TabPage ClientXServ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Clases.TextBox01 txt_year_C;
        private System.Windows.Forms.Label txt_año;
        private System.Windows.Forms.Button btn_calcular_C;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Microsoft.Reporting.WinForms.ReportViewer rv_Clien_Serv;
    }
}