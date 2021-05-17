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
    public partial class Frm_Baja_Servicios_Contratados : Form
    {
        public string cod_servicio { get; set; }
        public Frm_Baja_Servicios_Contratados()
        {
            InitializeComponent();
        }

        private void MostrarDatos(DataTable tabla)
        {
            txt_id_Servicio.Text = tabla.Rows[0]["id_servicio"].ToString();

            string tipo = tabla.Rows[0]["tipo_servicio"].ToString();
            if (tipo == "A")
            {
                txt_tipo_servicio.Text = "Servicio de Datos";
            }
            else if (tipo == "B")
            {
                txt_tipo_servicio.Text = "Servicio Fijo";
            }
            else
            {
                txt_tipo_servicio.Text = "Servicio Prepago";
            }

            string cod_nac = tabla.Rows[0]["cod_nacional"].ToString();
            string cod_area = tabla.Rows[0]["cod_area"].ToString();
            string nro_tel = tabla.Rows[0]["nro_telefono"].ToString();
            txt_id_numero.Text = "+" + cod_nac + " " + cod_area + " " + nro_tel;

            string dia_desde = tabla.Rows[0]["dia_desde"].ToString();
            string mes_desde = tabla.Rows[0]["mes_desde"].ToString();
            string año_desde = tabla.Rows[0]["año_desde"].ToString();
            txt_fecha_desde.Text = dia_desde + "/" + mes_desde + "/" + año_desde;

            string dia_hasta = tabla.Rows[0]["dia_hasta"].ToString();
            string mes_hasta = tabla.Rows[0]["mes_hasta"].ToString();
            string año_hasta = tabla.Rows[0]["año_hasta"].ToString();
            txt_fecha_hasta.Text = dia_hasta + "/" + mes_hasta + "/" + año_hasta;
        }

        private void Frm_baja_servicio_Load(object sender, EventArgs e)
        {
            Servicios_Contratados servicios = new Servicios_Contratados();
            MostrarDatos(servicios.Servicios_contratados_por_codigo(cod_servicio));
        }

        private void bttn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttn_aceptar_Click(object sender, EventArgs e)
        {
            Servicios_Contratados servicios = new Servicios_Contratados() { Pp_cod_servicio = cod_servicio };
            if (MessageBox.Show("¿Esta seguro de Borrar?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                servicios.Borrar();
                MessageBox.Show("Se borró correctamente el servicio");
            }
        }
    }
}
