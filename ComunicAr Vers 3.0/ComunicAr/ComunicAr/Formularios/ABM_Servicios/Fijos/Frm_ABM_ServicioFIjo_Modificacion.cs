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
    public partial class Frm_ABM_ServicioFIjo_Modificacion : Form
    {
        public string cod_servicio { get; set; }
        public Frm_ABM_ServicioFIjo_Modificacion()
        {
            InitializeComponent();
        }
        private void btn_ServicioFIjo_Modifiacion_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_ServicioFIjo_Modificacion_Aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                Negocio.ServicioFijo serviciofijo = new Negocio.ServicioFijo();

                serviciofijo.descripcion = txt_ServicioFijo_Modificacion_descripcion.Text;
                serviciofijo.costo_mensual = txt_ServicioFijo_Modificacion_CostoMensual.Text;
                serviciofijo.cod_servicio = cod_servicio;

                serviciofijo.ModificarServicioFijo();
            }
            else 
            {
                return;
            }
        }
        private void MostrarDatosServicioFijos(DataTable tabla)
        {
            txt_ServicioFijo_Modificacion_descripcion.Text = tabla.Rows[0]["descripcion"].ToString();
            txt_ServicioFijo_Modificacion_CostoMensual.Text = tabla.Rows[0]["costo_mensual"].ToString();
            txt_ServicioFijo_Modificacion_TipoServicio.Text = tabla.Rows[0]["cod_servicio"].ToString();
        }
        private void Frm_ABM_ServicioFIjo_Modificacion_Load(object sender, EventArgs e)
        {
            ServicioFijo Fijos = new ServicioFijo();
            MostrarDatosServicioFijos(Fijos.ServicioFijoPorCodigo(cod_servicio));
        }
    }
}
