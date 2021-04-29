
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
            this.Codigo_Nacional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Datos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // GridServicios
            // 
            this.GridServicios.AllowUserToAddRows = false;
            this.GridServicios.AllowUserToDeleteRows = false;
            this.GridServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_Nacional,
            this.Codigo_Area,
            this.Numero_Telefono,
            this.Codigo_Servicio,
            this.Codigo_Datos,
            this.Fecha_Desde,
            this.Fecha_Hasta});
            this.GridServicios.Location = new System.Drawing.Point(12, 44);
            this.GridServicios.Name = "GridServicios";
            this.GridServicios.ReadOnly = true;
            this.GridServicios.Size = new System.Drawing.Size(735, 262);
            this.GridServicios.TabIndex = 3;
            this.GridServicios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridServicios_CellContentClick);
            // 
            // Codigo_Nacional
            // 
            this.Codigo_Nacional.HeaderText = "Codigo Nacional";
            this.Codigo_Nacional.Name = "Codigo_Nacional";
            this.Codigo_Nacional.ReadOnly = true;
            // 
            // Codigo_Area
            // 
            this.Codigo_Area.HeaderText = "Codigo Area";
            this.Codigo_Area.Name = "Codigo_Area";
            this.Codigo_Area.ReadOnly = true;
            // 
            // Numero_Telefono
            // 
            this.Numero_Telefono.HeaderText = "Numero Telefono";
            this.Numero_Telefono.Name = "Numero_Telefono";
            this.Numero_Telefono.ReadOnly = true;
            // 
            // Codigo_Servicio
            // 
            this.Codigo_Servicio.HeaderText = "Codigo Servicio";
            this.Codigo_Servicio.Name = "Codigo_Servicio";
            this.Codigo_Servicio.ReadOnly = true;
            // 
            // Codigo_Datos
            // 
            this.Codigo_Datos.HeaderText = "Codigo Datos";
            this.Codigo_Datos.Name = "Codigo_Datos";
            this.Codigo_Datos.ReadOnly = true;
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
            // Frm_ABM_Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 329);
            this.Controls.Add(this.GridServicios);
            this.Name = "Frm_ABM_Servicios";
            this.Text = "ServiciosContratados";
            ((System.ComponentModel.ISupportInitialize)(this.GridServicios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridServicios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Nacional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Hasta;
    }
}