
namespace ComunicAr.Formularios.ABM_Numeros
{
    partial class Frm_Mod_Numero
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
            this.cmb_nro_cliente = new ComunicAr.Clases.ComboBox01();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txt_nro_telefono = new ComunicAr.Clases.TextBox01();
            this.txt_cod_area = new ComunicAr.Clases.TextBox01();
            this.txt_cod_nacional = new ComunicAr.Clases.TextBox01();
            this.cmb_id_disp = new ComunicAr.Clases.ComboBox01();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_nro_cliente
            // 
            this.cmb_nro_cliente.FormattingEnabled = true;
            this.cmb_nro_cliente.Location = new System.Drawing.Point(126, 136);
            this.cmb_nro_cliente.Name = "cmb_nro_cliente";
            this.cmb_nro_cliente.Pp_Conseleccion = false;
            this.cmb_nro_cliente.Pp_Descripcion = "nombre_razonSocial";
            this.cmb_nro_cliente.Pp_MensajeError = null;
            this.cmb_nro_cliente.Pp_NombreCampo = null;
            this.cmb_nro_cliente.Pp_NombreTabla = "";
            this.cmb_nro_cliente.Pp_PK = "nro_cliente";
            this.cmb_nro_cliente.Pp_Tabla = "clientes";
            this.cmb_nro_cliente.Pp_Validable = true;
            this.cmb_nro_cliente.Size = new System.Drawing.Size(164, 21);
            this.cmb_nro_cliente.TabIndex = 45;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(180, 194);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 44;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(57, 194);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 43;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txt_nro_telefono
            // 
            this.txt_nro_telefono.Location = new System.Drawing.Point(126, 107);
            this.txt_nro_telefono.Name = "txt_nro_telefono";
            this.txt_nro_telefono.Pp_Campo = "nro";
            this.txt_nro_telefono.Pp_MensajeError = "Falta cargar el número de la calle";
            this.txt_nro_telefono.Pp_Tabla = null;
            this.txt_nro_telefono.Pp_Validable = false;
            this.txt_nro_telefono.Size = new System.Drawing.Size(164, 20);
            this.txt_nro_telefono.TabIndex = 42;
            // 
            // txt_cod_area
            // 
            this.txt_cod_area.Location = new System.Drawing.Point(126, 78);
            this.txt_cod_area.Name = "txt_cod_area";
            this.txt_cod_area.Pp_Campo = "calle";
            this.txt_cod_area.Pp_MensajeError = "Falta cargar la calle del cliente";
            this.txt_cod_area.Pp_Tabla = null;
            this.txt_cod_area.Pp_Validable = false;
            this.txt_cod_area.Size = new System.Drawing.Size(164, 20);
            this.txt_cod_area.TabIndex = 41;
            // 
            // txt_cod_nacional
            // 
            this.txt_cod_nacional.Location = new System.Drawing.Point(126, 49);
            this.txt_cod_nacional.Name = "txt_cod_nacional";
            this.txt_cod_nacional.Pp_Campo = "nombre_razonSocial";
            this.txt_cod_nacional.Pp_MensajeError = "Falta cargar el nombre del cliente";
            this.txt_cod_nacional.Pp_Tabla = null;
            this.txt_cod_nacional.Pp_Validable = false;
            this.txt_cod_nacional.Size = new System.Drawing.Size(164, 20);
            this.txt_cod_nacional.TabIndex = 40;
            // 
            // cmb_id_disp
            // 
            this.cmb_id_disp.FormattingEnabled = true;
            this.cmb_id_disp.Location = new System.Drawing.Point(126, 165);
            this.cmb_id_disp.Name = "cmb_id_disp";
            this.cmb_id_disp.Pp_Conseleccion = false;
            this.cmb_id_disp.Pp_Descripcion = "id_dispositivo";
            this.cmb_id_disp.Pp_MensajeError = null;
            this.cmb_id_disp.Pp_NombreCampo = null;
            this.cmb_id_disp.Pp_NombreTabla = "";
            this.cmb_id_disp.Pp_PK = "id_dispositivo";
            this.cmb_id_disp.Pp_Tabla = "dispositivos";
            this.cmb_id_disp.Pp_Validable = true;
            this.cmb_id_disp.Size = new System.Drawing.Size(164, 21);
            this.cmb_id_disp.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Id dispositivo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Numero Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Nro telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Codigo area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Codigo nacional";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "Modificar Numeros";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_Mod_Numero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 238);
            this.Controls.Add(this.cmb_nro_cliente);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_nro_telefono);
            this.Controls.Add(this.txt_cod_area);
            this.Controls.Add(this.txt_cod_nacional);
            this.Controls.Add(this.cmb_id_disp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Mod_Numero";
            this.Text = "Frm_Mod_Numero";
            this.Load += new System.EventHandler(this.Frm_Mod_Numero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.ComboBox01 cmb_nro_cliente;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private Clases.TextBox01 txt_nro_telefono;
        private Clases.TextBox01 txt_cod_area;
        private Clases.TextBox01 txt_cod_nacional;
        private Clases.ComboBox01 cmb_id_disp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}