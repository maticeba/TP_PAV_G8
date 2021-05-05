
namespace ComunicAr.Formularios.Barrio
{
    partial class Frm_ABM_Barrio
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
            this.GridBarrio = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Consulta = new System.Windows.Forms.Button();
            this.txt_filtro_cod_servicio = new ComunicAr.Clases.TextBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.bttn_baja_barrio = new System.Windows.Forms.Button();
            this.bttn_alta_barrio = new System.Windows.Forms.Button();
            this.bttn_modificar_barrio = new System.Windows.Forms.Button();
            this.bttn_salir = new System.Windows.Forms.Button();
            this.bttn_resfrecar = new System.Windows.Forms.Button();
            this.cod_barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridBarrio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridBarrio
            // 
            this.GridBarrio.AllowUserToAddRows = false;
            this.GridBarrio.AllowUserToDeleteRows = false;
            this.GridBarrio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridBarrio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_barrio,
            this.nombre_barrio,
            this.cod_ciudad});
            this.GridBarrio.Location = new System.Drawing.Point(61, 145);
            this.GridBarrio.Name = "GridBarrio";
            this.GridBarrio.ReadOnly = true;
            this.GridBarrio.Size = new System.Drawing.Size(342, 262);
            this.GridBarrio.TabIndex = 4;
            this.GridBarrio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridBarrio_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Consulta);
            this.groupBox1.Controls.Add(this.txt_filtro_cod_servicio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 77);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btn_Consulta
            // 
            this.btn_Consulta.Location = new System.Drawing.Point(315, 32);
            this.btn_Consulta.Name = "btn_Consulta";
            this.btn_Consulta.Size = new System.Drawing.Size(75, 23);
            this.btn_Consulta.TabIndex = 3;
            this.btn_Consulta.Text = "Consulta";
            this.btn_Consulta.UseVisualStyleBackColor = true;
            this.btn_Consulta.Click += new System.EventHandler(this.btn_Consulta_Click);
            // 
            // txt_filtro_cod_servicio
            // 
            this.txt_filtro_cod_servicio.Location = new System.Drawing.Point(110, 34);
            this.txt_filtro_cod_servicio.Name = "txt_filtro_cod_servicio";
            this.txt_filtro_cod_servicio.Pp_Campo = null;
            this.txt_filtro_cod_servicio.Pp_MensajeError = null;
            this.txt_filtro_cod_servicio.Pp_Tabla = null;
            this.txt_filtro_cod_servicio.Pp_Validable = false;
            this.txt_filtro_cod_servicio.Size = new System.Drawing.Size(183, 20);
            this.txt_filtro_cod_servicio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Barrio";
            // 
            // bttn_baja_barrio
            // 
            this.bttn_baja_barrio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttn_baja_barrio.Location = new System.Drawing.Point(221, 109);
            this.bttn_baja_barrio.Name = "bttn_baja_barrio";
            this.bttn_baja_barrio.Size = new System.Drawing.Size(92, 29);
            this.bttn_baja_barrio.TabIndex = 14;
            this.bttn_baja_barrio.Text = "Baja";
            this.bttn_baja_barrio.UseVisualStyleBackColor = true;
            this.bttn_baja_barrio.Click += new System.EventHandler(this.bttn_baja_barrio_Click);
            // 
            // bttn_alta_barrio
            // 
            this.bttn_alta_barrio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttn_alta_barrio.Location = new System.Drawing.Point(25, 109);
            this.bttn_alta_barrio.Name = "bttn_alta_barrio";
            this.bttn_alta_barrio.Size = new System.Drawing.Size(92, 29);
            this.bttn_alta_barrio.TabIndex = 13;
            this.bttn_alta_barrio.Text = "Alta";
            this.bttn_alta_barrio.UseVisualStyleBackColor = true;
            this.bttn_alta_barrio.Click += new System.EventHandler(this.bttn_alta_barrio_Click);
            // 
            // bttn_modificar_barrio
            // 
            this.bttn_modificar_barrio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttn_modificar_barrio.Location = new System.Drawing.Point(123, 109);
            this.bttn_modificar_barrio.Name = "bttn_modificar_barrio";
            this.bttn_modificar_barrio.Size = new System.Drawing.Size(92, 29);
            this.bttn_modificar_barrio.TabIndex = 12;
            this.bttn_modificar_barrio.Text = "Modificar";
            this.bttn_modificar_barrio.UseVisualStyleBackColor = true;
            this.bttn_modificar_barrio.Click += new System.EventHandler(this.bttn_modificar_barrio_Click);
            // 
            // bttn_salir
            // 
            this.bttn_salir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttn_salir.Location = new System.Drawing.Point(362, 413);
            this.bttn_salir.Name = "bttn_salir";
            this.bttn_salir.Size = new System.Drawing.Size(92, 29);
            this.bttn_salir.TabIndex = 15;
            this.bttn_salir.Text = "Salir";
            this.bttn_salir.UseVisualStyleBackColor = true;
            this.bttn_salir.Click += new System.EventHandler(this.bttn_salir_Click);
            // 
            // bttn_resfrecar
            // 
            this.bttn_resfrecar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttn_resfrecar.Location = new System.Drawing.Point(12, 413);
            this.bttn_resfrecar.Name = "bttn_resfrecar";
            this.bttn_resfrecar.Size = new System.Drawing.Size(92, 29);
            this.bttn_resfrecar.TabIndex = 16;
            this.bttn_resfrecar.Text = "Resfrescar";
            this.bttn_resfrecar.UseVisualStyleBackColor = true;
            this.bttn_resfrecar.Click += new System.EventHandler(this.bttn_resfrecar_Click);
            // 
            // cod_barrio
            // 
            this.cod_barrio.HeaderText = "Codigo Barrio";
            this.cod_barrio.Name = "cod_barrio";
            this.cod_barrio.ReadOnly = true;
            // 
            // nombre_barrio
            // 
            this.nombre_barrio.HeaderText = "Nombre Barrio";
            this.nombre_barrio.Name = "nombre_barrio";
            this.nombre_barrio.ReadOnly = true;
            // 
            // cod_ciudad
            // 
            this.cod_ciudad.HeaderText = "Codigo Ciudad";
            this.cod_ciudad.Name = "cod_ciudad";
            this.cod_ciudad.ReadOnly = true;
            // 
            // Frm_ABM_Barrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.bttn_resfrecar);
            this.Controls.Add(this.bttn_salir);
            this.Controls.Add(this.bttn_baja_barrio);
            this.Controls.Add(this.bttn_alta_barrio);
            this.Controls.Add(this.bttn_modificar_barrio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GridBarrio);
            this.Name = "Frm_ABM_Barrio";
            this.Text = "Frm_ABM_Barrio";
            this.Load += new System.EventHandler(this.Frm_ABM_Barrio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridBarrio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridBarrio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Consulta;
        private Clases.TextBox01 txt_filtro_cod_servicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttn_baja_barrio;
        private System.Windows.Forms.Button bttn_alta_barrio;
        private System.Windows.Forms.Button bttn_modificar_barrio;
        private System.Windows.Forms.Button bttn_salir;
        private System.Windows.Forms.Button bttn_resfrecar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_ciudad;
    }
}