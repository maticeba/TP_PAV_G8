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
   
    public partial class Frm_Modificar_prepagos : Form
    {
        public string tipo_servicios { get; set; }

        public string id_pack { get; set; }
        public Frm_Modificar_prepagos()
        {
            InitializeComponent();
        }

        private void Frm_Modificar_prepagos_Load(object sender, EventArgs e)
        {
            cmb_id_region.CargarCombo();
            cmb_id_region.SelectedIndex = -1;
            Servicios_Prepagos servicios = new Servicios_Prepagos();
            MostrarDatos(servicios.Servicios_prepagos_por_id(id_pack));
           
        }

        public void MostrarDatos(DataTable tabla)
        {
            txt_id_pack.Text = tabla.Rows[0]["id_pack"].ToString();
            txt_duracion.Text = tabla.Rows[0]["duracion"].ToString();
            txt_descripcion.Text = tabla.Rows[0]["descripcion"].ToString();
            txt_costo.Text = tabla.Rows[0]["costo"].ToString();
            cmb_id_region.SelectedValue = tabla.Rows[0]["id_region"].ToString();

        }
     

        private void bttn_aceptar_Click_1(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamientos = new TratamientosEspeciales();
            if (tratamientos.Validar(Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                Servicios_Prepagos servicio = new Servicios_Prepagos();


                servicio.Pp_id_pack = txt_id_pack.Text;
                servicio.Pp_duracion = txt_duracion.Text;
                servicio.Pp_descripcion = txt_descripcion.Text;
                servicio.Pp_costo = txt_costo.Text;
                servicio.Pp_id_region = cmb_id_region.SelectedValue.ToString();


                servicio.Modificar();

            }

            else
            {
                return;
            }
        }

        private void bttn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
