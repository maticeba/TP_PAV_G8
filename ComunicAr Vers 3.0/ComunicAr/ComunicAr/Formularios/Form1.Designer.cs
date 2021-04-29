
namespace ComunicAr.Formularios
{
    partial class ServiciosContratados
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
            this.Cod_Nacional = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cod_Nacional
            // 
            this.Cod_Nacional.AutoSize = true;
            this.Cod_Nacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cod_Nacional.Location = new System.Drawing.Point(58, 61);
            this.Cod_Nacional.Name = "Cod_Nacional";
            this.Cod_Nacional.Size = new System.Drawing.Size(101, 15);
            this.Cod_Nacional.TabIndex = 0;
            this.Cod_Nacional.Text = "Codigo Nacional:";
            this.Cod_Nacional.Click += new System.EventHandler(this.label1_Click);
            // 
            // ServiciosContratados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cod_Nacional);
            this.Name = "ServiciosContratados";
            this.Text = "Servicios Contratados";
            this.Load += new System.EventHandler(this.ServiciosContratados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cod_Nacional;
    }
}