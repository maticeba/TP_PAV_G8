
namespace ComunicAr.Formularios.ABM_Servicios.Prepagos
{
    partial class Frm_ABM_Prepagos
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
            this.bttn_refrescar = new System.Windows.Forms.Button();
            this.bttn_baja = new System.Windows.Forms.Button();
            this.bttn_alta_prepago = new System.Windows.Forms.Button();
            this.bttn_modificar_prepago = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.GridPrepago = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Consulta = new System.Windows.Forms.Button();
            this.txt_filtro_id_pack = new ComunicAr.Clases.TextBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.tipo_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_packs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridPrepago)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttn_refrescar
            // 
            this.bttn_refrescar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttn_refrescar.Location = new System.Drawing.Point(12, 425);
            this.bttn_refrescar.Name = "bttn_refrescar";
            this.bttn_refrescar.Size = new System.Drawing.Size(104, 34);
            this.bttn_refrescar.TabIndex = 15;
            this.bttn_refrescar.Text = "Refrescar";
            this.bttn_refrescar.UseVisualStyleBackColor = true;
            this.bttn_refrescar.Click += new System.EventHandler(this.bttn_refrescar_Click);
            // 
            // bttn_baja
            // 
            this.bttn_baja.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttn_baja.Location = new System.Drawing.Point(268, 115);
            this.bttn_baja.Name = "bttn_baja";
            this.bttn_baja.Size = new System.Drawing.Size(104, 34);
            this.bttn_baja.TabIndex = 14;
            this.bttn_baja.Text = "Baja";
            this.bttn_baja.UseVisualStyleBackColor = true;
            this.bttn_baja.Click += new System.EventHandler(this.bttn_baja_Click_1);
            // 
            // bttn_alta_prepago
            // 
            this.bttn_alta_prepago.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttn_alta_prepago.Location = new System.Drawing.Point(12, 115);
            this.bttn_alta_prepago.Name = "bttn_alta_prepago";
            this.bttn_alta_prepago.Size = new System.Drawing.Size(104, 34);
            this.bttn_alta_prepago.TabIndex = 13;
            this.bttn_alta_prepago.Text = "Alta";
            this.bttn_alta_prepago.UseVisualStyleBackColor = true;
            this.bttn_alta_prepago.Click += new System.EventHandler(this.bttn_alta_prepago_Click_1);
            // 
            // bttn_modificar_prepago
            // 
            this.bttn_modificar_prepago.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttn_modificar_prepago.Location = new System.Drawing.Point(140, 115);
            this.bttn_modificar_prepago.Name = "bttn_modificar_prepago";
            this.bttn_modificar_prepago.Size = new System.Drawing.Size(104, 34);
            this.bttn_modificar_prepago.TabIndex = 12;
            this.bttn_modificar_prepago.Text = "Modificar";
            this.bttn_modificar_prepago.UseVisualStyleBackColor = true;
            this.bttn_modificar_prepago.Click += new System.EventHandler(this.bttn_modificar_prepago_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(570, 425);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(104, 34);
            this.btn_salir.TabIndex = 11;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click_1);
            // 
            // GridPrepago
            // 
            this.GridPrepago.AllowUserToAddRows = false;
            this.GridPrepago.AllowUserToDeleteRows = false;
            this.GridPrepago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPrepago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipo_servicio,
            this.id_packs,
            this.duracion,
            this.descripcion,
            this.costo,
            this.id_region});
            this.GridPrepago.Location = new System.Drawing.Point(12, 155);
            this.GridPrepago.Name = "GridPrepago";
            this.GridPrepago.ReadOnly = true;
            this.GridPrepago.Size = new System.Drawing.Size(662, 252);
            this.GridPrepago.TabIndex = 10;
            this.GridPrepago.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPrepago_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Consulta);
            this.groupBox1.Controls.Add(this.txt_filtro_id_pack);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 88);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
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
            // txt_filtro_id_pack
            // 
            this.txt_filtro_id_pack.Location = new System.Drawing.Point(173, 33);
            this.txt_filtro_id_pack.Name = "txt_filtro_id_pack";
            this.txt_filtro_id_pack.Pp_Campo = null;
            this.txt_filtro_id_pack.Pp_MensajeError = null;
            this.txt_filtro_id_pack.Pp_Tabla = null;
            this.txt_filtro_id_pack.Pp_Validable = false;
            this.txt_filtro_id_pack.Size = new System.Drawing.Size(183, 23);
            this.txt_filtro_id_pack.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID pack";
            // 
            // tipo_servicio
            // 
            this.tipo_servicio.HeaderText = "Tipo Servicio";
            this.tipo_servicio.Name = "tipo_servicio";
            this.tipo_servicio.ReadOnly = true;
            // 
            // id_packs
            // 
            this.id_packs.HeaderText = "ID pack";
            this.id_packs.Name = "id_packs";
            this.id_packs.ReadOnly = true;
            // 
            // duracion
            // 
            this.duracion.HeaderText = "Duracion";
            this.duracion.Name = "duracion";
            this.duracion.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // costo
            // 
            this.costo.HeaderText = "Costo";
            this.costo.Name = "costo";
            this.costo.ReadOnly = true;
            // 
            // id_region
            // 
            this.id_region.HeaderText = "Region";
            this.id_region.Name = "id_region";
            this.id_region.ReadOnly = true;
            // 
            // Frm_ABM_Prepagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 463);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bttn_refrescar);
            this.Controls.Add(this.bttn_baja);
            this.Controls.Add(this.bttn_alta_prepago);
            this.Controls.Add(this.bttn_modificar_prepago);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.GridPrepago);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_ABM_Prepagos";
            this.Text = "Servicios Prepagos";
            this.Load += new System.EventHandler(this.Frm_ABM_Prepagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridPrepago)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttn_refrescar;
        private System.Windows.Forms.Button bttn_baja;
        private System.Windows.Forms.Button bttn_alta_prepago;
        private System.Windows.Forms.Button bttn_modificar_prepago;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridView GridPrepago;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Consulta;
        private Clases.TextBox01 txt_filtro_id_pack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_packs;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_region;
    }
}