
namespace ComunicAr.Formularios.Barrio
{
    partial class Frm_Alta_Barrio
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
            this.btn_cliente_alta_cancelar = new System.Windows.Forms.Button();
            this.btn_cliente_alta_aceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_codigo_ciudad = new ComunicAr.Clases.ComboBox01();
            this.txt_nombre_barrio = new ComunicAr.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // btn_cliente_alta_cancelar
            // 
            this.btn_cliente_alta_cancelar.Location = new System.Drawing.Point(132, 97);
            this.btn_cliente_alta_cancelar.Name = "btn_cliente_alta_cancelar";
            this.btn_cliente_alta_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cliente_alta_cancelar.TabIndex = 25;
            this.btn_cliente_alta_cancelar.Text = "Cancelar";
            this.btn_cliente_alta_cancelar.UseVisualStyleBackColor = true;
            this.btn_cliente_alta_cancelar.Click += new System.EventHandler(this.btn_cliente_alta_cancelar_Click);
            // 
            // btn_cliente_alta_aceptar
            // 
            this.btn_cliente_alta_aceptar.Location = new System.Drawing.Point(32, 97);
            this.btn_cliente_alta_aceptar.Name = "btn_cliente_alta_aceptar";
            this.btn_cliente_alta_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_cliente_alta_aceptar.TabIndex = 24;
            this.btn_cliente_alta_aceptar.Text = "Aceptar";
            this.btn_cliente_alta_aceptar.UseVisualStyleBackColor = true;
            this.btn_cliente_alta_aceptar.Click += new System.EventHandler(this.btn_cliente_alta_aceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ciudad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Barrio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Altas Barrios";
            // 
            // cmb_codigo_ciudad
            // 
            this.cmb_codigo_ciudad.FormattingEnabled = true;
            this.cmb_codigo_ciudad.Location = new System.Drawing.Point(58, 70);
            this.cmb_codigo_ciudad.Name = "cmb_codigo_ciudad";
            this.cmb_codigo_ciudad.Pp_Conseleccion = false;
            this.cmb_codigo_ciudad.Pp_Descripcion = "nombre_ciudad";
            this.cmb_codigo_ciudad.Pp_MensajeError = null;
            this.cmb_codigo_ciudad.Pp_NombreCampo = null;
            this.cmb_codigo_ciudad.Pp_NombreTabla = null;
            this.cmb_codigo_ciudad.Pp_PK = "cod_ciudad";
            this.cmb_codigo_ciudad.Pp_Tabla = "Ciudad";
            this.cmb_codigo_ciudad.Pp_Validable = false;
            this.cmb_codigo_ciudad.Size = new System.Drawing.Size(164, 21);
            this.cmb_codigo_ciudad.TabIndex = 34;
            // 
            // txt_nombre_barrio
            // 
            this.txt_nombre_barrio.Location = new System.Drawing.Point(58, 44);
            this.txt_nombre_barrio.Name = "txt_nombre_barrio";
            this.txt_nombre_barrio.Pp_Campo = "nombre_razonSocial";
            this.txt_nombre_barrio.Pp_MensajeError = "Falta cargar el nombre del cliente";
            this.txt_nombre_barrio.Pp_Tabla = null;
            this.txt_nombre_barrio.Pp_Validable = false;
            this.txt_nombre_barrio.Size = new System.Drawing.Size(164, 20);
            this.txt_nombre_barrio.TabIndex = 21;
            // 
            // Frm_Alta_Barrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 129);
            this.Controls.Add(this.cmb_codigo_ciudad);
            this.Controls.Add(this.btn_cliente_alta_cancelar);
            this.Controls.Add(this.btn_cliente_alta_aceptar);
            this.Controls.Add(this.txt_nombre_barrio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Alta_Barrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Alta_Barrio";
            this.Load += new System.EventHandler(this.Frm_Alta_Barrio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cliente_alta_cancelar;
        private System.Windows.Forms.Button btn_cliente_alta_aceptar;
        private Clases.TextBox01 txt_nombre_barrio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Clases.ComboBox01 cmb_codigo_ciudad;
    }
}