
namespace ComunicAr.Formularios.ABM_Numeros
{
    partial class Frm_ABM_Numeros
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
            this.GridNumero = new System.Windows.Forms.DataGridView();
            this.btn_refrescar_numero = new System.Windows.Forms.Button();
            this.btn_salir_numero = new System.Windows.Forms.Button();
            this.btn_eliminar_numero = new System.Windows.Forms.Button();
            this.btn_modificar_numero = new System.Windows.Forms.Button();
            this.btn_crear_numero = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.filtro_id_numero = new ComunicAr.Clases.TextBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.id_numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_dispositivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridNumero)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridNumero
            // 
            this.GridNumero.AllowUserToAddRows = false;
            this.GridNumero.AllowUserToDeleteRows = false;
            this.GridNumero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridNumero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_numero,
            this.nro_telefono,
            this.nro_cliente,
            this.id_dispositivo});
            this.GridNumero.Location = new System.Drawing.Point(12, 160);
            this.GridNumero.Name = "GridNumero";
            this.GridNumero.ReadOnly = true;
            this.GridNumero.Size = new System.Drawing.Size(607, 291);
            this.GridNumero.TabIndex = 7;
            this.GridNumero.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridNumero_CellContentClick_1);
            // 
            // btn_refrescar_numero
            // 
            this.btn_refrescar_numero.Location = new System.Drawing.Point(12, 471);
            this.btn_refrescar_numero.Name = "btn_refrescar_numero";
            this.btn_refrescar_numero.Size = new System.Drawing.Size(104, 34);
            this.btn_refrescar_numero.TabIndex = 2;
            this.btn_refrescar_numero.Text = "Refrescar";
            this.btn_refrescar_numero.UseVisualStyleBackColor = true;
            this.btn_refrescar_numero.Click += new System.EventHandler(this.btn_refrescar_numero_Click);
            // 
            // btn_salir_numero
            // 
            this.btn_salir_numero.Location = new System.Drawing.Point(515, 471);
            this.btn_salir_numero.Name = "btn_salir_numero";
            this.btn_salir_numero.Size = new System.Drawing.Size(104, 34);
            this.btn_salir_numero.TabIndex = 3;
            this.btn_salir_numero.Text = "Salir";
            this.btn_salir_numero.UseVisualStyleBackColor = true;
            this.btn_salir_numero.Click += new System.EventHandler(this.btn_salir_numero_Click);
            // 
            // btn_eliminar_numero
            // 
            this.btn_eliminar_numero.Location = new System.Drawing.Point(310, 120);
            this.btn_eliminar_numero.Name = "btn_eliminar_numero";
            this.btn_eliminar_numero.Size = new System.Drawing.Size(104, 34);
            this.btn_eliminar_numero.TabIndex = 4;
            this.btn_eliminar_numero.Text = "Eliminar";
            this.btn_eliminar_numero.UseVisualStyleBackColor = true;
            this.btn_eliminar_numero.Click += new System.EventHandler(this.btn_eliminar_numero_Click);
            // 
            // btn_modificar_numero
            // 
            this.btn_modificar_numero.Location = new System.Drawing.Point(161, 120);
            this.btn_modificar_numero.Name = "btn_modificar_numero";
            this.btn_modificar_numero.Size = new System.Drawing.Size(104, 34);
            this.btn_modificar_numero.TabIndex = 5;
            this.btn_modificar_numero.Text = "Modificar";
            this.btn_modificar_numero.UseVisualStyleBackColor = true;
            this.btn_modificar_numero.Click += new System.EventHandler(this.btn_modificar_numero_Click);
            // 
            // btn_crear_numero
            // 
            this.btn_crear_numero.Location = new System.Drawing.Point(12, 120);
            this.btn_crear_numero.Name = "btn_crear_numero";
            this.btn_crear_numero.Size = new System.Drawing.Size(104, 34);
            this.btn_crear_numero.TabIndex = 6;
            this.btn_crear_numero.Text = "Crear";
            this.btn_crear_numero.UseVisualStyleBackColor = true;
            this.btn_crear_numero.Click += new System.EventHandler(this.btn_crear_numero_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsulta);
            this.groupBox1.Controls.Add(this.filtro_id_numero);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 87);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(361, 36);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(87, 27);
            this.btnConsulta.TabIndex = 3;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // filtro_id_numero
            // 
            this.filtro_id_numero.Location = new System.Drawing.Point(124, 36);
            this.filtro_id_numero.Name = "filtro_id_numero";
            this.filtro_id_numero.Pp_Campo = null;
            this.filtro_id_numero.Pp_MensajeError = null;
            this.filtro_id_numero.Pp_Tabla = null;
            this.filtro_id_numero.Pp_Validable = false;
            this.filtro_id_numero.Size = new System.Drawing.Size(213, 23);
            this.filtro_id_numero.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID numero";
            // 
            // id_numero
            // 
            this.id_numero.HeaderText = "ID numero";
            this.id_numero.Name = "id_numero";
            this.id_numero.ReadOnly = true;
            // 
            // nro_telefono
            // 
            this.nro_telefono.HeaderText = "Numero Telefono";
            this.nro_telefono.Name = "nro_telefono";
            this.nro_telefono.ReadOnly = true;
            this.nro_telefono.Width = 150;
            // 
            // nro_cliente
            // 
            this.nro_cliente.HeaderText = "Cliente";
            this.nro_cliente.Name = "nro_cliente";
            this.nro_cliente.ReadOnly = true;
            this.nro_cliente.Width = 140;
            // 
            // id_dispositivo
            // 
            this.id_dispositivo.HeaderText = "Dispositivo";
            this.id_dispositivo.Name = "id_dispositivo";
            this.id_dispositivo.ReadOnly = true;
            this.id_dispositivo.Width = 150;
            // 
            // Frm_ABM_Numeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 514);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GridNumero);
            this.Controls.Add(this.btn_refrescar_numero);
            this.Controls.Add(this.btn_salir_numero);
            this.Controls.Add(this.btn_eliminar_numero);
            this.Controls.Add(this.btn_modificar_numero);
            this.Controls.Add(this.btn_crear_numero);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_ABM_Numeros";
            this.Text = "Frm_ABM_Numeros";
            this.Load += new System.EventHandler(this.Frm_ABM_Numeros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridNumero)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridNumero;
        private System.Windows.Forms.Button btn_refrescar_numero;
        private System.Windows.Forms.Button btn_salir_numero;
        private System.Windows.Forms.Button btn_eliminar_numero;
        private System.Windows.Forms.Button btn_modificar_numero;
        private System.Windows.Forms.Button btn_crear_numero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConsulta;
        private Clases.TextBox01 filtro_id_numero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_dispositivo;
    }
}