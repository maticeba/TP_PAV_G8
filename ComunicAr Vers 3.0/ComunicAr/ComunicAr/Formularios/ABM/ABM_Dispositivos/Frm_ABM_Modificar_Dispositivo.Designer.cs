
namespace ComunicAr.Formularios.ABM_Dispositivos
{
    partial class Frm_ABM_Modificar_Dispositivo
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
            this.label8 = new System.Windows.Forms.Label();
            this.txt_id_dispositivo_M = new ComunicAr.Clases.TextBox01();
            this.txt_precio_M = new ComunicAr.Clases.TextBox01();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.txt_marca_M = new ComunicAr.Clases.TextBox01();
            this.txt_modelo_M = new ComunicAr.Clases.TextBox01();
            this.txt_caracteristicas_M = new ComunicAr.Clases.TextBox01();
            this.txt_fecha_elaboracion_M = new ComunicAr.Clases.TextBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_tipo_dispositivo = new ComunicAr.Clases.ComboBox01();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 15);
            this.label8.TabIndex = 60;
            this.label8.Text = "ID";
            // 
            // txt_id_dispositivo_M
            // 
            this.txt_id_dispositivo_M.Enabled = false;
            this.txt_id_dispositivo_M.Location = new System.Drawing.Point(136, 42);
            this.txt_id_dispositivo_M.Name = "txt_id_dispositivo_M";
            this.txt_id_dispositivo_M.Pp_Campo = "id_dispositivo";
            this.txt_id_dispositivo_M.Pp_MensajeError = "Falta cargar ID del dispositivo";
            this.txt_id_dispositivo_M.Pp_Tabla = null;
            this.txt_id_dispositivo_M.Pp_Validable = false;
            this.txt_id_dispositivo_M.Size = new System.Drawing.Size(178, 23);
            this.txt_id_dispositivo_M.TabIndex = 59;
            // 
            // txt_precio_M
            // 
            this.txt_precio_M.Location = new System.Drawing.Point(136, 187);
            this.txt_precio_M.Name = "txt_precio_M";
            this.txt_precio_M.Pp_Campo = "precio";
            this.txt_precio_M.Pp_MensajeError = "Falta cargar el precio";
            this.txt_precio_M.Pp_Tabla = null;
            this.txt_precio_M.Pp_Validable = false;
            this.txt_precio_M.Size = new System.Drawing.Size(178, 23);
            this.txt_precio_M.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 57;
            this.label7.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 55;
            this.label5.Text = "Caracteristicas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 54;
            this.label4.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 53;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 52;
            this.label2.Text = "Fecha de Elaboracion";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(175, 254);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(87, 27);
            this.btn_Cancelar.TabIndex = 51;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(63, 254);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(87, 27);
            this.btn_Aceptar.TabIndex = 50;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // txt_marca_M
            // 
            this.txt_marca_M.Location = new System.Drawing.Point(136, 100);
            this.txt_marca_M.Name = "txt_marca_M";
            this.txt_marca_M.Pp_Campo = "marca";
            this.txt_marca_M.Pp_MensajeError = "Falta cargar la marca";
            this.txt_marca_M.Pp_Tabla = null;
            this.txt_marca_M.Pp_Validable = false;
            this.txt_marca_M.Size = new System.Drawing.Size(178, 23);
            this.txt_marca_M.TabIndex = 49;
            // 
            // txt_modelo_M
            // 
            this.txt_modelo_M.Location = new System.Drawing.Point(136, 129);
            this.txt_modelo_M.Name = "txt_modelo_M";
            this.txt_modelo_M.Pp_Campo = "modelo";
            this.txt_modelo_M.Pp_MensajeError = "Falta cargar modelo";
            this.txt_modelo_M.Pp_Tabla = null;
            this.txt_modelo_M.Pp_Validable = false;
            this.txt_modelo_M.Size = new System.Drawing.Size(178, 23);
            this.txt_modelo_M.TabIndex = 48;
            // 
            // txt_caracteristicas_M
            // 
            this.txt_caracteristicas_M.Location = new System.Drawing.Point(136, 158);
            this.txt_caracteristicas_M.Name = "txt_caracteristicas_M";
            this.txt_caracteristicas_M.Pp_Campo = "caracteristicas";
            this.txt_caracteristicas_M.Pp_MensajeError = "Falta cargar las caracteriscas";
            this.txt_caracteristicas_M.Pp_Tabla = null;
            this.txt_caracteristicas_M.Pp_Validable = false;
            this.txt_caracteristicas_M.Size = new System.Drawing.Size(178, 23);
            this.txt_caracteristicas_M.TabIndex = 47;
            // 
            // txt_fecha_elaboracion_M
            // 
            this.txt_fecha_elaboracion_M.Location = new System.Drawing.Point(136, 71);
            this.txt_fecha_elaboracion_M.Name = "txt_fecha_elaboracion_M";
            this.txt_fecha_elaboracion_M.Pp_Campo = "fecha_elaboracion";
            this.txt_fecha_elaboracion_M.Pp_MensajeError = "Falta cargar la fecha de elaboracion";
            this.txt_fecha_elaboracion_M.Pp_Tabla = null;
            this.txt_fecha_elaboracion_M.Pp_Validable = false;
            this.txt_fecha_elaboracion_M.Size = new System.Drawing.Size(178, 23);
            this.txt_fecha_elaboracion_M.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 45;
            this.label1.Text = "Modificar Dispositivo";
            // 
            // Cmb_tipo_dispositivo
            // 
            this.Cmb_tipo_dispositivo.FormattingEnabled = true;
            this.Cmb_tipo_dispositivo.Location = new System.Drawing.Point(136, 216);
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
            this.Cmb_tipo_dispositivo.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 15);
            this.label9.TabIndex = 61;
            this.label9.Text = "Tipo Dispositivo";
            // 
            // Frm_ABM_Modificar_Dispositivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 298);
            this.Controls.Add(this.Cmb_tipo_dispositivo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_id_dispositivo_M);
            this.Controls.Add(this.txt_precio_M);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.txt_marca_M);
            this.Controls.Add(this.txt_modelo_M);
            this.Controls.Add(this.txt_caracteristicas_M);
            this.Controls.Add(this.txt_fecha_elaboracion_M);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ABM_Modificar_Dispositivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ABM_Modificar_Dispositivo";
            this.Load += new System.EventHandler(this.Frm_ABM_Modificar_Dispositivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private Clases.TextBox01 txt_id_dispositivo_M;
        private Clases.TextBox01 txt_precio_M;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Aceptar;
        private Clases.TextBox01 txt_marca_M;
        private Clases.TextBox01 txt_modelo_M;
        private Clases.TextBox01 txt_caracteristicas_M;
        private Clases.TextBox01 txt_fecha_elaboracion_M;
        private System.Windows.Forms.Label label1;
        private Clases.ComboBox01 Cmb_tipo_dispositivo;
        private System.Windows.Forms.Label label9;
    }
}