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
    public partial class Frm_Baja_prepago : Form
    {
        public string tipo_servicios { get; set; }
        public string id_pack { get; set; }
        public Frm_Baja_prepago()
        {
            InitializeComponent();
        }

        private void Frm_Baja_prepago_Load(object sender, EventArgs e)
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

        private void bttn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

        private void bttn_aceptar_Click_1(object sender, EventArgs e)
        {
            Servicios_Prepagos servicios = new Servicios_Prepagos() { Pp_id_pack = id_pack }; /*Aca puede haber un error*/
            if (MessageBox.Show("¿Esta seguro de Borrar?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                servicios.Borrar();
                MessageBox.Show("Se borró correctamente el servicio");
            }
        }

        private void bttn_cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
