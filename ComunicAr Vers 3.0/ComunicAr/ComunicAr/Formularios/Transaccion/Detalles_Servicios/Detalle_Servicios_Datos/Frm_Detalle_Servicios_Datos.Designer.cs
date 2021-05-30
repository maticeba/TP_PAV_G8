
namespace ComunicAr.Formularios.Transaccion.Detalles_Servicios.Detalle_Servicios_Datos
{
    partial class Frm_Detalle_Servicios_Datos
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
            this.btn_descuento = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_generarDetalle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_id_cliente = new ComunicAr.Clases.TextBox01();
            this.txt_nro_factura = new ComunicAr.Clases.TextBox01();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre_cliente = new ComunicAr.Clases.TextBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grid_Servicios_Datos = new System.Windows.Forms.DataGridView();
            this.txt_subtotla_SF = new ComunicAr.Clases.TextBox01();
            this.cod_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_mensual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Servicios_Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_descuento
            // 
            this.btn_descuento.Location = new System.Drawing.Point(318, 615);
            this.btn_descuento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_descuento.Name = "btn_descuento";
            this.btn_descuento.Size = new System.Drawing.Size(112, 35);
            this.btn_descuento.TabIndex = 25;
            this.btn_descuento.Text = "Descuento";
            this.btn_descuento.UseVisualStyleBackColor = true;
            this.btn_descuento.Click += new System.EventHandler(this.btn_descuento_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(174, 615);
            this.btn_borrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(112, 35);
            this.btn_borrar.TabIndex = 24;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(32, 615);
            this.btn_modificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(112, 35);
            this.btn_modificar.TabIndex = 23;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(898, 615);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 35);
            this.button3.TabIndex = 21;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_generarDetalle
            // 
            this.btn_generarDetalle.Location = new System.Drawing.Point(670, 615);
            this.btn_generarDetalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_generarDetalle.Name = "btn_generarDetalle";
            this.btn_generarDetalle.Size = new System.Drawing.Size(213, 35);
            this.btn_generarDetalle.TabIndex = 22;
            this.btn_generarDetalle.Text = "Generar Detalle";
            this.btn_generarDetalle.UseVisualStyleBackColor = true;
            this.btn_generarDetalle.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_id_cliente);
            this.groupBox1.Controls.Add(this.txt_nro_factura);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_nombre_cliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1080, 103);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Clientes";
            // 
            // txt_id_cliente
            // 
            this.txt_id_cliente.Enabled = false;
            this.txt_id_cliente.Location = new System.Drawing.Point(112, 43);
            this.txt_id_cliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_id_cliente.Name = "txt_id_cliente";
            this.txt_id_cliente.Pp_Campo = null;
            this.txt_id_cliente.Pp_MensajeError = null;
            this.txt_id_cliente.Pp_Tabla = null;
            this.txt_id_cliente.Pp_Validable = false;
            this.txt_id_cliente.Size = new System.Drawing.Size(140, 26);
            this.txt_id_cliente.TabIndex = 1;
            // 
            // txt_nro_factura
            // 
            this.txt_nro_factura.Enabled = false;
            this.txt_nro_factura.Location = new System.Drawing.Point(814, 43);
            this.txt_nro_factura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_nro_factura.Name = "txt_nro_factura";
            this.txt_nro_factura.Pp_Campo = null;
            this.txt_nro_factura.Pp_MensajeError = null;
            this.txt_nro_factura.Pp_Tabla = null;
            this.txt_nro_factura.Pp_Validable = false;
            this.txt_nro_factura.Size = new System.Drawing.Size(246, 26);
            this.txt_nro_factura.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(700, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nro Factura";
            // 
            // txt_nombre_cliente
            // 
            this.txt_nombre_cliente.Enabled = false;
            this.txt_nombre_cliente.Location = new System.Drawing.Point(423, 43);
            this.txt_nombre_cliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_nombre_cliente.Name = "txt_nombre_cliente";
            this.txt_nombre_cliente.Pp_Campo = null;
            this.txt_nombre_cliente.Pp_MensajeError = null;
            this.txt_nombre_cliente.Pp_Tabla = null;
            this.txt_nombre_cliente.Pp_Validable = false;
            this.txt_nombre_cliente.Size = new System.Drawing.Size(246, 26);
            this.txt_nombre_cliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(884, 545);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Subtotal";
            // 
            // grid_Servicios_Datos
            // 
            this.grid_Servicios_Datos.AllowUserToAddRows = false;
            this.grid_Servicios_Datos.AllowUserToDeleteRows = false;
            this.grid_Servicios_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Servicios_Datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_servicio,
            this.Tipo_Servicio,
            this.costo_mensual,
            this.Cuota,
            this.descuento,
            this.costo_final});
            this.grid_Servicios_Datos.Location = new System.Drawing.Point(32, 122);
            this.grid_Servicios_Datos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grid_Servicios_Datos.Name = "grid_Servicios_Datos";
            this.grid_Servicios_Datos.ReadOnly = true;
            this.grid_Servicios_Datos.RowHeadersWidth = 62;
            this.grid_Servicios_Datos.Size = new System.Drawing.Size(1080, 409);
            this.grid_Servicios_Datos.TabIndex = 17;
            this.grid_Servicios_Datos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Servicios_Datos_CellContentClick);
            // 
            // txt_subtotla_SF
            // 
            this.txt_subtotla_SF.Enabled = false;
            this.txt_subtotla_SF.Location = new System.Drawing.Point(962, 540);
            this.txt_subtotla_SF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_subtotla_SF.Name = "txt_subtotla_SF";
            this.txt_subtotla_SF.Pp_Campo = null;
            this.txt_subtotla_SF.Pp_MensajeError = null;
            this.txt_subtotla_SF.Pp_Tabla = null;
            this.txt_subtotla_SF.Pp_Validable = false;
            this.txt_subtotla_SF.Size = new System.Drawing.Size(148, 26);
            this.txt_subtotla_SF.TabIndex = 19;
            // 
            // cod_servicio
            // 
            this.cod_servicio.HeaderText = "Codigo";
            this.cod_servicio.MinimumWidth = 8;
            this.cod_servicio.Name = "cod_servicio";
            this.cod_servicio.ReadOnly = true;
            this.cod_servicio.Width = 70;
            // 
            // Tipo_Servicio
            // 
            this.Tipo_Servicio.HeaderText = "Tipo Servicio";
            this.Tipo_Servicio.MinimumWidth = 8;
            this.Tipo_Servicio.Name = "Tipo_Servicio";
            this.Tipo_Servicio.ReadOnly = true;
            this.Tipo_Servicio.Width = 145;
            // 
            // costo_mensual
            // 
            this.costo_mensual.HeaderText = "Costo Mensual";
            this.costo_mensual.MinimumWidth = 8;
            this.costo_mensual.Name = "costo_mensual";
            this.costo_mensual.ReadOnly = true;
            this.costo_mensual.Width = 120;
            // 
            // Cuota
            // 
            this.Cuota.HeaderText = "Nro de Cuota";
            this.Cuota.MinimumWidth = 8;
            this.Cuota.Name = "Cuota";
            this.Cuota.ReadOnly = true;
            // 
            // descuento
            // 
            this.descuento.HeaderText = "Descuento";
            this.descuento.MinimumWidth = 8;
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            // 
            // costo_final
            // 
            this.costo_final.HeaderText = "Costo Final";
            this.costo_final.MinimumWidth = 8;
            this.costo_final.Name = "costo_final";
            this.costo_final.ReadOnly = true;
            this.costo_final.Width = 120;
            // 
            // Frm_Detalle_Servicios_Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 692);
            this.Controls.Add(this.btn_descuento);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_generarDetalle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_subtotla_SF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grid_Servicios_Datos);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Detalle_Servicios_Datos";
            this.Text = "Detalle_Servicios_Datos";
            this.Load += new System.EventHandler(this.Detalle_Servicios_Datos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Servicios_Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_descuento;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_generarDetalle;
        private System.Windows.Forms.GroupBox groupBox1;
        private Clases.TextBox01 txt_id_cliente;
        private Clases.TextBox01 txt_nro_factura;
        private System.Windows.Forms.Label label3;
        private Clases.TextBox01 txt_nombre_cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Clases.TextBox01 txt_subtotla_SF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grid_Servicios_Datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_mensual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_final;
    }
}