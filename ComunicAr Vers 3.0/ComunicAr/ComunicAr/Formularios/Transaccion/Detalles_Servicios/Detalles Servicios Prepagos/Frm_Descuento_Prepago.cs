using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComunicAr.Formularios.Transaccion.Detalles_Servicios.Detalles_Servicios_Prepagos
{
    public partial class Frm_Descuento_Prepago : Form
    {
        public float Pp_descuento { get; set; }
        public Frm_Descuento_Prepago()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pp_descuento = float.Parse(txt_desc.Text);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
