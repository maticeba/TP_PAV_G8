
namespace ComunicAr.Transaccion.Emision_de_Factura
{
    partial class Frm_Detalle_Llamada
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_ID_DLlamadas = new ComunicAr.Clases.TextBox01();
            this.Txt_NroFac_DLlamadas = new ComunicAr.Clases.TextBox01();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Nombre_DLlamadas = new ComunicAr.Clases.TextBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_subtotal = new ComunicAr.Clases.TextBox01();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(743, 266);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nro. Emisor";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nro. Receptor";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fecha";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Duración";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Costo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(598, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Subtotal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_ID_DLlamadas);
            this.groupBox1.Controls.Add(this.Txt_NroFac_DLlamadas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txt_Nombre_DLlamadas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 67);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Clientes";
            // 
            // Txt_ID_DLlamadas
            // 
            this.Txt_ID_DLlamadas.Enabled = false;
            this.Txt_ID_DLlamadas.Location = new System.Drawing.Point(105, 23);
            this.Txt_ID_DLlamadas.Name = "Txt_ID_DLlamadas";
            this.Txt_ID_DLlamadas.Pp_Campo = null;
            this.Txt_ID_DLlamadas.Pp_MensajeError = null;
            this.Txt_ID_DLlamadas.Pp_Tabla = null;
            this.Txt_ID_DLlamadas.Pp_Validable = false;
            this.Txt_ID_DLlamadas.Size = new System.Drawing.Size(95, 23);
            this.Txt_ID_DLlamadas.TabIndex = 1;
            // 
            // Txt_NroFac_DLlamadas
            // 
            this.Txt_NroFac_DLlamadas.Enabled = false;
            this.Txt_NroFac_DLlamadas.Location = new System.Drawing.Point(578, 22);
            this.Txt_NroFac_DLlamadas.Name = "Txt_NroFac_DLlamadas";
            this.Txt_NroFac_DLlamadas.Pp_Campo = null;
            this.Txt_NroFac_DLlamadas.Pp_MensajeError = null;
            this.Txt_NroFac_DLlamadas.Pp_Tabla = null;
            this.Txt_NroFac_DLlamadas.Pp_Validable = false;
            this.Txt_NroFac_DLlamadas.Size = new System.Drawing.Size(165, 23);
            this.Txt_NroFac_DLlamadas.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nro Factura";
            // 
            // Txt_Nombre_DLlamadas
            // 
            this.Txt_Nombre_DLlamadas.Enabled = false;
            this.Txt_Nombre_DLlamadas.Location = new System.Drawing.Point(317, 22);
            this.Txt_Nombre_DLlamadas.Name = "Txt_Nombre_DLlamadas";
            this.Txt_Nombre_DLlamadas.Pp_Campo = null;
            this.Txt_Nombre_DLlamadas.Pp_MensajeError = null;
            this.Txt_Nombre_DLlamadas.Pp_Tabla = null;
            this.Txt_Nombre_DLlamadas.Pp_Validable = false;
            this.Txt_Nombre_DLlamadas.Size = new System.Drawing.Size(165, 23);
            this.Txt_Nombre_DLlamadas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Cliente";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(450, 410);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(142, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Generar Detalle";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(613, 410);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Enabled = false;
            this.txt_subtotal.Location = new System.Drawing.Point(655, 361);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Pp_Campo = null;
            this.txt_subtotal.Pp_MensajeError = null;
            this.txt_subtotal.Pp_Tabla = null;
            this.txt_subtotal.Pp_Validable = false;
            this.txt_subtotal.Size = new System.Drawing.Size(100, 23);
            this.txt_subtotal.TabIndex = 2;
            // 
            // Frm_Detalle_Llamada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 441);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_subtotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Detalle_Llamada";
            this.Text = "Frm_EmisionFactura";
            this.Load += new System.EventHandler(this.Frm_Detalle_Llamada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private Clases.TextBox01 txt_subtotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Clases.TextBox01 Txt_ID_DLlamadas;
        private Clases.TextBox01 Txt_NroFac_DLlamadas;
        private System.Windows.Forms.Label label3;
        private Clases.TextBox01 Txt_Nombre_DLlamadas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}