
namespace ComunicAr.Formularios.ABM_Ciudad
{
    partial class Frm_Alta_Ciudad
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.txt_Nom_Ciud = new ComunicAr.Clases.TextBox01();
            this.cmb_alta_ciudad = new ComunicAr.Clases.ComboBox01();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altas Ciudades";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre Ciudad";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(131, 102);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(69, 23);
            this.btn_Cancelar.TabIndex = 5;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(39, 102);
            this.btn_Aceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(69, 23);
            this.btn_Aceptar.TabIndex = 5;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // txt_Nom_Ciud
            // 
            this.txt_Nom_Ciud.Location = new System.Drawing.Point(111, 47);
            this.txt_Nom_Ciud.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Nom_Ciud.Name = "txt_Nom_Ciud";
            this.txt_Nom_Ciud.Pp_Campo = null;
            this.txt_Nom_Ciud.Pp_MensajeError = "Falta el nombre de Ciudad.";
            this.txt_Nom_Ciud.Pp_Tabla = null;
            this.txt_Nom_Ciud.Pp_Validable = false;
            this.txt_Nom_Ciud.Size = new System.Drawing.Size(121, 20);
            this.txt_Nom_Ciud.TabIndex = 2;
            this.txt_Nom_Ciud.TextChanged += new System.EventHandler(this.txt_Nom_Ciud_TextChanged);
            // 
            // cmb_alta_ciudad
            // 
            this.cmb_alta_ciudad.FormattingEnabled = true;
            this.cmb_alta_ciudad.Location = new System.Drawing.Point(111, 71);
            this.cmb_alta_ciudad.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_alta_ciudad.Name = "cmb_alta_ciudad";
            this.cmb_alta_ciudad.Pp_Conseleccion = false;
            this.cmb_alta_ciudad.Pp_Descripcion = "nombre_prov";
            this.cmb_alta_ciudad.Pp_MensajeError = "Falta el codigo de Provincia.";
            this.cmb_alta_ciudad.Pp_NombreCampo = null;
            this.cmb_alta_ciudad.Pp_NombreTabla = null;
            this.cmb_alta_ciudad.Pp_PK = "cod_prov";
            this.cmb_alta_ciudad.Pp_Tabla = "Provincia";
            this.cmb_alta_ciudad.Pp_Validable = false;
            this.cmb_alta_ciudad.Size = new System.Drawing.Size(121, 21);
            this.cmb_alta_ciudad.TabIndex = 6;
            this.cmb_alta_ciudad.SelectedIndexChanged += new System.EventHandler(this.cmb_alta_ciudad_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Codigo de Provincia";
            // 
            // Frm_Alta_Ciudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 136);
            this.Controls.Add(this.cmb_alta_ciudad);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Nom_Ciud);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Alta_Ciudad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Ciudades";
            this.Load += new System.EventHandler(this.Frm_Alta_Ciudad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Clases.TextBox01 txt_Nom_Ciud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Aceptar;
        private Clases.ComboBox01 cmb_alta_ciudad;
        private System.Windows.Forms.Label label4;
    }
}