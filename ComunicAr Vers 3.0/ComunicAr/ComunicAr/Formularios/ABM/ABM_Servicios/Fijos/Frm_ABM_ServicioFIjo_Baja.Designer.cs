
namespace ComunicAr.Formularios.ABM_Servicios.Fijos
{
    partial class Frm_ABM_ServicioFIjo_Baja
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
            this.lbl_ServicioFIjo_Modificacion_Descripcion = new System.Windows.Forms.Label();
            this.lbl_ServicioFijo_Modificacion_CostoMensual = new System.Windows.Forms.Label();
            this.btn_ServicioFIjo_Baja_Cancelar = new System.Windows.Forms.Button();
            this.btn_ServicioFIjo_Baja_Aceptar = new System.Windows.Forms.Button();
            this.Label_Mod = new System.Windows.Forms.Label();
            this.txt_ServicioFijo_Baja_CostoMensual = new ComunicAr.Clases.TextBox01();
            this.txt_ServicioFijo_Baja_descripcion = new ComunicAr.Clases.TextBox01();
            this.lbl_ServicioFijo_Modificacion_TipoServicio = new System.Windows.Forms.Label();
            this.txt_ServicioFijo_Baja_IdServicio = new ComunicAr.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // lbl_ServicioFIjo_Modificacion_Descripcion
            // 
            this.lbl_ServicioFIjo_Modificacion_Descripcion.AutoSize = true;
            this.lbl_ServicioFIjo_Modificacion_Descripcion.Location = new System.Drawing.Point(44, 85);
            this.lbl_ServicioFIjo_Modificacion_Descripcion.Name = "lbl_ServicioFIjo_Modificacion_Descripcion";
            this.lbl_ServicioFIjo_Modificacion_Descripcion.Size = new System.Drawing.Size(63, 13);
            this.lbl_ServicioFIjo_Modificacion_Descripcion.TabIndex = 4;
            this.lbl_ServicioFIjo_Modificacion_Descripcion.Text = "Descripcion";
            // 
            // lbl_ServicioFijo_Modificacion_CostoMensual
            // 
            this.lbl_ServicioFijo_Modificacion_CostoMensual.AutoSize = true;
            this.lbl_ServicioFijo_Modificacion_CostoMensual.Location = new System.Drawing.Point(30, 111);
            this.lbl_ServicioFijo_Modificacion_CostoMensual.Name = "lbl_ServicioFijo_Modificacion_CostoMensual";
            this.lbl_ServicioFijo_Modificacion_CostoMensual.Size = new System.Drawing.Size(77, 13);
            this.lbl_ServicioFijo_Modificacion_CostoMensual.TabIndex = 5;
            this.lbl_ServicioFijo_Modificacion_CostoMensual.Text = "Costo Mensual";
            // 
            // btn_ServicioFIjo_Baja_Cancelar
            // 
            this.btn_ServicioFIjo_Baja_Cancelar.Location = new System.Drawing.Point(183, 148);
            this.btn_ServicioFIjo_Baja_Cancelar.Name = "btn_ServicioFIjo_Baja_Cancelar";
            this.btn_ServicioFIjo_Baja_Cancelar.Size = new System.Drawing.Size(86, 23);
            this.btn_ServicioFIjo_Baja_Cancelar.TabIndex = 7;
            this.btn_ServicioFIjo_Baja_Cancelar.Text = "Cancelar";
            this.btn_ServicioFIjo_Baja_Cancelar.UseVisualStyleBackColor = true;
            this.btn_ServicioFIjo_Baja_Cancelar.Click += new System.EventHandler(this.Btn_ServicioFIjo_Baja_Cancelar_Click);
            // 
            // btn_ServicioFIjo_Baja_Aceptar
            // 
            this.btn_ServicioFIjo_Baja_Aceptar.Location = new System.Drawing.Point(72, 148);
            this.btn_ServicioFIjo_Baja_Aceptar.Name = "btn_ServicioFIjo_Baja_Aceptar";
            this.btn_ServicioFIjo_Baja_Aceptar.Size = new System.Drawing.Size(86, 23);
            this.btn_ServicioFIjo_Baja_Aceptar.TabIndex = 8;
            this.btn_ServicioFIjo_Baja_Aceptar.Text = "Aceptar";
            this.btn_ServicioFIjo_Baja_Aceptar.UseVisualStyleBackColor = true;
            this.btn_ServicioFIjo_Baja_Aceptar.Click += new System.EventHandler(this.btn_ServicioFIjo_Baja_Aceptar_Click);
            // 
            // Label_Mod
            // 
            this.Label_Mod.AutoSize = true;
            this.Label_Mod.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Mod.Location = new System.Drawing.Point(25, 9);
            this.Label_Mod.Name = "Label_Mod";
            this.Label_Mod.Size = new System.Drawing.Size(277, 32);
            this.Label_Mod.TabIndex = 9;
            this.Label_Mod.Text = "Eliminar Servicios Fijos";
            // 
            // txt_ServicioFijo_Baja_CostoMensual
            // 
            this.txt_ServicioFijo_Baja_CostoMensual.Enabled = false;
            this.txt_ServicioFijo_Baja_CostoMensual.Location = new System.Drawing.Point(113, 108);
            this.txt_ServicioFijo_Baja_CostoMensual.Name = "txt_ServicioFijo_Baja_CostoMensual";
            this.txt_ServicioFijo_Baja_CostoMensual.Pp_Campo = "costo_mensual";
            this.txt_ServicioFijo_Baja_CostoMensual.Pp_MensajeError = "Faltar cargar costo mensual";
            this.txt_ServicioFijo_Baja_CostoMensual.Pp_Tabla = null;
            this.txt_ServicioFijo_Baja_CostoMensual.Pp_Validable = false;
            this.txt_ServicioFijo_Baja_CostoMensual.Size = new System.Drawing.Size(156, 20);
            this.txt_ServicioFijo_Baja_CostoMensual.TabIndex = 2;
            // 
            // txt_ServicioFijo_Baja_descripcion
            // 
            this.txt_ServicioFijo_Baja_descripcion.Enabled = false;
            this.txt_ServicioFijo_Baja_descripcion.Location = new System.Drawing.Point(113, 82);
            this.txt_ServicioFijo_Baja_descripcion.Name = "txt_ServicioFijo_Baja_descripcion";
            this.txt_ServicioFijo_Baja_descripcion.Pp_Campo = "descripcion";
            this.txt_ServicioFijo_Baja_descripcion.Pp_MensajeError = "Falta descripcion del Servicio Fijo";
            this.txt_ServicioFijo_Baja_descripcion.Pp_Tabla = null;
            this.txt_ServicioFijo_Baja_descripcion.Pp_Validable = false;
            this.txt_ServicioFijo_Baja_descripcion.Size = new System.Drawing.Size(156, 20);
            this.txt_ServicioFijo_Baja_descripcion.TabIndex = 0;
            // 
            // lbl_ServicioFijo_Modificacion_TipoServicio
            // 
            this.lbl_ServicioFijo_Modificacion_TipoServicio.AutoSize = true;
            this.lbl_ServicioFijo_Modificacion_TipoServicio.Location = new System.Drawing.Point(28, 59);
            this.lbl_ServicioFijo_Modificacion_TipoServicio.Name = "lbl_ServicioFijo_Modificacion_TipoServicio";
            this.lbl_ServicioFijo_Modificacion_TipoServicio.Size = new System.Drawing.Size(79, 13);
            this.lbl_ServicioFijo_Modificacion_TipoServicio.TabIndex = 11;
            this.lbl_ServicioFijo_Modificacion_TipoServicio.Text = "Id. Servicio Fijo";
            // 
            // txt_ServicioFijo_Baja_IdServicio
            // 
            this.txt_ServicioFijo_Baja_IdServicio.Enabled = false;
            this.txt_ServicioFijo_Baja_IdServicio.Location = new System.Drawing.Point(113, 56);
            this.txt_ServicioFijo_Baja_IdServicio.Name = "txt_ServicioFijo_Baja_IdServicio";
            this.txt_ServicioFijo_Baja_IdServicio.Pp_Campo = "tipo_servicio";
            this.txt_ServicioFijo_Baja_IdServicio.Pp_MensajeError = "Falta cargar tipo servicio";
            this.txt_ServicioFijo_Baja_IdServicio.Pp_Tabla = null;
            this.txt_ServicioFijo_Baja_IdServicio.Pp_Validable = false;
            this.txt_ServicioFijo_Baja_IdServicio.Size = new System.Drawing.Size(156, 20);
            this.txt_ServicioFijo_Baja_IdServicio.TabIndex = 10;
            // 
            // Frm_ABM_ServicioFIjo_Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 183);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_ServicioFijo_Modificacion_TipoServicio);
            this.Controls.Add(this.txt_ServicioFijo_Baja_IdServicio);
            this.Controls.Add(this.Label_Mod);
            this.Controls.Add(this.btn_ServicioFIjo_Baja_Aceptar);
            this.Controls.Add(this.btn_ServicioFIjo_Baja_Cancelar);
            this.Controls.Add(this.lbl_ServicioFijo_Modificacion_CostoMensual);
            this.Controls.Add(this.lbl_ServicioFIjo_Modificacion_Descripcion);
            this.Controls.Add(this.txt_ServicioFijo_Baja_CostoMensual);
            this.Controls.Add(this.txt_ServicioFijo_Baja_descripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ABM_ServicioFIjo_Baja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificación";
            this.Load += new System.EventHandler(this.Frm_ABM_ServicioFIjo_Baja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.TextBox01 txt_ServicioFijo_Baja_descripcion;
        private Clases.TextBox01 txt_ServicioFijo_Baja_CostoMensual;
        private System.Windows.Forms.Label lbl_ServicioFIjo_Modificacion_Descripcion;
        private System.Windows.Forms.Label lbl_ServicioFijo_Modificacion_CostoMensual;
        private System.Windows.Forms.Button btn_ServicioFIjo_Baja_Cancelar;
        private System.Windows.Forms.Button btn_ServicioFIjo_Baja_Aceptar;
        private System.Windows.Forms.Label Label_Mod;
        private System.Windows.Forms.Label lbl_ServicioFijo_Modificacion_TipoServicio;
        private Clases.TextBox01 txt_ServicioFijo_Baja_IdServicio;
    }
}