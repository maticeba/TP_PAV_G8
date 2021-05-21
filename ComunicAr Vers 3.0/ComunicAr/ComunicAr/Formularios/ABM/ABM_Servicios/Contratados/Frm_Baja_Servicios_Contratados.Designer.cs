
namespace ComunicAr.Formularios.ABM_Servicios.Contratados
{
    partial class Frm_Baja_Servicios_Contratados
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
            this.bttn_cancelar = new System.Windows.Forms.Button();
            this.bttn_aceptar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fecha_hasta = new ComunicAr.Clases.TextBox01();
            this.txt_id_numero = new ComunicAr.Clases.TextBox01();
            this.txt_tipo_servicio = new ComunicAr.Clases.TextBox01();
            this.txt_fecha_desde = new ComunicAr.Clases.TextBox01();
            this.txt_id_Servicio = new ComunicAr.Clases.TextBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttn_cancelar
            // 
            this.bttn_cancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttn_cancelar.Location = new System.Drawing.Point(215, 195);
            this.bttn_cancelar.Name = "bttn_cancelar";
            this.bttn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bttn_cancelar.TabIndex = 38;
            this.bttn_cancelar.Text = "Cancelar";
            this.bttn_cancelar.UseVisualStyleBackColor = true;
            this.bttn_cancelar.Click += new System.EventHandler(this.bttn_cancelar_Click);
            // 
            // bttn_aceptar
            // 
            this.bttn_aceptar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttn_aceptar.Location = new System.Drawing.Point(109, 195);
            this.bttn_aceptar.Name = "bttn_aceptar";
            this.bttn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.bttn_aceptar.TabIndex = 37;
            this.bttn_aceptar.Text = "Aceptar";
            this.bttn_aceptar.UseVisualStyleBackColor = true;
            this.bttn_aceptar.Click += new System.EventHandler(this.bttn_aceptar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.Location = new System.Drawing.Point(41, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 36;
            this.label7.Text = "ID Servicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(30, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 35;
            this.label6.Text = "Fecha Desde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(32, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Fecha Hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(29, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "Tipo Servicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(9, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nro. de Teléfono";
            // 
            // txt_fecha_hasta
            // 
            this.txt_fecha_hasta.Enabled = false;
            this.txt_fecha_hasta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_fecha_hasta.Location = new System.Drawing.Point(109, 166);
            this.txt_fecha_hasta.Name = "txt_fecha_hasta";
            this.txt_fecha_hasta.Pp_Campo = null;
            this.txt_fecha_hasta.Pp_MensajeError = null;
            this.txt_fecha_hasta.Pp_Tabla = null;
            this.txt_fecha_hasta.Pp_Validable = false;
            this.txt_fecha_hasta.Size = new System.Drawing.Size(181, 23);
            this.txt_fecha_hasta.TabIndex = 31;
            this.txt_fecha_hasta.Text = "DD/MM/YYYY";
            // 
            // txt_id_numero
            // 
            this.txt_id_numero.Enabled = false;
            this.txt_id_numero.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_id_numero.Location = new System.Drawing.Point(109, 108);
            this.txt_id_numero.Name = "txt_id_numero";
            this.txt_id_numero.Pp_Campo = null;
            this.txt_id_numero.Pp_MensajeError = null;
            this.txt_id_numero.Pp_Tabla = null;
            this.txt_id_numero.Pp_Validable = false;
            this.txt_id_numero.Size = new System.Drawing.Size(181, 23);
            this.txt_id_numero.TabIndex = 30;
            // 
            // txt_tipo_servicio
            // 
            this.txt_tipo_servicio.Enabled = false;
            this.txt_tipo_servicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_tipo_servicio.Location = new System.Drawing.Point(109, 79);
            this.txt_tipo_servicio.Name = "txt_tipo_servicio";
            this.txt_tipo_servicio.Pp_Campo = null;
            this.txt_tipo_servicio.Pp_MensajeError = null;
            this.txt_tipo_servicio.Pp_Tabla = null;
            this.txt_tipo_servicio.Pp_Validable = false;
            this.txt_tipo_servicio.Size = new System.Drawing.Size(181, 23);
            this.txt_tipo_servicio.TabIndex = 29;
            // 
            // txt_fecha_desde
            // 
            this.txt_fecha_desde.Enabled = false;
            this.txt_fecha_desde.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_fecha_desde.Location = new System.Drawing.Point(109, 137);
            this.txt_fecha_desde.Name = "txt_fecha_desde";
            this.txt_fecha_desde.Pp_Campo = null;
            this.txt_fecha_desde.Pp_MensajeError = null;
            this.txt_fecha_desde.Pp_Tabla = null;
            this.txt_fecha_desde.Pp_Validable = false;
            this.txt_fecha_desde.Size = new System.Drawing.Size(181, 23);
            this.txt_fecha_desde.TabIndex = 28;
            this.txt_fecha_desde.Text = "DD/MM/YYYY";
            // 
            // txt_id_Servicio
            // 
            this.txt_id_Servicio.Enabled = false;
            this.txt_id_Servicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_id_Servicio.Location = new System.Drawing.Point(109, 50);
            this.txt_id_Servicio.Name = "txt_id_Servicio";
            this.txt_id_Servicio.Pp_Campo = null;
            this.txt_id_Servicio.Pp_MensajeError = null;
            this.txt_id_Servicio.Pp_Tabla = null;
            this.txt_id_Servicio.Pp_Validable = false;
            this.txt_id_Servicio.Size = new System.Drawing.Size(181, 23);
            this.txt_id_Servicio.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 32);
            this.label1.TabIndex = 26;
            this.label1.Text = "Baja Servicios Contratados";
            // 
            // Frm_Baja_Servicios_Contratados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 225);
            this.Controls.Add(this.bttn_cancelar);
            this.Controls.Add(this.bttn_aceptar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_fecha_hasta);
            this.Controls.Add(this.txt_id_numero);
            this.Controls.Add(this.txt_tipo_servicio);
            this.Controls.Add(this.txt_fecha_desde);
            this.Controls.Add(this.txt_id_Servicio);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Baja_Servicios_Contratados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_baja_servicio";
            this.Load += new System.EventHandler(this.Frm_baja_servicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_cancelar;
        private System.Windows.Forms.Button bttn_aceptar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Clases.TextBox01 txt_fecha_hasta;
        private Clases.TextBox01 txt_id_numero;
        private Clases.TextBox01 txt_tipo_servicio;
        private Clases.TextBox01 txt_fecha_desde;
        private Clases.TextBox01 txt_id_Servicio;
        private System.Windows.Forms.Label label1;
    }
}