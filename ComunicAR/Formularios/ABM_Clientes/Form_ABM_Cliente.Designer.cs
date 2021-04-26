
namespace ComunicAR.Formularios.ABM_Clientes
{
    partial class Form_ABM_Cliente
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
            this.CrearCliente = new System.Windows.Forms.Button();
            this.ModificarCliente = new System.Windows.Forms.Button();
            this.EliminarCliente = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CrearCliente
            // 
            this.CrearCliente.Location = new System.Drawing.Point(12, 12);
            this.CrearCliente.Name = "CrearCliente";
            this.CrearCliente.Size = new System.Drawing.Size(104, 34);
            this.CrearCliente.TabIndex = 0;
            this.CrearCliente.Text = "Crear";
            this.CrearCliente.UseVisualStyleBackColor = true;
            this.CrearCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModificarCliente
            // 
            this.ModificarCliente.Location = new System.Drawing.Point(133, 12);
            this.ModificarCliente.Name = "ModificarCliente";
            this.ModificarCliente.Size = new System.Drawing.Size(104, 34);
            this.ModificarCliente.TabIndex = 1;
            this.ModificarCliente.Text = "Modificar";
            this.ModificarCliente.UseVisualStyleBackColor = true;
            // 
            // EliminarCliente
            // 
            this.EliminarCliente.Location = new System.Drawing.Point(255, 12);
            this.EliminarCliente.Name = "EliminarCliente";
            this.EliminarCliente.Size = new System.Drawing.Size(104, 34);
            this.EliminarCliente.TabIndex = 2;
            this.EliminarCliente.Text = "Eliminar";
            this.EliminarCliente.UseVisualStyleBackColor = true;
            this.EliminarCliente.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(545, 269);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nro";
            this.Column1.Name = "Column1";
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cod_Barrio";
            this.Column3.Name = "Column3";
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Calle";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Nro Calle";
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Piso";
            this.Column6.Name = "Column6";
            this.Column6.Width = 50;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(465, 361);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 34);
            this.button4.TabIndex = 4;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form_ABM_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 407);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EliminarCliente);
            this.Controls.Add(this.ModificarCliente);
            this.Controls.Add(this.CrearCliente);
            this.Name = "Form_ABM_Cliente";
            this.Text = "Form_ABM_Cliente";
            this.Load += new System.EventHandler(this.Form_ABM_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CrearCliente;
        private System.Windows.Forms.Button ModificarCliente;
        private System.Windows.Forms.Button EliminarCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button button4;
    }
}