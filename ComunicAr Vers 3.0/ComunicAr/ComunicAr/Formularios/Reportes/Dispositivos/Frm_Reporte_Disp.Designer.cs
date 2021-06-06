
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
            this.RepDisp02BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_ReportDisp = new ComunicAr.Formularios.Reportes.Dispositivos.DS_ReportDisp();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox01 = new ComunicAr.Clases.TextBox01();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rB2 = new System.Windows.Forms.RadioButton();
            this.rB1 = new System.Windows.Forms.RadioButton();
            this.textBox02 = new ComunicAr.Clases.TextBox01();
            ((System.ComponentModel.ISupportInitialize)(this.RepDisp02BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_ReportDisp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.reportViewer1.Location = new System.Drawing.Point(30, 134);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(645, 278);
            this.reportViewer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(600, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox01
            // 
            this.textBox01.Enabled = false;
            this.textBox01.Location = new System.Drawing.Point(338, 31);
            this.textBox01.Name = "textBox01";
            this.textBox01.Pp_Campo = null;
            this.textBox01.Pp_MensajeError = null;
            this.textBox01.Pp_Tabla = null;
            this.textBox01.Pp_Validable = false;
            this.textBox01.Size = new System.Drawing.Size(100, 20);
            this.textBox01.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::ComunicAr.Properties.Resources.kisspng_telephone_computer_icons_smartphone_phone_portrait_smartphone_telephone_icon_5ab125de762f86_4600409415215590064841;
            this.pictureBox1.Location = new System.Drawing.Point(30, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rB2);
            this.groupBox1.Controls.Add(this.rB1);
            this.groupBox1.Location = new System.Drawing.Point(183, 13);
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
            // textBox02
            // 
            this.textBox02.Enabled = false;
            this.textBox02.Location = new System.Drawing.Point(338, 60);
            this.textBox02.Name = "textBox02";
            this.textBox02.Pp_Campo = null;
            this.textBox02.Pp_MensajeError = null;
            this.textBox02.Pp_Tabla = null;
            this.textBox02.Pp_Validable = false;
            this.textBox02.Size = new System.Drawing.Size(100, 20);
            this.textBox02.TabIndex = 8;
            // 
            // Frm_Reporte_Disp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 453);
            this.Controls.Add(this.textBox02);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox01);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Reporte_Disp";
            this.Text = "Frm_Reporte_Disp";
            this.Load += new System.EventHandler(this.Frm_Reporte_Disp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RepDisp02BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_ReportDisp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Clases.TextBox01 textBox02;
    }
}