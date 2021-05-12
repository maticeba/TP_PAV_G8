
namespace ComunicAr.Formularios.ABM_Servicios.Datos
{
    partial class Frm_ABM_Datos_Modificar
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.txt_descripcion_M = new ComunicAr.Clases.TextBox01();
            this.txt_costoFijo_M = new ComunicAr.Clases.TextBox01();
            this.txt_recargo_M = new ComunicAr.Clases.TextBox01();
            this.txt_limite_M = new ComunicAr.Clases.TextBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Tipo = new ComunicAr.Clases.TextBox01();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Cod = new ComunicAr.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Tipo de Servicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Recargo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Costo Fijo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Limite de datos";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(211, 222);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 35;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(115, 222);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 34;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // txt_descripcion_M
            // 
            this.txt_descripcion_M.Location = new System.Drawing.Point(133, 96);
            this.txt_descripcion_M.Name = "txt_descripcion_M";
            this.txt_descripcion_M.Pp_Campo = "descripcion";
            this.txt_descripcion_M.Pp_MensajeError = "Falta cargar la descripcion";
            this.txt_descripcion_M.Pp_Tabla = null;
            this.txt_descripcion_M.Pp_Validable = false;
            this.txt_descripcion_M.Size = new System.Drawing.Size(153, 20);
            this.txt_descripcion_M.TabIndex = 33;
            // 
            // txt_costoFijo_M
            // 
            this.txt_costoFijo_M.Location = new System.Drawing.Point(133, 122);
            this.txt_costoFijo_M.Name = "txt_costoFijo_M";
            this.txt_costoFijo_M.Pp_Campo = "costo_fijo";
            this.txt_costoFijo_M.Pp_MensajeError = "Falta cargar el costo fijo";
            this.txt_costoFijo_M.Pp_Tabla = null;
            this.txt_costoFijo_M.Pp_Validable = false;
            this.txt_costoFijo_M.Size = new System.Drawing.Size(153, 20);
            this.txt_costoFijo_M.TabIndex = 32;
            // 
            // txt_recargo_M
            // 
            this.txt_recargo_M.Location = new System.Drawing.Point(133, 148);
            this.txt_recargo_M.Name = "txt_recargo_M";
            this.txt_recargo_M.Pp_Campo = "recargo";
            this.txt_recargo_M.Pp_MensajeError = "Falta cargar el recargo";
            this.txt_recargo_M.Pp_Tabla = null;
            this.txt_recargo_M.Pp_Validable = false;
            this.txt_recargo_M.Size = new System.Drawing.Size(153, 20);
            this.txt_recargo_M.TabIndex = 31;
            // 
            // txt_limite_M
            // 
            this.txt_limite_M.Location = new System.Drawing.Point(133, 70);
            this.txt_limite_M.Name = "txt_limite_M";
            this.txt_limite_M.Pp_Campo = "limite_datos";
            this.txt_limite_M.Pp_MensajeError = "Falta cargar el limite de datos";
            this.txt_limite_M.Pp_Tabla = null;
            this.txt_limite_M.Pp_Validable = false;
            this.txt_limite_M.Size = new System.Drawing.Size(153, 20);
            this.txt_limite_M.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Modificar Servicios de Datos";
            // 
            // txt_Tipo
            // 
            this.txt_Tipo.Location = new System.Drawing.Point(133, 174);
            this.txt_Tipo.Name = "txt_Tipo";
            this.txt_Tipo.Pp_Campo = null;
            this.txt_Tipo.Pp_MensajeError = null;
            this.txt_Tipo.Pp_Tabla = null;
            this.txt_Tipo.Pp_Validable = false;
            this.txt_Tipo.Size = new System.Drawing.Size(153, 20);
            this.txt_Tipo.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Codigo";
            // 
            // txt_Cod
            // 
            this.txt_Cod.Enabled = false;
            this.txt_Cod.Location = new System.Drawing.Point(133, 44);
            this.txt_Cod.Name = "txt_Cod";
            this.txt_Cod.Pp_Campo = "limite_datos";
            this.txt_Cod.Pp_MensajeError = "Falta cargar el limite de datos";
            this.txt_Cod.Pp_Tabla = null;
            this.txt_Cod.Pp_Validable = false;
            this.txt_Cod.Size = new System.Drawing.Size(153, 20);
            this.txt_Cod.TabIndex = 43;
            // 
            // Frm_ABM_Datos_Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 257);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Cod);
            this.Controls.Add(this.txt_Tipo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.txt_descripcion_M);
            this.Controls.Add(this.txt_costoFijo_M);
            this.Controls.Add(this.txt_recargo_M);
            this.Controls.Add(this.txt_limite_M);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ABM_Datos_Modificar";
            this.Text = "Frm_ABM_Datos_Modificar";
            this.Load += new System.EventHandler(this.Frm_ABM_Datos_Modificar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Aceptar;
        private Clases.TextBox01 txt_descripcion_M;
        private Clases.TextBox01 txt_costoFijo_M;
        private Clases.TextBox01 txt_recargo_M;
        private Clases.TextBox01 txt_limite_M;
        private System.Windows.Forms.Label label1;
        private Clases.TextBox01 txt_Tipo;
        private System.Windows.Forms.Label label8;
        private Clases.TextBox01 txt_Cod;
    }
}