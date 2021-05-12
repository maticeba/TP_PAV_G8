
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
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_descripcion = new ComunicAr.Clases.TextBox01();
            this.txt_costoFijo = new ComunicAr.Clases.TextBox01();
            this.txt_limite = new ComunicAr.Clases.TextBox01();
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
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(86, 121);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 4;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_aceptar_datos);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(182, 121);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 5;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Limite de datos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Costo Fijo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 12;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(104, 44);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Pp_Campo = "descripcion";
            this.txt_descripcion.Pp_MensajeError = "Falta cargar la descripcion";
            this.txt_descripcion.Pp_Tabla = null;
            this.txt_descripcion.Pp_Validable = false;
            this.txt_descripcion.Size = new System.Drawing.Size(153, 20);
            this.txt_descripcion.TabIndex = 2;
            // 
            // txt_costoFijo
            // 
            this.txt_costoFijo.Location = new System.Drawing.Point(104, 95);
            this.txt_costoFijo.Name = "txt_costoFijo";
            this.txt_costoFijo.Pp_Campo = "costo_fijo";
            this.txt_costoFijo.Pp_MensajeError = "Falta cargar el costo fijo";
            this.txt_costoFijo.Pp_Tabla = null;
            this.txt_costoFijo.Pp_Validable = false;
            this.txt_costoFijo.Size = new System.Drawing.Size(153, 20);
            this.txt_costoFijo.TabIndex = 3;
            // 
            // txt_limite
            // 
            this.txt_limite.Location = new System.Drawing.Point(104, 70);
            this.txt_limite.Name = "txt_limite";
            this.txt_limite.Pp_Campo = "limite_datos";
            this.txt_limite.Pp_MensajeError = "Falta cargar el limite de datos";
            this.txt_limite.Pp_Tabla = null;
            this.txt_limite.Pp_Validable = false;
            this.txt_limite.Size = new System.Drawing.Size(153, 20);
            this.txt_limite.TabIndex = 1;
            // 
            // Frm_Alta_Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 164);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_costoFijo);
            this.Controls.Add(this.txt_limite);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Alta_Datos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Alta_Datos";
            this.Load += new System.EventHandler(this.Frm_Alta_Datos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Clases.TextBox01 txt_limite;
        private Clases.TextBox01 txt_costoFijo;
        private Clases.TextBox01 txt_descripcion;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}