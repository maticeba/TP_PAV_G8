
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_estadistica_cliente_baja_calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rv_estadistica_cliente_baja = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_estadistica_cliente_baja_año = new ComunicAr.Clases.TextBox01();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
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
            // rv_estadistica_cliente_baja
            // 
            this.rv_estadistica_cliente_baja.Location = new System.Drawing.Point(3, 69);
            this.rv_estadistica_cliente_baja.Name = "rv_estadistica_cliente_baja";
            this.rv_estadistica_cliente_baja.ServerReport.BearerToken = null;
            this.rv_estadistica_cliente_baja.Size = new System.Drawing.Size(845, 436);
            this.rv_estadistica_cliente_baja.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(788, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer rv_estadistica_cliente_baja;
        private System.Windows.Forms.Button btn_estadistica_cliente_baja_calcular;
        private System.Windows.Forms.Label label1;
        private Clases.TextBox01 txt_estadistica_cliente_baja_año;
    }
}