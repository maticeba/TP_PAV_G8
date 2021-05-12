
namespace ComunicAr.Formularios.ABM_Provincia
{
    partial class Frm_Mod_Provincia
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nom_prov = new ComunicAr.Clases.TextBox01();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_cod_prov = new ComunicAr.Clases.ComboBox01();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modificar Provincias";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre de Provincia";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_nom_prov
            // 
            this.txt_nom_prov.Location = new System.Drawing.Point(117, 73);
            this.txt_nom_prov.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nom_prov.Name = "txt_nom_prov";
            this.txt_nom_prov.Pp_Campo = null;
            this.txt_nom_prov.Pp_MensajeError = null;
            this.txt_nom_prov.Pp_Tabla = null;
            this.txt_nom_prov.Pp_Validable = false;
            this.txt_nom_prov.Size = new System.Drawing.Size(128, 20);
            this.txt_nom_prov.TabIndex = 6;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(38, 109);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 21);
            this.btn_aceptar.TabIndex = 7;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(141, 109);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 21);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Codigo Provincia";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmb_cod_prov
            // 
            this.cmb_cod_prov.Enabled = false;
            this.cmb_cod_prov.FormattingEnabled = true;
            this.cmb_cod_prov.Location = new System.Drawing.Point(117, 46);
            this.cmb_cod_prov.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_cod_prov.Name = "cmb_cod_prov";
            this.cmb_cod_prov.Pp_Conseleccion = false;
            this.cmb_cod_prov.Pp_Descripcion = "cod_prov";
            this.cmb_cod_prov.Pp_MensajeError = null;
            this.cmb_cod_prov.Pp_NombreCampo = null;
            this.cmb_cod_prov.Pp_NombreTabla = null;
            this.cmb_cod_prov.Pp_PK = "cod_prov";
            this.cmb_cod_prov.Pp_Tabla = "provincias";
            this.cmb_cod_prov.Pp_Validable = false;
            this.cmb_cod_prov.Size = new System.Drawing.Size(127, 21);
            this.cmb_cod_prov.TabIndex = 8;
            this.cmb_cod_prov.SelectedIndexChanged += new System.EventHandler(this.cmb_cod_prov_SelectedIndexChanged);
            // 
            // Frm_Mod_Provincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 141);
            this.Controls.Add(this.cmb_cod_prov);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_nom_prov);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Mod_Provincia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Mod_Provincia";
            this.Load += new System.EventHandler(this.Frm_Mod_Provincia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Clases.TextBox01 txt_nom_prov;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label3;
        private Clases.ComboBox01 cmb_cod_prov;
    }
}