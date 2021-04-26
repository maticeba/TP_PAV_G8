
namespace ComunicAR.Formularios.ABM_Clientes
{
    partial class Form_Altas_Clientes
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Barrio = new System.Windows.Forms.ComboBox();
            this.textBox11 = new ComunicAR.Clases.TextBox1();
            this.textBox12 = new ComunicAR.Clases.TextBox1();
            this.textBox13 = new ComunicAR.Clases.TextBox1();
            this.textBox14 = new ComunicAR.Clases.TextBox1();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altas Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre/Razon Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Calle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Piso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Barrio";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cb_Barrio
            // 
            this.cb_Barrio.FormattingEnabled = true;
            this.cb_Barrio.Location = new System.Drawing.Point(140, 208);
            this.cb_Barrio.Name = "cb_Barrio";
            this.cb_Barrio.Size = new System.Drawing.Size(171, 23);
            this.cb_Barrio.TabIndex = 6;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(140, 54);
            this.textBox11.Name = "textBox11";
            this.textBox11.Pp_Campo = null;
            this.textBox11.Pp_MensajeError = "Falta cargar el nombre";
            this.textBox11.Pp_Tabla = null;
            this.textBox11.Pp_Validable = true;
            this.textBox11.Size = new System.Drawing.Size(171, 23);
            this.textBox11.TabIndex = 7;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(140, 170);
            this.textBox12.Name = "textBox12";
            this.textBox12.Pp_Campo = null;
            this.textBox12.Pp_MensajeError = "Falta cargar el piso";
            this.textBox12.Pp_Tabla = null;
            this.textBox12.Pp_Validable = true;
            this.textBox12.Size = new System.Drawing.Size(171, 23);
            this.textBox12.TabIndex = 8;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(140, 131);
            this.textBox13.Name = "textBox13";
            this.textBox13.Pp_Campo = null;
            this.textBox13.Pp_MensajeError = "Falta cargar el numero de calle";
            this.textBox13.Pp_Tabla = null;
            this.textBox13.Pp_Validable = true;
            this.textBox13.Size = new System.Drawing.Size(171, 23);
            this.textBox13.TabIndex = 9;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(140, 91);
            this.textBox14.Name = "textBox14";
            this.textBox14.Pp_Campo = null;
            this.textBox14.Pp_MensajeError = "Falta cargar la calle";
            this.textBox14.Pp_Tabla = null;
            this.textBox14.Pp_Validable = true;
            this.textBox14.Size = new System.Drawing.Size(171, 23);
            this.textBox14.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_Altas_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 294);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.cb_Barrio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Altas_Clientes";
            this.Text = "Form_Altas_Clientes";
            this.Load += new System.EventHandler(this.Form_Altas_Clientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Clases.ComboBox1 comboBox11;
        private System.Windows.Forms.ComboBox cb_Barrio;
        private Clases.TextBox1 textBox11;
        private Clases.TextBox1 textBox12;
        private Clases.TextBox1 textBox13;
        private Clases.TextBox1 textBox14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}