
namespace ComunicAr.Formularios.Transaccion.Generar_Venta
{
    partial class Frm_Generar_Venta
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
            this.txt_Venta_Cliente = new ComunicAr.Clases.TextBox01();
            this.textBox011 = new ComunicAr.Clases.TextBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox012 = new ComunicAr.Clases.ComboBox01();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox013 = new ComunicAr.Clases.ComboBox01();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox012 = new ComunicAr.Clases.TextBox01();
            this.comboBox014 = new ComunicAr.Clases.ComboBox01();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox021 = new ComunicAr.Clases.ComboBox02();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Cliente";
            // 
            // txt_Venta_Cliente
            // 
            this.txt_Venta_Cliente.Location = new System.Drawing.Point(152, 17);
            this.txt_Venta_Cliente.Name = "txt_Venta_Cliente";
            this.txt_Venta_Cliente.Pp_Campo = null;
            this.txt_Venta_Cliente.Pp_MensajeError = null;
            this.txt_Venta_Cliente.Pp_Tabla = null;
            this.txt_Venta_Cliente.Pp_Validable = false;
            this.txt_Venta_Cliente.Size = new System.Drawing.Size(134, 26);
            this.txt_Venta_Cliente.TabIndex = 2;
            // 
            // textBox011
            // 
            this.textBox011.Enabled = false;
            this.textBox011.Location = new System.Drawing.Point(152, 49);
            this.textBox011.Name = "textBox011";
            this.textBox011.Pp_Campo = null;
            this.textBox011.Pp_MensajeError = null;
            this.textBox011.Pp_Tabla = null;
            this.textBox011.Pp_Validable = false;
            this.textBox011.Size = new System.Drawing.Size(134, 26);
            this.textBox011.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "nro tel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "crear nuevo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox012
            // 
            this.comboBox012.FormattingEnabled = true;
            this.comboBox012.Location = new System.Drawing.Point(152, 116);
            this.comboBox012.Name = "comboBox012";
            this.comboBox012.Pp_Conseleccion = false;
            this.comboBox012.Pp_Descripcion = null;
            this.comboBox012.Pp_MensajeError = null;
            this.comboBox012.Pp_NombreCampo = null;
            this.comboBox012.Pp_NombreTabla = null;
            this.comboBox012.Pp_PK = null;
            this.comboBox012.Pp_Tabla = null;
            this.comboBox012.Pp_Validable = false;
            this.comboBox012.Size = new System.Drawing.Size(134, 28);
            this.comboBox012.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "tipo disp";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(490, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "disp";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox013
            // 
            this.comboBox013.FormattingEnabled = true;
            this.comboBox013.Location = new System.Drawing.Point(152, 150);
            this.comboBox013.Name = "comboBox013";
            this.comboBox013.Pp_Conseleccion = false;
            this.comboBox013.Pp_Descripcion = null;
            this.comboBox013.Pp_MensajeError = null;
            this.comboBox013.Pp_NombreCampo = null;
            this.comboBox013.Pp_NombreTabla = null;
            this.comboBox013.Pp_PK = null;
            this.comboBox013.Pp_Tabla = null;
            this.comboBox013.Pp_Validable = false;
            this.comboBox013.Size = new System.Drawing.Size(134, 28);
            this.comboBox013.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "prec";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox012
            // 
            this.textBox012.Location = new System.Drawing.Point(152, 184);
            this.textBox012.Name = "textBox012";
            this.textBox012.Pp_Campo = null;
            this.textBox012.Pp_MensajeError = null;
            this.textBox012.Pp_Tabla = null;
            this.textBox012.Pp_Validable = false;
            this.textBox012.Size = new System.Drawing.Size(134, 26);
            this.textBox012.TabIndex = 14;
            // 
            // comboBox014
            // 
            this.comboBox014.FormattingEnabled = true;
            this.comboBox014.Location = new System.Drawing.Point(152, 216);
            this.comboBox014.Name = "comboBox014";
            this.comboBox014.Pp_Conseleccion = false;
            this.comboBox014.Pp_Descripcion = null;
            this.comboBox014.Pp_MensajeError = null;
            this.comboBox014.Pp_NombreCampo = null;
            this.comboBox014.Pp_NombreTabla = null;
            this.comboBox014.Pp_PK = null;
            this.comboBox014.Pp_Tabla = null;
            this.comboBox014.Pp_Validable = false;
            this.comboBox014.Size = new System.Drawing.Size(134, 28);
            this.comboBox014.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "cant cuota";
            this.label7.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox021
            // 
            this.comboBox021.Enable = false;
            this.comboBox021.FormattingEnabled = true;
            this.comboBox021.Location = new System.Drawing.Point(152, 82);
            this.comboBox021.Name = "comboBox021";
            this.comboBox021.Pp_Conseleccion = false;
            this.comboBox021.Pp_Descripcion1 = null;
            this.comboBox021.Pp_Descripcion2 = null;
            this.comboBox021.Pp_Descripcion3 = null;
            this.comboBox021.Pp_MensajeError = null;
            this.comboBox021.Pp_NombreCampo = null;
            this.comboBox021.Pp_NombreTabla = null;
            this.comboBox021.Pp_PK1 = null;
            this.comboBox021.Pp_Tabla = null;
            this.comboBox021.Pp_Validable = false;
            this.comboBox021.Size = new System.Drawing.Size(134, 28);
            this.comboBox021.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(37, 276);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 44);
            this.button3.TabIndex = 17;
            this.button3.Text = "Aceptar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(482, 276);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 44);
            this.button4.TabIndex = 18;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(327, 12);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(97, 36);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // Frm_Generar_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 350);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox021);
            this.Controls.Add(this.comboBox014);
            this.Controls.Add(this.textBox012);
            this.Controls.Add(this.comboBox013);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox012);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox011);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_Venta_Cliente);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Generar_Venta";
            this.Text = "Frm_Generar_Venta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Clases.TextBox01 txt_Venta_Cliente;
        private Clases.TextBox01 textBox011;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private Clases.ComboBox01 comboBox012;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private Clases.ComboBox01 comboBox013;
        private System.Windows.Forms.Label label6;
        private Clases.TextBox01 textBox012;
        private Clases.ComboBox01 comboBox014;
        private System.Windows.Forms.Label label7;
        private Clases.ComboBox02 comboBox021;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_buscar;
    }
}