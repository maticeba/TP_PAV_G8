
namespace ComunicAr.Formularios.Reportes.Dispositivos
{
    partial class Frm_Reporte_Disp
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Reporte_Disp));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RepDisp02BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_ReportDisp = new ComunicAr.Formularios.Reportes.Dispositivos.DS_ReportDisp();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rB2 = new System.Windows.Forms.RadioButton();
            this.rB1 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox011 = new ComunicAr.Clases.ComboBox01();
            this.textBox01 = new ComunicAr.Clases.TextBox01();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.textBox03 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox07 = new System.Windows.Forms.TextBox();
            this.textBox05 = new System.Windows.Forms.TextBox();
            this.textBox06 = new System.Windows.Forms.TextBox();
            this.textBox04 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rB5 = new System.Windows.Forms.RadioButton();
            this.rB4 = new System.Windows.Forms.RadioButton();
            this.rB3 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RepDisp02BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_ReportDisp)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RepDisp02BindingSource
            // 
            this.RepDisp02BindingSource.DataMember = "RepDisp02";
            this.RepDisp02BindingSource.DataSource = this.DS_ReportDisp;
            // 
            // DS_ReportDisp
            // 
            this.DS_ReportDisp.DataSetName = "DS_ReportDisp";
            this.DS_ReportDisp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.RepDisp02BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.Dispositivos.Reporte_Disp.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(26, 135);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(666, 321);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rB2);
            this.groupBox1.Controls.Add(this.rB1);
            this.groupBox1.Location = new System.Drawing.Point(179, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 93);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // rB2
            // 
            this.rB2.AutoSize = true;
            this.rB2.Location = new System.Drawing.Point(6, 46);
            this.rB2.Name = "rB2";
            this.rB2.Size = new System.Drawing.Size(77, 17);
            this.rB2.TabIndex = 2;
            this.rB2.TabStop = true;
            this.rB2.Text = "Por Marca:";
            this.rB2.UseVisualStyleBackColor = true;
            this.rB2.CheckedChanged += new System.EventHandler(this.rB2_CheckedChanged);
            // 
            // rB1
            // 
            this.rB1.AutoSize = true;
            this.rB1.Location = new System.Drawing.Point(6, 19);
            this.rB1.Name = "rB1";
            this.rB1.Size = new System.Drawing.Size(125, 17);
            this.rB1.TabIndex = 1;
            this.rB1.TabStop = true;
            this.rB1.Text = "Por Fecha Anterior a:";
            this.rB1.UseVisualStyleBackColor = true;
            this.rB1.CheckedChanged += new System.EventHandler(this.rB1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::ComunicAr.Properties.Resources.kisspng_telephone_computer_icons_smartphone_phone_portrait_smartphone_telephone_icon_5ab125de762f86_4600409415215590064841;
            this.pictureBox1.Location = new System.Drawing.Point(26, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(729, 533);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox011);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.textBox01);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(721, 507);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dispositivos";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // comboBox011
            // 
            this.comboBox011.Enabled = false;
            this.comboBox011.FormattingEnabled = true;
            this.comboBox011.Location = new System.Drawing.Point(334, 60);
            this.comboBox011.Name = "comboBox011";
            this.comboBox011.Pp_Conseleccion = false;
            this.comboBox011.Pp_Descripcion = "marca";
            this.comboBox011.Pp_MensajeError = null;
            this.comboBox011.Pp_NombreCampo = null;
            this.comboBox011.Pp_NombreTabla = null;
            this.comboBox011.Pp_PK = "NULL";
            this.comboBox011.Pp_Tabla = "Dispositivos";
            this.comboBox011.Pp_Validable = false;
            this.comboBox011.Size = new System.Drawing.Size(121, 21);
            this.comboBox011.TabIndex = 8;
            // 
            // textBox01
            // 
            this.textBox01.Enabled = false;
            this.textBox01.Location = new System.Drawing.Point(334, 32);
            this.textBox01.Name = "textBox01";
            this.textBox01.Pp_Campo = null;
            this.textBox01.Pp_MensajeError = null;
            this.textBox01.Pp_Tabla = null;
            this.textBox01.Pp_Validable = false;
            this.textBox01.Size = new System.Drawing.Size(121, 20);
            this.textBox01.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Controls.Add(this.textBox03);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.textBox07);
            this.tabPage2.Controls.Add(this.textBox05);
            this.tabPage2.Controls.Add(this.textBox06);
            this.tabPage2.Controls.Add(this.textBox04);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(721, 507);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dispositivos Vendidos";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.RepDisp02BindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.Dispositivos.Reporte_Disp.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(24, 126);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(661, 346);
            this.reportViewer2.TabIndex = 21;
            // 
            // textBox03
            // 
            this.textBox03.Enabled = false;
            this.textBox03.Location = new System.Drawing.Point(406, 25);
            this.textBox03.Name = "textBox03";
            this.textBox03.Size = new System.Drawing.Size(100, 20);
            this.textBox03.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(610, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Calcular";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox07
            // 
            this.textBox07.Enabled = false;
            this.textBox07.Location = new System.Drawing.Point(444, 78);
            this.textBox07.Name = "textBox07";
            this.textBox07.Size = new System.Drawing.Size(62, 20);
            this.textBox07.TabIndex = 18;
            // 
            // textBox05
            // 
            this.textBox05.Enabled = false;
            this.textBox05.Location = new System.Drawing.Point(512, 51);
            this.textBox05.Name = "textBox05";
            this.textBox05.Size = new System.Drawing.Size(100, 20);
            this.textBox05.TabIndex = 17;
            // 
            // textBox06
            // 
            this.textBox06.Enabled = false;
            this.textBox06.Location = new System.Drawing.Point(406, 78);
            this.textBox06.Name = "textBox06";
            this.textBox06.Size = new System.Drawing.Size(32, 20);
            this.textBox06.TabIndex = 16;
            // 
            // textBox04
            // 
            this.textBox04.Enabled = false;
            this.textBox04.Location = new System.Drawing.Point(406, 51);
            this.textBox04.Name = "textBox04";
            this.textBox04.Size = new System.Drawing.Size(100, 20);
            this.textBox04.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = global::ComunicAr.Properties.Resources.kisspng_telephone_computer_icons_smartphone_phone_portrait_smartphone_telephone_icon_5ab125de762f86_4600409415215590064841;
            this.pictureBox2.Location = new System.Drawing.Point(24, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(409, -24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rB5);
            this.groupBox2.Controls.Add(this.rB4);
            this.groupBox2.Controls.Add(this.rB3);
            this.groupBox2.Location = new System.Drawing.Point(201, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // rB5
            // 
            this.rB5.AutoSize = true;
            this.rB5.Location = new System.Drawing.Point(6, 69);
            this.rB5.Name = "rB5";
            this.rB5.Size = new System.Drawing.Size(149, 17);
            this.rB5.TabIndex = 2;
            this.rB5.TabStop = true;
            this.rB5.Text = "Por Mes y Año Especifico:";
            this.rB5.UseVisualStyleBackColor = true;
            this.rB5.CheckedChanged += new System.EventHandler(this.rB5_CheckedChanged);
            // 
            // rB4
            // 
            this.rB4.AutoSize = true;
            this.rB4.Location = new System.Drawing.Point(6, 43);
            this.rB4.Name = "rB4";
            this.rB4.Size = new System.Drawing.Size(127, 17);
            this.rB4.TabIndex = 1;
            this.rB4.TabStop = true;
            this.rB4.Text = "Por Rango de Precio:";
            this.rB4.UseVisualStyleBackColor = true;
            this.rB4.CheckedChanged += new System.EventHandler(this.rB4_CheckedChanged);
            // 
            // rB3
            // 
            this.rB3.AutoSize = true;
            this.rB3.Location = new System.Drawing.Point(6, 17);
            this.rB3.Name = "rB3";
            this.rB3.Size = new System.Drawing.Size(77, 17);
            this.rB3.TabIndex = 0;
            this.rB3.TabStop = true;
            this.rB3.Text = "Por Precio:";
            this.rB3.UseVisualStyleBackColor = true;
            this.rB3.CheckedChanged += new System.EventHandler(this.rB3_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(610, -40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Frm_Reporte_Disp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 557);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_Reporte_Disp";
            this.Text = "Frm_Reporte_Disp";
            this.Load += new System.EventHandler(this.Frm_Reporte_Disp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RepDisp02BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_ReportDisp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RepDisp02BindingSource;
        private DS_ReportDisp DS_ReportDisp;
        private System.Windows.Forms.Button button1;
        private Clases.TextBox01 textBox01;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rB1;
        private System.Windows.Forms.RadioButton rB2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox07;
        private System.Windows.Forms.TextBox textBox05;
        private System.Windows.Forms.TextBox textBox06;
        private System.Windows.Forms.TextBox textBox04;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rB5;
        private System.Windows.Forms.RadioButton rB4;
        private System.Windows.Forms.RadioButton rB3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox03;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Clases.ComboBox01 comboBox011;
    }
}