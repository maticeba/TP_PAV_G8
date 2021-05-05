
namespace ComunicAr.Formularios.Servicios
{
    partial class Frm_ABM_Servicios
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
            this.GridServicios = new System.Windows.Forms.DataGridView();
            this.codigo_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_salir_cliente = new System.Windows.Forms.Button();
            this.bttn_modificar_servicios = new System.Windows.Forms.Button();
            this.bttn_alta_servicio = new System.Windows.Forms.Button();
            this.bttn_baja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // GridServicios
            // 
            this.GridServicios.AllowUserToAddRows = false;
            this.GridServicios.AllowUserToDeleteRows = false;
            this.GridServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_servicio,
            this.nombre_servicio,
            this.tipo_servicio,
            this.fecha_desde,
            this.fecha_hasta,
            this.id_numero});
            this.GridServicios.Location = new System.Drawing.Point(12, 103);
            this.GridServicios.Name = "GridServicios";
            this.GridServicios.ReadOnly = true;
            this.GridServicios.Size = new System.Drawing.Size(644, 262);
            this.GridServicios.TabIndex = 3;
            this.GridServicios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridServicios_CellContentClick);
            // 
            // codigo_servicio
            // 
            this.codigo_servicio.HeaderText = "Codigo Servicio";
            this.codigo_servicio.Name = "codigo_servicio";
            this.codigo_servicio.ReadOnly = true;
            // 
            // nombre_servicio
            // 
            this.nombre_servicio.HeaderText = "Nombre Servicio";
            this.nombre_servicio.Name = "nombre_servicio";
            this.nombre_servicio.ReadOnly = true;
            // 
            // tipo_servicio
            // 
            this.tipo_servicio.HeaderText = "Tipo Servicio";
            this.tipo_servicio.Name = "tipo_servicio";
            this.tipo_servicio.ReadOnly = true;
            // 
            // fecha_desde
            // 
            this.fecha_desde.HeaderText = "Fecha Desde";
            this.fecha_desde.Name = "fecha_desde";
            this.fecha_desde.ReadOnly = true;
            // 
            // fecha_hasta
            // 
            this.fecha_hasta.HeaderText = "Fecha Hasta";
            this.fecha_hasta.Name = "fecha_hasta";
            this.fecha_hasta.ReadOnly = true;
            // 
            // id_numero
            // 
            this.id_numero.HeaderText = "Id Numero";
            this.id_numero.Name = "id_numero";
            this.id_numero.ReadOnly = true;
            // 
            // btn_salir_cliente
            // 
            this.btn_salir_cliente.Location = new System.Drawing.Point(552, 371);
            this.btn_salir_cliente.Name = "btn_salir_cliente";
            this.btn_salir_cliente.Size = new System.Drawing.Size(104, 34);
            this.btn_salir_cliente.TabIndex = 5;
            this.btn_salir_cliente.Text = "Salir";
            this.btn_salir_cliente.UseVisualStyleBackColor = true;
            this.btn_salir_cliente.Click += new System.EventHandler(this.btn_salir_cliente_Click);
            // 
            // bttn_modificar_servicios
            // 
            this.bttn_modificar_servicios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttn_modificar_servicios.Location = new System.Drawing.Point(12, 68);
            this.bttn_modificar_servicios.Name = "bttn_modificar_servicios";
            this.bttn_modificar_servicios.Size = new System.Drawing.Size(92, 29);
            this.bttn_modificar_servicios.TabIndex = 6;
            this.bttn_modificar_servicios.Text = "Modificar";
            this.bttn_modificar_servicios.UseVisualStyleBackColor = true;
            this.bttn_modificar_servicios.Click += new System.EventHandler(this.bttn_modificar_servicios_Click);
            // 
            // bttn_alta_servicio
            // 
            this.bttn_alta_servicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttn_alta_servicio.Location = new System.Drawing.Point(133, 68);
            this.bttn_alta_servicio.Name = "bttn_alta_servicio";
            this.bttn_alta_servicio.Size = new System.Drawing.Size(92, 29);
            this.bttn_alta_servicio.TabIndex = 7;
            this.bttn_alta_servicio.Text = "Alta";
            this.bttn_alta_servicio.UseVisualStyleBackColor = true;
            this.bttn_alta_servicio.Click += new System.EventHandler(this.bttn_alta_servicio_Click);
            // 
            // bttn_baja
            // 
            this.bttn_baja.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttn_baja.Location = new System.Drawing.Point(251, 68);
            this.bttn_baja.Name = "bttn_baja";
            this.bttn_baja.Size = new System.Drawing.Size(92, 29);
            this.bttn_baja.TabIndex = 8;
            this.bttn_baja.Text = "Baja";
            this.bttn_baja.UseVisualStyleBackColor = true;
            this.bttn_baja.Click += new System.EventHandler(this.bttn_baja_Click);
            // 
            // Frm_ABM_Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 417);
            this.Controls.Add(this.bttn_baja);
            this.Controls.Add(this.bttn_alta_servicio);
            this.Controls.Add(this.bttn_modificar_servicios);
            this.Controls.Add(this.btn_salir_cliente);
            this.Controls.Add(this.GridServicios);
            this.Name = "Frm_ABM_Servicios";
            this.Text = "ServiciosContratados";
            this.Load += new System.EventHandler(this.Frm_ABM_Servicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridServicios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridServicios;
        private System.Windows.Forms.Button btn_salir_cliente;
        private System.Windows.Forms.Button bttn_modificar_servicios;
        private System.Windows.Forms.DataGridViewTextBoxColumn codi_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_numero;
        private System.Windows.Forms.Button bttn_alta_servicio;
        private System.Windows.Forms.Button bttn_baja;
    }
}