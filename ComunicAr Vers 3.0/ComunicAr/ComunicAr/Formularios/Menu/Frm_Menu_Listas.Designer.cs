
namespace ComunicAr.Formularios.Menu
{
    partial class Frm_Menu_Listas
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
            this.bnt_menu_lista_cancelar = new System.Windows.Forms.Button();
            this.bnt_menu_lista_cliente = new System.Windows.Forms.Button();
            this.bnt_menu_lista_dispositivos = new System.Windows.Forms.Button();
            this.bnt_menu_lista_numero = new System.Windows.Forms.Button();
            this.bnt_menu_lista_llamadas = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnt_menu_lista_cancelar
            // 
            this.bnt_menu_lista_cancelar.Location = new System.Drawing.Point(73, 266);
            this.bnt_menu_lista_cancelar.Name = "bnt_menu_lista_cancelar";
            this.bnt_menu_lista_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bnt_menu_lista_cancelar.TabIndex = 0;
            this.bnt_menu_lista_cancelar.Text = "Cancelar";
            this.bnt_menu_lista_cancelar.UseVisualStyleBackColor = true;
            this.bnt_menu_lista_cancelar.Click += new System.EventHandler(this.bnt_menu_lista_cancelar_Click);
            // 
            // bnt_menu_lista_cliente
            // 
            this.bnt_menu_lista_cliente.Location = new System.Drawing.Point(40, 12);
            this.bnt_menu_lista_cliente.Name = "bnt_menu_lista_cliente";
            this.bnt_menu_lista_cliente.Size = new System.Drawing.Size(140, 23);
            this.bnt_menu_lista_cliente.TabIndex = 1;
            this.bnt_menu_lista_cliente.Text = "Listas de Clientes";
            this.bnt_menu_lista_cliente.UseVisualStyleBackColor = true;
            this.bnt_menu_lista_cliente.Click += new System.EventHandler(this.bnt_menu_lista_cliente_Click);
            // 
            // bnt_menu_lista_dispositivos
            // 
            this.bnt_menu_lista_dispositivos.Location = new System.Drawing.Point(40, 99);
            this.bnt_menu_lista_dispositivos.Name = "bnt_menu_lista_dispositivos";
            this.bnt_menu_lista_dispositivos.Size = new System.Drawing.Size(140, 23);
            this.bnt_menu_lista_dispositivos.TabIndex = 1;
            this.bnt_menu_lista_dispositivos.Text = "Listas de Dispositivos";
            this.bnt_menu_lista_dispositivos.UseVisualStyleBackColor = true;
            this.bnt_menu_lista_dispositivos.Click += new System.EventHandler(this.bnt_menu_lista_dispositivos_Click);
            // 
            // bnt_menu_lista_numero
            // 
            this.bnt_menu_lista_numero.Location = new System.Drawing.Point(40, 41);
            this.bnt_menu_lista_numero.Name = "bnt_menu_lista_numero";
            this.bnt_menu_lista_numero.Size = new System.Drawing.Size(140, 23);
            this.bnt_menu_lista_numero.TabIndex = 1;
            this.bnt_menu_lista_numero.Text = "Listas de Números";
            this.bnt_menu_lista_numero.UseVisualStyleBackColor = true;
            this.bnt_menu_lista_numero.Click += new System.EventHandler(this.bnt_menu_lista_numero_Click);
            // 
            // bnt_menu_lista_llamadas
            // 
            this.bnt_menu_lista_llamadas.Location = new System.Drawing.Point(40, 70);
            this.bnt_menu_lista_llamadas.Name = "bnt_menu_lista_llamadas";
            this.bnt_menu_lista_llamadas.Size = new System.Drawing.Size(140, 23);
            this.bnt_menu_lista_llamadas.TabIndex = 1;
            this.bnt_menu_lista_llamadas.Text = "Listas de Llamadas";
            this.bnt_menu_lista_llamadas.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Listas de Facturas";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(40, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Listas de Servicios";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Frm_Menu_Listas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 305);
            this.Controls.Add(this.bnt_menu_lista_llamadas);
            this.Controls.Add(this.bnt_menu_lista_numero);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bnt_menu_lista_dispositivos);
            this.Controls.Add(this.bnt_menu_lista_cliente);
            this.Controls.Add(this.bnt_menu_lista_cancelar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Menu_Listas";
            this.Text = "Menu Listas";
            this.Load += new System.EventHandler(this.Frm_Menu_Listas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnt_menu_lista_cancelar;
        private System.Windows.Forms.Button bnt_menu_lista_cliente;
        private System.Windows.Forms.Button bnt_menu_lista_dispositivos;
        private System.Windows.Forms.Button bnt_menu_lista_numero;
        private System.Windows.Forms.Button bnt_menu_lista_llamadas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}