
namespace ComunicAr.Formularios.ABM_Provincia
{
    partial class Frm_ABM_Provincia
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
            this.btn_crear_provincia = new System.Windows.Forms.Button();
            this.btn_modificar_provincia = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_refrescar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.dataGrid_Provincia = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.txt_filtro_nomb = new ComunicAr.Clases.TextBox01();
            this.txt_filtro_cod = new ComunicAr.Clases.TextBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Provincia)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_crear_provincia
            // 
            this.btn_crear_provincia.Location = new System.Drawing.Point(8, 81);
            this.btn_crear_provincia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_crear_provincia.Name = "btn_crear_provincia";
            this.btn_crear_provincia.Size = new System.Drawing.Size(65, 23);
            this.btn_crear_provincia.TabIndex = 0;
            this.btn_crear_provincia.Text = "Crear";
            this.btn_crear_provincia.UseVisualStyleBackColor = true;
            this.btn_crear_provincia.Click += new System.EventHandler(this.btn_crear_provincia_Click);
            // 
            // btn_modificar_provincia
            // 
            this.btn_modificar_provincia.Location = new System.Drawing.Point(113, 81);
            this.btn_modificar_provincia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_modificar_provincia.Name = "btn_modificar_provincia";
            this.btn_modificar_provincia.Size = new System.Drawing.Size(65, 23);
            this.btn_modificar_provincia.TabIndex = 0;
            this.btn_modificar_provincia.Text = "Modificar";
            this.btn_modificar_provincia.UseVisualStyleBackColor = true;
            this.btn_modificar_provincia.Click += new System.EventHandler(this.btn_modificar_provinciaClick);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(230, 81);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(65, 23);
            this.btn_eliminar.TabIndex = 0;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.Location = new System.Drawing.Point(8, 276);
            this.btn_refrescar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Size = new System.Drawing.Size(65, 23);
            this.btn_refrescar.TabIndex = 0;
            this.btn_refrescar.Text = "Refrescar";
            this.btn_refrescar.UseVisualStyleBackColor = true;
            this.btn_refrescar.Click += new System.EventHandler(this.btn_refrescar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(230, 276);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(65, 23);
            this.btn_salir.TabIndex = 0;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // dataGrid_Provincia
            // 
            this.dataGrid_Provincia.AllowUserToAddRows = false;
            this.dataGrid_Provincia.AllowUserToDeleteRows = false;
            this.dataGrid_Provincia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Provincia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGrid_Provincia.Location = new System.Drawing.Point(8, 108);
            this.dataGrid_Provincia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGrid_Provincia.Name = "dataGrid_Provincia";
            this.dataGrid_Provincia.ReadOnly = true;
            this.dataGrid_Provincia.RowHeadersWidth = 62;
            this.dataGrid_Provincia.Size = new System.Drawing.Size(287, 164);
            this.dataGrid_Provincia.TabIndex = 5;
            this.dataGrid_Provincia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Provincia_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cod_Prov";
            this.Column1.MinimumWidth = 15;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre_Prov";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 165;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_filtrar);
            this.groupBox1.Controls.Add(this.txt_filtro_nomb);
            this.groupBox1.Controls.Add(this.txt_filtro_cod);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(287, 69);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Location = new System.Drawing.Point(228, 38);
            this.btn_filtrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(55, 23);
            this.btn_filtrar.TabIndex = 8;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // txt_filtro_nomb
            // 
            this.txt_filtro_nomb.Location = new System.Drawing.Point(114, 41);
            this.txt_filtro_nomb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_filtro_nomb.Name = "txt_filtro_nomb";
            this.txt_filtro_nomb.Pp_Campo = null;
            this.txt_filtro_nomb.Pp_MensajeError = null;
            this.txt_filtro_nomb.Pp_Tabla = null;
            this.txt_filtro_nomb.Pp_Validable = false;
            this.txt_filtro_nomb.Size = new System.Drawing.Size(111, 20);
            this.txt_filtro_nomb.TabIndex = 7;
            // 
            // txt_filtro_cod
            // 
            this.txt_filtro_cod.Location = new System.Drawing.Point(114, 20);
            this.txt_filtro_cod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_filtro_cod.Name = "txt_filtro_cod";
            this.txt_filtro_cod.Pp_Campo = null;
            this.txt_filtro_cod.Pp_MensajeError = null;
            this.txt_filtro_cod.Pp_Tabla = null;
            this.txt_filtro_cod.Pp_Validable = false;
            this.txt_filtro_cod.Size = new System.Drawing.Size(110, 20);
            this.txt_filtro_cod.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Codigo de Provincia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre de Provincia";
            // 
            // Frm_ABM_Provincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 304);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGrid_Provincia);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_refrescar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar_provincia);
            this.Controls.Add(this.btn_crear_provincia);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_ABM_Provincia";
            this.Text = "ABM Provincia";
            this.Load += new System.EventHandler(this.Frm_ABM_Provincia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Provincia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_crear_provincia;
        private System.Windows.Forms.Button btn_modificar_provincia;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_refrescar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridView dataGrid_Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_filtrar;
        private Clases.TextBox01 txt_filtro_nomb;
        private Clases.TextBox01 txt_filtro_cod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}