
namespace ComunicAr.Formularios.ABM_Clientes
{
    partial class Frm_ABM_Cliente
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
            this.btn_modificar_cliente = new System.Windows.Forms.Button();
            this.btn_eliminar_cliente = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_salir_cliente = new System.Windows.Forms.Button();
            this.btn_refresh_client = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_crear_cliente
            // 
            this.btn_crear_cliente.Location = new System.Drawing.Point(29, 12);
            this.btn_crear_cliente.Name = "btn_crear_cliente";
            this.btn_crear_cliente.Size = new System.Drawing.Size(104, 34);
            this.btn_crear_cliente.TabIndex = 0;
            this.btn_crear_cliente.Text = "Crear";
            this.btn_crear_cliente.UseVisualStyleBackColor = true;
            this.btn_crear_cliente.Click += new System.EventHandler(this.btn_crear_cliente_Click);
            // 
            // btn_modificar_cliente
            // 
            this.btn_modificar_cliente.Location = new System.Drawing.Point(152, 12);
            this.btn_modificar_cliente.Name = "btn_modificar_cliente";
            this.btn_modificar_cliente.Size = new System.Drawing.Size(104, 34);
            this.btn_modificar_cliente.TabIndex = 0;
            this.btn_modificar_cliente.Text = "Modificar";
            this.btn_modificar_cliente.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar_cliente
            // 
            this.btn_eliminar_cliente.Location = new System.Drawing.Point(275, 12);
            this.btn_eliminar_cliente.Name = "btn_eliminar_cliente";
            this.btn_eliminar_cliente.Size = new System.Drawing.Size(104, 34);
            this.btn_eliminar_cliente.TabIndex = 0;
            this.btn_eliminar_cliente.Text = "Eliminar";
            this.btn_eliminar_cliente.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(29, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(693, 252);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_salir_cliente
            // 
            this.btn_salir_cliente.Location = new System.Drawing.Point(618, 327);
            this.btn_salir_cliente.Name = "btn_salir_cliente";
            this.btn_salir_cliente.Size = new System.Drawing.Size(104, 34);
            this.btn_salir_cliente.TabIndex = 0;
            this.btn_salir_cliente.Text = "Salir";
            this.btn_salir_cliente.UseVisualStyleBackColor = true;
            this.btn_salir_cliente.Click += new System.EventHandler(this.btn_salir_cliente_Click);
            // 
            // btn_refresh_client
            // 
            this.btn_refresh_client.Location = new System.Drawing.Point(29, 327);
            this.btn_refresh_client.Name = "btn_refresh_client";
            this.btn_refresh_client.Size = new System.Drawing.Size(104, 34);
            this.btn_refresh_client.TabIndex = 0;
            this.btn_refresh_client.Text = "Refrescar";
            this.btn_refresh_client.UseVisualStyleBackColor = true;
            this.btn_refresh_client.Click += new System.EventHandler(this.btn_refresh_client_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nro";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cod_Barrio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 75;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Calle";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Nro Calle";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 75;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Piso";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            // 
            // Frm_ABM_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 373);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_refresh_client);
            this.Controls.Add(this.btn_salir_cliente);
            this.Controls.Add(this.btn_eliminar_cliente);
            this.Controls.Add(this.btn_modificar_cliente);
            this.Controls.Add(this.btn_crear_cliente);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_ABM_Cliente";
            this.Text = "ABM Cliente";
            this.Load += new System.EventHandler(this.Frm_ABM_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_crear_cliente;
        private System.Windows.Forms.Button btn_modificar_cliente;
        private System.Windows.Forms.Button btn_eliminar_cliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btn_salir_cliente;
        private System.Windows.Forms.Button btn_refresh_client;
    }
}