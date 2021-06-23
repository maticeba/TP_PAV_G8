
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
            this.rv_Clien_Serv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_year_C = new ComunicAr.Clases.TextBox01();
            this.txt_año = new System.Windows.Forms.Label();
            this.btn_calcular_C = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox012 = new ComunicAr.Clases.TextBox01();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox011 = new ComunicAr.Clases.TextBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ClientXServ.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.ClientXServ);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1149, 661);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox4);
            this.tabPage1.Controls.Add(this.btn_estadistica_cliente_baja_calcular);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_estadistica_cliente_baja_año);
            this.tabPage1.Controls.Add(this.rv_estadistica_cliente_baja);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1141, 632);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes dados de baja";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_estadistica_cliente_baja_calcular
            // 
            this.btn_estadistica_cliente_baja_calcular.Location = new System.Drawing.Point(342, 90);
            this.btn_estadistica_cliente_baja_calcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_estadistica_cliente_baja_calcular.Name = "btn_estadistica_cliente_baja_calcular";
            this.btn_estadistica_cliente_baja_calcular.Size = new System.Drawing.Size(100, 22);
            this.btn_estadistica_cliente_baja_calcular.TabIndex = 3;
            this.btn_estadistica_cliente_baja_calcular.Text = "Calcular";
            this.btn_estadistica_cliente_baja_calcular.UseVisualStyleBackColor = true;
            this.btn_estadistica_cliente_baja_calcular.Click += new System.EventHandler(this.btn_estadistica_cliente_baja_calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Año";
            // 
            // txt_estadistica_cliente_baja_año
            // 
            this.txt_estadistica_cliente_baja_año.Location = new System.Drawing.Point(206, 90);
            this.txt_estadistica_cliente_baja_año.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_estadistica_cliente_baja_año.Name = "txt_estadistica_cliente_baja_año";
            this.txt_estadistica_cliente_baja_año.Pp_Campo = null;
            this.txt_estadistica_cliente_baja_año.Pp_MensajeError = null;
            this.txt_estadistica_cliente_baja_año.Pp_Tabla = null;
            this.txt_estadistica_cliente_baja_año.Pp_Validable = false;
            this.txt_estadistica_cliente_baja_año.Size = new System.Drawing.Size(119, 22);
            this.txt_estadistica_cliente_baja_año.TabIndex = 1;
            // 
            // rv_estadistica_cliente_baja
            // 
            this.rv_estadistica_cliente_baja.Location = new System.Drawing.Point(15, 133);
            this.rv_estadistica_cliente_baja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rv_estadistica_cliente_baja.Name = "rv_estadistica_cliente_baja";
            this.rv_estadistica_cliente_baja.ServerReport.BearerToken = null;
            this.rv_estadistica_cliente_baja.Size = new System.Drawing.Size(1126, 491);
            this.rv_estadistica_cliente_baja.TabIndex = 0;
            // 
            // ClientXServ
            // 
            this.ClientXServ.Controls.Add(this.rv_Clien_Serv);
            this.ClientXServ.Controls.Add(this.groupBox1);
            this.ClientXServ.Location = new System.Drawing.Point(4, 25);
            this.ClientXServ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClientXServ.Name = "ClientXServ";
            this.ClientXServ.Size = new System.Drawing.Size(1141, 632);
            this.ClientXServ.TabIndex = 1;
            this.ClientXServ.Text = "Cliente por Servicio Usado";
            this.ClientXServ.UseVisualStyleBackColor = true;
            // 
            // rv_Clien_Serv
            // 
            this.rv_Clien_Serv.Location = new System.Drawing.Point(5, 139);
            this.rv_Clien_Serv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rv_Clien_Serv.Name = "rv_Clien_Serv";
            this.rv_Clien_Serv.ServerReport.BearerToken = null;
            this.rv_Clien_Serv.Size = new System.Drawing.Size(1125, 483);
            this.rv_Clien_Serv.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btn_calcular_C);
            this.groupBox1.Location = new System.Drawing.Point(9, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(439, 127);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_year_C);
            this.groupBox2.Controls.Add(this.txt_año);
            this.groupBox2.Location = new System.Drawing.Point(155, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(263, 62);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // txt_year_C
            // 
            this.txt_year_C.Location = new System.Drawing.Point(173, 22);
            this.txt_year_C.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_year_C.Name = "txt_year_C";
            this.txt_year_C.Pp_Campo = null;
            this.txt_year_C.Pp_MensajeError = null;
            this.txt_year_C.Pp_Tabla = null;
            this.txt_year_C.Pp_Validable = false;
            this.txt_year_C.Size = new System.Drawing.Size(79, 22);
            this.txt_year_C.TabIndex = 1;
            this.txt_year_C.Text = "AAAA";
            this.txt_year_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_year_C.Click += new System.EventHandler(this.txt_year_C_Click);
            // 
            // txt_año
            // 
            this.txt_año.AutoSize = true;
            this.txt_año.Location = new System.Drawing.Point(8, 22);
            this.txt_año.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_año.Name = "txt_año";
            this.txt_año.Size = new System.Drawing.Size(157, 17);
            this.txt_año.TabIndex = 25;
            this.txt_año.Text = "Ingrese el año a buscar";
            // 
            // btn_calcular_C
            // 
            this.btn_calcular_C.Location = new System.Drawing.Point(317, 92);
            this.btn_calcular_C.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_calcular_C.Name = "btn_calcular_C";
            this.btn_calcular_C.Size = new System.Drawing.Size(100, 28);
            this.btn_calcular_C.TabIndex = 1;
            this.btn_calcular_C.Text = "Calcular";
            this.btn_calcular_C.UseVisualStyleBackColor = true;
            this.btn_calcular_C.Click += new System.EventHandler(this.btn_calcular_C_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1141, 632);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Cantidad de Clientes por Ciudad";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1141, 632);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Cantidad de Clientes por Provincia";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.ErrorImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 15);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(132, 91);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox012);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(155, 23);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(290, 62);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            // 
            // textBox012
            // 
            this.textBox012.Location = new System.Drawing.Point(187, 22);
            this.textBox012.Margin = new System.Windows.Forms.Padding(4);
            this.textBox012.Name = "textBox012";
            this.textBox012.Pp_Campo = null;
            this.textBox012.Pp_MensajeError = null;
            this.textBox012.Pp_Tabla = null;
            this.textBox012.Pp_Validable = false;
            this.textBox012.Size = new System.Drawing.Size(95, 22);
            this.textBox012.TabIndex = 1;
            this.textBox012.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Cantidad a Mostrar";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pictureBox3);
            this.groupBox6.Controls.Add(this.groupBox5);
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Location = new System.Drawing.Point(8, 7);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(466, 127);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(336, 91);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Mostrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(8, 7);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(447, 127);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox011);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(155, 23);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(284, 62);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            // 
            // textBox011
            // 
            this.textBox011.Location = new System.Drawing.Point(173, 22);
            this.textBox011.Margin = new System.Windows.Forms.Padding(4);
            this.textBox011.Name = "textBox011";
            this.textBox011.Pp_Campo = null;
            this.textBox011.Pp_MensajeError = null;
            this.textBox011.Pp_Tabla = null;
            this.textBox011.Pp_Validable = false;
            this.textBox011.Size = new System.Drawing.Size(100, 22);
            this.textBox011.TabIndex = 1;
            this.textBox011.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Cantidad a Mostrar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 92);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 23);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.ErrorImage = null;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(16, 21);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(132, 91);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 30;
            this.pictureBox4.TabStop = false;
            // 
            // Frm_Estadistica_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 667);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private Microsoft.Reporting.WinForms.ReportViewer rv_Clien_Serv;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private Clases.TextBox01 textBox012;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Clases.TextBox01 textBox011;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}