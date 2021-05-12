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
using ComunicAr.Clases;

namespace ComunicAr.Formularios.ABM_Servicios.Prepagos
{
    public partial class Frm_Alta_prepago : Form
    {
        public Frm_Alta_prepago()
        {
            InitializeComponent();
        }

        private void Frm_Alta_prepago_Load(object sender, EventArgs e)
        {
            cmb_id_region.CargarCombo();
            cmb_id_region.SelectedIndex = -1;
        }

        private void bttn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamientos = new TratamientosEspeciales();
            if (tratamientos.Validar(Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                Servicios_Prepagos servicio = new Servicios_Prepagos();


             
                servicio.Pp_duracion = txt_duracion.Text;
                servicio.Pp_descripcion = txt_descripcion.Text;
                servicio.Pp_costo = txt_costo.Text;
                servicio.Pp_id_region = cmb_id_region.SelectedValue.ToString();


                servicio.Insertar();

            }

            else
            {
                return;
            }
        }
    }
}
