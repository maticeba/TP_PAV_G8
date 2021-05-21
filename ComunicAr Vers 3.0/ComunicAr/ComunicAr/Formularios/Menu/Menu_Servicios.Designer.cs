
namespace ComunicAr.Formularios.Menu
{
    partial class Menu_Servicios
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
            this.btn_menu_servicios_datos = new System.Windows.Forms.Button();
            this.btn_menu_servicios_fijo = new System.Windows.Forms.Button();
            this.btn_menu_servicios_prepago = new System.Windows.Forms.Button();
            this.btn_menu_servicios_contratados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_menu_servicios_datos
            // 
            this.btn_menu_servicios_datos.Location = new System.Drawing.Point(12, 48);
            this.btn_menu_servicios_datos.Name = "btn_menu_servicios_datos";
            this.btn_menu_servicios_datos.Size = new System.Drawing.Size(131, 27);
            this.btn_menu_servicios_datos.TabIndex = 0;
            this.btn_menu_servicios_datos.Text = "Servicio de Datos";
            this.btn_menu_servicios_datos.UseVisualStyleBackColor = true;
            this.btn_menu_servicios_datos.Click += new System.EventHandler(this.btn_menu_servicios_datos_Click);
            // 
            // btn_menu_servicios_fijo
            // 
            this.btn_menu_servicios_fijo.Location = new System.Drawing.Point(12, 82);
            this.btn_menu_servicios_fijo.Name = "btn_menu_servicios_fijo";
            this.btn_menu_servicios_fijo.Size = new System.Drawing.Size(131, 27);
            this.btn_menu_servicios_fijo.TabIndex = 1;
            this.btn_menu_servicios_fijo.Text = "Servicio Fijo";
            this.btn_menu_servicios_fijo.UseVisualStyleBackColor = true;
            this.btn_menu_servicios_fijo.Click += new System.EventHandler(this.btn_menu_servicios_fijo_Click);
            // 
            // btn_menu_servicios_prepago
            // 
            this.btn_menu_servicios_prepago.Location = new System.Drawing.Point(12, 115);
            this.btn_menu_servicios_prepago.Name = "btn_menu_servicios_prepago";
            this.btn_menu_servicios_prepago.Size = new System.Drawing.Size(131, 27);
            this.btn_menu_servicios_prepago.TabIndex = 2;
            this.btn_menu_servicios_prepago.Text = "Servicio Prepago";
            this.btn_menu_servicios_prepago.UseVisualStyleBackColor = true;
            this.btn_menu_servicios_prepago.Click += new System.EventHandler(this.btn_menu_servicios_prepago_Click);
            // 
            // btn_menu_servicios_contratados
            // 
            this.btn_menu_servicios_contratados.Location = new System.Drawing.Point(12, 150);
            this.btn_menu_servicios_contratados.Name = "btn_menu_servicios_contratados";
            this.btn_menu_servicios_contratados.Size = new System.Drawing.Size(131, 27);
            this.btn_menu_servicios_contratados.TabIndex = 3;
            this.btn_menu_servicios_contratados.Text = "Servicios Contratados";
            this.btn_menu_servicios_contratados.UseVisualStyleBackColor = true;
            this.btn_menu_servicios_contratados.Click += new System.EventHandler(this.btn_menu_servicios_contratados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Servicios";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu_Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(158, 217);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_menu_servicios_contratados);
            this.Controls.Add(this.btn_menu_servicios_prepago);
            this.Controls.Add(this.btn_menu_servicios_fijo);
            this.Controls.Add(this.btn_menu_servicios_datos);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_Servicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_menu_servicios_datos;
        private System.Windows.Forms.Button btn_menu_servicios_fijo;
        private System.Windows.Forms.Button btn_menu_servicios_prepago;
        private System.Windows.Forms.Button btn_menu_servicios_contratados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}