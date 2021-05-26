
namespace ComunicAr.Transaccion.Emision_de_Factura
{
    partial class Frm_EmisionFactura
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
            this.btn_emision_emitir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_emision_buscar_cliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_emision_servicio_fijo = new System.Windows.Forms.Button();
            this.btn_emision_servicio_datos = new System.Windows.Forms.Button();
            this.btn_emision_servicio_prepago = new System.Windows.Forms.Button();
            this.btn_emision_llamadas = new System.Windows.Forms.Button();
            this.btn_emision_vta_dispo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_emision_cancelar = new System.Windows.Forms.Button();
            this.cmb_emision_tipo_factura = new ComunicAr.Clases.ComboBox01();
            this.Txt_2do = new ComunicAr.Clases.TextBox01();
            this.Txt_1er = new ComunicAr.Clases.TextBox01();
            this.Txt_FechEm = new ComunicAr.Clases.TextBox01();
            this.Txt_nroFac = new ComunicAr.Clases.TextBox01();
            this.Txt_NombreCliente = new ComunicAr.Clases.TextBox01();
            this.Txt_Cliente = new ComunicAr.Clases.TextBox01();
            this.chk_emision_serv_fijo = new ComunicAr.Clases.CheckBox01();
            this.chk_emision_Llamadas = new ComunicAr.Clases.CheckBox01();
            this.chk_emision_serv_datos = new ComunicAr.Clases.CheckBox01();
            this.chk_emision_vta_dispo = new ComunicAr.Clases.CheckBox01();
            this.chk_emision_serv_prepago = new ComunicAr.Clases.CheckBox01();
            this.SuspendLayout();
            // 
            // btn_emision_emitir
            // 
            this.btn_emision_emitir.Location = new System.Drawing.Point(303, 216);
            this.btn_emision_emitir.Name = "btn_emision_emitir";
            this.btn_emision_emitir.Size = new System.Drawing.Size(94, 29);
            this.btn_emision_emitir.TabIndex = 5;
            this.btn_emision_emitir.Text = "Emitir Factura";
            this.btn_emision_emitir.UseVisualStyleBackColor = true;
            this.btn_emision_emitir.Click += new System.EventHandler(this.btn_emision_emitir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID Cliente";
            // 
            // btn_emision_buscar_cliente
            // 
            this.btn_emision_buscar_cliente.Location = new System.Drawing.Point(278, 10);
            this.btn_emision_buscar_cliente.Name = "btn_emision_buscar_cliente";
            this.btn_emision_buscar_cliente.Size = new System.Drawing.Size(75, 23);
            this.btn_emision_buscar_cliente.TabIndex = 8;
            this.btn_emision_buscar_cliente.Text = "Buscar";
            this.btn_emision_buscar_cliente.UseVisualStyleBackColor = true;
            this.btn_emision_buscar_cliente.Click += new System.EventHandler(this.btn_emision_buscar_cliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(36, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre Cliente";
            // 
            // btn_emision_servicio_fijo
            // 
            this.btn_emision_servicio_fijo.Enabled = false;
            this.btn_emision_servicio_fijo.Location = new System.Drawing.Point(356, 39);
            this.btn_emision_servicio_fijo.Name = "btn_emision_servicio_fijo";
            this.btn_emision_servicio_fijo.Size = new System.Drawing.Size(141, 23);
            this.btn_emision_servicio_fijo.TabIndex = 11;
            this.btn_emision_servicio_fijo.Text = "Servicio Fijo";
            this.btn_emision_servicio_fijo.UseVisualStyleBackColor = true;
            this.btn_emision_servicio_fijo.Click += new System.EventHandler(this.bnt_emision_servicio_fijo_Click);
            // 
            // btn_emision_servicio_datos
            // 
            this.btn_emision_servicio_datos.Enabled = false;
            this.btn_emision_servicio_datos.Location = new System.Drawing.Point(356, 68);
            this.btn_emision_servicio_datos.Name = "btn_emision_servicio_datos";
            this.btn_emision_servicio_datos.Size = new System.Drawing.Size(141, 23);
            this.btn_emision_servicio_datos.TabIndex = 11;
            this.btn_emision_servicio_datos.Text = "Servicio de Datos";
            this.btn_emision_servicio_datos.UseVisualStyleBackColor = true;
            this.btn_emision_servicio_datos.Click += new System.EventHandler(this.bnt_emision_servicio_datos_Click);
            // 
            // btn_emision_servicio_prepago
            // 
            this.btn_emision_servicio_prepago.Enabled = false;
            this.btn_emision_servicio_prepago.Location = new System.Drawing.Point(356, 97);
            this.btn_emision_servicio_prepago.Name = "btn_emision_servicio_prepago";
            this.btn_emision_servicio_prepago.Size = new System.Drawing.Size(141, 23);
            this.btn_emision_servicio_prepago.TabIndex = 11;
            this.btn_emision_servicio_prepago.Text = "Servicio Prepago";
            this.btn_emision_servicio_prepago.UseVisualStyleBackColor = true;
            this.btn_emision_servicio_prepago.Click += new System.EventHandler(this.bnt_emision_servicio_prepago_Click);
            // 
            // btn_emision_llamadas
            // 
            this.btn_emision_llamadas.Enabled = false;
            this.btn_emision_llamadas.Location = new System.Drawing.Point(356, 126);
            this.btn_emision_llamadas.Name = "btn_emision_llamadas";
            this.btn_emision_llamadas.Size = new System.Drawing.Size(141, 23);
            this.btn_emision_llamadas.TabIndex = 11;
            this.btn_emision_llamadas.Text = "Llamadas";
            this.btn_emision_llamadas.UseVisualStyleBackColor = true;
            this.btn_emision_llamadas.Click += new System.EventHandler(this.btn_emision_llamadas_Click);
            // 
            // btn_emision_vta_dispo
            // 
            this.btn_emision_vta_dispo.Enabled = false;
            this.btn_emision_vta_dispo.Location = new System.Drawing.Point(356, 155);
            this.btn_emision_vta_dispo.Name = "btn_emision_vta_dispo";
            this.btn_emision_vta_dispo.Size = new System.Drawing.Size(141, 23);
            this.btn_emision_vta_dispo.TabIndex = 11;
            this.btn_emision_vta_dispo.Text = "Ventas de Dispositivos";
            this.btn_emision_vta_dispo.UseVisualStyleBackColor = true;
            this.btn_emision_vta_dispo.Click += new System.EventHandler(this.bnt_emision_vta_dispo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(58, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nro Factura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tipo Factura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Fecha Emision";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Fecha 1º Vencimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Fecha 2º Vencimiento";
            // 
            // btn_emision_cancelar
            // 
            this.btn_emision_cancelar.Location = new System.Drawing.Point(403, 216);
            this.btn_emision_cancelar.Name = "btn_emision_cancelar";
            this.btn_emision_cancelar.Size = new System.Drawing.Size(94, 29);
            this.btn_emision_cancelar.TabIndex = 5;
            this.btn_emision_cancelar.Text = "Cancelar";
            this.btn_emision_cancelar.UseVisualStyleBackColor = true;
            this.btn_emision_cancelar.Click += new System.EventHandler(this.btn_emision_cancelar_Click);
            // 
            // cmb_emision_tipo_factura
            // 
            this.cmb_emision_tipo_factura.FormattingEnabled = true;
            this.cmb_emision_tipo_factura.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cmb_emision_tipo_factura.Location = new System.Drawing.Point(133, 67);
            this.cmb_emision_tipo_factura.Name = "cmb_emision_tipo_factura";
            this.cmb_emision_tipo_factura.Pp_Conseleccion = false;
            this.cmb_emision_tipo_factura.Pp_Descripcion = null;
            this.cmb_emision_tipo_factura.Pp_MensajeError = "No se ha seleccionado un tipo de Factura";
            this.cmb_emision_tipo_factura.Pp_NombreCampo = null;
            this.cmb_emision_tipo_factura.Pp_NombreTabla = null;
            this.cmb_emision_tipo_factura.Pp_PK = null;
            this.cmb_emision_tipo_factura.Pp_Tabla = null;
            this.cmb_emision_tipo_factura.Pp_Validable = false;
            this.cmb_emision_tipo_factura.Size = new System.Drawing.Size(139, 23);
            this.cmb_emision_tipo_factura.TabIndex = 22;
            // 
            // Txt_2do
            // 
            this.Txt_2do.Enabled = false;
            this.Txt_2do.Location = new System.Drawing.Point(133, 183);
            this.Txt_2do.Name = "Txt_2do";
            this.Txt_2do.Pp_Campo = null;
            this.Txt_2do.Pp_MensajeError = null;
            this.Txt_2do.Pp_Tabla = null;
            this.Txt_2do.Pp_Validable = false;
            this.Txt_2do.Size = new System.Drawing.Size(139, 23);
            this.Txt_2do.TabIndex = 20;
            // 
            // Txt_1er
            // 
            this.Txt_1er.Enabled = false;
            this.Txt_1er.Location = new System.Drawing.Point(133, 154);
            this.Txt_1er.Name = "Txt_1er";
            this.Txt_1er.Pp_Campo = null;
            this.Txt_1er.Pp_MensajeError = null;
            this.Txt_1er.Pp_Tabla = null;
            this.Txt_1er.Pp_Validable = false;
            this.Txt_1er.Size = new System.Drawing.Size(139, 23);
            this.Txt_1er.TabIndex = 20;
            // 
            // Txt_FechEm
            // 
            this.Txt_FechEm.Enabled = false;
            this.Txt_FechEm.Location = new System.Drawing.Point(133, 125);
            this.Txt_FechEm.Name = "Txt_FechEm";
            this.Txt_FechEm.Pp_Campo = null;
            this.Txt_FechEm.Pp_MensajeError = null;
            this.Txt_FechEm.Pp_Tabla = null;
            this.Txt_FechEm.Pp_Validable = false;
            this.Txt_FechEm.Size = new System.Drawing.Size(139, 23);
            this.Txt_FechEm.TabIndex = 20;
            // 
            // Txt_nroFac
            // 
            this.Txt_nroFac.Enabled = false;
            this.Txt_nroFac.Location = new System.Drawing.Point(133, 96);
            this.Txt_nroFac.Name = "Txt_nroFac";
            this.Txt_nroFac.Pp_Campo = null;
            this.Txt_nroFac.Pp_MensajeError = null;
            this.Txt_nroFac.Pp_Tabla = null;
            this.Txt_nroFac.Pp_Validable = false;
            this.Txt_nroFac.Size = new System.Drawing.Size(139, 23);
            this.Txt_nroFac.TabIndex = 20;
            // 
            // Txt_NombreCliente
            // 
            this.Txt_NombreCliente.Enabled = false;
            this.Txt_NombreCliente.Location = new System.Drawing.Point(133, 39);
            this.Txt_NombreCliente.Name = "Txt_NombreCliente";
            this.Txt_NombreCliente.Pp_Campo = null;
            this.Txt_NombreCliente.Pp_MensajeError = null;
            this.Txt_NombreCliente.Pp_Tabla = null;
            this.Txt_NombreCliente.Pp_Validable = false;
            this.Txt_NombreCliente.Size = new System.Drawing.Size(139, 23);
            this.Txt_NombreCliente.TabIndex = 19;
            // 
            // Txt_Cliente
            // 
            this.Txt_Cliente.Location = new System.Drawing.Point(133, 10);
            this.Txt_Cliente.Name = "Txt_Cliente";
            this.Txt_Cliente.Pp_Campo = null;
            this.Txt_Cliente.Pp_MensajeError = "Buscar Cliente por ID";
            this.Txt_Cliente.Pp_Tabla = null;
            this.Txt_Cliente.Pp_Validable = false;
            this.Txt_Cliente.Size = new System.Drawing.Size(139, 23);
            this.Txt_Cliente.TabIndex = 19;
            // 
            // chk_emision_serv_fijo
            // 
            this.chk_emision_serv_fijo.AutoSize = true;
            this.chk_emision_serv_fijo.Enabled = false;
            this.chk_emision_serv_fijo.Location = new System.Drawing.Point(503, 39);
            this.chk_emision_serv_fijo.Name = "chk_emision_serv_fijo";
            this.chk_emision_serv_fijo.Pp_MensajeError = "No se ha buscado los servicios fijos";
            this.chk_emision_serv_fijo.Size = new System.Drawing.Size(15, 14);
            this.chk_emision_serv_fijo.TabIndex = 23;
            this.chk_emision_serv_fijo.UseVisualStyleBackColor = true;
            // 
            // chk_emision_Llamadas
            // 
            this.chk_emision_Llamadas.AutoSize = true;
            this.chk_emision_Llamadas.Enabled = false;
            this.chk_emision_Llamadas.Location = new System.Drawing.Point(503, 131);
            this.chk_emision_Llamadas.Name = "chk_emision_Llamadas";
            this.chk_emision_Llamadas.Pp_MensajeError = "No se ha buscado las llamadas";
            this.chk_emision_Llamadas.Size = new System.Drawing.Size(15, 14);
            this.chk_emision_Llamadas.TabIndex = 23;
            this.chk_emision_Llamadas.UseVisualStyleBackColor = true;
            // 
            // chk_emision_serv_datos
            // 
            this.chk_emision_serv_datos.AutoSize = true;
            this.chk_emision_serv_datos.Enabled = false;
            this.chk_emision_serv_datos.Location = new System.Drawing.Point(503, 73);
            this.chk_emision_serv_datos.Name = "chk_emision_serv_datos";
            this.chk_emision_serv_datos.Pp_MensajeError = "No se ha buscado los servicios datos";
            this.chk_emision_serv_datos.Size = new System.Drawing.Size(15, 14);
            this.chk_emision_serv_datos.TabIndex = 23;
            this.chk_emision_serv_datos.UseVisualStyleBackColor = true;
            // 
            // chk_emision_vta_dispo
            // 
            this.chk_emision_vta_dispo.AutoSize = true;
            this.chk_emision_vta_dispo.Enabled = false;
            this.chk_emision_vta_dispo.Location = new System.Drawing.Point(503, 160);
            this.chk_emision_vta_dispo.Name = "chk_emision_vta_dispo";
            this.chk_emision_vta_dispo.Pp_MensajeError = "No se ha buscado las vtas de dispositivos";
            this.chk_emision_vta_dispo.Size = new System.Drawing.Size(15, 14);
            this.chk_emision_vta_dispo.TabIndex = 23;
            this.chk_emision_vta_dispo.UseVisualStyleBackColor = true;
            // 
            // chk_emision_serv_prepago
            // 
            this.chk_emision_serv_prepago.AutoSize = true;
            this.chk_emision_serv_prepago.Enabled = false;
            this.chk_emision_serv_prepago.Location = new System.Drawing.Point(503, 102);
            this.chk_emision_serv_prepago.Name = "chk_emision_serv_prepago";
            this.chk_emision_serv_prepago.Pp_MensajeError = "No se ha buscado los servicios prepagos";
            this.chk_emision_serv_prepago.Size = new System.Drawing.Size(15, 14);
            this.chk_emision_serv_prepago.TabIndex = 23;
            this.chk_emision_serv_prepago.UseVisualStyleBackColor = true;
            // 
            // Frm_EmisionFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 249);
            this.Controls.Add(this.chk_emision_Llamadas);
            this.Controls.Add(this.chk_emision_serv_prepago);
            this.Controls.Add(this.chk_emision_vta_dispo);
            this.Controls.Add(this.chk_emision_serv_datos);
            this.Controls.Add(this.chk_emision_serv_fijo);
            this.Controls.Add(this.cmb_emision_tipo_factura);
            this.Controls.Add(this.Txt_2do);
            this.Controls.Add(this.Txt_1er);
            this.Controls.Add(this.Txt_FechEm);
            this.Controls.Add(this.Txt_nroFac);
            this.Controls.Add(this.Txt_NombreCliente);
            this.Controls.Add(this.Txt_Cliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_emision_vta_dispo);
            this.Controls.Add(this.btn_emision_llamadas);
            this.Controls.Add(this.btn_emision_servicio_prepago);
            this.Controls.Add(this.btn_emision_servicio_datos);
            this.Controls.Add(this.btn_emision_servicio_fijo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_emision_buscar_cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_emision_cancelar);
            this.Controls.Add(this.btn_emision_emitir);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_EmisionFactura";
            this.Text = "Frm_EmisionFactura";
            this.Load += new System.EventHandler(this.Frm_EmisionFactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Clases.TextBox01 textBox011;
        private System.Windows.Forms.Button btn_emision_emitir;
        private System.Windows.Forms.Label label2;
        private Clases.TextBox01 textBox012;
        private System.Windows.Forms.Button btn_emision_buscar_cliente;
        private System.Windows.Forms.Label label3;
        private Clases.TextBox01 textBox013;
        private System.Windows.Forms.Button btn_emision_servicio_fijo;
        private System.Windows.Forms.Button btn_emision_servicio_datos;
        private System.Windows.Forms.Button btn_emision_servicio_prepago;
        private System.Windows.Forms.Button btn_emision_llamadas;
        private System.Windows.Forms.Button btn_emision_vta_dispo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Clases.TextBox01 textBox014;
        private Clases.TextBox01 textBox015;
        private Clases.TextBox01 textBox016;
        private Clases.TextBox01 textBox017;
        private Clases.TextBox01 Txt_Cliente;
        private Clases.TextBox01 Txt_NombreCliente;
        private Clases.TextBox01 Txt_nroFac;
        private Clases.TextBox01 Txt_FechEm;
        private Clases.TextBox01 Txt_1er;
        private Clases.TextBox01 Txt_2do;
        private System.Windows.Forms.Button btn_emision_cancelar;
        private Clases.ComboBox01 cmb_emision_tipo_factura;
        private Clases.CheckBox01 chk_emision_serv_fijo;
        private Clases.CheckBox01 chk_emision_Llamadas;
        private Clases.CheckBox01 chk_emision_serv_datos;
        private Clases.CheckBox01 chk_emision_vta_dispo;
        private Clases.CheckBox01 chk_emision_serv_prepago;
    }
}