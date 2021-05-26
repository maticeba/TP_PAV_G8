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

namespace ComunicAr.Formularios.Transaccion.Detalles_Servicios.Detalles_Servicios_Prepagos
{
    public partial class Frm_Descuento_Prepago : Form
    {
        public float Pp_cod_servicio_contratado { get; set; }
        public Frm_Descuento_Prepago()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string descuento = txt_desc.Text;
            Acceso_BD BD = new Acceso_BD();
            string sql = @"UPDATE Servicios_contratados SET descuento = " + descuento +
                " WHERE cod_servicio = " + Pp_cod_servicio_contratado;
            BD.Insertar(sql);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Descuento_Prepago_Load(object sender, EventArgs e)
        {

        }
    }
}
