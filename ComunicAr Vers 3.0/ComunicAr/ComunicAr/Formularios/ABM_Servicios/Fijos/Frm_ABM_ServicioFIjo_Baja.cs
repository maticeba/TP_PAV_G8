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
using ComunicAr.Negocio;

namespace ComunicAr.Formularios.ABM_Servicios.Fijos
{
    public partial class Frm_ABM_ServicioFIjo_Baja : Form
    { 
        public string cod_servicio { get; set; }
    
     
        public Frm_ABM_ServicioFIjo_Baja()
        {
            InitializeComponent();
        }

        private void Btn_ServicioFIjo_Baja_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ServicioFIjo_Baja_Aceptar_Click(object sender, EventArgs e)
        {
            ServicioFijo serviciofijo = new ServicioFijo() { cod_servicio = cod_servicio };

            if (MessageBox.Show("¿Esta seguro de Borrar?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                serviciofijo.borrarServicioFIjo();
                MessageBox.Show("Se borró correctamente el cliente");
            }
            this.Close();
        }

        private void MostrarDatosServicioFijos(DataTable tabla)
        {
            txt_ServicioFijo_Baja_descripcion.Text = tabla.Rows[0]["descripcion"].ToString();
            txt_ServicioFijo_Baja_CostoMensual.Text = tabla.Rows[0]["costo_mensual"].ToString();
            txt_ServicioFijo_Baja_IdServicio.Text = tabla.Rows[0]["cod_servicio"].ToString();
           
        }

        private void Frm_ABM_ServicioFIjo_Baja_Load(object sender, EventArgs e)
        {
            ServicioFijo Fijos = new ServicioFijo();
            MostrarDatosServicioFijos(Fijos.ServicioFijoPorCodigo(cod_servicio));
        }
    }
}
