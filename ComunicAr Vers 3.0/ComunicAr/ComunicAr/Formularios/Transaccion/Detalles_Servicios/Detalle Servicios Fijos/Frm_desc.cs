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

namespace ComunicAr.Formularios.Transaccion.Detalles_Servicios.Detalle_Servicios_Fijos
{
    public partial class Frm_desc : Form
    {
        public string Pp_cod_servicio { get; set; }

        public Frm_desc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string desc = txt_desc.Text;
            Acceso_BD BD = new Acceso_BD();
            string sql = @"UPDATE Servicios_contratados SET descuento = " + desc +
                " WHERE cod_servicio = " + Pp_cod_servicio;
            BD.Insertar(sql);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_desc_Load(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
