
namespace ComunicAr.Formularios.ABM_Servicios.Datos
{
    partial class Frm_Baja_Datos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tipo = new ComunicAr.Clases.TextBox01();
            this.textBox011 = new ComunicAr.Clases.TextBox01();
            this.txt_descripcion_B = new ComunicAr.Clases.TextBox01();
            this.txt_costoFijo_B = new ComunicAr.Clases.TextBox01();
            this.txt_recargo_B = new ComunicAr.Clases.TextBox01();
            this.txt_limite_B = new ComunicAr.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Tipo de Servicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Recargo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Costo Fijo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Limite de datos";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(209, 223);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 21;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(113, 223);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 20;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Bajas Servicios de Datos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Codigo";
            // 
            // txt_tipo
            // 
            this.txt_tipo.Enabled = false;
            this.txt_tipo.Location = new System.Drawing.Point(131, 187);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Pp_Campo = "limite_datos";
            this.txt_tipo.Pp_MensajeError = "Falta cargar el limite de datos";
            this.txt_tipo.Pp_Tabla = null;
            this.txt_tipo.Pp_Validable = false;
            this.txt_tipo.Size = new System.Drawing.Size(153, 20);
            this.txt_tipo.TabIndex = 31;
            // 
            // textBox011
            // 
            this.textBox011.Enabled = false;
            this.textBox011.Location = new System.Drawing.Point(131, 53);
            this.textBox011.Name = "textBox011";
            this.textBox011.Pp_Campo = "limite_datos";
            this.textBox011.Pp_MensajeError = "Falta cargar el limite de datos";
            this.textBox011.Pp_Tabla = null;
            this.textBox011.Pp_Validable = false;
            this.textBox011.Size = new System.Drawing.Size(153, 20);
            this.textBox011.TabIndex = 29;
            // 
            // txt_descripcion_B
            // 
            this.txt_descripcion_B.Enabled = false;
            this.txt_descripcion_B.Location = new System.Drawing.Point(131, 105);
            this.txt_descripcion_B.Name = "txt_descripcion_B";
            this.txt_descripcion_B.Pp_Campo = "descripcion";
            this.txt_descripcion_B.Pp_MensajeError = "Falta cargar la descripcion";
            this.txt_descripcion_B.Pp_Tabla = null;
            this.txt_descripcion_B.Pp_Validable = false;
            this.txt_descripcion_B.Size = new System.Drawing.Size(153, 20);
            this.txt_descripcion_B.TabIndex = 19;
            // 
            // txt_costoFijo_B
            // 
            this.txt_costoFijo_B.Enabled = false;
            this.txt_costoFijo_B.Location = new System.Drawing.Point(131, 131);
            this.txt_costoFijo_B.Name = "txt_costoFijo_B";
            this.txt_costoFijo_B.Pp_Campo = "costo_fijo";
            this.txt_costoFijo_B.Pp_MensajeError = "Falta cargar el costo fijo";
            this.txt_costoFijo_B.Pp_Tabla = null;
            this.txt_costoFijo_B.Pp_Validable = false;
            this.txt_costoFijo_B.Size = new System.Drawing.Size(153, 20);
            this.txt_costoFijo_B.TabIndex = 18;
            // 
            // txt_recargo_B
            // 
            this.txt_recargo_B.Enabled = false;
            this.txt_recargo_B.Location = new System.Drawing.Point(131, 157);
            this.txt_recargo_B.Name = "txt_recargo_B";
            this.txt_recargo_B.Pp_Campo = "recargo";
            this.txt_recargo_B.Pp_MensajeError = "Falta cargar el recargo";
            this.txt_recargo_B.Pp_Tabla = null;
            this.txt_recargo_B.Pp_Validable = false;
            this.txt_recargo_B.Size = new System.Drawing.Size(153, 20);
            this.txt_recargo_B.TabIndex = 17;
            // 
            // txt_limite_B
            // 
            this.txt_limite_B.Enabled = false;
            this.txt_limite_B.Location = new System.Drawing.Point(131, 79);
            this.txt_limite_B.Name = "txt_limite_B";
            this.txt_limite_B.Pp_Campo = "limite_datos";
            this.txt_limite_B.Pp_MensajeError = "Falta cargar el limite de datos";
            this.txt_limite_B.Pp_Tabla = null;
            this.txt_limite_B.Pp_Validable = false;
            this.txt_limite_B.Size = new System.Drawing.Size(153, 20);
            this.txt_limite_B.TabIndex = 16;
            // 
            // Frm_Baja_Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 267);
            this.Controls.Add(this.txt_tipo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox011);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.txt_descripcion_B);
            this.Controls.Add(this.txt_costoFijo_B);
            this.Controls.Add(this.txt_recargo_B);
            this.Controls.Add(this.txt_limite_B);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Baja_Datos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_Baja_Datos";
            this.Load += new System.EventHandler(this.Frm_Baja_Datos_Load);
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
        private Clases.TextBox01 txt_descripcion_B;
        private Clases.TextBox01 txt_costoFijo_B;
        private Clases.TextBox01 txt_recargo_B;
        private Clases.TextBox01 txt_limite_B;
        private System.Windows.Forms.Label label1;
        private Clases.TextBox01 textBox011;
        private System.Windows.Forms.Label label8;
        private Clases.TextBox01 txt_tipo;
    }
}