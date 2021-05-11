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

namespace ComunicAr.Formularios.ABM_Servicios.Contratados
{
    public partial class Frm_Alta_Servicios : Form
    {

        public string cod_servicio { get; set; }
        public Frm_Alta_Servicios()
        {
            InitializeComponent();
        }

       
        private void bttn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamientos = new TratamientosEspeciales();
            if (tratamientos.Validar(Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                Servicios_Contratados servicio = new Servicios_Contratados();

                
                servicio.Pp_tipo_servicio = txt_tipo_servicio.Text;
                servicio.Pp_id_servicio = txt_id_Servicio.Text;
                servicio.Pp_fecha_desde = txt_fecha_desde.Text;
                servicio.Pp_fecha_hasta = txt_fecha_hasta.Text;
                servicio.Pp_id_numero = txt_id_numero.Text;
                servicio.Pp_cod_servicio = cod_servicio;

                servicio.Insertar();

            }

            else
            {
                return;
            }
        }

        private void txt_fecha_hasta_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_nombre_servicio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
