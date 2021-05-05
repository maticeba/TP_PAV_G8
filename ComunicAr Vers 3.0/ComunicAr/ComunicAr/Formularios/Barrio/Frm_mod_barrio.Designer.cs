
namespace ComunicAr.Formularios.Barrio
{
    partial class Frm_mod_barrio
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
            this.btn_cliente_alta_cancelar = new System.Windows.Forms.Button();
            this.btn_cliente_mod_aceptar = new System.Windows.Forms.Button();
            this.txt_nombre_barrio = new ComunicAr.Clases.TextBox01();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_codigo_ciudad = new ComunicAr.Clases.ComboBox01();
            this.SuspendLayout();
            // 
            // btn_cliente_alta_cancelar
            // 
            this.btn_cliente_alta_cancelar.Location = new System.Drawing.Point(226, 190);
            this.btn_cliente_alta_cancelar.Name = "btn_cliente_alta_cancelar";
            this.btn_cliente_alta_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cliente_alta_cancelar.TabIndex = 32;
            this.btn_cliente_alta_cancelar.Text = "Cancelar";
            this.btn_cliente_alta_cancelar.UseVisualStyleBackColor = true;
            this.btn_cliente_alta_cancelar.Click += new System.EventHandler(this.btn_cliente_alta_cancelar_Click);
            // 
            // btn_cliente_mod_aceptar
            // 
            this.btn_cliente_mod_aceptar.Location = new System.Drawing.Point(53, 190);
            this.btn_cliente_mod_aceptar.Name = "btn_cliente_mod_aceptar";
            this.btn_cliente_mod_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_cliente_mod_aceptar.TabIndex = 31;
            this.btn_cliente_mod_aceptar.Text = "Aceptar";
            this.btn_cliente_mod_aceptar.UseVisualStyleBackColor = true;
            this.btn_cliente_mod_aceptar.Click += new System.EventHandler(this.btn_cliente_mod_aceptar_Click);
            // 
            // txt_nombre_barrio
            // 
            this.txt_nombre_barrio.Location = new System.Drawing.Point(137, 98);
            this.txt_nombre_barrio.Name = "txt_nombre_barrio";
            this.txt_nombre_barrio.Pp_Campo = "nombre_razonSocial";
            this.txt_nombre_barrio.Pp_MensajeError = "Falta cargar el nombre del cliente";
            this.txt_nombre_barrio.Pp_Tabla = null;
            this.txt_nombre_barrio.Pp_Validable = false;
            this.txt_nombre_barrio.Size = new System.Drawing.Size(164, 20);
            this.txt_nombre_barrio.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Codigo Ciudad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre Barrio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 32);
            this.label1.TabIndex = 26;
            this.label1.Text = "Modificar Barrios";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmb_codigo_ciudad
            // 
            this.cmb_codigo_ciudad.FormattingEnabled = true;
            this.cmb_codigo_ciudad.Location = new System.Drawing.Point(137, 130);
            this.cmb_codigo_ciudad.Name = "cmb_codigo_ciudad";
            this.cmb_codigo_ciudad.Pp_Conseleccion = false;
            this.cmb_codigo_ciudad.Pp_Descripcion = "nombre_ciudad";
            this.cmb_codigo_ciudad.Pp_MensajeError = null;
            this.cmb_codigo_ciudad.Pp_NombreCampo = null;
            this.cmb_codigo_ciudad.Pp_NombreTabla = null;
            this.cmb_codigo_ciudad.Pp_PK = "cod_ciudad";
            this.cmb_codigo_ciudad.Pp_Tabla = "ciudades";
            this.cmb_codigo_ciudad.Pp_Validable = false;
            this.cmb_codigo_ciudad.Size = new System.Drawing.Size(163, 21);
            this.cmb_codigo_ciudad.TabIndex = 33;
            this.cmb_codigo_ciudad.SelectedIndexChanged += new System.EventHandler(this.comobox_codigo_ciudad_SelectedIndexChanged);
            // 
            // Frm_mod_barrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 266);
            this.Controls.Add(this.cmb_codigo_ciudad);
            this.Controls.Add(this.btn_cliente_alta_cancelar);
            this.Controls.Add(this.btn_cliente_mod_aceptar);
            this.Controls.Add(this.txt_nombre_barrio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_mod_barrio";
            this.Text = "Frm_mod_barrio";
            this.Load += new System.EventHandler(this.Frm_mod_barrio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cliente_alta_cancelar;
        private System.Windows.Forms.Button btn_cliente_mod_aceptar;
        private Clases.TextBox01 txt_nombre_barrio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Clases.ComboBox01 cmb_codigo_ciudad;
    }
}