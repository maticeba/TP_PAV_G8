using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComunicAr.Transaccion.Emision_de_Factura
{
    public partial class Frm_EmisionFactura : Form
    {
        public Frm_EmisionFactura()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_Detalle_Llamada Llamadas = new Frm_Detalle_Llamada();
            Llamadas.ShowDialog();
        }
    }
}
