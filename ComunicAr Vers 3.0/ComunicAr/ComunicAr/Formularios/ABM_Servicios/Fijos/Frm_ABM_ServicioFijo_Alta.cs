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
    public partial class Frm_ABM_ServicioFijo_Alta : Form
    {
        public Frm_ABM_ServicioFijo_Alta()
        {
            InitializeComponent();
        }
        private void btn_ServicioFIjo_Alta_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_ServicioFijo_Alta_Aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                ServicioFijo serviciofijo = new ServicioFijo();

                serviciofijo.cod_servicio = txt_ServicioFijo_Alta_CodigoServicio.Text;
                serviciofijo.descripcion = txt_ServicioFijo_Alta_Descripcion.Text;
                serviciofijo.costo_mensual = txt_ServicioFijo_Alta_CostoMensual.Text;
                serviciofijo.tipo_servicio = txt_ServicioFijo_Alta_TipoServicio.Text;

                serviciofijo.insertarServicioFijo(this.Controls);
            }
            else
            {
                return;
            }
        }
    }
}
