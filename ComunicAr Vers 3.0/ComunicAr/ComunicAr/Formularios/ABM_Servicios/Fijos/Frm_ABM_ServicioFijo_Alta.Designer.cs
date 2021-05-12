
namespace ComunicAr.Formularios.ABM_Servicios.Fijos
{
    partial class Frm_ABM_ServicioFijo_Alta
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
            this.lbl_ServicioFijo_Alta_descripcion = new System.Windows.Forms.Label();
            this.lbl_ServicioFijo_Alta_CostoMensual = new System.Windows.Forms.Label();
            this.btn_ServicioFIjo_Alta_Cancelar = new System.Windows.Forms.Button();
            this.btn_ServicioFijo_Alta_Aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ServicioFijo_Alta_CostoMensual = new ComunicAr.Clases.TextBox01();
            this.txt_ServicioFijo_Alta_Descripcion = new ComunicAr.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // lbl_ServicioFijo_Alta_descripcion
            // 
            this.lbl_ServicioFijo_Alta_descripcion.AutoSize = true;
            this.lbl_ServicioFijo_Alta_descripcion.Location = new System.Drawing.Point(44, 59);
            this.lbl_ServicioFijo_Alta_descripcion.Name = "lbl_ServicioFijo_Alta_descripcion";
            this.lbl_ServicioFijo_Alta_descripcion.Size = new System.Drawing.Size(63, 13);
            this.lbl_ServicioFijo_Alta_descripcion.TabIndex = 3;
            this.lbl_ServicioFijo_Alta_descripcion.Text = "Descripción";
            // 
            // lbl_ServicioFijo_Alta_CostoMensual
            // 
            this.lbl_ServicioFijo_Alta_CostoMensual.AutoSize = true;
            this.lbl_ServicioFijo_Alta_CostoMensual.Location = new System.Drawing.Point(30, 85);
            this.lbl_ServicioFijo_Alta_CostoMensual.Name = "lbl_ServicioFijo_Alta_CostoMensual";
            this.lbl_ServicioFijo_Alta_CostoMensual.Size = new System.Drawing.Size(77, 13);
            this.lbl_ServicioFijo_Alta_CostoMensual.TabIndex = 4;
            this.lbl_ServicioFijo_Alta_CostoMensual.Text = "Costo Mensual";
            // 
            // btn_ServicioFIjo_Alta_Cancelar
            // 
            this.btn_ServicioFIjo_Alta_Cancelar.Location = new System.Drawing.Point(183, 122);
            this.btn_ServicioFIjo_Alta_Cancelar.Name = "btn_ServicioFIjo_Alta_Cancelar";
            this.btn_ServicioFIjo_Alta_Cancelar.Size = new System.Drawing.Size(86, 23);
            this.btn_ServicioFIjo_Alta_Cancelar.TabIndex = 8;
            this.btn_ServicioFIjo_Alta_Cancelar.Text = "Cancelar";
            this.btn_ServicioFIjo_Alta_Cancelar.UseVisualStyleBackColor = true;
            this.btn_ServicioFIjo_Alta_Cancelar.Click += new System.EventHandler(this.btn_ServicioFIjo_Alta_Cancelar_Click);
            // 
            // btn_ServicioFijo_Alta_Aceptar
            // 
            this.btn_ServicioFijo_Alta_Aceptar.Location = new System.Drawing.Point(72, 122);
            this.btn_ServicioFijo_Alta_Aceptar.Name = "btn_ServicioFijo_Alta_Aceptar";
            this.btn_ServicioFijo_Alta_Aceptar.Size = new System.Drawing.Size(92, 23);
            this.btn_ServicioFijo_Alta_Aceptar.TabIndex = 9;
            this.btn_ServicioFijo_Alta_Aceptar.Text = "Aceptar";
            this.btn_ServicioFijo_Alta_Aceptar.UseVisualStyleBackColor = true;
            this.btn_ServicioFijo_Alta_Aceptar.Click += new System.EventHandler(this.btn_ServicioFijo_Alta_Aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Altas Servicios Fijos";
            // 
            // txt_ServicioFijo_Alta_CostoMensual
            // 
            this.txt_ServicioFijo_Alta_CostoMensual.Location = new System.Drawing.Point(113, 82);
            this.txt_ServicioFijo_Alta_CostoMensual.Name = "txt_ServicioFijo_Alta_CostoMensual";
            this.txt_ServicioFijo_Alta_CostoMensual.Pp_Campo = "costo_mensual";
            this.txt_ServicioFijo_Alta_CostoMensual.Pp_MensajeError = "Falta Cargar tipo de servicio";
            this.txt_ServicioFijo_Alta_CostoMensual.Pp_Tabla = null;
            this.txt_ServicioFijo_Alta_CostoMensual.Pp_Validable = false;
            this.txt_ServicioFijo_Alta_CostoMensual.Size = new System.Drawing.Size(156, 20);
            this.txt_ServicioFijo_Alta_CostoMensual.TabIndex = 13;
            // 
            // txt_ServicioFijo_Alta_Descripcion
            // 
            this.txt_ServicioFijo_Alta_Descripcion.Location = new System.Drawing.Point(113, 56);
            this.txt_ServicioFijo_Alta_Descripcion.Name = "txt_ServicioFijo_Alta_Descripcion";
            this.txt_ServicioFijo_Alta_Descripcion.Pp_Campo = "descripcion";
            this.txt_ServicioFijo_Alta_Descripcion.Pp_MensajeError = "Falta cargar descripcion de servicio fijo";
            this.txt_ServicioFijo_Alta_Descripcion.Pp_Tabla = null;
            this.txt_ServicioFijo_Alta_Descripcion.Pp_Validable = false;
            this.txt_ServicioFijo_Alta_Descripcion.Size = new System.Drawing.Size(156, 20);
            this.txt_ServicioFijo_Alta_Descripcion.TabIndex = 12;
            // 
            // Frm_ABM_ServicioFijo_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 160);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ServicioFijo_Alta_CostoMensual);
            this.Controls.Add(this.txt_ServicioFijo_Alta_Descripcion);
            this.Controls.Add(this.btn_ServicioFijo_Alta_Aceptar);
            this.Controls.Add(this.btn_ServicioFIjo_Alta_Cancelar);
            this.Controls.Add(this.lbl_ServicioFijo_Alta_CostoMensual);
            this.Controls.Add(this.lbl_ServicioFijo_Alta_descripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ABM_ServicioFijo_Alta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_ServicioFijo_Alta_descripcion;
        private System.Windows.Forms.Label lbl_ServicioFijo_Alta_CostoMensual;
        private System.Windows.Forms.Button btn_ServicioFIjo_Alta_Cancelar;
        private System.Windows.Forms.Button btn_ServicioFijo_Alta_Aceptar;
        private Clases.TextBox01 txt_ServicioFijo_Alta_Descripcion;
        private Clases.TextBox01 txt_ServicioFijo_Alta_CostoMensual;
        private System.Windows.Forms.Label label1;
    }
}