
namespace ComunicAr.Formularios.Reportes.Servicios
{
    partial class Frm_Rep_Servicios
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.rb_limite = new System.Windows.Forms.RadioButton();
            this.rb_Costo = new System.Windows.Forms.RadioButton();
            this.txt_costo = new ComunicAr.Clases.TextBox01();
            this.txt_limite = new ComunicAr.Clases.TextBox01();
            this.btn_Calcular_Datos = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1002, 605);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Controls.Add(this.btn_Calcular_Datos);
            this.tabPage1.Controls.Add(this.txt_limite);
            this.tabPage1.Controls.Add(this.txt_costo);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(994, 572);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Servicio de Datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(994, 572);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Gb";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "$";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_todos);
            this.groupBox2.Controls.Add(this.rb_limite);
            this.groupBox2.Controls.Add(this.rb_Costo);
            this.groupBox2.Location = new System.Drawing.Point(153, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(224, 143);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Location = new System.Drawing.Point(9, 111);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(82, 24);
            this.rb_todos.TabIndex = 3;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "Todos ";
            this.rb_todos.UseVisualStyleBackColor = true;
            this.rb_todos.CheckedChanged += new System.EventHandler(this.rb_todos_CheckedChanged);
            // 
            // rb_limite
            // 
            this.rb_limite.AutoSize = true;
            this.rb_limite.Location = new System.Drawing.Point(9, 71);
            this.rb_limite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_limite.Name = "rb_limite";
            this.rb_limite.Size = new System.Drawing.Size(212, 24);
            this.rb_limite.TabIndex = 2;
            this.rb_limite.TabStop = true;
            this.rb_limite.Text = "Por limite de datos hasta:";
            this.rb_limite.UseVisualStyleBackColor = true;
            this.rb_limite.CheckedChanged += new System.EventHandler(this.rb_limite_CheckedChanged);
            // 
            // rb_Costo
            // 
            this.rb_Costo.AutoSize = true;
            this.rb_Costo.Location = new System.Drawing.Point(9, 29);
            this.rb_Costo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_Costo.Name = "rb_Costo";
            this.rb_Costo.Size = new System.Drawing.Size(149, 24);
            this.rb_Costo.TabIndex = 1;
            this.rb_Costo.TabStop = true;
            this.rb_Costo.Text = "Por costo hasta:";
            this.rb_Costo.UseVisualStyleBackColor = true;
            this.rb_Costo.CheckedChanged += new System.EventHandler(this.rb_Costo_CheckedChanged);
            // 
            // txt_costo
            // 
            this.txt_costo.Location = new System.Drawing.Point(384, 36);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Pp_Campo = null;
            this.txt_costo.Pp_MensajeError = null;
            this.txt_costo.Pp_Tabla = null;
            this.txt_costo.Pp_Validable = false;
            this.txt_costo.Size = new System.Drawing.Size(125, 26);
            this.txt_costo.TabIndex = 17;
            // 
            // txt_limite
            // 
            this.txt_limite.Location = new System.Drawing.Point(384, 78);
            this.txt_limite.Name = "txt_limite";
            this.txt_limite.Pp_Campo = null;
            this.txt_limite.Pp_MensajeError = null;
            this.txt_limite.Pp_Tabla = null;
            this.txt_limite.Pp_Validable = false;
            this.txt_limite.Size = new System.Drawing.Size(124, 26);
            this.txt_limite.TabIndex = 18;
            // 
            // btn_Calcular_Datos
            // 
            this.btn_Calcular_Datos.Location = new System.Drawing.Point(894, 16);
            this.btn_Calcular_Datos.Name = "btn_Calcular_Datos";
            this.btn_Calcular_Datos.Size = new System.Drawing.Size(82, 27);
            this.btn_Calcular_Datos.TabIndex = 19;
            this.btn_Calcular_Datos.Text = "Calcular";
            this.btn_Calcular_Datos.UseVisualStyleBackColor = true;
            this.btn_Calcular_Datos.Click += new System.EventHandler(this.btn_Calcular_Datos_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(7, 156);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(969, 410);
            this.reportViewer1.TabIndex = 20;
            // 
            // Frm_Rep_Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 630);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_Rep_Servicios";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Rep_Servicios_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btn_Calcular_Datos;
        private Clases.TextBox01 txt_limite;
        private Clases.TextBox01 txt_costo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_todos;
        private System.Windows.Forms.RadioButton rb_limite;
        private System.Windows.Forms.RadioButton rb_Costo;
    }
}