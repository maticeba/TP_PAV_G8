
namespace ComunicAr.Formularios.ABM_Dispositivos
{
    partial class Frm_ABM_Alta_Dispositivo
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_precio = new ComunicAr.Clases.TextBox01();
            this.txt_marca = new ComunicAr.Clases.TextBox01();
            this.txt_modelo = new ComunicAr.Clases.TextBox01();
            this.txt_caracteristicas = new ComunicAr.Clases.TextBox01();
            this.txt_fecha_elaboracion = new ComunicAr.Clases.TextBox01();
            this.label8 = new System.Windows.Forms.Label();
            this.Cmb_tipo_dispositivo = new ComunicAr.Clases.ComboBox01();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 46;
            this.label7.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 44;
            this.label5.Text = "Caracteristicas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 43;
            this.label4.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "Fecha de Elaboracion";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(175, 225);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(89, 28);
            this.btn_Cancelar.TabIndex = 40;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(63, 225);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(89, 28);
            this.btn_Aceptar.TabIndex = 39;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "Altas Dispositivos";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(136, 158);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Pp_Campo = "precio";
            this.txt_precio.Pp_MensajeError = "Falta cargar el Precio";
            this.txt_precio.Pp_Tabla = null;
            this.txt_precio.Pp_Validable = false;
            this.txt_precio.Size = new System.Drawing.Size(178, 23);
            this.txt_precio.TabIndex = 49;
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(136, 71);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Pp_Campo = "marca";
            this.txt_marca.Pp_MensajeError = "Falta cargar la marca";
            this.txt_marca.Pp_Tabla = null;
            this.txt_marca.Pp_Validable = false;
            this.txt_marca.Size = new System.Drawing.Size(178, 23);
            this.txt_marca.TabIndex = 38;
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(136, 100);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Pp_Campo = "modelo";
            this.txt_modelo.Pp_MensajeError = "Falta cargar el modelo";
            this.txt_modelo.Pp_Tabla = null;
            this.txt_modelo.Pp_Validable = false;
            this.txt_modelo.Size = new System.Drawing.Size(178, 23);
            this.txt_modelo.TabIndex = 37;
            // 
            // txt_caracteristicas
            // 
            this.txt_caracteristicas.Location = new System.Drawing.Point(136, 129);
            this.txt_caracteristicas.Name = "txt_caracteristicas";
            this.txt_caracteristicas.Pp_Campo = "caracteristicas";
            this.txt_caracteristicas.Pp_MensajeError = "Falta cargar las caracteristicas";
            this.txt_caracteristicas.Pp_Tabla = null;
            this.txt_caracteristicas.Pp_Validable = false;
            this.txt_caracteristicas.Size = new System.Drawing.Size(178, 23);
            this.txt_caracteristicas.TabIndex = 36;
            // 
            // txt_fecha_elaboracion
            // 
            this.txt_fecha_elaboracion.Location = new System.Drawing.Point(136, 42);
            this.txt_fecha_elaboracion.Name = "txt_fecha_elaboracion";
            this.txt_fecha_elaboracion.Pp_Campo = "fecha_elaboracion";
            this.txt_fecha_elaboracion.Pp_MensajeError = "Falta cargar el lfecha de elaboracion";
            this.txt_fecha_elaboracion.Pp_Tabla = null;
            this.txt_fecha_elaboracion.Pp_Validable = false;
            this.txt_fecha_elaboracion.Size = new System.Drawing.Size(178, 23);
            this.txt_fecha_elaboracion.TabIndex = 35;
            this.txt_fecha_elaboracion.Text = "DD/MM/YYYY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 15);
            this.label8.TabIndex = 50;
            this.label8.Text = "Tipo Dispositivo";
            // 
            // Cmb_tipo_dispositivo
            // 
            this.Cmb_tipo_dispositivo.FormattingEnabled = true;
            this.Cmb_tipo_dispositivo.Location = new System.Drawing.Point(136, 187);
            this.Cmb_tipo_dispositivo.Name = "Cmb_tipo_dispositivo";
            this.Cmb_tipo_dispositivo.Pp_Conseleccion = false;
            this.Cmb_tipo_dispositivo.Pp_Descripcion = "nombre_tipo";
            this.Cmb_tipo_dispositivo.Pp_MensajeError = "Falta seleccionar el tipo de dispositivo";
            this.Cmb_tipo_dispositivo.Pp_NombreCampo = null;
            this.Cmb_tipo_dispositivo.Pp_NombreTabla = null;
            this.Cmb_tipo_dispositivo.Pp_PK = "id_tipo_dispositivo";
            this.Cmb_tipo_dispositivo.Pp_Tabla = "Tipo_dispositivo";
            this.Cmb_tipo_dispositivo.Pp_Validable = false;
            this.Cmb_tipo_dispositivo.Size = new System.Drawing.Size(178, 23);
            this.Cmb_tipo_dispositivo.TabIndex = 51;
            // 
            // Frm_ABM_Alta_Dispositivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 272);
            this.Controls.Add(this.Cmb_tipo_dispositivo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.txt_modelo);
            this.Controls.Add(this.txt_caracteristicas);
            this.Controls.Add(this.txt_fecha_elaboracion);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ABM_Alta_Dispositivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ABM_Alta_Dispositivo";
            this.Load += new System.EventHandler(this.Frm_ABM_Alta_Dispositivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.TextBox01 txt_precio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Aceptar;
        private Clases.TextBox01 txt_marca;
        private Clases.TextBox01 txt_modelo;
        private Clases.TextBox01 txt_caracteristicas;
        private Clases.TextBox01 txt_fecha_elaboracion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private Clases.ComboBox01 Cmb_tipo_dispositivo;
    }
}