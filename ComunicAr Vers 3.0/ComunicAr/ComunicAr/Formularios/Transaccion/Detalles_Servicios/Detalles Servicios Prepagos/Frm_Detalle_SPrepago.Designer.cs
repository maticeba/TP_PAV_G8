
namespace ComunicAr.Formularios.Transaccion.Detalles_Servicios.Detalles_Servicios_Prepagos
{
    partial class Frm_Detalle_SPrepago
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
            this.descuento_ = new System.Windows.Forms.Button();
            this.btn_det_prepago_borrar = new System.Windows.Forms.Button();
            this.btn_det_prepago_modificar = new System.Windows.Forms.Button();
            this.btn_det_prepago_cancelar = new System.Windows.Forms.Button();
            this.btn_det_prepago_generar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_ID_SPrepagos = new ComunicAr.Clases.TextBox01();
            this.Txt_NroFac_SPrepagos = new ComunicAr.Clases.TextBox01();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Nombre_SPrepagos = new ComunicAr.Clases.TextBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grid_Serv_Prepagos = new System.Windows.Forms.DataGridView();
            this.cod_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_subtotla_SP = new ComunicAr.Clases.TextBox01();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Serv_Prepagos)).BeginInit();
            this.SuspendLayout();
            // 
            // descuento_
            // 
            this.descuento_.Location = new System.Drawing.Point(204, 411);
            this.descuento_.Name = "descuento_";
            this.descuento_.Size = new System.Drawing.Size(75, 23);
            this.descuento_.TabIndex = 25;
            this.descuento_.Text = "Descuento";
            this.descuento_.UseVisualStyleBackColor = true;
            this.descuento_.Click += new System.EventHandler(this.descuento_Click);
            // 
            // btn_det_prepago_borrar
            // 
            this.btn_det_prepago_borrar.Location = new System.Drawing.Point(108, 411);
            this.btn_det_prepago_borrar.Name = "btn_det_prepago_borrar";
            this.btn_det_prepago_borrar.Size = new System.Drawing.Size(75, 23);
            this.btn_det_prepago_borrar.TabIndex = 24;
            this.btn_det_prepago_borrar.Text = "Borrar";
            this.btn_det_prepago_borrar.UseVisualStyleBackColor = true;
            this.btn_det_prepago_borrar.Click += new System.EventHandler(this.btn_det_prepago_borrar_Click);
            // 
            // btn_det_prepago_modificar
            // 
            this.btn_det_prepago_modificar.Location = new System.Drawing.Point(13, 411);
            this.btn_det_prepago_modificar.Name = "btn_det_prepago_modificar";
            this.btn_det_prepago_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_det_prepago_modificar.TabIndex = 23;
            this.btn_det_prepago_modificar.Text = "Modificar";
            this.btn_det_prepago_modificar.UseVisualStyleBackColor = true;
            this.btn_det_prepago_modificar.Click += new System.EventHandler(this.btn_det_prepago_modificar_Click);
            // 
            // btn_det_prepago_cancelar
            // 
            this.btn_det_prepago_cancelar.Location = new System.Drawing.Point(632, 411);
            this.btn_det_prepago_cancelar.Name = "btn_det_prepago_cancelar";
            this.btn_det_prepago_cancelar.Size = new System.Drawing.Size(142, 23);
            this.btn_det_prepago_cancelar.TabIndex = 21;
            this.btn_det_prepago_cancelar.Text = "Cancelar";
            this.btn_det_prepago_cancelar.UseVisualStyleBackColor = true;
            this.btn_det_prepago_cancelar.Click += new System.EventHandler(this.btn_det_prepago_cancelar_Click);
            // 
            // btn_det_prepago_generar
            // 
            this.btn_det_prepago_generar.Location = new System.Drawing.Point(480, 411);
            this.btn_det_prepago_generar.Name = "btn_det_prepago_generar";
            this.btn_det_prepago_generar.Size = new System.Drawing.Size(142, 23);
            this.btn_det_prepago_generar.TabIndex = 22;
            this.btn_det_prepago_generar.Text = "Generar Detalle";
            this.btn_det_prepago_generar.UseVisualStyleBackColor = true;
            this.btn_det_prepago_generar.Click += new System.EventHandler(this.btn_det_prepago_generar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_ID_SPrepagos);
            this.groupBox1.Controls.Add(this.Txt_NroFac_SPrepagos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txt_Nombre_SPrepagos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 67);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Clientes";
            // 
            // Txt_ID_SPrepagos
            // 
            this.Txt_ID_SPrepagos.Enabled = false;
            this.Txt_ID_SPrepagos.Location = new System.Drawing.Point(105, 23);
            this.Txt_ID_SPrepagos.Name = "Txt_ID_SPrepagos";
            this.Txt_ID_SPrepagos.Pp_Campo = null;
            this.Txt_ID_SPrepagos.Pp_MensajeError = null;
            this.Txt_ID_SPrepagos.Pp_Tabla = null;
            this.Txt_ID_SPrepagos.Pp_Validable = false;
            this.Txt_ID_SPrepagos.Size = new System.Drawing.Size(95, 20);
            this.Txt_ID_SPrepagos.TabIndex = 1;
            // 
            // Txt_NroFac_SPrepagos
            // 
            this.Txt_NroFac_SPrepagos.Enabled = false;
            this.Txt_NroFac_SPrepagos.Location = new System.Drawing.Point(578, 22);
            this.Txt_NroFac_SPrepagos.Name = "Txt_NroFac_SPrepagos";
            this.Txt_NroFac_SPrepagos.Pp_Campo = null;
            this.Txt_NroFac_SPrepagos.Pp_MensajeError = null;
            this.Txt_NroFac_SPrepagos.Pp_Tabla = null;
            this.Txt_NroFac_SPrepagos.Pp_Validable = false;
            this.Txt_NroFac_SPrepagos.Size = new System.Drawing.Size(165, 20);
            this.Txt_NroFac_SPrepagos.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nro Factura";
            // 
            // Txt_Nombre_SPrepagos
            // 
            this.Txt_Nombre_SPrepagos.Enabled = false;
            this.Txt_Nombre_SPrepagos.Location = new System.Drawing.Point(317, 22);
            this.Txt_Nombre_SPrepagos.Name = "Txt_Nombre_SPrepagos";
            this.Txt_Nombre_SPrepagos.Pp_Campo = null;
            this.Txt_Nombre_SPrepagos.Pp_MensajeError = null;
            this.Txt_Nombre_SPrepagos.Pp_Tabla = null;
            this.Txt_Nombre_SPrepagos.Pp_Validable = false;
            this.Txt_Nombre_SPrepagos.Size = new System.Drawing.Size(165, 20);
            this.Txt_Nombre_SPrepagos.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(622, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Subtotal";
            // 
            // grid_Serv_Prepagos
            // 
            this.grid_Serv_Prepagos.AllowUserToAddRows = false;
            this.grid_Serv_Prepagos.AllowUserToDeleteRows = false;
            this.grid_Serv_Prepagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Serv_Prepagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_servicio,
            this.tipo_servicio,
            this.descripcion,
            this.costo,
            this.descuento,
            this.costo_final});
            this.grid_Serv_Prepagos.Location = new System.Drawing.Point(8, 90);
            this.grid_Serv_Prepagos.Name = "grid_Serv_Prepagos";
            this.grid_Serv_Prepagos.ReadOnly = true;
            this.grid_Serv_Prepagos.Size = new System.Drawing.Size(766, 266);
            this.grid_Serv_Prepagos.TabIndex = 17;
            this.grid_Serv_Prepagos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Serv_Prepagos_CellContentClick);
            // 
            // cod_servicio
            // 
            this.cod_servicio.HeaderText = "Codigo";
            this.cod_servicio.Name = "cod_servicio";
            this.cod_servicio.ReadOnly = true;
            // 
            // tipo_servicio
            // 
            this.tipo_servicio.HeaderText = "Tipo de Servicio";
            this.tipo_servicio.Name = "tipo_servicio";
            this.tipo_servicio.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 150;
            // 
            // costo
            // 
            this.costo.HeaderText = "Costo ";
            this.costo.Name = "costo";
            this.costo.ReadOnly = true;
            this.costo.Width = 150;
            // 
            // descuento
            // 
            this.descuento.HeaderText = "Descuento";
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            // 
            // costo_final
            // 
            this.costo_final.HeaderText = "Costo Final";
            this.costo_final.Name = "costo_final";
            this.costo_final.ReadOnly = true;
            // 
            // txt_subtotla_SP
            // 
            this.txt_subtotla_SP.Enabled = false;
            this.txt_subtotla_SP.Location = new System.Drawing.Point(674, 362);
            this.txt_subtotla_SP.Name = "txt_subtotla_SP";
            this.txt_subtotla_SP.Pp_Campo = null;
            this.txt_subtotla_SP.Pp_MensajeError = null;
            this.txt_subtotla_SP.Pp_Tabla = null;
            this.txt_subtotla_SP.Pp_Validable = false;
            this.txt_subtotla_SP.Size = new System.Drawing.Size(100, 20);
            this.txt_subtotla_SP.TabIndex = 19;
            this.txt_subtotla_SP.TextChanged += new System.EventHandler(this.txt_subtotla_SP_TextChanged);
            // 
            // Frm_Detalle_SPrepago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 455);
            this.Controls.Add(this.descuento_);
            this.Controls.Add(this.btn_det_prepago_borrar);
            this.Controls.Add(this.btn_det_prepago_modificar);
            this.Controls.Add(this.btn_det_prepago_cancelar);
            this.Controls.Add(this.btn_det_prepago_generar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_subtotla_SP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grid_Serv_Prepagos);
            this.Name = "Frm_Detalle_SPrepago";
            this.Text = "Frm_Detalle_SPrepago";
            this.Load += new System.EventHandler(this.Frm_Detalle_SPrepago_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Serv_Prepagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button descuento_;
        private System.Windows.Forms.Button btn_det_prepago_borrar;
        private System.Windows.Forms.Button btn_det_prepago_modificar;
        private System.Windows.Forms.Button btn_det_prepago_cancelar;
        private System.Windows.Forms.Button btn_det_prepago_generar;
        private System.Windows.Forms.GroupBox groupBox1;
        private Clases.TextBox01 Txt_ID_SPrepagos;
        private Clases.TextBox01 Txt_NroFac_SPrepagos;
        private System.Windows.Forms.Label label3;
        private Clases.TextBox01 Txt_Nombre_SPrepagos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Clases.TextBox01 txt_subtotla_SP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grid_Serv_Prepagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_final;
    }
}