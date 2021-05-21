
namespace ComunicAr.Formularios.ABM_Dispositivos
{
    partial class Frm_ABM_Dispositivos
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
            this.btn_modificar_Dispo = new System.Windows.Forms.Button();
            this.btn_eliminar_Dispo = new System.Windows.Forms.Button();
            this.btn_crear_Dispo = new System.Windows.Forms.Button();
            this.btn_salir_Dispo = new System.Windows.Forms.Button();
            this.btn_refrescar_Dispo = new System.Windows.Forms.Button();
            this.grid_Dispo = new System.Windows.Forms.DataGridView();
            this.id_dispositivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_elaboracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caracteristicas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tipo_dispositivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btm_Consulta = new System.Windows.Forms.Button();
            this.filtro_ID_Dis = new ComunicAr.Clases.TextBox01();
            this.cmb_FiltroMarca = new ComunicAr.Clases.ComboBox01();
            this.label_marca = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Dispo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_modificar_Dispo
            // 
            this.btn_modificar_Dispo.Location = new System.Drawing.Point(140, 140);
            this.btn_modificar_Dispo.Name = "btn_modificar_Dispo";
            this.btn_modificar_Dispo.Size = new System.Drawing.Size(104, 34);
            this.btn_modificar_Dispo.TabIndex = 16;
            this.btn_modificar_Dispo.Text = "Modificar";
            this.btn_modificar_Dispo.UseVisualStyleBackColor = true;
            this.btn_modificar_Dispo.Click += new System.EventHandler(this.btn_modificar_Dispo_Click);
            // 
            // btn_eliminar_Dispo
            // 
            this.btn_eliminar_Dispo.Location = new System.Drawing.Point(268, 140);
            this.btn_eliminar_Dispo.Name = "btn_eliminar_Dispo";
            this.btn_eliminar_Dispo.Size = new System.Drawing.Size(104, 34);
            this.btn_eliminar_Dispo.TabIndex = 15;
            this.btn_eliminar_Dispo.Text = "Eliminar";
            this.btn_eliminar_Dispo.UseVisualStyleBackColor = true;
            this.btn_eliminar_Dispo.Click += new System.EventHandler(this.btn_eliminar_Dispo_Click);
            // 
            // btn_crear_Dispo
            // 
            this.btn_crear_Dispo.Location = new System.Drawing.Point(12, 140);
            this.btn_crear_Dispo.Name = "btn_crear_Dispo";
            this.btn_crear_Dispo.Size = new System.Drawing.Size(104, 34);
            this.btn_crear_Dispo.TabIndex = 14;
            this.btn_crear_Dispo.Text = "Crear";
            this.btn_crear_Dispo.UseVisualStyleBackColor = true;
            this.btn_crear_Dispo.Click += new System.EventHandler(this.btn_crear_Dispo_Click);
            // 
            // btn_salir_Dispo
            // 
            this.btn_salir_Dispo.Location = new System.Drawing.Point(670, 450);
            this.btn_salir_Dispo.Name = "btn_salir_Dispo";
            this.btn_salir_Dispo.Size = new System.Drawing.Size(104, 34);
            this.btn_salir_Dispo.TabIndex = 13;
            this.btn_salir_Dispo.Text = "Salir";
            this.btn_salir_Dispo.UseVisualStyleBackColor = true;
            this.btn_salir_Dispo.Click += new System.EventHandler(this.btn_salir_Dispo_Click);
            // 
            // btn_refrescar_Dispo
            // 
            this.btn_refrescar_Dispo.Location = new System.Drawing.Point(12, 450);
            this.btn_refrescar_Dispo.Name = "btn_refrescar_Dispo";
            this.btn_refrescar_Dispo.Size = new System.Drawing.Size(104, 34);
            this.btn_refrescar_Dispo.TabIndex = 12;
            this.btn_refrescar_Dispo.Text = "Refrescar";
            this.btn_refrescar_Dispo.UseVisualStyleBackColor = true;
            this.btn_refrescar_Dispo.Click += new System.EventHandler(this.btn_refrescar_Dispo_Click);
            // 
            // grid_Dispo
            // 
            this.grid_Dispo.AllowUserToAddRows = false;
            this.grid_Dispo.AllowUserToDeleteRows = false;
            this.grid_Dispo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Dispo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_dispositivo,
            this.fecha_elaboracion,
            this.marca,
            this.modelo,
            this.caracteristicas,
            this.precio,
            this.id_tipo_dispositivo});
            this.grid_Dispo.Location = new System.Drawing.Point(12, 180);
            this.grid_Dispo.Name = "grid_Dispo";
            this.grid_Dispo.ReadOnly = true;
            this.grid_Dispo.Size = new System.Drawing.Size(762, 252);
            this.grid_Dispo.TabIndex = 11;
            this.grid_Dispo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Dispo_CellContentClick);
            // 
            // id_dispositivo
            // 
            this.id_dispositivo.HeaderText = "ID";
            this.id_dispositivo.Name = "id_dispositivo";
            this.id_dispositivo.ReadOnly = true;
            this.id_dispositivo.Width = 65;
            // 
            // fecha_elaboracion
            // 
            this.fecha_elaboracion.HeaderText = "Fecha de Elaboracion";
            this.fecha_elaboracion.Name = "fecha_elaboracion";
            this.fecha_elaboracion.ReadOnly = true;
            this.fecha_elaboracion.Width = 125;
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // modelo
            // 
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            // 
            // caracteristicas
            // 
            this.caracteristicas.HeaderText = "Caracteristicas";
            this.caracteristicas.Name = "caracteristicas";
            this.caracteristicas.ReadOnly = true;
            this.caracteristicas.Width = 125;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // id_tipo_dispositivo
            // 
            this.id_tipo_dispositivo.HeaderText = "Tipo";
            this.id_tipo_dispositivo.Name = "id_tipo_dispositivo";
            this.id_tipo_dispositivo.ReadOnly = true;
            this.id_tipo_dispositivo.Width = 75;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btm_Consulta);
            this.groupBox1.Controls.Add(this.filtro_ID_Dis);
            this.groupBox1.Controls.Add(this.cmb_FiltroMarca);
            this.groupBox1.Controls.Add(this.label_marca);
            this.groupBox1.Controls.Add(this.label_id);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 113);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btm_Consulta
            // 
            this.btm_Consulta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_Consulta.Location = new System.Drawing.Point(377, 68);
            this.btm_Consulta.Name = "btm_Consulta";
            this.btm_Consulta.Size = new System.Drawing.Size(75, 23);
            this.btm_Consulta.TabIndex = 4;
            this.btm_Consulta.Text = "Consulta";
            this.btm_Consulta.UseVisualStyleBackColor = true;
            this.btm_Consulta.Click += new System.EventHandler(this.btm_Consulta_Click);
            // 
            // filtro_ID_Dis
            // 
            this.filtro_ID_Dis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtro_ID_Dis.Location = new System.Drawing.Point(173, 33);
            this.filtro_ID_Dis.Name = "filtro_ID_Dis";
            this.filtro_ID_Dis.Pp_Campo = null;
            this.filtro_ID_Dis.Pp_MensajeError = null;
            this.filtro_ID_Dis.Pp_Tabla = null;
            this.filtro_ID_Dis.Pp_Validable = false;
            this.filtro_ID_Dis.Size = new System.Drawing.Size(163, 23);
            this.filtro_ID_Dis.TabIndex = 3;
            // 
            // cmb_FiltroMarca
            // 
            this.cmb_FiltroMarca.FormattingEnabled = true;
            this.cmb_FiltroMarca.Location = new System.Drawing.Point(173, 69);
            this.cmb_FiltroMarca.Name = "cmb_FiltroMarca";
            this.cmb_FiltroMarca.Pp_Conseleccion = false;
            this.cmb_FiltroMarca.Pp_Descripcion = "marca";
            this.cmb_FiltroMarca.Pp_MensajeError = null;
            this.cmb_FiltroMarca.Pp_NombreCampo = null;
            this.cmb_FiltroMarca.Pp_NombreTabla = null;
            this.cmb_FiltroMarca.Pp_PK = "marca";
            this.cmb_FiltroMarca.Pp_Tabla = "dispositivos";
            this.cmb_FiltroMarca.Pp_Validable = false;
            this.cmb_FiltroMarca.Size = new System.Drawing.Size(163, 23);
            this.cmb_FiltroMarca.TabIndex = 2;
            // 
            // label_marca
            // 
            this.label_marca.AutoSize = true;
            this.label_marca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_marca.Location = new System.Drawing.Point(127, 72);
            this.label_marca.Name = "label_marca";
            this.label_marca.Size = new System.Drawing.Size(40, 15);
            this.label_marca.TabIndex = 1;
            this.label_marca.Text = "Marca";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(149, 37);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(18, 15);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "ID";
            // 
            // Frm_ABM_Dispositivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 488);
            this.ControlBox = false;
            this.Controls.Add(this.btn_modificar_Dispo);
            this.Controls.Add(this.btn_eliminar_Dispo);
            this.Controls.Add(this.btn_crear_Dispo);
            this.Controls.Add(this.btn_salir_Dispo);
            this.Controls.Add(this.btn_refrescar_Dispo);
            this.Controls.Add(this.grid_Dispo);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_ABM_Dispositivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ABM_Dispositivos";
            this.Load += new System.EventHandler(this.Frm_ABM_Dispositivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Dispo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_modificar_Dispo;
        private System.Windows.Forms.Button btn_eliminar_Dispo;
        private System.Windows.Forms.Button btn_crear_Dispo;
        private System.Windows.Forms.Button btn_salir_Dispo;
        private System.Windows.Forms.Button btn_refrescar_Dispo;
        private System.Windows.Forms.DataGridView grid_Dispo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btm_Consulta;
        private Clases.TextBox01 filtro_ID_Dis;
        private Clases.ComboBox01 cmb_FiltroMarca;
        private System.Windows.Forms.Label label_marca;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_dispositivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_elaboracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn caracteristicas;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tipo_dispositivo;
    }
}