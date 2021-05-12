
namespace ComunicAr.Formularios.ABM_Ciudad
{
    partial class Frm_Mod_Ciudad
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
            this.txt_cod_ciud = new ComunicAr.Clases.TextBox01();
            this.txt_nom_ciud = new ComunicAr.Clases.TextBox01();
            this.txt_cod_prov = new ComunicAr.Clases.TextBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modificar Ciudad";
            // 
            // txt_cod_ciud
            // 
            this.txt_cod_ciud.Location = new System.Drawing.Point(172, 64);
            this.txt_cod_ciud.Name = "txt_cod_ciud";
            this.txt_cod_ciud.Pp_Campo = null;
            this.txt_cod_ciud.Pp_MensajeError = null;
            this.txt_cod_ciud.Pp_Tabla = null;
            this.txt_cod_ciud.Pp_Validable = false;
            this.txt_cod_ciud.Size = new System.Drawing.Size(140, 26);
            this.txt_cod_ciud.TabIndex = 2;
            // 
            // txt_nom_ciud
            // 
            this.txt_nom_ciud.Location = new System.Drawing.Point(172, 96);
            this.txt_nom_ciud.Name = "txt_nom_ciud";
            this.txt_nom_ciud.Pp_Campo = null;
            this.txt_nom_ciud.Pp_MensajeError = null;
            this.txt_nom_ciud.Pp_Tabla = null;
            this.txt_nom_ciud.Pp_Validable = false;
            this.txt_nom_ciud.Size = new System.Drawing.Size(140, 26);
            this.txt_nom_ciud.TabIndex = 2;
            // 
            // txt_cod_prov
            // 
            this.txt_cod_prov.Enabled = false;
            this.txt_cod_prov.Location = new System.Drawing.Point(170, 128);
            this.txt_cod_prov.Name = "txt_cod_prov";
            this.txt_cod_prov.Pp_Campo = null;
            this.txt_cod_prov.Pp_MensajeError = "Cargar codigo de Provincia";
            this.txt_cod_prov.Pp_Tabla = null;
            this.txt_cod_prov.Pp_Validable = false;
            this.txt_cod_prov.Size = new System.Drawing.Size(142, 26);
            this.txt_cod_prov.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo de Provincia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Codigo de Ciudad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre de Ciudad";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(200, 179);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(97, 34);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(20, 179);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(87, 32);
            this.btn_aceptar.TabIndex = 4;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // Frm_Mod_Ciudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 225);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cod_prov);
            this.Controls.Add(this.txt_nom_ciud);
            this.Controls.Add(this.txt_cod_ciud);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Mod_Ciudad";
            this.Text = "Frm_Mod_Ciudad";
            this.Load += new System.EventHandler(this.Frm_Mod_Ciudad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Clases.TextBox01 txt_cod_ciud;
        private Clases.TextBox01 txt_nom_ciud;
        private Clases.TextBox01 txt_cod_prov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
    }
}