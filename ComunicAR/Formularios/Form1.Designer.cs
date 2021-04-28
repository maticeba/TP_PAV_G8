
namespace ComunicAR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox021 = new ComunicAR.Clases.ComboBox02();
            this.SuspendLayout();
            // 
            // comboBox021
            // 
            this.comboBox021.FormattingEnabled = true;
            this.comboBox021.Location = new System.Drawing.Point(155, 79);
            this.comboBox021.Name = "comboBox021";
            this.comboBox021.Pp_Conseleccion = false;
            this.comboBox021.Pp_Descripcion = null;
            this.comboBox021.Pp_MensajeError = null;
            this.comboBox021.Pp_NombreCampo = null;
            this.comboBox021.Pp_NombreTabla = null;
            this.comboBox021.Pp_PK = null;
            this.comboBox021.Pp_Tabla = null;
            this.comboBox021.Pp_Validable = false;
            this.comboBox021.Size = new System.Drawing.Size(121, 23);
            this.comboBox021.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox021);
            this.Name = "Form1";
            this.Text = "ComunicAR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Clases.ComboBox02 comboBox021;
    }
}

