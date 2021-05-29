
namespace ComunicAr.Formularios.Transaccion.Detalle_Dsipositivos
{
    partial class Frm_Detalle_VtaDispo
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
            this.gb_DetVtaDisp = new System.Windows.Forms.GroupBox();
            this.lbl_DetVtaDisp_IdCliente = new System.Windows.Forms.Label();
            this.lbl_DetVtaDisp_NombreCliente = new System.Windows.Forms.Label();
            this.lbl_DetVtaDisp_NroFac = new System.Windows.Forms.Label();
            this.dataGridView_DetVtaDisp = new System.Windows.Forms.DataGridView();
            this.IdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Descuento_VtaDispo = new System.Windows.Forms.Button();
            this.btn_DetVtaDisp_Generar = new System.Windows.Forms.Button();
            this.btn_DetVtaDispo_Cancelar = new System.Windows.Forms.Button();
            this.lbl_SubTotal = new System.Windows.Forms.Label();
            this.txt_DetVtaDispo_Subtotal = new ComunicAr.Clases.TextBox01();
            this.txt_DetVtaDisp_NroFactura = new ComunicAr.Clases.TextBox01();
            this.txt_DetVtaDisp_IdCliente = new ComunicAr.Clases.TextBox01();
            this.txt_DetVtaDisp_NombCliente = new ComunicAr.Clases.TextBox01();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_DetVtaDisp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DetVtaDisp)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_DetVtaDisp
            // 
            this.gb_DetVtaDisp.Controls.Add(this.lbl_DetVtaDisp_IdCliente);
            this.gb_DetVtaDisp.Controls.Add(this.lbl_DetVtaDisp_NombreCliente);
            this.gb_DetVtaDisp.Controls.Add(this.lbl_DetVtaDisp_NroFac);
            this.gb_DetVtaDisp.Controls.Add(this.txt_DetVtaDisp_NroFactura);
            this.gb_DetVtaDisp.Controls.Add(this.txt_DetVtaDisp_IdCliente);
            this.gb_DetVtaDisp.Controls.Add(this.txt_DetVtaDisp_NombCliente);
            this.gb_DetVtaDisp.Location = new System.Drawing.Point(0, 1);
            this.gb_DetVtaDisp.Name = "gb_DetVtaDisp";
            this.gb_DetVtaDisp.Size = new System.Drawing.Size(895, 110);
            this.gb_DetVtaDisp.TabIndex = 0;
            this.gb_DetVtaDisp.TabStop = false;
            this.gb_DetVtaDisp.Text = "Datos del Cliente";
            // 
            // lbl_DetVtaDisp_IdCliente
            // 
            this.lbl_DetVtaDisp_IdCliente.AutoSize = true;
            this.lbl_DetVtaDisp_IdCliente.Location = new System.Drawing.Point(27, 57);
            this.lbl_DetVtaDisp_IdCliente.Name = "lbl_DetVtaDisp_IdCliente";
            this.lbl_DetVtaDisp_IdCliente.Size = new System.Drawing.Size(51, 13);
            this.lbl_DetVtaDisp_IdCliente.TabIndex = 4;
            this.lbl_DetVtaDisp_IdCliente.Text = "Id Cliente";
            // 
            // lbl_DetVtaDisp_NombreCliente
            // 
            this.lbl_DetVtaDisp_NombreCliente.AutoEllipsis = true;
            this.lbl_DetVtaDisp_NombreCliente.AutoSize = true;
            this.lbl_DetVtaDisp_NombreCliente.Location = new System.Drawing.Point(240, 57);
            this.lbl_DetVtaDisp_NombreCliente.Name = "lbl_DetVtaDisp_NombreCliente";
            this.lbl_DetVtaDisp_NombreCliente.Size = new System.Drawing.Size(79, 13);
            this.lbl_DetVtaDisp_NombreCliente.TabIndex = 5;
            this.lbl_DetVtaDisp_NombreCliente.Text = "Nombre Cliente";
            // 
            // lbl_DetVtaDisp_NroFac
            // 
            this.lbl_DetVtaDisp_NroFac.AutoSize = true;
            this.lbl_DetVtaDisp_NroFac.Location = new System.Drawing.Point(513, 57);
            this.lbl_DetVtaDisp_NroFac.Name = "lbl_DetVtaDisp_NroFac";
            this.lbl_DetVtaDisp_NroFac.Size = new System.Drawing.Size(63, 13);
            this.lbl_DetVtaDisp_NroFac.TabIndex = 6;
            this.lbl_DetVtaDisp_NroFac.Text = "Nro Factura";
            // 
            // dataGridView_DetVtaDisp
            // 
            this.dataGridView_DetVtaDisp.AllowUserToAddRows = false;
            this.dataGridView_DetVtaDisp.AllowUserToDeleteRows = false;
            this.dataGridView_DetVtaDisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DetVtaDisp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVenta,
            this.FechaVta,
            this.Marca,
            this.Modelo,
            this.NroCuota,
            this.Precio,
            this.Descuento,
            this.PrecioDescuento,
            this.Column1});
            this.dataGridView_DetVtaDisp.Location = new System.Drawing.Point(12, 128);
            this.dataGridView_DetVtaDisp.Name = "dataGridView_DetVtaDisp";
            this.dataGridView_DetVtaDisp.ReadOnly = true;
            this.dataGridView_DetVtaDisp.Size = new System.Drawing.Size(883, 199);
            this.dataGridView_DetVtaDisp.TabIndex = 3;
            this.dataGridView_DetVtaDisp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DetVtaDisp_CellContentClick);
            // 
            // IdVenta
            // 
            this.IdVenta.HeaderText = "Id Venta";
            this.IdVenta.Name = "IdVenta";
            this.IdVenta.ReadOnly = true;
            this.IdVenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FechaVta
            // 
            this.FechaVta.HeaderText = "Fecha de Venta";
            this.FechaVta.Name = "FechaVta";
            this.FechaVta.ReadOnly = true;
            this.FechaVta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NroCuota
            // 
            this.NroCuota.HeaderText = "Nro Cuota";
            this.NroCuota.Name = "NroCuota";
            this.NroCuota.ReadOnly = true;
            this.NroCuota.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            this.Descuento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PrecioDescuento
            // 
            this.PrecioDescuento.HeaderText = "Precio Con Descuento";
            this.PrecioDescuento.Name = "PrecioDescuento";
            this.PrecioDescuento.ReadOnly = true;
            this.PrecioDescuento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btn_Descuento_VtaDispo
            // 
            this.btn_Descuento_VtaDispo.Location = new System.Drawing.Point(544, 400);
            this.btn_Descuento_VtaDispo.Name = "btn_Descuento_VtaDispo";
            this.btn_Descuento_VtaDispo.Size = new System.Drawing.Size(75, 23);
            this.btn_Descuento_VtaDispo.TabIndex = 6;
            this.btn_Descuento_VtaDispo.Text = "Descuento";
            this.btn_Descuento_VtaDispo.UseVisualStyleBackColor = true;
            this.btn_Descuento_VtaDispo.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_DetVtaDisp_Generar
            // 
            this.btn_DetVtaDisp_Generar.Location = new System.Drawing.Point(686, 400);
            this.btn_DetVtaDisp_Generar.Name = "btn_DetVtaDisp_Generar";
            this.btn_DetVtaDisp_Generar.Size = new System.Drawing.Size(75, 23);
            this.btn_DetVtaDisp_Generar.TabIndex = 7;
            this.btn_DetVtaDisp_Generar.Text = "Generar Detalle";
            this.btn_DetVtaDisp_Generar.UseVisualStyleBackColor = true;
            this.btn_DetVtaDisp_Generar.Click += new System.EventHandler(this.btn_DetVtaDisp_Generar_Click);
            // 
            // btn_DetVtaDispo_Cancelar
            // 
            this.btn_DetVtaDispo_Cancelar.Location = new System.Drawing.Point(809, 400);
            this.btn_DetVtaDispo_Cancelar.Name = "btn_DetVtaDispo_Cancelar";
            this.btn_DetVtaDispo_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_DetVtaDispo_Cancelar.TabIndex = 8;
            this.btn_DetVtaDispo_Cancelar.Text = "Cancelar";
            this.btn_DetVtaDispo_Cancelar.UseVisualStyleBackColor = true;
            this.btn_DetVtaDispo_Cancelar.Click += new System.EventHandler(this.button5_Click);
            // 
            // lbl_SubTotal
            // 
            this.lbl_SubTotal.AutoSize = true;
            this.lbl_SubTotal.Location = new System.Drawing.Point(693, 356);
            this.lbl_SubTotal.Name = "lbl_SubTotal";
            this.lbl_SubTotal.Size = new System.Drawing.Size(46, 13);
            this.lbl_SubTotal.TabIndex = 10;
            this.lbl_SubTotal.Text = "Subtotal";
            // 
            // txt_DetVtaDispo_Subtotal
            // 
            this.txt_DetVtaDispo_Subtotal.Enabled = false;
            this.txt_DetVtaDispo_Subtotal.Location = new System.Drawing.Point(784, 353);
            this.txt_DetVtaDispo_Subtotal.Name = "txt_DetVtaDispo_Subtotal";
            this.txt_DetVtaDispo_Subtotal.Pp_Campo = null;
            this.txt_DetVtaDispo_Subtotal.Pp_MensajeError = null;
            this.txt_DetVtaDispo_Subtotal.Pp_Tabla = null;
            this.txt_DetVtaDispo_Subtotal.Pp_Validable = false;
            this.txt_DetVtaDispo_Subtotal.Size = new System.Drawing.Size(100, 20);
            this.txt_DetVtaDispo_Subtotal.TabIndex = 9;
            // 
            // txt_DetVtaDisp_NroFactura
            // 
            this.txt_DetVtaDisp_NroFactura.Enabled = false;
            this.txt_DetVtaDisp_NroFactura.Location = new System.Drawing.Point(649, 54);
            this.txt_DetVtaDisp_NroFactura.Name = "txt_DetVtaDisp_NroFactura";
            this.txt_DetVtaDisp_NroFactura.Pp_Campo = null;
            this.txt_DetVtaDisp_NroFactura.Pp_MensajeError = null;
            this.txt_DetVtaDisp_NroFactura.Pp_Tabla = null;
            this.txt_DetVtaDisp_NroFactura.Pp_Validable = false;
            this.txt_DetVtaDisp_NroFactura.Size = new System.Drawing.Size(149, 20);
            this.txt_DetVtaDisp_NroFactura.TabIndex = 0;
            // 
            // txt_DetVtaDisp_IdCliente
            // 
            this.txt_DetVtaDisp_IdCliente.Enabled = false;
            this.txt_DetVtaDisp_IdCliente.Location = new System.Drawing.Point(90, 54);
            this.txt_DetVtaDisp_IdCliente.Name = "txt_DetVtaDisp_IdCliente";
            this.txt_DetVtaDisp_IdCliente.Pp_Campo = null;
            this.txt_DetVtaDisp_IdCliente.Pp_MensajeError = null;
            this.txt_DetVtaDisp_IdCliente.Pp_Tabla = null;
            this.txt_DetVtaDisp_IdCliente.Pp_Validable = false;
            this.txt_DetVtaDisp_IdCliente.Size = new System.Drawing.Size(132, 20);
            this.txt_DetVtaDisp_IdCliente.TabIndex = 2;
            // 
            // txt_DetVtaDisp_NombCliente
            // 
            this.txt_DetVtaDisp_NombCliente.Enabled = false;
            this.txt_DetVtaDisp_NombCliente.Location = new System.Drawing.Point(344, 54);
            this.txt_DetVtaDisp_NombCliente.Name = "txt_DetVtaDisp_NombCliente";
            this.txt_DetVtaDisp_NombCliente.Pp_Campo = null;
            this.txt_DetVtaDisp_NombCliente.Pp_MensajeError = null;
            this.txt_DetVtaDisp_NombCliente.Pp_Tabla = null;
            this.txt_DetVtaDisp_NombCliente.Pp_Validable = false;
            this.txt_DetVtaDisp_NombCliente.Size = new System.Drawing.Size(137, 20);
            this.txt_DetVtaDisp_NombCliente.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ubic_cuota";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Frm_Detalle_VtaDispo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 450);
            this.Controls.Add(this.lbl_SubTotal);
            this.Controls.Add(this.txt_DetVtaDispo_Subtotal);
            this.Controls.Add(this.btn_DetVtaDispo_Cancelar);
            this.Controls.Add(this.btn_DetVtaDisp_Generar);
            this.Controls.Add(this.btn_Descuento_VtaDispo);
            this.Controls.Add(this.dataGridView_DetVtaDisp);
            this.Controls.Add(this.gb_DetVtaDisp);
            this.Name = "Frm_Detalle_VtaDispo";
            this.Text = "Detalle Venta Dipositivo";
            this.Load += new System.EventHandler(this.Frm_Detalle_VtaDispo_Load);
            this.gb_DetVtaDisp.ResumeLayout(false);
            this.gb_DetVtaDisp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DetVtaDisp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_DetVtaDisp;
        private System.Windows.Forms.Label lbl_DetVtaDisp_IdCliente;
        private System.Windows.Forms.Label lbl_DetVtaDisp_NombreCliente;
        private System.Windows.Forms.Label lbl_DetVtaDisp_NroFac;
        private Clases.TextBox01 txt_DetVtaDisp_NroFactura;
        private Clases.TextBox01 txt_DetVtaDisp_IdCliente;
        private Clases.TextBox01 txt_DetVtaDisp_NombCliente;
        private System.Windows.Forms.DataGridView dataGridView_DetVtaDisp;
        private System.Windows.Forms.Button btn_Descuento_VtaDispo;
        private System.Windows.Forms.Button btn_DetVtaDisp_Generar;
        private System.Windows.Forms.Button btn_DetVtaDispo_Cancelar;
        private Clases.TextBox01 txt_DetVtaDispo_Subtotal;
        private System.Windows.Forms.Label lbl_SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}