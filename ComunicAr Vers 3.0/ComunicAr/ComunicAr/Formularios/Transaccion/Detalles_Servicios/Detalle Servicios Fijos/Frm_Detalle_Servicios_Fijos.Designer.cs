
namespace ComunicAr.Formularios.Transaccion.Detalles_Servicios.Detalle_Servicios_Fijos
{
    partial class Frm_Detalle_Servicios_Fijos
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grid_Serv_Fijos = new System.Windows.Forms.DataGridView();
            this.descuento_fijo = new System.Windows.Forms.Button();
            this.cod_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_mensual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_ID_SFijos = new ComunicAr.Clases.TextBox01();
            this.Txt_NroFac_SFijos = new ComunicAr.Clases.TextBox01();
            this.Txt_Nombre_SFijos = new ComunicAr.Clases.TextBox01();
            this.txt_subtotla_SF = new ComunicAr.Clases.TextBox01();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Serv_Fijos)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(755, 411);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(603, 411);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(142, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Generar Detalle";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_ID_SFijos);
            this.groupBox1.Controls.Add(this.Txt_NroFac_SFijos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txt_Nombre_SFijos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 67);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nro Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(745, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Subtotal";
            // 
            // grid_Serv_Fijos
            // 
            this.grid_Serv_Fijos.AllowUserToAddRows = false;
            this.grid_Serv_Fijos.AllowUserToDeleteRows = false;
            this.grid_Serv_Fijos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Serv_Fijos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_servicio,
            this.tipo_servicio,
            this.descripcion,
            this.costo_mensual,
            this.Cuota,
            this.descuento,
            this.costo_final});
            this.grid_Serv_Fijos.Location = new System.Drawing.Point(25, 90);
            this.grid_Serv_Fijos.Name = "grid_Serv_Fijos";
            this.grid_Serv_Fijos.ReadOnly = true;
            this.grid_Serv_Fijos.Size = new System.Drawing.Size(872, 266);
            this.grid_Serv_Fijos.TabIndex = 8;
            this.grid_Serv_Fijos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Serv_Fijos_CellContentClick);
            // 
            // descuento_fijo
            // 
            this.descuento_fijo.Location = new System.Drawing.Point(216, 411);
            this.descuento_fijo.Name = "descuento_fijo";
            this.descuento_fijo.Size = new System.Drawing.Size(75, 23);
            this.descuento_fijo.TabIndex = 16;
            this.descuento_fijo.Text = "Descuento";
            this.descuento_fijo.UseVisualStyleBackColor = true;
            this.descuento_fijo.Click += new System.EventHandler(this.descuento_fijo_Click);
            // 
            // cod_servicio
            // 
            this.cod_servicio.HeaderText = "Codigo";
            this.cod_servicio.Name = "cod_servicio";
            this.cod_servicio.ReadOnly = true;
            // 
            // tipo_servicio
            // 
            this.tipo_servicio.HeaderText = "Tipo de Servicio";
            this.tipo_servicio.Name = "tipo_servicio";
            this.tipo_servicio.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 150;
            // 
            // costo_mensual
            // 
            this.costo_mensual.HeaderText = "Costo Mensual";
            this.costo_mensual.Name = "costo_mensual";
            this.costo_mensual.ReadOnly = true;
            this.costo_mensual.Width = 150;
            // 
            // Cuota
            // 
            this.Cuota.HeaderText = "Nro de Cuota";
            this.Cuota.Name = "Cuota";
            this.Cuota.ReadOnly = true;
            // 
            // descuento
            // 
            this.descuento.HeaderText = "Descuento";
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            // 
            // costo_final
            // 
            this.costo_final.HeaderText = "Costo Final";
            this.costo_final.Name = "costo_final";
            this.costo_final.ReadOnly = true;
            // 
            // Txt_ID_SFijos
            // 
            this.Txt_ID_SFijos.Enabled = false;
            this.Txt_ID_SFijos.Location = new System.Drawing.Point(105, 23);
            this.Txt_ID_SFijos.Name = "Txt_ID_SFijos";
            this.Txt_ID_SFijos.Pp_Campo = null;
            this.Txt_ID_SFijos.Pp_MensajeError = null;
            this.Txt_ID_SFijos.Pp_Tabla = null;
            this.Txt_ID_SFijos.Pp_Validable = false;
            this.Txt_ID_SFijos.Size = new System.Drawing.Size(95, 20);
            this.Txt_ID_SFijos.TabIndex = 1;
            // 
            // Txt_NroFac_SFijos
            // 
            this.Txt_NroFac_SFijos.Enabled = false;
            this.Txt_NroFac_SFijos.Location = new System.Drawing.Point(578, 22);
            this.Txt_NroFac_SFijos.Name = "Txt_NroFac_SFijos";
            this.Txt_NroFac_SFijos.Pp_Campo = null;
            this.Txt_NroFac_SFijos.Pp_MensajeError = null;
            this.Txt_NroFac_SFijos.Pp_Tabla = null;
            this.Txt_NroFac_SFijos.Pp_Validable = false;
            this.Txt_NroFac_SFijos.Size = new System.Drawing.Size(165, 20);
            this.Txt_NroFac_SFijos.TabIndex = 1;
            // 
            // Txt_Nombre_SFijos
            // 
            this.Txt_Nombre_SFijos.Enabled = false;
            this.Txt_Nombre_SFijos.Location = new System.Drawing.Point(317, 22);
            this.Txt_Nombre_SFijos.Name = "Txt_Nombre_SFijos";
            this.Txt_Nombre_SFijos.Pp_Campo = null;
            this.Txt_Nombre_SFijos.Pp_MensajeError = null;
            this.Txt_Nombre_SFijos.Pp_Tabla = null;
            this.Txt_Nombre_SFijos.Pp_Validable = false;
            this.Txt_Nombre_SFijos.Size = new System.Drawing.Size(165, 20);
            this.Txt_Nombre_SFijos.TabIndex = 1;
            // 
            // txt_subtotla_SF
            // 
            this.txt_subtotla_SF.Enabled = false;
            this.txt_subtotla_SF.Location = new System.Drawing.Point(797, 362);
            this.txt_subtotla_SF.Name = "txt_subtotla_SF";
            this.txt_subtotla_SF.Pp_Campo = null;
            this.txt_subtotla_SF.Pp_MensajeError = null;
            this.txt_subtotla_SF.Pp_Tabla = null;
            this.txt_subtotla_SF.Pp_Validable = false;
            this.txt_subtotla_SF.Size = new System.Drawing.Size(100, 20);
            this.txt_subtotla_SF.TabIndex = 10;
            // 
            // Frm_Detalle_Servicios_Fijos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 450);
            this.Controls.Add(this.descuento_fijo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_subtotla_SF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grid_Serv_Fijos);
            this.Name = "Frm_Detalle_Servicios_Fijos";
            this.Text = "Frm_Detalle_Servicios_Fijos";
            this.Load += new System.EventHandler(this.Frm_Detalle_Servicios_Fijos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Serv_Fijos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
        private Clases.TextBox01 Txt_ID_SFijos;
        private Clases.TextBox01 Txt_NroFac_SFijos;
        private System.Windows.Forms.Label label3;
        private Clases.TextBox01 Txt_Nombre_SFijos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Clases.TextBox01 txt_subtotla_SF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grid_Serv_Fijos;
        private System.Windows.Forms.Button descuento_fijo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_mensual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_final;
    }
}