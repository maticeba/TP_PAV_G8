﻿
namespace ComunicAr.Formularios.ABM_Servicios.Datos
{
    partial class Frm_ABM_Datos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btm_Consulta = new System.Windows.Forms.Button();
            this.filtro_Cod = new ComunicAr.Clases.TextBox01();
            this.cmb_FiltroTipo = new ComunicAr.Clases.ComboBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.Label();
            this.grid_Datos = new System.Windows.Forms.DataGridView();
            this.cod_datos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limite_datos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_fijo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_refrescar_dato = new System.Windows.Forms.Button();
            this.btn_salir_cliente = new System.Windows.Forms.Button();
            this.btn_crear_Datos = new System.Windows.Forms.Button();
            this.btn_eliminar_cliente = new System.Windows.Forms.Button();
            this.btn_modificar_Datos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btm_Consulta);
            this.groupBox1.Controls.Add(this.filtro_Cod);
            this.groupBox1.Controls.Add(this.cmb_FiltroTipo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Codigo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // btm_Consulta
            // 
            this.btm_Consulta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_Consulta.Location = new System.Drawing.Point(385, 67);
            this.btm_Consulta.Name = "btm_Consulta";
            this.btm_Consulta.Size = new System.Drawing.Size(87, 27);
            this.btm_Consulta.TabIndex = 4;
            this.btm_Consulta.Text = "Consulta";
            this.btm_Consulta.UseVisualStyleBackColor = true;
            this.btm_Consulta.Click += new System.EventHandler(this.btm_Consulta_Click);
            // 
            // filtro_Cod
            // 
            this.filtro_Cod.Location = new System.Drawing.Point(173, 33);
            this.filtro_Cod.Name = "filtro_Cod";
            this.filtro_Cod.Pp_Campo = null;
            this.filtro_Cod.Pp_MensajeError = null;
            this.filtro_Cod.Pp_Tabla = null;
            this.filtro_Cod.Pp_Validable = false;
            this.filtro_Cod.Size = new System.Drawing.Size(163, 22);
            this.filtro_Cod.TabIndex = 3;
            // 
            // cmb_FiltroTipo
            // 
            this.cmb_FiltroTipo.FormattingEnabled = true;
            this.cmb_FiltroTipo.Location = new System.Drawing.Point(173, 69);
            this.cmb_FiltroTipo.Name = "cmb_FiltroTipo";
            this.cmb_FiltroTipo.Pp_Conseleccion = false;
            this.cmb_FiltroTipo.Pp_Descripcion = "tipo_servicio";
            this.cmb_FiltroTipo.Pp_MensajeError = null;
            this.cmb_FiltroTipo.Pp_NombreCampo = null;
            this.cmb_FiltroTipo.Pp_NombreTabla = null;
            this.cmb_FiltroTipo.Pp_PK = "tipo_servicio";
            this.cmb_FiltroTipo.Pp_Tabla = "servicios_datos";
            this.cmb_FiltroTipo.Pp_Validable = false;
            this.cmb_FiltroTipo.Size = new System.Drawing.Size(163, 24);
            this.cmb_FiltroTipo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Servicio";
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.Location = new System.Drawing.Point(121, 37);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(46, 15);
            this.Codigo.TabIndex = 0;
            this.Codigo.Text = "Codigo";
            // 
            // grid_Datos
            // 
            this.grid_Datos.AllowUserToAddRows = false;
            this.grid_Datos.AllowUserToDeleteRows = false;
            this.grid_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_datos,
            this.limite_datos,
            this.descripcion,
            this.costo_fijo,
            this.recargo,
            this.tipo_servicio});
            this.grid_Datos.Location = new System.Drawing.Point(12, 181);
            this.grid_Datos.Name = "grid_Datos";
            this.grid_Datos.ReadOnly = true;
            this.grid_Datos.Size = new System.Drawing.Size(671, 252);
            this.grid_Datos.TabIndex = 1;
            this.grid_Datos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Datos_CellContentClick);
            // 
            // cod_datos
            // 
            this.cod_datos.HeaderText = "Codigo";
            this.cod_datos.Name = "cod_datos";
            this.cod_datos.ReadOnly = true;
            // 
            // limite_datos
            // 
            this.limite_datos.HeaderText = "Limite de datos";
            this.limite_datos.Name = "limite_datos";
            this.limite_datos.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // costo_fijo
            // 
            this.costo_fijo.HeaderText = "Costo Fijo";
            this.costo_fijo.Name = "costo_fijo";
            this.costo_fijo.ReadOnly = true;
            // 
            // recargo
            // 
            this.recargo.HeaderText = "Recargo";
            this.recargo.Name = "recargo";
            this.recargo.ReadOnly = true;
            // 
            // tipo_servicio
            // 
            this.tipo_servicio.HeaderText = "Tipo de Servicio";
            this.tipo_servicio.Name = "tipo_servicio";
            this.tipo_servicio.ReadOnly = true;
            // 
            // btn_refrescar_dato
            // 
            this.btn_refrescar_dato.Location = new System.Drawing.Point(12, 450);
            this.btn_refrescar_dato.Name = "btn_refrescar_dato";
            this.btn_refrescar_dato.Size = new System.Drawing.Size(104, 34);
            this.btn_refrescar_dato.TabIndex = 5;
            this.btn_refrescar_dato.Text = "Refrescar";
            this.btn_refrescar_dato.UseVisualStyleBackColor = true;
            this.btn_refrescar_dato.Click += new System.EventHandler(this.btn_refrescar_dato_Click);
            // 
            // btn_salir_cliente
            // 
            this.btn_salir_cliente.Location = new System.Drawing.Point(579, 450);
            this.btn_salir_cliente.Name = "btn_salir_cliente";
            this.btn_salir_cliente.Size = new System.Drawing.Size(104, 34);
            this.btn_salir_cliente.TabIndex = 6;
            this.btn_salir_cliente.Text = "Salir";
            this.btn_salir_cliente.UseVisualStyleBackColor = true;
            this.btn_salir_cliente.Click += new System.EventHandler(this.btn_salir_cliente_Click);
            // 
            // btn_crear_Datos
            // 
            this.btn_crear_Datos.Location = new System.Drawing.Point(12, 140);
            this.btn_crear_Datos.Name = "btn_crear_Datos";
            this.btn_crear_Datos.Size = new System.Drawing.Size(104, 34);
            this.btn_crear_Datos.TabIndex = 7;
            this.btn_crear_Datos.Text = "Crear";
            this.btn_crear_Datos.UseVisualStyleBackColor = true;
            this.btn_crear_Datos.Click += new System.EventHandler(this.btn_crear_Datos_Click);
            // 
            // btn_eliminar_cliente
            // 
            this.btn_eliminar_cliente.Location = new System.Drawing.Point(268, 140);
            this.btn_eliminar_cliente.Name = "btn_eliminar_cliente";
            this.btn_eliminar_cliente.Size = new System.Drawing.Size(104, 34);
            this.btn_eliminar_cliente.TabIndex = 8;
            this.btn_eliminar_cliente.Text = "Eliminar";
            this.btn_eliminar_cliente.UseVisualStyleBackColor = true;
            this.btn_eliminar_cliente.Click += new System.EventHandler(this.btn_eliminar_cliente_Click);
            // 
            // btn_modificar_Datos
            // 
            this.btn_modificar_Datos.Location = new System.Drawing.Point(140, 140);
            this.btn_modificar_Datos.Name = "btn_modificar_Datos";
            this.btn_modificar_Datos.Size = new System.Drawing.Size(104, 34);
            this.btn_modificar_Datos.TabIndex = 9;
            this.btn_modificar_Datos.Text = "Modificar";
            this.btn_modificar_Datos.UseVisualStyleBackColor = true;
            this.btn_modificar_Datos.Click += new System.EventHandler(this.btn_modificar_Datos_Click);
            // 
            // Frm_ABM_Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 488);
            this.ControlBox = false;
            this.Controls.Add(this.btn_modificar_Datos);
            this.Controls.Add(this.btn_eliminar_cliente);
            this.Controls.Add(this.btn_crear_Datos);
            this.Controls.Add(this.btn_salir_cliente);
            this.Controls.Add(this.btn_refrescar_dato);
            this.Controls.Add(this.grid_Datos);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_ABM_Datos";
            this.Text = "Servicios de Datos";
            this.Load += new System.EventHandler(this.Frm_ABM_Datos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Datos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.Label label1;
        private Clases.TextBox01 filtro_Cod;
        private Clases.ComboBox01 cmb_FiltroTipo;
        private System.Windows.Forms.Button btm_Consulta;
        private System.Windows.Forms.DataGridView grid_Datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn limite_datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_fijo;
        private System.Windows.Forms.DataGridViewTextBoxColumn recargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_servicio;
        private System.Windows.Forms.Button btn_refrescar_dato;
        private System.Windows.Forms.Button btn_salir_cliente;
        private System.Windows.Forms.Button btn_crear_Datos;
        private System.Windows.Forms.Button btn_eliminar_cliente;
        private System.Windows.Forms.Button btn_modificar_Datos;
    }
}