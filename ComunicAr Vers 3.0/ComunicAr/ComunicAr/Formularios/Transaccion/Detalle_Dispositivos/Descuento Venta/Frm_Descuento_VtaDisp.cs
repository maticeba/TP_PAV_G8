using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComunicAr.Clases;

namespace ComunicAr.Formularios.Transaccion.Detalle_Dispositivos.Descuento_Venta
{
    public partial class Frm_Descuento_VtaDisp : Form
    {
        public string Pp_venta_dispositivo { get; set; }
        public Frm_Descuento_VtaDisp()
        {
            InitializeComponent();
        }

        private void btn_descuento_aceptar_Click(object sender, EventArgs e)
        {
            string desc = txt_Descuento_VtaDispo.Text;
            Acceso_BD BD = new Acceso_BD();
            string sql = @"UPDATE Venta_Dispositivo SET descuento = " + desc +
                " WHERE cod_servicio = " + Pp_venta_dispositivo;
            BD.Insertar(sql);
            this.Close();
        }

        private void btn_Descuento_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Descuento_VtaDisp_Load(object sender, EventArgs e)
        {

        }
    }
}
