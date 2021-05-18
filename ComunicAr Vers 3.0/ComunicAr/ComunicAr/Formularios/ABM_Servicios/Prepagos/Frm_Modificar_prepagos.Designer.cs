
namespace ComunicAr.Formularios.ABM_Servicios.Prepagos
{
    partial class Frm_Modificar_prepagos
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_id_region = new ComunicAr.Clases.ComboBox01();
            this.txt_costo = new ComunicAr.Clases.TextBox01();
            this.txt_duracion = new ComunicAr.Clases.TextBox01();
            this.txt_descripcion = new ComunicAr.Clases.TextBox01();
            this.txt_id_pack = new ComunicAr.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // bttn_cancelar
            // 
            this.bttn_cancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttn_cancelar.Location = new System.Drawing.Point(204, 197);
            this.bttn_cancelar.Name = "bttn_cancelar";
            this.bttn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bttn_cancelar.TabIndex = 28;
            this.bttn_cancelar.Text = "Cancelar";
            this.bttn_cancelar.UseVisualStyleBackColor = true;
            this.bttn_cancelar.Click += new System.EventHandler(this.bttn_cancelar_Click);
            // 
            // bttn_aceptar
            // 
            this.bttn_aceptar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttn_aceptar.Location = new System.Drawing.Point(98, 197);
            this.bttn_aceptar.Name = "bttn_aceptar";
            this.bttn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.bttn_aceptar.TabIndex = 27;
            this.bttn_aceptar.Text = "Aceptar";
            this.bttn_aceptar.UseVisualStyleBackColor = true;
            this.bttn_aceptar.Click += new System.EventHandler(this.bttn_aceptar_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(48, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(79, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(62, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Duracion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(52, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Región";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Modificar Servicios Prepagos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.Location = new System.Drawing.Point(71, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "ID Pack";
            // 
            // cmb_id_region
            // 
            this.cmb_id_region.FormattingEnabled = true;
            this.cmb_id_region.Location = new System.Drawing.Point(123, 170);
            this.cmb_id_region.Name = "cmb_id_region";
            this.cmb_id_region.Pp_Conseleccion = false;
            this.cmb_id_region.Pp_Descripcion = "descripcion";
            this.cmb_id_region.Pp_MensajeError = null;
            this.cmb_id_region.Pp_NombreCampo = null;
            this.cmb_id_region.Pp_NombreTabla = null;
            this.cmb_id_region.Pp_PK = "id_region";
            this.cmb_id_region.Pp_Tabla = "region";
            this.cmb_id_region.Pp_Validable = false;
            this.cmb_id_region.Size = new System.Drawing.Size(181, 21);
            this.cmb_id_region.TabIndex = 42;
            // 
            // txt_costo
            // 
            this.txt_costo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_costo.Location = new System.Drawing.Point(123, 141);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Pp_Campo = null;
            this.txt_costo.Pp_MensajeError = null;
            this.txt_costo.Pp_Tabla = null;
            this.txt_costo.Pp_Validable = false;
            this.txt_costo.Size = new System.Drawing.Size(181, 23);
            this.txt_costo.TabIndex = 21;
            // 
            // txt_duracion
            // 
            this.txt_duracion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_duracion.Location = new System.Drawing.Point(123, 81);
            this.txt_duracion.Name = "txt_duracion";
            this.txt_duracion.Pp_Campo = null;
            this.txt_duracion.Pp_MensajeError = null;
            this.txt_duracion.Pp_Tabla = null;
            this.txt_duracion.Pp_Validable = false;
            this.txt_duracion.Size = new System.Drawing.Size(181, 23);
            this.txt_duracion.TabIndex = 19;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_descripcion.Location = new System.Drawing.Point(123, 112);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Pp_Campo = null;
            this.txt_descripcion.Pp_MensajeError = null;
            this.txt_descripcion.Pp_Tabla = null;
            this.txt_descripcion.Pp_Validable = false;
            this.txt_descripcion.Size = new System.Drawing.Size(181, 23);
            this.txt_descripcion.TabIndex = 18;
            // 
            // txt_id_pack
            // 
            this.txt_id_pack.Enabled = false;
            this.txt_id_pack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_id_pack.Location = new System.Drawing.Point(123, 52);
            this.txt_id_pack.Name = "txt_id_pack";
            this.txt_id_pack.Pp_Campo = null;
            this.txt_id_pack.Pp_MensajeError = null;
            this.txt_id_pack.Pp_Tabla = null;
            this.txt_id_pack.Pp_Validable = false;
            this.txt_id_pack.Size = new System.Drawing.Size(181, 23);
            this.txt_id_pack.TabIndex = 17;
            // 
            // Frm_Modificar_prepagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 232);
            this.Controls.Add(this.cmb_id_region);
            this.Controls.Add(this.bttn_cancelar);
            this.Controls.Add(this.bttn_aceptar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_costo);
            this.Controls.Add(this.txt_duracion);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_id_pack);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Modificar_prepagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Modificar_prepagos";
            this.Load += new System.EventHandler(this.Frm_Modificar_prepagos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_cancelar;
        private System.Windows.Forms.Button bttn_aceptar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Clases.TextBox01 txt_costo;
        private Clases.TextBox01 txt_duracion;
        private Clases.TextBox01 txt_descripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private Clases.TextBox01 txt_id_pack;
        private Clases.ComboBox01 cmb_id_region;
    }
}