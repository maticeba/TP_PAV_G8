
namespace ComunicAr.Formularios.Transaccion.Detalle_Dispositivos.Descuento_Venta
{
    partial class Frm_Descuento_VtaDisp
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
            this.Grpb_DescuentoVtaDisp = new System.Windows.Forms.GroupBox();
            this.lbl_DescuentoVtaDisp = new System.Windows.Forms.Label();
            this.lbl_Simbolo = new System.Windows.Forms.Label();
            this.txt_Descuento_VtaDispo = new ComunicAr.Clases.TextBox01();
            this.btn_Descuento_Cancelar = new System.Windows.Forms.Button();
            this.btn_descuento_aceptar = new System.Windows.Forms.Button();
            this.Grpb_DescuentoVtaDisp.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grpb_DescuentoVtaDisp
            // 
            this.Grpb_DescuentoVtaDisp.Controls.Add(this.lbl_DescuentoVtaDisp);
            this.Grpb_DescuentoVtaDisp.Controls.Add(this.lbl_Simbolo);
            this.Grpb_DescuentoVtaDisp.Controls.Add(this.txt_Descuento_VtaDispo);
            this.Grpb_DescuentoVtaDisp.Location = new System.Drawing.Point(12, 12);
            this.Grpb_DescuentoVtaDisp.Name = "Grpb_DescuentoVtaDisp";
            this.Grpb_DescuentoVtaDisp.Size = new System.Drawing.Size(427, 66);
            this.Grpb_DescuentoVtaDisp.TabIndex = 0;
            this.Grpb_DescuentoVtaDisp.TabStop = false;
            // 
            // lbl_DescuentoVtaDisp
            // 
            this.lbl_DescuentoVtaDisp.AutoSize = true;
            this.lbl_DescuentoVtaDisp.Location = new System.Drawing.Point(6, 23);
            this.lbl_DescuentoVtaDisp.Name = "lbl_DescuentoVtaDisp";
            this.lbl_DescuentoVtaDisp.Size = new System.Drawing.Size(153, 13);
            this.lbl_DescuentoVtaDisp.TabIndex = 3;
            this.lbl_DescuentoVtaDisp.Text = "Ingrese  número de Descuento";
            // 
            // lbl_Simbolo
            // 
            this.lbl_Simbolo.AutoSize = true;
            this.lbl_Simbolo.Location = new System.Drawing.Point(338, 22);
            this.lbl_Simbolo.Name = "lbl_Simbolo";
            this.lbl_Simbolo.Size = new System.Drawing.Size(15, 13);
            this.lbl_Simbolo.TabIndex = 4;
            this.lbl_Simbolo.Text = "%";
            // 
            // txt_Descuento_VtaDispo
            // 
            this.txt_Descuento_VtaDispo.Location = new System.Drawing.Point(192, 19);
            this.txt_Descuento_VtaDispo.Name = "txt_Descuento_VtaDispo";
            this.txt_Descuento_VtaDispo.Pp_Campo = null;
            this.txt_Descuento_VtaDispo.Pp_MensajeError = null;
            this.txt_Descuento_VtaDispo.Pp_Tabla = null;
            this.txt_Descuento_VtaDispo.Pp_Validable = false;
            this.txt_Descuento_VtaDispo.Size = new System.Drawing.Size(123, 20);
            this.txt_Descuento_VtaDispo.TabIndex = 0;
            // 
            // btn_Descuento_Cancelar
            // 
            this.btn_Descuento_Cancelar.Location = new System.Drawing.Point(280, 96);
            this.btn_Descuento_Cancelar.Name = "btn_Descuento_Cancelar";
            this.btn_Descuento_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Descuento_Cancelar.TabIndex = 1;
            this.btn_Descuento_Cancelar.Text = "Cancelar";
            this.btn_Descuento_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Descuento_Cancelar.Click += new System.EventHandler(this.btn_Descuento_Cancelar_Click);
            // 
            // btn_descuento_aceptar
            // 
            this.btn_descuento_aceptar.Location = new System.Drawing.Point(174, 96);
            this.btn_descuento_aceptar.Name = "btn_descuento_aceptar";
            this.btn_descuento_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_descuento_aceptar.TabIndex = 2;
            this.btn_descuento_aceptar.Text = "Aceptar";
            this.btn_descuento_aceptar.UseVisualStyleBackColor = true;
            this.btn_descuento_aceptar.Click += new System.EventHandler(this.btn_descuento_aceptar_Click);
            // 
            // Frm_Descuento_VtaDisp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 143);
            this.Controls.Add(this.btn_descuento_aceptar);
            this.Controls.Add(this.btn_Descuento_Cancelar);
            this.Controls.Add(this.Grpb_DescuentoVtaDisp);
            this.Name = "Frm_Descuento_VtaDisp";
            this.Text = "Descuento";
            this.Load += new System.EventHandler(this.Frm_Descuento_VtaDisp_Load);
            this.Grpb_DescuentoVtaDisp.ResumeLayout(false);
            this.Grpb_DescuentoVtaDisp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Grpb_DescuentoVtaDisp;
        private Clases.TextBox01 txt_Descuento_VtaDispo;
        private System.Windows.Forms.Button btn_Descuento_Cancelar;
        private System.Windows.Forms.Button btn_descuento_aceptar;
        private System.Windows.Forms.Label lbl_DescuentoVtaDisp;
        private System.Windows.Forms.Label lbl_Simbolo;
    }
}