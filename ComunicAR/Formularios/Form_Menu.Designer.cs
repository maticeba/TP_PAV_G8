
namespace ComunicAR.Formularios
{
    partial class Form_Menu
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Emitir Factura";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(3, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Actualizar Datos";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Clientes",
            "Dispositivos en ventas",
            "Servicios fijos ofrecidos",
            "Packs de datos ofrecidos",
            "Opciones de prepago ofrecidas",
            "Números que contratan nuestro servicio",
            "Llamadas realizadas por banda horaria",
            "Todas las facturas y sus detalles emitidas por la empresa",
            "Dispositivos vendidos en el último mes",
            "Clientes con recargo en el pack de datos en un mes especifico",
            "Clientes por provincia",
            "Clientes por ciudad",
            "Llamadas realizadas en un rango de fechas",
            "Clientes que usan un modelo de dispositivo especificado",
            "Clientes con una cantidad de números especificada",
            "Facturas que sobrepasen un monto especificado",
            "Clientes que hayan cargado más de un monto especificado por prepago",
            "Clientes que tengan más de cierto tiempo de llamadas",
            "Sispositivos con fecha de fabricación anterior a la especificada",
            "Servicios fijos prestados por número"});
            this.comboBox2.Location = new System.Drawing.Point(3, 60);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(209, 23);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.Text = "Generar Listas";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Cantidad facturada por mes",
            "Cantidad facturada por cada servicio",
            "Cantidad de packs vendidos por mes",
            "Cantidad de packs vendidos por servicio",
            "Cantidad de packs excedidos por servicio",
            "Cantidad de números dados de alta por servicio",
            "Cantidad de números dados de baja por servicio",
            "Cantidad de clientes dado de baja",
            "Cantidad de clientes por servicio celular",
            "Cantidad de clientes por servicio fijo",
            "Cantidad de clientes excedidos del pack de datos por mes",
            "Cantidad de dispositivos vendidos por marca",
            "Cantidad de clientes por provincia",
            "Cantidad de llamadas por banda horaria",
            "Cantidad de llamadas emitidas por mes",
            "Cantidad de llamadas por tipo de comunicación",
            "Promedio de minutos usados por servicios de llamadas",
            "Cantidad de facturas vencidas por mes"});
            this.comboBox3.Location = new System.Drawing.Point(3, 107);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(209, 23);
            this.comboBox3.TabIndex = 3;
            this.comboBox3.Text = "Generar estadisticas";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(215, 245);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form_Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button2;
    }
}