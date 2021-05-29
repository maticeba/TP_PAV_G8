
namespace ComunicAr.Formularios.Transaccion.Generar_Venta
{
    partial class Frm_Generar_Ventas
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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.bttn_crearSoloDisp = new System.Windows.Forms.Button();
            this.cmb_nmro_telefono = new ComunicAr.Clases.ComboBox02();
            this.cmb_cantCuota = new ComunicAr.Clases.ComboBox01();
            this.txt_precio = new ComunicAr.Clases.TextBox01();
            this.cmb_disp = new ComunicAr.Clases.ComboBox01();
            this.cmb_tipoDisp = new ComunicAr.Clases.ComboBox01();
            this.txt_nombre_cliente = new ComunicAr.Clases.TextBox01();
            this.txt_id_cliente = new ComunicAr.Clases.TextBox01();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_fecha = new ComunicAr.Clases.TextBox01();
            this.txt_Descuento = new ComunicAr.Clases.TextBox01();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nmro Telefono";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "crear nuevo numero";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bttn_CrearNuevo);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tipo Dispositivo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Modelo";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Precio";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 162);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cuotas";
            this.label7.Click += new System.EventHandler(this.label4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 244);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 29);
            this.button3.TabIndex = 17;
            this.button3.Text = "Aceptar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(312, 244);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 29);
            this.button4.TabIndex = 18;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(188, 12);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(107, 20);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // bttn_crearSoloDisp
            // 
            this.bttn_crearSoloDisp.Location = new System.Drawing.Point(299, 60);
            this.bttn_crearSoloDisp.Margin = new System.Windows.Forms.Padding(2);
            this.bttn_crearSoloDisp.Name = "bttn_crearSoloDisp";
            this.bttn_crearSoloDisp.Size = new System.Drawing.Size(124, 66);
            this.bttn_crearSoloDisp.TabIndex = 19;
            this.bttn_crearSoloDisp.Text = "Comprar nuevo dispositivo para numero";
            this.bttn_crearSoloDisp.UseVisualStyleBackColor = true;
            this.bttn_crearSoloDisp.Click += new System.EventHandler(this.bttn_crearSoloDisp_Click);
            // 
            // cmb_nmro_telefono
            // 
            this.cmb_nmro_telefono.Enable = false;
            this.cmb_nmro_telefono.FormattingEnabled = true;
            this.cmb_nmro_telefono.Location = new System.Drawing.Point(113, 60);
            this.cmb_nmro_telefono.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_nmro_telefono.Name = "cmb_nmro_telefono";
            this.cmb_nmro_telefono.Pp_Conseleccion = true;
            this.cmb_nmro_telefono.Pp_Descripcion1 = "cod_nacional";
            this.cmb_nmro_telefono.Pp_Descripcion2 = "cod_area";
            this.cmb_nmro_telefono.Pp_Descripcion3 = "nro_telefono";
            this.cmb_nmro_telefono.Pp_MensajeError = null;
            this.cmb_nmro_telefono.Pp_NombreCampo = null;
            this.cmb_nmro_telefono.Pp_NombreTabla = null;
            this.cmb_nmro_telefono.Pp_PK1 = "id_numero";
            this.cmb_nmro_telefono.Pp_Tabla = "Numero";
            this.cmb_nmro_telefono.Pp_Validable = false;
            this.cmb_nmro_telefono.Size = new System.Drawing.Size(182, 21);
            this.cmb_nmro_telefono.TabIndex = 16;
            this.cmb_nmro_telefono.SelectedIndexChanged += new System.EventHandler(this.cmb_nmro_telefono_SelectedIndexChanged);
            // 
            // cmb_cantCuota
            // 
            this.cmb_cantCuota.Enabled = false;
            this.cmb_cantCuota.FormattingEnabled = true;
            this.cmb_cantCuota.Location = new System.Drawing.Point(113, 159);
            this.cmb_cantCuota.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_cantCuota.Name = "cmb_cantCuota";
            this.cmb_cantCuota.Pp_Conseleccion = false;
            this.cmb_cantCuota.Pp_Descripcion = null;
            this.cmb_cantCuota.Pp_MensajeError = null;
            this.cmb_cantCuota.Pp_NombreCampo = null;
            this.cmb_cantCuota.Pp_NombreTabla = null;
            this.cmb_cantCuota.Pp_PK = null;
            this.cmb_cantCuota.Pp_Tabla = null;
            this.cmb_cantCuota.Pp_Validable = false;
            this.cmb_cantCuota.Size = new System.Drawing.Size(182, 21);
            this.cmb_cantCuota.TabIndex = 15;
            // 
            // txt_precio
            // 
            this.txt_precio.Enabled = false;
            this.txt_precio.Location = new System.Drawing.Point(113, 135);
            this.txt_precio.Margin = new System.Windows.Forms.Padding(2);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Pp_Campo = null;
            this.txt_precio.Pp_MensajeError = null;
            this.txt_precio.Pp_Tabla = null;
            this.txt_precio.Pp_Validable = false;
            this.txt_precio.Size = new System.Drawing.Size(182, 20);
            this.txt_precio.TabIndex = 14;
            // 
            // cmb_disp
            // 
            this.cmb_disp.Enabled = false;
            this.cmb_disp.FormattingEnabled = true;
            this.cmb_disp.Location = new System.Drawing.Point(113, 110);
            this.cmb_disp.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_disp.Name = "cmb_disp";
            this.cmb_disp.Pp_Conseleccion = false;
            this.cmb_disp.Pp_Descripcion = "modelo";
            this.cmb_disp.Pp_MensajeError = null;
            this.cmb_disp.Pp_NombreCampo = null;
            this.cmb_disp.Pp_NombreTabla = null;
            this.cmb_disp.Pp_PK = "id_dispositivo";
            this.cmb_disp.Pp_Tabla = "Dispositivos";
            this.cmb_disp.Pp_Validable = false;
            this.cmb_disp.Size = new System.Drawing.Size(182, 21);
            this.cmb_disp.TabIndex = 13;
            this.cmb_disp.SelectedIndexChanged += new System.EventHandler(this.cmb_disp_SelectedIndexChanged);
            // 
            // cmb_tipoDisp
            // 
            this.cmb_tipoDisp.Enabled = false;
            this.cmb_tipoDisp.FormattingEnabled = true;
            this.cmb_tipoDisp.Location = new System.Drawing.Point(113, 85);
            this.cmb_tipoDisp.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_tipoDisp.Name = "cmb_tipoDisp";
            this.cmb_tipoDisp.Pp_Conseleccion = false;
            this.cmb_tipoDisp.Pp_Descripcion = "nombre_tipo";
            this.cmb_tipoDisp.Pp_MensajeError = "Falta seleccionar el tipo de dispositivo";
            this.cmb_tipoDisp.Pp_NombreCampo = null;
            this.cmb_tipoDisp.Pp_NombreTabla = null;
            this.cmb_tipoDisp.Pp_PK = "id_tipo_dispositivo";
            this.cmb_tipoDisp.Pp_Tabla = "Tipo_dispositivo";
            this.cmb_tipoDisp.Pp_Validable = false;
            this.cmb_tipoDisp.Size = new System.Drawing.Size(182, 21);
            this.cmb_tipoDisp.TabIndex = 11;
            this.cmb_tipoDisp.SelectedIndexChanged += new System.EventHandler(this.cmb_tipoDisp_SelectedIndexChanged);
            // 
            // txt_nombre_cliente
            // 
            this.txt_nombre_cliente.Enabled = false;
            this.txt_nombre_cliente.Location = new System.Drawing.Point(113, 36);
            this.txt_nombre_cliente.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre_cliente.Name = "txt_nombre_cliente";
            this.txt_nombre_cliente.Pp_Campo = null;
            this.txt_nombre_cliente.Pp_MensajeError = null;
            this.txt_nombre_cliente.Pp_Tabla = null;
            this.txt_nombre_cliente.Pp_Validable = false;
            this.txt_nombre_cliente.Size = new System.Drawing.Size(182, 20);
            this.txt_nombre_cliente.TabIndex = 4;
            // 
            // txt_id_cliente
            // 
            this.txt_id_cliente.Location = new System.Drawing.Point(113, 12);
            this.txt_id_cliente.Margin = new System.Windows.Forms.Padding(2);
            this.txt_id_cliente.Name = "txt_id_cliente";
            this.txt_id_cliente.Pp_Campo = null;
            this.txt_id_cliente.Pp_MensajeError = null;
            this.txt_id_cliente.Pp_Tabla = null;
            this.txt_id_cliente.Pp_Validable = false;
            this.txt_id_cliente.Size = new System.Drawing.Size(71, 20);
            this.txt_id_cliente.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Fecha";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Enabled = false;
            this.txt_fecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha.Location = new System.Drawing.Point(113, 209);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Pp_Campo = null;
            this.txt_fecha.Pp_MensajeError = null;
            this.txt_fecha.Pp_Tabla = null;
            this.txt_fecha.Pp_Validable = false;
            this.txt_fecha.Size = new System.Drawing.Size(182, 23);
            this.txt_fecha.TabIndex = 23;
            this.txt_fecha.Text = "DD/MM/YYYY";
            this.txt_fecha.TextChanged += new System.EventHandler(this.txt_fecha_TextChanged);
            // 
            // txt_Descuento
            // 
            this.txt_Descuento.Enabled = false;
            this.txt_Descuento.Location = new System.Drawing.Point(113, 184);
            this.txt_Descuento.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Descuento.Name = "txt_Descuento";
            this.txt_Descuento.Pp_Campo = null;
            this.txt_Descuento.Pp_MensajeError = null;
            this.txt_Descuento.Pp_Tabla = null;
            this.txt_Descuento.Pp_Validable = false;
            this.txt_Descuento.Size = new System.Drawing.Size(182, 20);
            this.txt_Descuento.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 187);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Descuento";
            // 
            // Frm_Generar_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 284);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Descuento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.bttn_crearSoloDisp);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmb_nmro_telefono);
            this.Controls.Add(this.cmb_cantCuota);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.cmb_disp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_tipoDisp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre_cliente);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_id_cliente);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Generar_Ventas";
            this.Text = "Frm_Generar_Venta";
            this.Load += new System.EventHandler(this.Frm_Generar_Venta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Clases.TextBox01 txt_id_cliente;
        private Clases.TextBox01 txt_nombre_cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private Clases.ComboBox01 cmb_tipoDisp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Clases.ComboBox01 cmb_disp;
        private System.Windows.Forms.Label label6;
        private Clases.TextBox01 txt_precio;
        private Clases.ComboBox01 cmb_cantCuota;
        private System.Windows.Forms.Label label7;
        private Clases.ComboBox02 cmb_nmro_telefono;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button bttn_crearSoloDisp;
        private System.Windows.Forms.Label label8;
        private Clases.TextBox01 txt_fecha;
        private Clases.TextBox01 txt_Descuento;
        private System.Windows.Forms.Label label9;
    }
}