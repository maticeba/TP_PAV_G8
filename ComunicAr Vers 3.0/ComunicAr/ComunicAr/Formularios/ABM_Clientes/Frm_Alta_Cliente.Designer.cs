
namespace ComunicAr.Formularios.ABM_Clientes
{
    partial class Frm_Alta_Cliente
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altas Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre/Razón Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Calle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nro. de Calle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Piso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Barrio";
            // 
            // btn_cliente_alta_aceptar
            // 
            this.btn_cliente_alta_aceptar.Location = new System.Drawing.Point(143, 210);
            this.btn_cliente_alta_aceptar.Name = "btn_cliente_alta_aceptar";
            this.btn_cliente_alta_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_cliente_alta_aceptar.TabIndex = 15;
            this.btn_cliente_alta_aceptar.Text = "Aceptar";
            this.btn_cliente_alta_aceptar.UseVisualStyleBackColor = true;
            this.btn_cliente_alta_aceptar.Click += new System.EventHandler(this.btn_cliente_alta_aceptar_Click);
            // 
            // btn_cliente_alta_cancelar
            // 
            this.btn_cliente_alta_cancelar.Location = new System.Drawing.Point(232, 210);
            this.btn_cliente_alta_cancelar.Name = "btn_cliente_alta_cancelar";
            this.btn_cliente_alta_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cliente_alta_cancelar.TabIndex = 16;
            this.btn_cliente_alta_cancelar.Text = "Cancelar";
            this.btn_cliente_alta_cancelar.UseVisualStyleBackColor = true;
            this.btn_cliente_alta_cancelar.Click += new System.EventHandler(this.btn_cliente_alta_cancelar_Click);
            // 
            // txt_cliente_alta_piso
            // 
            this.txt_cliente_alta_piso.Location = new System.Drawing.Point(143, 152);
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
            this.txt_cliente_alta_nro.Location = new System.Drawing.Point(143, 123);
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
            this.txt_cliente_alta_calle.Location = new System.Drawing.Point(143, 94);
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
            this.txt_cliente_alta_nombre.Location = new System.Drawing.Point(143, 65);
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
            this.cmb_cliente_alta_barrio.FormattingEnabled = true;
            this.cmb_cliente_alta_barrio.Location = new System.Drawing.Point(143, 181);
            this.cmb_cliente_alta_barrio.Name = "cmb_cliente_alta_barrio";
            this.cmb_cliente_alta_barrio.Pp_Conseleccion = false;
            this.cmb_cliente_alta_barrio.Pp_Descripcion = "nombre_barrio";
            this.cmb_cliente_alta_barrio.Pp_MensajeError = null;
            this.cmb_cliente_alta_barrio.Pp_NombreCampo = null;
            this.cmb_cliente_alta_barrio.Pp_NombreTabla = "";
            this.cmb_cliente_alta_barrio.Pp_PK = "cod_barrio";
            this.cmb_cliente_alta_barrio.Pp_Tabla = "barrios";
            this.cmb_cliente_alta_barrio.Pp_Validable = true;
            this.cmb_cliente_alta_barrio.Size = new System.Drawing.Size(164, 23);
            this.cmb_cliente_alta_barrio.TabIndex = 10;
            // 
            // Frm_Alta_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 257);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Alta_Cliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Alta_Cliente_Load);
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
    }
}