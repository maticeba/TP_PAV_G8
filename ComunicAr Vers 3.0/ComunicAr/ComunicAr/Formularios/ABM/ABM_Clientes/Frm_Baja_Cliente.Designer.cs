
namespace ComunicAr.Formularios.ABM_Clientes
{
    partial class Frm_Baja_Cliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_cliente_alta_aceptar = new System.Windows.Forms.Button();
            this.btn_cliente_alta_cancelar = new System.Windows.Forms.Button();
            this.txt_cliente_alta_piso = new ComunicAr.Clases.TextBox01();
            this.txt_cliente_alta_nro = new ComunicAr.Clases.TextBox01();
            this.txt_cliente_alta_calle = new ComunicAr.Clases.TextBox01();
            this.txt_cliente_alta_nombre = new ComunicAr.Clases.TextBox01();
            this.cmb_cliente_alta_barrio = new ComunicAr.Clases.ComboBox01();
            this.cmb_Ciudades = new ComunicAr.Clases.ComboBox01();
            this.cmb_Provincias = new ComunicAr.Clases.ComboBox01();
            this.label7 = new System.Windows.Forms.Label();
            this.Provincia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borrar Cliente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre/Razón Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Calle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nro. de Calle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Piso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Barrio";
            // 
            // btn_cliente_alta_aceptar
            // 
            this.btn_cliente_alta_aceptar.Location = new System.Drawing.Point(140, 244);
            this.btn_cliente_alta_aceptar.Name = "btn_cliente_alta_aceptar";
            this.btn_cliente_alta_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_cliente_alta_aceptar.TabIndex = 15;
            this.btn_cliente_alta_aceptar.Text = "Aceptar";
            this.btn_cliente_alta_aceptar.UseVisualStyleBackColor = true;
            this.btn_cliente_alta_aceptar.Click += new System.EventHandler(this.btn_cliente_alta_aceptar_Click);
            // 
            // btn_cliente_alta_cancelar
            // 
            this.btn_cliente_alta_cancelar.Location = new System.Drawing.Point(229, 244);
            this.btn_cliente_alta_cancelar.Name = "btn_cliente_alta_cancelar";
            this.btn_cliente_alta_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cliente_alta_cancelar.TabIndex = 16;
            this.btn_cliente_alta_cancelar.Text = "Cancelar";
            this.btn_cliente_alta_cancelar.UseVisualStyleBackColor = true;
            this.btn_cliente_alta_cancelar.Click += new System.EventHandler(this.btn_cliente_alta_cancelar_Click);
            // 
            // txt_cliente_alta_piso
            // 
            this.txt_cliente_alta_piso.Enabled = false;
            this.txt_cliente_alta_piso.Location = new System.Drawing.Point(140, 215);
            this.txt_cliente_alta_piso.Name = "txt_cliente_alta_piso";
            this.txt_cliente_alta_piso.Pp_Campo = "piso";
            this.txt_cliente_alta_piso.Pp_MensajeError = "Falta cargar el piso del cliente";
            this.txt_cliente_alta_piso.Pp_Tabla = null;
            this.txt_cliente_alta_piso.Pp_Validable = false;
            this.txt_cliente_alta_piso.Size = new System.Drawing.Size(164, 23);
            this.txt_cliente_alta_piso.TabIndex = 14;
            // 
            // txt_cliente_alta_nro
            // 
            this.txt_cliente_alta_nro.Enabled = false;
            this.txt_cliente_alta_nro.Location = new System.Drawing.Point(140, 186);
            this.txt_cliente_alta_nro.Name = "txt_cliente_alta_nro";
            this.txt_cliente_alta_nro.Pp_Campo = "nro";
            this.txt_cliente_alta_nro.Pp_MensajeError = "Falta cargar el número de la calle";
            this.txt_cliente_alta_nro.Pp_Tabla = null;
            this.txt_cliente_alta_nro.Pp_Validable = false;
            this.txt_cliente_alta_nro.Size = new System.Drawing.Size(164, 23);
            this.txt_cliente_alta_nro.TabIndex = 13;
            // 
            // txt_cliente_alta_calle
            // 
            this.txt_cliente_alta_calle.Enabled = false;
            this.txt_cliente_alta_calle.Location = new System.Drawing.Point(140, 157);
            this.txt_cliente_alta_calle.Name = "txt_cliente_alta_calle";
            this.txt_cliente_alta_calle.Pp_Campo = "calle";
            this.txt_cliente_alta_calle.Pp_MensajeError = "Falta cargar la calle del cliente";
            this.txt_cliente_alta_calle.Pp_Tabla = null;
            this.txt_cliente_alta_calle.Pp_Validable = false;
            this.txt_cliente_alta_calle.Size = new System.Drawing.Size(164, 23);
            this.txt_cliente_alta_calle.TabIndex = 12;
            // 
            // txt_cliente_alta_nombre
            // 
            this.txt_cliente_alta_nombre.Enabled = false;
            this.txt_cliente_alta_nombre.Location = new System.Drawing.Point(140, 44);
            this.txt_cliente_alta_nombre.Name = "txt_cliente_alta_nombre";
            this.txt_cliente_alta_nombre.Pp_Campo = "nombre_razonSocial";
            this.txt_cliente_alta_nombre.Pp_MensajeError = "Falta cargar el nombre del cliente";
            this.txt_cliente_alta_nombre.Pp_Tabla = null;
            this.txt_cliente_alta_nombre.Pp_Validable = false;
            this.txt_cliente_alta_nombre.Size = new System.Drawing.Size(164, 23);
            this.txt_cliente_alta_nombre.TabIndex = 11;
            // 
            // cmb_cliente_alta_barrio
            // 
            this.cmb_cliente_alta_barrio.Enabled = false;
            this.cmb_cliente_alta_barrio.FormattingEnabled = true;
            this.cmb_cliente_alta_barrio.Location = new System.Drawing.Point(140, 128);
            this.cmb_cliente_alta_barrio.Name = "cmb_cliente_alta_barrio";
            this.cmb_cliente_alta_barrio.Pp_Conseleccion = false;
            this.cmb_cliente_alta_barrio.Pp_Descripcion = "nombre_barrio";
            this.cmb_cliente_alta_barrio.Pp_MensajeError = null;
            this.cmb_cliente_alta_barrio.Pp_NombreCampo = null;
            this.cmb_cliente_alta_barrio.Pp_NombreTabla = "";
            this.cmb_cliente_alta_barrio.Pp_PK = "cod_barrio";
            this.cmb_cliente_alta_barrio.Pp_Tabla = "Barrio";
            this.cmb_cliente_alta_barrio.Pp_Validable = true;
            this.cmb_cliente_alta_barrio.Size = new System.Drawing.Size(164, 23);
            this.cmb_cliente_alta_barrio.TabIndex = 10;
            // 
            // cmb_Ciudades
            // 
            this.cmb_Ciudades.Enabled = false;
            this.cmb_Ciudades.FormattingEnabled = true;
            this.cmb_Ciudades.Location = new System.Drawing.Point(140, 102);
            this.cmb_Ciudades.Name = "cmb_Ciudades";
            this.cmb_Ciudades.Pp_Conseleccion = false;
            this.cmb_Ciudades.Pp_Descripcion = null;
            this.cmb_Ciudades.Pp_MensajeError = null;
            this.cmb_Ciudades.Pp_NombreCampo = null;
            this.cmb_Ciudades.Pp_NombreTabla = null;
            this.cmb_Ciudades.Pp_PK = null;
            this.cmb_Ciudades.Pp_Tabla = null;
            this.cmb_Ciudades.Pp_Validable = false;
            this.cmb_Ciudades.Size = new System.Drawing.Size(164, 23);
            this.cmb_Ciudades.TabIndex = 28;
            this.cmb_Ciudades.Text = "Ciudades";
            // 
            // cmb_Provincias
            // 
            this.cmb_Provincias.Enabled = false;
            this.cmb_Provincias.FormattingEnabled = true;
            this.cmb_Provincias.Location = new System.Drawing.Point(140, 73);
            this.cmb_Provincias.Name = "cmb_Provincias";
            this.cmb_Provincias.Pp_Conseleccion = false;
            this.cmb_Provincias.Pp_Descripcion = "nombre_prov";
            this.cmb_Provincias.Pp_MensajeError = null;
            this.cmb_Provincias.Pp_NombreCampo = null;
            this.cmb_Provincias.Pp_NombreTabla = null;
            this.cmb_Provincias.Pp_PK = "cod_prov";
            this.cmb_Provincias.Pp_Tabla = "Provincia";
            this.cmb_Provincias.Pp_Validable = false;
            this.cmb_Provincias.Size = new System.Drawing.Size(164, 23);
            this.cmb_Provincias.TabIndex = 27;
            this.cmb_Provincias.Text = "Provincias";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Ciudad";
            // 
            // Provincia
            // 
            this.Provincia.AutoSize = true;
            this.Provincia.Location = new System.Drawing.Point(78, 81);
            this.Provincia.Name = "Provincia";
            this.Provincia.Size = new System.Drawing.Size(56, 15);
            this.Provincia.TabIndex = 25;
            this.Provincia.Text = "Provincia";
            // 
            // Frm_Baja_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 275);
            this.Controls.Add(this.cmb_Ciudades);
            this.Controls.Add(this.cmb_Provincias);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Provincia);
            this.Controls.Add(this.btn_cliente_alta_cancelar);
            this.Controls.Add(this.btn_cliente_alta_aceptar);
            this.Controls.Add(this.txt_cliente_alta_piso);
            this.Controls.Add(this.txt_cliente_alta_nro);
            this.Controls.Add(this.txt_cliente_alta_calle);
            this.Controls.Add(this.txt_cliente_alta_nombre);
            this.Controls.Add(this.cmb_cliente_alta_barrio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Baja_Cliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Mod_Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Clases.ComboBox01 cmb_cliente_alta_barrio;
        private Clases.TextBox01 txt_cliente_alta_nombre;
        private Clases.TextBox01 txt_cliente_alta_calle;
        private Clases.TextBox01 txt_cliente_alta_nro;
        private Clases.TextBox01 txt_cliente_alta_piso;
        private System.Windows.Forms.Button btn_cliente_alta_aceptar;
        private System.Windows.Forms.Button btn_cliente_alta_cancelar;
        private Clases.ComboBox01 cmb_Ciudades;
        private Clases.ComboBox01 cmb_Provincias;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Provincia;
    }
}