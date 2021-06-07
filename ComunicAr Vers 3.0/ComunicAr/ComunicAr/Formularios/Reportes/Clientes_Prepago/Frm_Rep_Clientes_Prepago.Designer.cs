
namespace ComunicAr.Formularios.Reportes.Clientes_Prepago
{
    partial class Frm_Rep_Clientes_Prepago
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rB2 = new System.Windows.Forms.RadioButton();
            this.rB1 = new System.Windows.Forms.RadioButton();
            this.textBox011 = new ComunicAr.Clases.TextBox01();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 140);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1003, 428);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rB2);
            this.groupBox1.Controls.Add(this.rB1);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(311, 118);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // rB2
            // 
            this.rB2.AutoSize = true;
            this.rB2.Location = new System.Drawing.Point(9, 71);
            this.rB2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rB2.Name = "rB2";
            this.rB2.Size = new System.Drawing.Size(82, 24);
            this.rB2.TabIndex = 2;
            this.rB2.TabStop = true;
            this.rB2.Text = "Todos:";
            this.rB2.UseVisualStyleBackColor = true;
            this.rB2.CheckedChanged += new System.EventHandler(this.rB2_CheckedChanged);
            // 
            // rB1
            // 
            this.rB1.AutoSize = true;
            this.rB1.Location = new System.Drawing.Point(9, 29);
            this.rB1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rB1.Name = "rB1";
            this.rB1.Size = new System.Drawing.Size(288, 24);
            this.rB1.TabIndex = 1;
            this.rB1.TabStop = true;
            this.rB1.Text = "Cantidad de prepagos contratados: ";
            this.rB1.UseVisualStyleBackColor = true;
            // 
            // textBox011
            // 
            this.textBox011.Location = new System.Drawing.Point(331, 45);
            this.textBox011.Name = "textBox011";
            this.textBox011.Pp_Campo = null;
            this.textBox011.Pp_MensajeError = null;
            this.textBox011.Pp_Tabla = null;
            this.textBox011.Pp_Validable = false;
            this.textBox011.Size = new System.Drawing.Size(144, 26);
            this.textBox011.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(900, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_Rep_Clientes_Prepago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 580);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox011);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rep_Clientes_Prepago";
            this.Text = "Frm_Rep_Clientes_Prepago";
            this.Load += new System.EventHandler(this.Frm_Rep_Clientes_Prepago_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rB2;
        private System.Windows.Forms.RadioButton rB1;
        private Clases.TextBox01 textBox011;
        private System.Windows.Forms.Button button1;
    }
}