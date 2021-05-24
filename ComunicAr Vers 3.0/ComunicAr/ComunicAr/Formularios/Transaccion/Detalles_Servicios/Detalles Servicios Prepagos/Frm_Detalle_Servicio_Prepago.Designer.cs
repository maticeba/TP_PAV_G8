
namespace ComunicAr.Formularios.Transaccion.Detalles_Servicios.Detalles_Servicios_Prepagos
{
    partial class Frm_Detalle_Servicio_Prepago
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_ID_Prepago = new ComunicAr.Clases.TextBox01();
            this.Txt_NroFac_Prepago = new ComunicAr.Clases.TextBox01();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Nombre_Prepago = new ComunicAr.Clases.TextBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_Serv_Prepago = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txt_subtotal_prepago = new ComunicAr.Clases.TextBox01();
            this.label4 = new System.Windows.Forms.Label();
            this.cod_detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_servicio_contratado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_mensual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Serv_Prepago)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_ID_Prepago);
            this.groupBox1.Controls.Add(this.Txt_NroFac_Prepago);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txt_Nombre_Prepago);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 67);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Clientes";
            // 
            // Txt_ID_Prepago
            // 
            this.Txt_ID_Prepago.Enabled = false;
            this.Txt_ID_Prepago.Location = new System.Drawing.Point(105, 23);
            this.Txt_ID_Prepago.Name = "Txt_ID_Prepago";
            this.Txt_ID_Prepago.Pp_Campo = null;
            this.Txt_ID_Prepago.Pp_MensajeError = null;
            this.Txt_ID_Prepago.Pp_Tabla = null;
            this.Txt_ID_Prepago.Pp_Validable = false;
            this.Txt_ID_Prepago.Size = new System.Drawing.Size(95, 20);
            this.Txt_ID_Prepago.TabIndex = 1;
            // 
            // Txt_NroFac_Prepago
            // 
            this.Txt_NroFac_Prepago.Enabled = false;
            this.Txt_NroFac_Prepago.Location = new System.Drawing.Point(578, 22);
            this.Txt_NroFac_Prepago.Name = "Txt_NroFac_Prepago";
            this.Txt_NroFac_Prepago.Pp_Campo = null;
            this.Txt_NroFac_Prepago.Pp_MensajeError = null;
            this.Txt_NroFac_Prepago.Pp_Tabla = null;
            this.Txt_NroFac_Prepago.Pp_Validable = false;
            this.Txt_NroFac_Prepago.Size = new System.Drawing.Size(165, 20);
            this.Txt_NroFac_Prepago.TabIndex = 1;
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
            // Txt_Nombre_Prepago
            // 
            this.Txt_Nombre_Prepago.Enabled = false;
            this.Txt_Nombre_Prepago.Location = new System.Drawing.Point(317, 22);
            this.Txt_Nombre_Prepago.Name = "Txt_Nombre_Prepago";
            this.Txt_Nombre_Prepago.Pp_Campo = null;
            this.Txt_Nombre_Prepago.Pp_MensajeError = null;
            this.Txt_Nombre_Prepago.Pp_Tabla = null;
            this.Txt_Nombre_Prepago.Pp_Validable = false;
            this.Txt_Nombre_Prepago.Size = new System.Drawing.Size(165, 20);
            this.Txt_Nombre_Prepago.TabIndex = 1;
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
            // grid_Serv_Prepago
            // 
            this.grid_Serv_Prepago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Serv_Prepago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_detalle,
            this.codigo_servicio_contratado,
            this.descripcion,
            this.costo_mensual,
            this.Cuota});
            this.grid_Serv_Prepago.Location = new System.Drawing.Point(12, 85);
            this.grid_Serv_Prepago.Name = "grid_Serv_Prepago";
            this.grid_Serv_Prepago.Size = new System.Drawing.Size(751, 273);
            this.grid_Serv_Prepago.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(613, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(450, 415);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(142, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "Generar Detalle";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txt_subtotal_prepago
            // 
            this.txt_subtotal_prepago.Enabled = false;
            this.txt_subtotal_prepago.Location = new System.Drawing.Point(672, 373);
            this.txt_subtotal_prepago.Name = "txt_subtotal_prepago";
            this.txt_subtotal_prepago.Pp_Campo = null;
            this.txt_subtotal_prepago.Pp_MensajeError = null;
            this.txt_subtotal_prepago.Pp_Tabla = null;
            this.txt_subtotal_prepago.Pp_Validable = false;
            this.txt_subtotal_prepago.Size = new System.Drawing.Size(100, 20);
            this.txt_subtotal_prepago.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(620, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Subtotal";
            // 
            // cod_detalle
            // 
            this.cod_detalle.HeaderText = "Codigo";
            this.cod_detalle.Name = "cod_detalle";
            // 
            // codigo_servicio_contratado
            // 
            this.codigo_servicio_contratado.HeaderText = "Codigo de Servicio";
            this.codigo_servicio_contratado.Name = "codigo_servicio_contratado";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 150;
            // 
            // costo_mensual
            // 
            this.costo_mensual.HeaderText = "Costo Mensual";
            this.costo_mensual.Name = "costo_mensual";
            this.costo_mensual.Width = 150;
            // 
            // Cuota
            // 
            this.Cuota.HeaderText = "Cuota";
            this.Cuota.Name = "Cuota";
            // 
            // Frm_Detalle_Servicio_Prepago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.txt_subtotal_prepago);
            this.Controls.Add(this.grid_Serv_Prepago);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Detalle_Servicio_Prepago";
            this.Text = "Frm_Detalle_Servicio_Prepago";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Serv_Prepago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Clases.TextBox01 Txt_ID_Prepago;
        private Clases.TextBox01 Txt_NroFac_Prepago;
        private System.Windows.Forms.Label label3;
        private Clases.TextBox01 Txt_Nombre_Prepago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_Serv_Prepago;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private Clases.TextBox01 txt_subtotal_prepago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_servicio_contratado;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_mensual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuota;
    }
}