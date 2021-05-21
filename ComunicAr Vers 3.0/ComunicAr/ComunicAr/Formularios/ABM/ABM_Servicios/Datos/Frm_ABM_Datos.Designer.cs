
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
            this.Codigo = new System.Windows.Forms.Label();
            this.grid_Datos = new System.Windows.Forms.DataGridView();
            this.cod_datos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limite_datos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_fijo = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox1.Controls.Add(this.Codigo);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // btm_Consulta
            // 
            this.btm_Consulta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_Consulta.Location = new System.Drawing.Point(370, 33);
            this.btm_Consulta.Name = "btm_Consulta";
            this.btm_Consulta.Size = new System.Drawing.Size(75, 23);
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
            this.filtro_Cod.Size = new System.Drawing.Size(163, 23);
            this.filtro_Cod.TabIndex = 3;
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.Location = new System.Drawing.Point(121, 36);
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
            this.costo_fijo});
            this.grid_Datos.Location = new System.Drawing.Point(12, 165);
            this.grid_Datos.Name = "grid_Datos";
            this.grid_Datos.ReadOnly = true;
            this.grid_Datos.Size = new System.Drawing.Size(458, 252);
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
            // btn_refrescar_dato
            // 
            this.btn_refrescar_dato.Location = new System.Drawing.Point(12, 442);
            this.btn_refrescar_dato.Name = "btn_refrescar_dato";
            this.btn_refrescar_dato.Size = new System.Drawing.Size(104, 34);
            this.btn_refrescar_dato.TabIndex = 5;
            this.btn_refrescar_dato.Text = "Refrescar";
            this.btn_refrescar_dato.UseVisualStyleBackColor = true;
            this.btn_refrescar_dato.Click += new System.EventHandler(this.btn_refrescar_dato_Click);
            // 
            // btn_salir_cliente
            // 
            this.btn_salir_cliente.Location = new System.Drawing.Point(366, 442);
            this.btn_salir_cliente.Name = "btn_salir_cliente";
            this.btn_salir_cliente.Size = new System.Drawing.Size(104, 34);
            this.btn_salir_cliente.TabIndex = 6;
            this.btn_salir_cliente.Text = "Salir";
            this.btn_salir_cliente.UseVisualStyleBackColor = true;
            this.btn_salir_cliente.Click += new System.EventHandler(this.btn_salir_cliente_Click);
            // 
            // btn_crear_Datos
            // 
            this.btn_crear_Datos.Location = new System.Drawing.Point(12, 125);
            this.btn_crear_Datos.Name = "btn_crear_Datos";
            this.btn_crear_Datos.Size = new System.Drawing.Size(104, 34);
            this.btn_crear_Datos.TabIndex = 7;
            this.btn_crear_Datos.Text = "Crear";
            this.btn_crear_Datos.UseVisualStyleBackColor = true;
            this.btn_crear_Datos.Click += new System.EventHandler(this.btn_crear_Datos_Click);
            // 
            // btn_eliminar_cliente
            // 
            this.btn_eliminar_cliente.Location = new System.Drawing.Point(268, 125);
            this.btn_eliminar_cliente.Name = "btn_eliminar_cliente";
            this.btn_eliminar_cliente.Size = new System.Drawing.Size(104, 34);
            this.btn_eliminar_cliente.TabIndex = 8;
            this.btn_eliminar_cliente.Text = "Eliminar";
            this.btn_eliminar_cliente.UseVisualStyleBackColor = true;
            this.btn_eliminar_cliente.Click += new System.EventHandler(this.btn_eliminar_cliente_Click);
            // 
            // btn_modificar_Datos
            // 
            this.btn_modificar_Datos.Location = new System.Drawing.Point(140, 125);
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
            this.ClientSize = new System.Drawing.Size(492, 488);
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
        private Clases.TextBox01 filtro_Cod;
        private System.Windows.Forms.Button btm_Consulta;
        private System.Windows.Forms.DataGridView grid_Datos;
        private System.Windows.Forms.Button btn_refrescar_dato;
        private System.Windows.Forms.Button btn_salir_cliente;
        private System.Windows.Forms.Button btn_crear_Datos;
        private System.Windows.Forms.Button btn_eliminar_cliente;
        private System.Windows.Forms.Button btn_modificar_Datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn limite_datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_fijo;
    }
}