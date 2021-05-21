
namespace ComunicAr.Formularios.ABM_Llamadas
{
    partial class Frm_ABM_Llamadas
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
            this.btn_crear_ABM_llamadas = new System.Windows.Forms.Button();
            this.btn_modificar_ABM_llamadas = new System.Windows.Forms.Button();
            this.btn_eliminar_ABM_llamadas = new System.Windows.Forms.Button();
            this.btn_salir_ABM_llamadas = new System.Windows.Forms.Button();
            this.btn_refresh_ABM_llamadas = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_crear_ABM_llamadas
            // 
            this.btn_crear_ABM_llamadas.Location = new System.Drawing.Point(12, 11);
            this.btn_crear_ABM_llamadas.Name = "btn_crear_ABM_llamadas";
            this.btn_crear_ABM_llamadas.Size = new System.Drawing.Size(104, 34);
            this.btn_crear_ABM_llamadas.TabIndex = 0;
            this.btn_crear_ABM_llamadas.Text = "Crear";
            this.btn_crear_ABM_llamadas.UseVisualStyleBackColor = true;
            this.btn_crear_ABM_llamadas.Click += new System.EventHandler(this.btn_crear_ABM_llamadas_Click);
            // 
            // btn_modificar_ABM_llamadas
            // 
            this.btn_modificar_ABM_llamadas.Location = new System.Drawing.Point(135, 11);
            this.btn_modificar_ABM_llamadas.Name = "btn_modificar_ABM_llamadas";
            this.btn_modificar_ABM_llamadas.Size = new System.Drawing.Size(104, 34);
            this.btn_modificar_ABM_llamadas.TabIndex = 0;
            this.btn_modificar_ABM_llamadas.Text = "Modificar";
            this.btn_modificar_ABM_llamadas.UseVisualStyleBackColor = true;
            this.btn_modificar_ABM_llamadas.Click += new System.EventHandler(this.btn_modificar_ABM_llamadas_Click);
            // 
            // btn_eliminar_ABM_llamadas
            // 
            this.btn_eliminar_ABM_llamadas.Location = new System.Drawing.Point(258, 11);
            this.btn_eliminar_ABM_llamadas.Name = "btn_eliminar_ABM_llamadas";
            this.btn_eliminar_ABM_llamadas.Size = new System.Drawing.Size(104, 34);
            this.btn_eliminar_ABM_llamadas.TabIndex = 0;
            this.btn_eliminar_ABM_llamadas.Text = "Eliminar";
            this.btn_eliminar_ABM_llamadas.UseVisualStyleBackColor = true;
            this.btn_eliminar_ABM_llamadas.Click += new System.EventHandler(this.btn_eliminar_ABM_llamadas_Click);
            // 
            // btn_salir_ABM_llamadas
            // 
            this.btn_salir_ABM_llamadas.Location = new System.Drawing.Point(669, 326);
            this.btn_salir_ABM_llamadas.Name = "btn_salir_ABM_llamadas";
            this.btn_salir_ABM_llamadas.Size = new System.Drawing.Size(104, 34);
            this.btn_salir_ABM_llamadas.TabIndex = 0;
            this.btn_salir_ABM_llamadas.Text = "Salir";
            this.btn_salir_ABM_llamadas.UseVisualStyleBackColor = true;
            this.btn_salir_ABM_llamadas.Click += new System.EventHandler(this.btn_salir_ABM_llamadas_Click);
            // 
            // btn_refresh_ABM_llamadas
            // 
            this.btn_refresh_ABM_llamadas.Location = new System.Drawing.Point(12, 326);
            this.btn_refresh_ABM_llamadas.Name = "btn_refresh_ABM_llamadas";
            this.btn_refresh_ABM_llamadas.Size = new System.Drawing.Size(104, 34);
            this.btn_refresh_ABM_llamadas.TabIndex = 0;
            this.btn_refresh_ABM_llamadas.Text = "Refrescar";
            this.btn_refresh_ABM_llamadas.UseVisualStyleBackColor = true;
            this.btn_refresh_ABM_llamadas.Click += new System.EventHandler(this.btn_refresh_ABM_llamadas_Click);
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
            this.Column6,
            this.identificador});
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(761, 240);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Emisor";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Receptor";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Inicio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Duración";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 75;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tipo Com.";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Banda Horaria";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 75;
            // 
            // identificador
            // 
            this.identificador.HeaderText = "identificador";
            this.identificador.Name = "identificador";
            this.identificador.ReadOnly = true;
            this.identificador.Visible = false;
            // 
            // Frm_ABM_Llamadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 373);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_refresh_ABM_llamadas);
            this.Controls.Add(this.btn_salir_ABM_llamadas);
            this.Controls.Add(this.btn_eliminar_ABM_llamadas);
            this.Controls.Add(this.btn_modificar_ABM_llamadas);
            this.Controls.Add(this.btn_crear_ABM_llamadas);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_ABM_Llamadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Llamadas";
            this.Load += new System.EventHandler(this.Frm_ABM_Llamadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_crear_ABM_llamadas;
        private System.Windows.Forms.Button btn_modificar_ABM_llamadas;
        private System.Windows.Forms.Button btn_eliminar_ABM_llamadas;
        private System.Windows.Forms.Button btn_salir_ABM_llamadas;
        private System.Windows.Forms.Button btn_refresh_ABM_llamadas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificador;
    }
}