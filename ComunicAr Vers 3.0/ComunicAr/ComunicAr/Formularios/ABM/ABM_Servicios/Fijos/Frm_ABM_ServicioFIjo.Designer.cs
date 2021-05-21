
namespace ComunicAr.Formularios.ABM_Servicios.Fijos
{
    partial class Frm_ABM_ServicioFijo
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
            this.groupBox_ServicioFijo1 = new System.Windows.Forms.GroupBox();
            this.btn_ServicioFijo_Consultar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_ServicioFijo_descripcion = new System.Windows.Forms.Label();
            this.lbl_ServicioFijo_cod_servicio = new System.Windows.Forms.Label();
            this.dataGridView_ServicioFijo1 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ServicioFijo_Crear = new System.Windows.Forms.Button();
            this.btn_ServicioFijo_Modificar = new System.Windows.Forms.Button();
            this.btn_ServcioFijo_Eliminar = new System.Windows.Forms.Button();
            this.btn_ServicioFijo_Refrescar1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox_ServicioFijo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServicioFijo1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_ServicioFijo1
            // 
            this.groupBox_ServicioFijo1.Controls.Add(this.btn_ServicioFijo_Consultar);
            this.groupBox_ServicioFijo1.Controls.Add(this.textBox2);
            this.groupBox_ServicioFijo1.Controls.Add(this.textBox1);
            this.groupBox_ServicioFijo1.Controls.Add(this.lbl_ServicioFijo_descripcion);
            this.groupBox_ServicioFijo1.Controls.Add(this.lbl_ServicioFijo_cod_servicio);
            this.groupBox_ServicioFijo1.Location = new System.Drawing.Point(12, 12);
            this.groupBox_ServicioFijo1.Name = "groupBox_ServicioFijo1";
            this.groupBox_ServicioFijo1.Size = new System.Drawing.Size(530, 113);
            this.groupBox_ServicioFijo1.TabIndex = 2;
            this.groupBox_ServicioFijo1.TabStop = false;
            this.groupBox_ServicioFijo1.Text = "Filtro";
            // 
            // btn_ServicioFijo_Consultar
            // 
            this.btn_ServicioFijo_Consultar.Location = new System.Drawing.Point(386, 62);
            this.btn_ServicioFijo_Consultar.Name = "btn_ServicioFijo_Consultar";
            this.btn_ServicioFijo_Consultar.Size = new System.Drawing.Size(138, 35);
            this.btn_ServicioFijo_Consultar.TabIndex = 4;
            this.btn_ServicioFijo_Consultar.Text = "Consultar";
            this.btn_ServicioFijo_Consultar.UseVisualStyleBackColor = true;
            this.btn_ServicioFijo_Consultar.Click += new System.EventHandler(this.btn_ServicioFijo_Consultar_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 23);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 23);
            this.textBox1.TabIndex = 2;
            // 
            // lbl_ServicioFijo_descripcion
            // 
            this.lbl_ServicioFijo_descripcion.AutoSize = true;
            this.lbl_ServicioFijo_descripcion.Location = new System.Drawing.Point(54, 72);
            this.lbl_ServicioFijo_descripcion.Name = "lbl_ServicioFijo_descripcion";
            this.lbl_ServicioFijo_descripcion.Size = new System.Drawing.Size(69, 15);
            this.lbl_ServicioFijo_descripcion.TabIndex = 1;
            this.lbl_ServicioFijo_descripcion.Text = "Descripción";
            // 
            // lbl_ServicioFijo_cod_servicio
            // 
            this.lbl_ServicioFijo_cod_servicio.AutoSize = true;
            this.lbl_ServicioFijo_cod_servicio.Location = new System.Drawing.Point(54, 40);
            this.lbl_ServicioFijo_cod_servicio.Name = "lbl_ServicioFijo_cod_servicio";
            this.lbl_ServicioFijo_cod_servicio.Size = new System.Drawing.Size(90, 15);
            this.lbl_ServicioFijo_cod_servicio.TabIndex = 0;
            this.lbl_ServicioFijo_cod_servicio.Text = "Codigo Servicio";
            // 
            // dataGridView_ServicioFijo1
            // 
            this.dataGridView_ServicioFijo1.AllowUserToAddRows = false;
            this.dataGridView_ServicioFijo1.AllowUserToDeleteRows = false;
            this.dataGridView_ServicioFijo1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ServicioFijo1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView_ServicioFijo1.Location = new System.Drawing.Point(24, 186);
            this.dataGridView_ServicioFijo1.Name = "dataGridView_ServicioFijo1";
            this.dataGridView_ServicioFijo1.ReadOnly = true;
            this.dataGridView_ServicioFijo1.Size = new System.Drawing.Size(518, 247);
            this.dataGridView_ServicioFijo1.TabIndex = 1;
            this.dataGridView_ServicioFijo1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ServicioFijo1_CellContentClick);
            // 
            // Column4
            // 
            this.Column4.FillWeight = 300F;
            this.Column4.HeaderText = "tipo_servicio";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            this.Column4.Width = 110;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "cod_servicio";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 97;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "descripcion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 200F;
            this.Column3.HeaderText = "costo_mensual";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // btn_ServicioFijo_Crear
            // 
            this.btn_ServicioFijo_Crear.Location = new System.Drawing.Point(24, 140);
            this.btn_ServicioFijo_Crear.Name = "btn_ServicioFijo_Crear";
            this.btn_ServicioFijo_Crear.Size = new System.Drawing.Size(75, 23);
            this.btn_ServicioFijo_Crear.TabIndex = 3;
            this.btn_ServicioFijo_Crear.Text = "Crear";
            this.btn_ServicioFijo_Crear.UseVisualStyleBackColor = true;
            this.btn_ServicioFijo_Crear.Click += new System.EventHandler(this.btn_ServicioFijo_Crear_Click);
            // 
            // btn_ServicioFijo_Modificar
            // 
            this.btn_ServicioFijo_Modificar.Location = new System.Drawing.Point(132, 140);
            this.btn_ServicioFijo_Modificar.Name = "btn_ServicioFijo_Modificar";
            this.btn_ServicioFijo_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_ServicioFijo_Modificar.TabIndex = 4;
            this.btn_ServicioFijo_Modificar.Text = "Modificar";
            this.btn_ServicioFijo_Modificar.UseVisualStyleBackColor = true;
            this.btn_ServicioFijo_Modificar.Click += new System.EventHandler(this.btn_ServicioFijo_Modificar_Click);
            // 
            // btn_ServcioFijo_Eliminar
            // 
            this.btn_ServcioFijo_Eliminar.Location = new System.Drawing.Point(243, 140);
            this.btn_ServcioFijo_Eliminar.Name = "btn_ServcioFijo_Eliminar";
            this.btn_ServcioFijo_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_ServcioFijo_Eliminar.TabIndex = 5;
            this.btn_ServcioFijo_Eliminar.Text = "Eliminar";
            this.btn_ServcioFijo_Eliminar.UseVisualStyleBackColor = true;
            this.btn_ServcioFijo_Eliminar.Click += new System.EventHandler(this.btn_ServicioFijo_Eliminar);
            // 
            // btn_ServicioFijo_Refrescar1
            // 
            this.btn_ServicioFijo_Refrescar1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ServicioFijo_Refrescar1.Location = new System.Drawing.Point(24, 453);
            this.btn_ServicioFijo_Refrescar1.Name = "btn_ServicioFijo_Refrescar1";
            this.btn_ServicioFijo_Refrescar1.Size = new System.Drawing.Size(75, 23);
            this.btn_ServicioFijo_Refrescar1.TabIndex = 6;
            this.btn_ServicioFijo_Refrescar1.Text = "Refrescar";
            this.btn_ServicioFijo_Refrescar1.UseVisualStyleBackColor = true;
            this.btn_ServicioFijo_Refrescar1.Click += new System.EventHandler(this.btn_ServicioFijo_refrescar1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(467, 453);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btn_ServicioFijo_salir1);
            // 
            // Frm_ABM_ServicioFijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 488);
            this.ControlBox = false;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_ServicioFijo_Refrescar1);
            this.Controls.Add(this.btn_ServcioFijo_Eliminar);
            this.Controls.Add(this.btn_ServicioFijo_Modificar);
            this.Controls.Add(this.btn_ServicioFijo_Crear);
            this.Controls.Add(this.dataGridView_ServicioFijo1);
            this.Controls.Add(this.groupBox_ServicioFijo1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_ABM_ServicioFijo";
            this.Text = "ABM Servicio Fijo";
            this.Load += new System.EventHandler(this.Frm_ABM_ServicioFijo_Load_1);
            this.groupBox_ServicioFijo1.ResumeLayout(false);
            this.groupBox_ServicioFijo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServicioFijo1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_ServicioFijo1;
        private System.Windows.Forms.DataGridView dataGridView_ServicioFijo1;
        private System.Windows.Forms.Button btn_ServicioFijo_Consultar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_ServicioFijo_descripcion;
        private System.Windows.Forms.Label lbl_ServicioFijo_cod_servicio;
        private System.Windows.Forms.Button btn_ServicioFijo_Crear;
        private System.Windows.Forms.Button btn_ServicioFijo_Modificar;
        private System.Windows.Forms.Button btn_ServcioFijo_Eliminar;
        private System.Windows.Forms.Button btn_ServicioFijo_Refrescar1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}