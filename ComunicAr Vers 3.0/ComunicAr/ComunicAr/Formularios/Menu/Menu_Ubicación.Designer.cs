
namespace ComunicAr.Formularios.Menu
{
    partial class Menu_Ubicacion
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
            this.btn_menu_ubicacion_barrio = new System.Windows.Forms.Button();
            this.btn_menu_ubicacion_ciudad = new System.Windows.Forms.Button();
            this.btn_menu_ubicacion_provincia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_menu_ubicacion_barrio
            // 
            this.btn_menu_ubicacion_barrio.Location = new System.Drawing.Point(12, 48);
            this.btn_menu_ubicacion_barrio.Name = "btn_menu_ubicacion_barrio";
            this.btn_menu_ubicacion_barrio.Size = new System.Drawing.Size(131, 27);
            this.btn_menu_ubicacion_barrio.TabIndex = 0;
            this.btn_menu_ubicacion_barrio.Text = "Barrio";
            this.btn_menu_ubicacion_barrio.UseVisualStyleBackColor = true;
            this.btn_menu_ubicacion_barrio.Click += new System.EventHandler(this.btn_menu_ubicacion_barrio_Click);
            // 
            // btn_menu_ubicacion_ciudad
            // 
            this.btn_menu_ubicacion_ciudad.Location = new System.Drawing.Point(12, 82);
            this.btn_menu_ubicacion_ciudad.Name = "btn_menu_ubicacion_ciudad";
            this.btn_menu_ubicacion_ciudad.Size = new System.Drawing.Size(131, 27);
            this.btn_menu_ubicacion_ciudad.TabIndex = 1;
            this.btn_menu_ubicacion_ciudad.Text = "Ciudad";
            this.btn_menu_ubicacion_ciudad.UseVisualStyleBackColor = true;
            this.btn_menu_ubicacion_ciudad.Click += new System.EventHandler(this.btn_menu_ubicacion_ciudad_Click);
            // 
            // btn_menu_ubicacion_provincia
            // 
            this.btn_menu_ubicacion_provincia.Location = new System.Drawing.Point(12, 115);
            this.btn_menu_ubicacion_provincia.Name = "btn_menu_ubicacion_provincia";
            this.btn_menu_ubicacion_provincia.Size = new System.Drawing.Size(131, 27);
            this.btn_menu_ubicacion_provincia.TabIndex = 2;
            this.btn_menu_ubicacion_provincia.Text = "Provincia";
            this.btn_menu_ubicacion_provincia.UseVisualStyleBackColor = true;
            this.btn_menu_ubicacion_provincia.Click += new System.EventHandler(this.btn_menu_ubicacion_provincia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ubicación";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu_Ubicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(158, 191);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_menu_ubicacion_provincia);
            this.Controls.Add(this.btn_menu_ubicacion_ciudad);
            this.Controls.Add(this.btn_menu_ubicacion_barrio);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu_Ubicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_menu_ubicacion_barrio;
        private System.Windows.Forms.Button btn_menu_ubicacion_ciudad;
        private System.Windows.Forms.Button btn_menu_ubicacion_provincia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}