
namespace ComunicAr.Formularios
{
    partial class Frm_Menu
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
            this.btn_emitir_factura = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.cmb_Gen_Estad = new ComunicAr.Clases.ComboBox01();
            this.cmb_Gen_Listas = new ComunicAr.Clases.ComboBox01();
            this.cmb_Actual_Datos = new ComunicAr.Clases.ComboBox01();
            this.SuspendLayout();
            // 
            // btn_emitir_factura
            // 
            this.btn_emitir_factura.Location = new System.Drawing.Point(12, 168);
            this.btn_emitir_factura.Name = "btn_emitir_factura";
            this.btn_emitir_factura.Size = new System.Drawing.Size(203, 30);
            this.btn_emitir_factura.TabIndex = 3;
            this.btn_emitir_factura.Text = "Emitir Factura";
            this.btn_emitir_factura.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(12, 208);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(203, 30);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // cmb_Gen_Estad
            // 
            this.cmb_Gen_Estad.FormattingEnabled = true;
            this.cmb_Gen_Estad.Location = new System.Drawing.Point(12, 117);
            this.cmb_Gen_Estad.Name = "cmb_Gen_Estad";
            this.cmb_Gen_Estad.Pp_Conseleccion = false;
            this.cmb_Gen_Estad.Pp_Descripcion = null;
            this.cmb_Gen_Estad.Pp_MensajeError = null;
            this.cmb_Gen_Estad.Pp_NombreCampo = null;
            this.cmb_Gen_Estad.Pp_NombreTabla = null;
            this.cmb_Gen_Estad.Pp_PK = null;
            this.cmb_Gen_Estad.Pp_Tabla = null;
            this.cmb_Gen_Estad.Pp_Validable = false;
            this.cmb_Gen_Estad.Size = new System.Drawing.Size(203, 23);
            this.cmb_Gen_Estad.TabIndex = 2;
            this.cmb_Gen_Estad.Text = "Generar Estadísticas";
            // 
            // cmb_Gen_Listas
            // 
            this.cmb_Gen_Listas.FormattingEnabled = true;
            this.cmb_Gen_Listas.Location = new System.Drawing.Point(12, 68);
            this.cmb_Gen_Listas.Name = "cmb_Gen_Listas";
            this.cmb_Gen_Listas.Pp_Conseleccion = false;
            this.cmb_Gen_Listas.Pp_Descripcion = null;
            this.cmb_Gen_Listas.Pp_MensajeError = null;
            this.cmb_Gen_Listas.Pp_NombreCampo = null;
            this.cmb_Gen_Listas.Pp_NombreTabla = null;
            this.cmb_Gen_Listas.Pp_PK = null;
            this.cmb_Gen_Listas.Pp_Tabla = null;
            this.cmb_Gen_Listas.Pp_Validable = false;
            this.cmb_Gen_Listas.Size = new System.Drawing.Size(203, 23);
            this.cmb_Gen_Listas.TabIndex = 1;
            this.cmb_Gen_Listas.Text = "Generar Listas";
            // 
            // cmb_Actual_Datos
            // 
            this.cmb_Actual_Datos.FormattingEnabled = true;
            this.cmb_Actual_Datos.Items.AddRange(new object[] {
            "Clientes",
            "Números",
            "Llamadas",
            "Dispositivos",
            "Servicios Contratados",
            "Servicios Prepago",
            "Servicios Fijos",
            "Servicios Datos",
            "Barrio",
            "Ciudad",
            "Provincia"});
            this.cmb_Actual_Datos.Location = new System.Drawing.Point(12, 24);
            this.cmb_Actual_Datos.Name = "cmb_Actual_Datos";
            this.cmb_Actual_Datos.Pp_Conseleccion = false;
            this.cmb_Actual_Datos.Pp_Descripcion = null;
            this.cmb_Actual_Datos.Pp_MensajeError = null;
            this.cmb_Actual_Datos.Pp_NombreCampo = null;
            this.cmb_Actual_Datos.Pp_NombreTabla = null;
            this.cmb_Actual_Datos.Pp_PK = null;
            this.cmb_Actual_Datos.Pp_Tabla = null;
            this.cmb_Actual_Datos.Pp_Validable = false;
            this.cmb_Actual_Datos.Size = new System.Drawing.Size(203, 23);
            this.cmb_Actual_Datos.TabIndex = 0;
            this.cmb_Actual_Datos.Text = "Actualizar Datos";
            this.cmb_Actual_Datos.SelectedValueChanged += new System.EventHandler(this.cmb_Actual_Datos_SelectedValueChanged);
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 246);
            this.ControlBox = false;
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_emitir_factura);
            this.Controls.Add(this.cmb_Gen_Estad);
            this.Controls.Add(this.cmb_Gen_Listas);
            this.Controls.Add(this.cmb_Actual_Datos);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Clases.ComboBox01 cmb_Actual_Datos;
        private Clases.ComboBox01 cmb_Gen_Listas;
        private Clases.ComboBox01 cmb_Gen_Estad;
        private System.Windows.Forms.Button btn_emitir_factura;
        private System.Windows.Forms.Button btn_salir;
    }
}