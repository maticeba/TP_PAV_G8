
namespace ComunicAr.Formularios.ABM_Ciudad
{
    partial class Frm_ABM_Ciudad
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
            this.btn_crear_cliente = new System.Windows.Forms.Button();
            this.btn_modificar_ciud = new System.Windows.Forms.Button();
            this.btn_eliminar_ciud = new System.Windows.Forms.Button();
            this.dataGrid_Ciudad = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_refresh_client = new System.Windows.Forms.Button();
            this.btn_salir_cliente = new System.Windows.Forms.Button();
            this.Filtro = new System.Windows.Forms.GroupBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.txt_cod_prov = new ComunicAr.Clases.TextBox01();
            this.txt_nomb_ciud = new ComunicAr.Clases.TextBox01();
            this.txt_cod_ciud = new ComunicAr.Clases.TextBox01();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Ciudad)).BeginInit();
            this.Filtro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_crear_cliente
            // 
            this.btn_crear_cliente.Location = new System.Drawing.Point(12, 152);
            this.btn_crear_cliente.Name = "btn_crear_cliente";
            this.btn_crear_cliente.Size = new System.Drawing.Size(104, 34);
            this.btn_crear_cliente.TabIndex = 1;
            this.btn_crear_cliente.Text = "Crear";
            this.btn_crear_cliente.UseVisualStyleBackColor = true;
            this.btn_crear_cliente.Click += new System.EventHandler(this.btn_crear_ciudad_Click);
            // 
            // btn_modificar_ciud
            // 
            this.btn_modificar_ciud.Location = new System.Drawing.Point(122, 152);
            this.btn_modificar_ciud.Name = "btn_modificar_ciud";
            this.btn_modificar_ciud.Size = new System.Drawing.Size(104, 34);
            this.btn_modificar_ciud.TabIndex = 2;
            this.btn_modificar_ciud.Text = "Modificar";
            this.btn_modificar_ciud.UseVisualStyleBackColor = true;
            this.btn_modificar_ciud.Click += new System.EventHandler(this.btn_modificar_ciud_Click);
            // 
            // btn_eliminar_ciud
            // 
            this.btn_eliminar_ciud.Location = new System.Drawing.Point(232, 152);
            this.btn_eliminar_ciud.Name = "btn_eliminar_ciud";
            this.btn_eliminar_ciud.Size = new System.Drawing.Size(104, 34);
            this.btn_eliminar_ciud.TabIndex = 3;
            this.btn_eliminar_ciud.Text = "Eliminar";
            this.btn_eliminar_ciud.UseVisualStyleBackColor = true;
            this.btn_eliminar_ciud.Click += new System.EventHandler(this.btn_eliminar_ciud_Click);
            // 
            // dataGrid_Ciudad
            // 
            this.dataGrid_Ciudad.AllowUserToAddRows = false;
            this.dataGrid_Ciudad.AllowUserToDeleteRows = false;
            this.dataGrid_Ciudad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Ciudad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGrid_Ciudad.Location = new System.Drawing.Point(12, 192);
            this.dataGrid_Ciudad.Name = "dataGrid_Ciudad";
            this.dataGrid_Ciudad.ReadOnly = true;
            this.dataGrid_Ciudad.RowHeadersWidth = 62;
            this.dataGrid_Ciudad.Size = new System.Drawing.Size(722, 252);
            this.dataGrid_Ciudad.TabIndex = 4;
            this.dataGrid_Ciudad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cod_Ciudad";
            this.Column1.MinimumWidth = 15;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre_Ciudad";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cod_Provincia";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // btn_refresh_client
            // 
            this.btn_refresh_client.Location = new System.Drawing.Point(12, 450);
            this.btn_refresh_client.Name = "btn_refresh_client";
            this.btn_refresh_client.Size = new System.Drawing.Size(104, 34);
            this.btn_refresh_client.TabIndex = 5;
            this.btn_refresh_client.Text = "Refrescar";
            this.btn_refresh_client.UseVisualStyleBackColor = true;
            this.btn_refresh_client.Click += new System.EventHandler(this.btn_refresh_client_Click);
            // 
            // btn_salir_cliente
            // 
            this.btn_salir_cliente.Location = new System.Drawing.Point(630, 450);
            this.btn_salir_cliente.Name = "btn_salir_cliente";
            this.btn_salir_cliente.Size = new System.Drawing.Size(104, 34);
            this.btn_salir_cliente.TabIndex = 6;
            this.btn_salir_cliente.Text = "Salir";
            this.btn_salir_cliente.UseVisualStyleBackColor = true;
            this.btn_salir_cliente.Click += new System.EventHandler(this.btn_salir_ciudad_Click);
            // 
            // Filtro
            // 
            this.Filtro.Controls.Add(this.btn_consultar);
            this.Filtro.Controls.Add(this.txt_cod_prov);
            this.Filtro.Controls.Add(this.txt_nomb_ciud);
            this.Filtro.Controls.Add(this.txt_cod_ciud);
            this.Filtro.Controls.Add(this.label3);
            this.Filtro.Controls.Add(this.label2);
            this.Filtro.Controls.Add(this.label1);
            this.Filtro.Location = new System.Drawing.Point(12, 12);
            this.Filtro.Name = "Filtro";
            this.Filtro.Size = new System.Drawing.Size(722, 134);
            this.Filtro.TabIndex = 7;
            this.Filtro.TabStop = false;
            this.Filtro.Text = "Filtro";
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(604, 91);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(112, 34);
            this.btn_consultar.TabIndex = 2;
            this.btn_consultar.Text = "Filtrar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // txt_cod_prov
            // 
            this.txt_cod_prov.Location = new System.Drawing.Point(165, 95);
            this.txt_cod_prov.Name = "txt_cod_prov";
            this.txt_cod_prov.Pp_Campo = null;
            this.txt_cod_prov.Pp_MensajeError = null;
            this.txt_cod_prov.Pp_Tabla = null;
            this.txt_cod_prov.Pp_Validable = false;
            this.txt_cod_prov.Size = new System.Drawing.Size(131, 26);
            this.txt_cod_prov.TabIndex = 1;
            // 
            // txt_nomb_ciud
            // 
            this.txt_nomb_ciud.Location = new System.Drawing.Point(165, 63);
            this.txt_nomb_ciud.Name = "txt_nomb_ciud";
            this.txt_nomb_ciud.Pp_Campo = null;
            this.txt_nomb_ciud.Pp_MensajeError = null;
            this.txt_nomb_ciud.Pp_Tabla = null;
            this.txt_nomb_ciud.Pp_Validable = false;
            this.txt_nomb_ciud.Size = new System.Drawing.Size(172, 26);
            this.txt_nomb_ciud.TabIndex = 1;
            // 
            // txt_cod_ciud
            // 
            this.txt_cod_ciud.Location = new System.Drawing.Point(165, 31);
            this.txt_cod_ciud.Name = "txt_cod_ciud";
            this.txt_cod_ciud.Pp_Campo = null;
            this.txt_cod_ciud.Pp_MensajeError = null;
            this.txt_cod_ciud.Pp_Tabla = null;
            this.txt_cod_ciud.Pp_Validable = false;
            this.txt_cod_ciud.Size = new System.Drawing.Size(131, 26);
            this.txt_cod_ciud.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Codigo de Provincia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre de Ciudad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de Ciudad";
            // 
            // Frm_ABM_Ciudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 500);
            this.Controls.Add(this.Filtro);
            this.Controls.Add(this.btn_salir_cliente);
            this.Controls.Add(this.btn_refresh_client);
            this.Controls.Add(this.dataGrid_Ciudad);
            this.Controls.Add(this.btn_eliminar_ciud);
            this.Controls.Add(this.btn_modificar_ciud);
            this.Controls.Add(this.btn_crear_cliente);
            this.Name = "Frm_ABM_Ciudad";
            this.Text = "ABM Ciudades";
            this.Load += new System.EventHandler(this.Frm_ABM_Ciudad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Ciudad)).EndInit();
            this.Filtro.ResumeLayout(false);
            this.Filtro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_crear_cliente;
        private System.Windows.Forms.Button btn_modificar_ciud;
        private System.Windows.Forms.Button btn_eliminar_ciud;
        private System.Windows.Forms.DataGridView dataGrid_Ciudad;
        private System.Windows.Forms.Button btn_refresh_client;
        private System.Windows.Forms.Button btn_salir_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox Filtro;
        private System.Windows.Forms.Button btn_consultar;
        private Clases.TextBox01 txt_cod_prov;
        private Clases.TextBox01 txt_nomb_ciud;
        private Clases.TextBox01 txt_cod_ciud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}