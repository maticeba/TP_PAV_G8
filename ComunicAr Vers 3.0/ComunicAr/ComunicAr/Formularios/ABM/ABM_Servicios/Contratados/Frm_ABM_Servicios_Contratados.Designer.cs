
namespace ComunicAr.Formularios.Servicios
{
    partial class Frm_ABM_Servicios_Contratados
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
            this.btn_salir_cliente = new System.Windows.Forms.Button();
            this.bttn_modificar_servicios = new System.Windows.Forms.Button();
            this.bttn_alta_servicio = new System.Windows.Forms.Button();
            this.bttn_baja = new System.Windows.Forms.Button();
            this.bttn_refrescar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Consulta = new System.Windows.Forms.Button();
            this.txt_filtro_cod_servicio = new ComunicAr.Clases.TextBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.codigo_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridServicios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridServicios
            // 
            this.GridServicios.AllowUserToAddRows = false;
            this.GridServicios.AllowUserToDeleteRows = false;
            this.GridServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_servicio,
            this.tipo_servicio,
            this.id_servicio,
            this.fecha_desde,
            this.fecha_hasta,
            this.id_numero});
            this.GridServicios.Location = new System.Drawing.Point(12, 143);
            this.GridServicios.Name = "GridServicios";
            this.GridServicios.ReadOnly = true;
            this.GridServicios.Size = new System.Drawing.Size(606, 252);
            this.GridServicios.TabIndex = 3;
            this.GridServicios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridServicios_CellContentClick);
            // 
            // btn_salir_cliente
            // 
            this.btn_salir_cliente.Location = new System.Drawing.Point(514, 414);
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
            this.bttn_modificar_servicios.Location = new System.Drawing.Point(140, 102);
            this.bttn_modificar_servicios.Name = "bttn_modificar_servicios";
            this.bttn_modificar_servicios.Size = new System.Drawing.Size(104, 34);
            this.bttn_modificar_servicios.TabIndex = 6;
            this.bttn_modificar_servicios.Text = "Modificar";
            this.bttn_modificar_servicios.UseVisualStyleBackColor = true;
            this.bttn_modificar_servicios.Click += new System.EventHandler(this.bttn_modificar_servicios_Click);
            // 
            // bttn_alta_servicio
            // 
            this.bttn_alta_servicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttn_alta_servicio.Location = new System.Drawing.Point(12, 102);
            this.bttn_alta_servicio.Name = "bttn_alta_servicio";
            this.bttn_alta_servicio.Size = new System.Drawing.Size(104, 34);
            this.bttn_alta_servicio.TabIndex = 7;
            this.bttn_alta_servicio.Text = "Alta";
            this.bttn_alta_servicio.UseVisualStyleBackColor = true;
            this.bttn_alta_servicio.Click += new System.EventHandler(this.bttn_alta_servicio_Click);
            // 
            // bttn_baja
            // 
            this.bttn_baja.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttn_baja.Location = new System.Drawing.Point(268, 102);
            this.bttn_baja.Name = "bttn_baja";
            this.bttn_baja.Size = new System.Drawing.Size(104, 34);
            this.bttn_baja.TabIndex = 8;
            this.bttn_baja.Text = "Baja";
            this.bttn_baja.UseVisualStyleBackColor = true;
            this.bttn_baja.Click += new System.EventHandler(this.bttn_baja_Click);
            // 
            // bttn_refrescar
            // 
            this.bttn_refrescar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttn_refrescar.Location = new System.Drawing.Point(12, 414);
            this.bttn_refrescar.Name = "bttn_refrescar";
            this.bttn_refrescar.Size = new System.Drawing.Size(104, 34);
            this.bttn_refrescar.TabIndex = 9;
            this.bttn_refrescar.Text = "Refrescar";
            this.bttn_refrescar.UseVisualStyleBackColor = true;
            this.bttn_refrescar.Click += new System.EventHandler(this.bttn_refrescar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Consulta);
            this.groupBox1.Controls.Add(this.txt_filtro_cod_servicio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 75);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_Consulta
            // 
            this.btn_Consulta.Location = new System.Drawing.Point(388, 33);
            this.btn_Consulta.Name = "btn_Consulta";
            this.btn_Consulta.Size = new System.Drawing.Size(75, 23);
            this.btn_Consulta.TabIndex = 3;
            this.btn_Consulta.Text = "Consulta";
            this.btn_Consulta.UseVisualStyleBackColor = true;
            this.btn_Consulta.Click += new System.EventHandler(this.btn_Consulta_Click);
            // 
            // txt_filtro_cod_servicio
            // 
            this.txt_filtro_cod_servicio.Location = new System.Drawing.Point(173, 33);
            this.txt_filtro_cod_servicio.Name = "txt_filtro_cod_servicio";
            this.txt_filtro_cod_servicio.Pp_Campo = null;
            this.txt_filtro_cod_servicio.Pp_MensajeError = null;
            this.txt_filtro_cod_servicio.Pp_Tabla = null;
            this.txt_filtro_cod_servicio.Pp_Validable = false;
            this.txt_filtro_cod_servicio.Size = new System.Drawing.Size(183, 23);
            this.txt_filtro_cod_servicio.TabIndex = 2;
            this.txt_filtro_cod_servicio.TextChanged += new System.EventHandler(this.txt_filtro_cod_servicio_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Servicio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // codigo_servicio
            // 
            this.codigo_servicio.HeaderText = "Id Serv.";
            this.codigo_servicio.Name = "codigo_servicio";
            this.codigo_servicio.ReadOnly = true;
            this.codigo_servicio.Width = 50;
            // 
            // tipo_servicio
            // 
            this.tipo_servicio.HeaderText = "Tipo Servicio";
            this.tipo_servicio.Name = "tipo_servicio";
            this.tipo_servicio.ReadOnly = true;
            // 
            // id_servicio
            // 
            this.id_servicio.HeaderText = "Nomb. de Serv.";
            this.id_servicio.Name = "id_servicio";
            this.id_servicio.ReadOnly = true;
            this.id_servicio.Width = 150;
            // 
            // fecha_desde
            // 
            this.fecha_desde.HeaderText = "Fecha Desde";
            this.fecha_desde.Name = "fecha_desde";
            this.fecha_desde.ReadOnly = true;
            this.fecha_desde.Width = 60;
            // 
            // fecha_hasta
            // 
            this.fecha_hasta.HeaderText = "Fecha Hasta";
            this.fecha_hasta.Name = "fecha_hasta";
            this.fecha_hasta.ReadOnly = true;
            this.fecha_hasta.Width = 60;
            // 
            // id_numero
            // 
            this.id_numero.HeaderText = "Nro. de Teléfono";
            this.id_numero.Name = "id_numero";
            this.id_numero.ReadOnly = true;
            this.id_numero.Width = 125;
            // 
            // Frm_ABM_Servicios_Contratados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 460);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bttn_refrescar);
            this.Controls.Add(this.bttn_baja);
            this.Controls.Add(this.bttn_alta_servicio);
            this.Controls.Add(this.bttn_modificar_servicios);
            this.Controls.Add(this.btn_salir_cliente);
            this.Controls.Add(this.GridServicios);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_ABM_Servicios_Contratados";
            this.Text = "Servicios Contratados";
            this.Load += new System.EventHandler(this.Frm_ABM_Servicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridServicios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridServicios;
        private System.Windows.Forms.Button btn_salir_cliente;
        private System.Windows.Forms.Button bttn_modificar_servicios;
        private System.Windows.Forms.DataGridViewTextBoxColumn codi_servicio;
        private System.Windows.Forms.Button bttn_alta_servicio;
        private System.Windows.Forms.Button bttn_baja;
        private System.Windows.Forms.Button bttn_refrescar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Consulta;
        private Clases.TextBox01 txt_filtro_cod_servicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_numero;
    }
}