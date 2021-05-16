
namespace ComunicAr.Formularios.Barrio
{
    partial class Frm_Baja_Barrio
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
            this.bttn_cancelar_baja_barrios = new System.Windows.Forms.Button();
            this.bttn_aceptar_baja_barrio = new System.Windows.Forms.Button();
            this.txt_nombre_barrio = new ComunicAr.Clases.TextBox01();
            this.cmb_codigo_ciudad = new ComunicAr.Clases.ComboBox01();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttn_cancelar_baja_barrios
            // 
            this.bttn_cancelar_baja_barrios.Location = new System.Drawing.Point(132, 97);
            this.bttn_cancelar_baja_barrios.Name = "bttn_cancelar_baja_barrios";
            this.bttn_cancelar_baja_barrios.Size = new System.Drawing.Size(75, 23);
            this.bttn_cancelar_baja_barrios.TabIndex = 29;
            this.bttn_cancelar_baja_barrios.Text = "Cancelar";
            this.bttn_cancelar_baja_barrios.UseVisualStyleBackColor = true;
            this.bttn_cancelar_baja_barrios.Click += new System.EventHandler(this.bttn_cancelar_baja_barrio);
            // 
            // bttn_aceptar_baja_barrio
            // 
            this.bttn_aceptar_baja_barrio.Location = new System.Drawing.Point(32, 97);
            this.bttn_aceptar_baja_barrio.Name = "bttn_aceptar_baja_barrio";
            this.bttn_aceptar_baja_barrio.Size = new System.Drawing.Size(75, 23);
            this.bttn_aceptar_baja_barrio.TabIndex = 28;
            this.bttn_aceptar_baja_barrio.Text = "Aceptar";
            this.bttn_aceptar_baja_barrio.UseVisualStyleBackColor = true;
            this.bttn_aceptar_baja_barrio.Click += new System.EventHandler(this.bttn_aceptar_baja_barrios);
            // 
            // txt_nombre_barrio
            // 
            this.txt_nombre_barrio.Enabled = false;
            this.txt_nombre_barrio.Location = new System.Drawing.Point(58, 44);
            this.txt_nombre_barrio.Name = "txt_nombre_barrio";
            this.txt_nombre_barrio.Pp_Campo = "nombre_razonSocial";
            this.txt_nombre_barrio.Pp_MensajeError = "Falta cargar el nombre del cliente";
            this.txt_nombre_barrio.Pp_Tabla = null;
            this.txt_nombre_barrio.Pp_Validable = false;
            this.txt_nombre_barrio.Size = new System.Drawing.Size(164, 20);
            this.txt_nombre_barrio.TabIndex = 24;
            // 
            // cmb_codigo_ciudad
            // 
            this.cmb_codigo_ciudad.Enabled = false;
            this.cmb_codigo_ciudad.FormattingEnabled = true;
            this.cmb_codigo_ciudad.Location = new System.Drawing.Point(58, 70);
            this.cmb_codigo_ciudad.Name = "cmb_codigo_ciudad";
            this.cmb_codigo_ciudad.Pp_Conseleccion = false;
            this.cmb_codigo_ciudad.Pp_Descripcion = "nombre_ciudad";
            this.cmb_codigo_ciudad.Pp_MensajeError = null;
            this.cmb_codigo_ciudad.Pp_NombreCampo = null;
            this.cmb_codigo_ciudad.Pp_NombreTabla = "";
            this.cmb_codigo_ciudad.Pp_PK = "cod_ciudad";
            this.cmb_codigo_ciudad.Pp_Tabla = "Ciudad";
            this.cmb_codigo_ciudad.Pp_Validable = true;
            this.cmb_codigo_ciudad.Size = new System.Drawing.Size(164, 21);
            this.cmb_codigo_ciudad.TabIndex = 23;
            this.cmb_codigo_ciudad.SelectedIndexChanged += new System.EventHandler(this.cmb_cliente_alta_barrio_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Ciudad";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Barrio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Borrar Barrio";
            // 
            // Frm_Baja_Barrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 129);
            this.Controls.Add(this.bttn_cancelar_baja_barrios);
            this.Controls.Add(this.bttn_aceptar_baja_barrio);
            this.Controls.Add(this.txt_nombre_barrio);
            this.Controls.Add(this.cmb_codigo_ciudad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Baja_Barrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Baja_Barrio";
            this.Load += new System.EventHandler(this.Frm_Baja_Barrio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_cancelar_baja_barrios;
        private System.Windows.Forms.Button bttn_aceptar_baja_barrio;
        private Clases.TextBox01 txt_nombre_barrio;
        private Clases.ComboBox01 cmb_codigo_ciudad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}