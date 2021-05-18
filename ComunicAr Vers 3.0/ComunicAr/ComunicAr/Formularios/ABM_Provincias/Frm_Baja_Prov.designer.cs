
namespace ComunicAr.Formularios.ABM_Provincia
{
    partial class Frm_Baja_Prov
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
            this.cmb_baja_prov = new ComunicAr.Clases.ComboBox01();
            this.txt_nom_prov = new ComunicAr.Clases.TextBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Borrar Provincia";
            // 
            // cmb_baja_prov
            // 
            this.cmb_baja_prov.Enabled = false;
            this.cmb_baja_prov.FormattingEnabled = true;
            this.cmb_baja_prov.Location = new System.Drawing.Point(121, 49);
            this.cmb_baja_prov.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_baja_prov.Name = "cmb_baja_prov";
            this.cmb_baja_prov.Pp_Conseleccion = false;
            this.cmb_baja_prov.Pp_Descripcion = "cod_prov";
            this.cmb_baja_prov.Pp_MensajeError = null;
            this.cmb_baja_prov.Pp_NombreCampo = null;
            this.cmb_baja_prov.Pp_NombreTabla = null;
            this.cmb_baja_prov.Pp_PK = "cod_prov";
            this.cmb_baja_prov.Pp_Tabla = "provincia";
            this.cmb_baja_prov.Pp_Validable = false;
            this.cmb_baja_prov.Size = new System.Drawing.Size(107, 21);
            this.cmb_baja_prov.TabIndex = 2;
            // 
            // txt_nom_prov
            // 
            this.txt_nom_prov.Enabled = false;
            this.txt_nom_prov.Location = new System.Drawing.Point(121, 77);
            this.txt_nom_prov.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nom_prov.Name = "txt_nom_prov";
            this.txt_nom_prov.Pp_Campo = null;
            this.txt_nom_prov.Pp_MensajeError = null;
            this.txt_nom_prov.Pp_Tabla = null;
            this.txt_nom_prov.Pp_Validable = false;
            this.txt_nom_prov.Size = new System.Drawing.Size(107, 20);
            this.txt_nom_prov.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codigo de Provincia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre de Provincia";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(43, 100);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(70, 21);
            this.btn_aceptar.TabIndex = 5;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(140, 100);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(70, 21);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Frm_Baja_Prov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 132);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nom_prov);
            this.Controls.Add(this.cmb_baja_prov);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Baja_Prov";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Baja_Prov";
            this.Load += new System.EventHandler(this.Frm_Baja_Prov_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Clases.ComboBox01 cmb_baja_prov;
        private Clases.TextBox01 txt_nom_prov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}