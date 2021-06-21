
namespace ComunicAr.Formularios.Estadisticas.Dispositivos
{
    partial class Frm_DispVend_Estadisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DispVend_Estadisticas));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DispositivosVendidos = new System.Windows.Forms.TabPage();
            this.DispositivosPorServicios = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtYear = new ComunicAr.Clases.TextBox01();
            this.txtMes = new ComunicAr.Clases.TextBox01();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.DispositivosVendidos.SuspendLayout();
            this.DispositivosPorServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(19, 128);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(603, 407);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(162, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 71);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(106, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Mes y año actual";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(158, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "En un mes y año especifico:";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DispositivosVendidos);
            this.tabControl1.Controls.Add(this.DispositivosPorServicios);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(652, 591);
            this.tabControl1.TabIndex = 6;
            // 
            // DispositivosVendidos
            // 
            this.DispositivosVendidos.Controls.Add(this.reportViewer1);
            this.DispositivosVendidos.Controls.Add(this.txtYear);
            this.DispositivosVendidos.Controls.Add(this.pictureBox1);
            this.DispositivosVendidos.Controls.Add(this.txtMes);
            this.DispositivosVendidos.Controls.Add(this.button1);
            this.DispositivosVendidos.Controls.Add(this.groupBox1);
            this.DispositivosVendidos.Location = new System.Drawing.Point(4, 22);
            this.DispositivosVendidos.Name = "DispositivosVendidos";
            this.DispositivosVendidos.Padding = new System.Windows.Forms.Padding(3);
            this.DispositivosVendidos.Size = new System.Drawing.Size(644, 565);
            this.DispositivosVendidos.TabIndex = 0;
            this.DispositivosVendidos.Text = "DispositivosVendidos";
            this.DispositivosVendidos.UseVisualStyleBackColor = true;
            this.DispositivosVendidos.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // DispositivosPorServicios
            // 
            this.DispositivosPorServicios.Controls.Add(this.reportViewer2);
            this.DispositivosPorServicios.Controls.Add(this.pictureBox2);
            this.DispositivosPorServicios.Controls.Add(this.button2);
            this.DispositivosPorServicios.Location = new System.Drawing.Point(4, 22);
            this.DispositivosPorServicios.Name = "DispositivosPorServicios";
            this.DispositivosPorServicios.Padding = new System.Windows.Forms.Padding(3);
            this.DispositivosPorServicios.Size = new System.Drawing.Size(644, 565);
            this.DispositivosPorServicios.TabIndex = 1;
            this.DispositivosPorServicios.Text = "DispositivosPorServicios";
            this.DispositivosPorServicios.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Location = new System.Drawing.Point(6, 133);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(626, 400);
            this.reportViewer2.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(557, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtYear
            // 
            this.txtYear.Enabled = false;
            this.txtYear.Location = new System.Drawing.Point(403, 38);
            this.txtYear.Name = "txtYear";
            this.txtYear.Pp_Campo = null;
            this.txtYear.Pp_MensajeError = null;
            this.txtYear.Pp_Tabla = null;
            this.txtYear.Pp_Validable = false;
            this.txtYear.Size = new System.Drawing.Size(57, 20);
            this.txtYear.TabIndex = 5;
            // 
            // txtMes
            // 
            this.txtMes.Enabled = false;
            this.txtMes.Location = new System.Drawing.Point(340, 38);
            this.txtMes.Name = "txtMes";
            this.txtMes.Pp_Campo = null;
            this.txtMes.Pp_MensajeError = null;
            this.txtMes.Pp_Tabla = null;
            this.txtMes.Pp_Validable = false;
            this.txtMes.Size = new System.Drawing.Size(57, 20);
            this.txtMes.TabIndex = 4;
            // 
            // Frm_DispVend_Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 627);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_DispVend_Estadisticas";
            this.Text = "Frm_DispVend_Estadisticas";
            this.Load += new System.EventHandler(this.Frm_DispVend_Estadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.DispositivosVendidos.ResumeLayout(false);
            this.DispositivosVendidos.PerformLayout();
            this.DispositivosPorServicios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private Clases.TextBox01 txtMes;
        private Clases.TextBox01 txtYear;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DispositivosVendidos;
        private System.Windows.Forms.TabPage DispositivosPorServicios;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}