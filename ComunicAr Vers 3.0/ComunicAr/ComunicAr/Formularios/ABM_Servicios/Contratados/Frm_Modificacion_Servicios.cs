using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComunicAr.Negocio;

namespace ComunicAr.Formularios.ABM_Servicios.Contratados
{
    public partial class Frm_Modificacion_Servicios : Form
    {
        public string cod_servicio { get; set; }
        public Frm_Modificacion_Servicios()
        {
            InitializeComponent();
        }

        private void textBox014_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Modificacion_Servicios_Load(object sender, EventArgs e)
        {
            Servicios_Contratados servicios = new Servicios_Contratados();
            MostrarDatos(servicios.Servicios_contratados_por_codigo(cod_servicio));

        }

        private void MostrarDatos(DataTable tabla)
        {
            txt_nombre_servicio.Text = tabla.Rows[0]["nombre_servicio"].ToString();
            txt_tipo_servicio.Text = tabla.Rows[0]["tipo_servicio"].ToString();
            txt_fecha_desde.Text = tabla.Rows[0]["fecha_desde"].ToString();
            txt_fecha_hasta.Text = tabla.Rows[0]["fecha_hasta"].ToString();
            txt_id_numero.Text = tabla.Rows[0]["id_numero"].ToString();

        }
    }
}
