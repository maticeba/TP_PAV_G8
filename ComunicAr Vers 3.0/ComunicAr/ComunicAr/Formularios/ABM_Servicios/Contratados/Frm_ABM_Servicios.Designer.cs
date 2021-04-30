
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
            this.Tipo_Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_salir_cliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // GridServicios
            // 
            this.GridServicios.AllowUserToAddRows = false;
            this.GridServicios.AllowUserToDeleteRows = false;
            this.GridServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo_Servicio,
            this.Nombre_Servicio,
            this.Codigo_Servicio,
            this.Fecha_Desde,
            this.Fecha_Hasta,
            this.id_numero});
            this.GridServicios.Location = new System.Drawing.Point(12, 44);
            this.GridServicios.Name = "GridServicios";
            this.GridServicios.ReadOnly = true;
            this.GridServicios.Size = new System.Drawing.Size(644, 262);
            this.GridServicios.TabIndex = 3;
            this.GridServicios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridServicios_CellContentClick);
            // 
            // Tipo_Servicio
            // 
            this.Tipo_Servicio.HeaderText = "Tipo Servicio";
            this.Tipo_Servicio.Name = "Tipo_Servicio";
            this.Tipo_Servicio.ReadOnly = true;
            // 
            // Nombre_Servicio
            // 
            this.Nombre_Servicio.HeaderText = "Nombre Servicio";
            this.Nombre_Servicio.Name = "Nombre_Servicio";
            this.Nombre_Servicio.ReadOnly = true;
            // 
            // Codigo_Servicio
            // 
            this.Codigo_Servicio.HeaderText = "Codigo Servicio";
            this.Codigo_Servicio.Name = "Codigo_Servicio";
            this.Codigo_Servicio.ReadOnly = true;
            // 
            // Fecha_Desde
            // 
            this.Fecha_Desde.HeaderText = "Fecha Desde";
            this.Fecha_Desde.Name = "Fecha_Desde";
            this.Fecha_Desde.ReadOnly = true;
            // 
            // Fecha_Hasta
            // 
            this.Fecha_Hasta.HeaderText = "Fecha Hasta";
            this.Fecha_Hasta.Name = "Fecha_Hasta";
            this.Fecha_Hasta.ReadOnly = true;
            // 
            // id_numero
            // 
            this.id_numero.HeaderText = "Numero Telefono";
            this.id_numero.Name = "id_numero";
            this.id_numero.ReadOnly = true;
            // 
            // btn_salir_cliente
            // 
            this.btn_salir_cliente.Location = new System.Drawing.Point(552, 315);
            this.btn_salir_cliente.Name = "btn_salir_cliente";
            this.btn_salir_cliente.Size = new System.Drawing.Size(104, 34);
            this.btn_salir_cliente.TabIndex = 5;
            this.btn_salir_cliente.Text = "Salir";
            this.btn_salir_cliente.UseVisualStyleBackColor = true;
            this.btn_salir_cliente.Click += new System.EventHandler(this.btn_salir_cliente_Click);
            // 
            // Frm_ABM_Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 361);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_numero;
        private System.Windows.Forms.Button btn_salir_cliente;
    }
}