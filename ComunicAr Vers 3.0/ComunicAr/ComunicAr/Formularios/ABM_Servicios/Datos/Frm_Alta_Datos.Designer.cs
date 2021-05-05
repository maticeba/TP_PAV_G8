
namespace ComunicAr.Formularios.ABM_Servicios.Datos
{
    partial class Frm_Alta_Datos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_limite = new ComunicAr.Clases.TextBox01();
            this.txt_recargo = new ComunicAr.Clases.TextBox01();
            this.txt_costoFijo = new ComunicAr.Clases.TextBox01();
            this.txt_descripcion = new ComunicAr.Clases.TextBox01();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Cod = new ComunicAr.Clases.TextBox01();
            this.txt_Tipo = new ComunicAr.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altas Servicios de Datos";
            // 
            // txt_limite
            // 
            this.txt_limite.Location = new System.Drawing.Point(131, 75);
            this.txt_limite.Name = "txt_limite";
            this.txt_limite.Pp_Campo = "limite_datos";
            this.txt_limite.Pp_MensajeError = "Falta cargar el limite de datos";
            this.txt_limite.Pp_Tabla = null;
            this.txt_limite.Pp_Validable = false;
            this.txt_limite.Size = new System.Drawing.Size(153, 20);
            this.txt_limite.TabIndex = 1;
            // 
            // txt_recargo
            // 
            this.txt_recargo.Location = new System.Drawing.Point(131, 153);
            this.txt_recargo.Name = "txt_recargo";
            this.txt_recargo.Pp_Campo = "recargo";
            this.txt_recargo.Pp_MensajeError = "Falta cargar el recargo";
            this.txt_recargo.Pp_Tabla = null;
            this.txt_recargo.Pp_Validable = false;
            this.txt_recargo.Size = new System.Drawing.Size(153, 20);
            this.txt_recargo.TabIndex = 3;
            // 
            // txt_costoFijo
            // 
            this.txt_costoFijo.Location = new System.Drawing.Point(131, 127);
            this.txt_costoFijo.Name = "txt_costoFijo";
            this.txt_costoFijo.Pp_Campo = "costo_fijo";
            this.txt_costoFijo.Pp_MensajeError = "Falta cargar el costo fijo";
            this.txt_costoFijo.Pp_Tabla = null;
            this.txt_costoFijo.Pp_Validable = false;
            this.txt_costoFijo.Size = new System.Drawing.Size(153, 20);
            this.txt_costoFijo.TabIndex = 4;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(131, 101);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Pp_Campo = "descripcion";
            this.txt_descripcion.Pp_MensajeError = "Falta cargar la descripcion";
            this.txt_descripcion.Pp_Tabla = null;
            this.txt_descripcion.Pp_Validable = false;
            this.txt_descripcion.Size = new System.Drawing.Size(153, 20);
            this.txt_descripcion.TabIndex = 5;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(113, 204);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 6;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_aceptar_datos);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(209, 204);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Limite de datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Costo Fijo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Recargo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tipo de Servicio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Codigo";
            // 
            // txt_Cod
            // 
            this.txt_Cod.Location = new System.Drawing.Point(131, 49);
            this.txt_Cod.Name = "txt_Cod";
            this.txt_Cod.Pp_Campo = "limite_datos";
            this.txt_Cod.Pp_MensajeError = "Falta cargar el limite de datos";
            this.txt_Cod.Pp_Tabla = null;
            this.txt_Cod.Pp_Validable = false;
            this.txt_Cod.Size = new System.Drawing.Size(153, 20);
            this.txt_Cod.TabIndex = 31;
            // 
            // txt_Tipo
            // 
            this.txt_Tipo.Location = new System.Drawing.Point(131, 178);
            this.txt_Tipo.Name = "txt_Tipo";
            this.txt_Tipo.Pp_Campo = null;
            this.txt_Tipo.Pp_MensajeError = null;
            this.txt_Tipo.Pp_Tabla = null;
            this.txt_Tipo.Pp_Validable = false;
            this.txt_Tipo.Size = new System.Drawing.Size(153, 20);
            this.txt_Tipo.TabIndex = 33;
            // 
            // Frm_Alta_Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 243);
            this.Controls.Add(this.txt_Tipo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Cod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_costoFijo);
            this.Controls.Add(this.txt_recargo);
            this.Controls.Add(this.txt_limite);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Alta_Datos";
            this.Text = "Frm_Alta_Datos";
            this.Load += new System.EventHandler(this.Frm_Alta_Datos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Clases.TextBox01 txt_limite;
        private Clases.TextBox01 txt_recargo;
        private Clases.TextBox01 txt_costoFijo;
        private Clases.TextBox01 txt_descripcion;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Clases.TextBox01 txt_Cod;
        private Clases.TextBox01 txt_Tipo;
    }
}