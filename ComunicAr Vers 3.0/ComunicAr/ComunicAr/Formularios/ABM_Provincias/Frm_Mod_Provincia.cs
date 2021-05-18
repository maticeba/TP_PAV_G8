using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComunicAr.Formularios.ABM_Provincia;
using ComunicAr.Clases;
using ComunicAr.Negocio;

namespace ComunicAr.Formularios.ABM_Provincia
{
    public partial class Frm_Mod_Provincia : Form
    {
        public string nro_Provincia { get; set; }
        public string Pp_codigoProvincia { get; set; }
        public Frm_Mod_Provincia()
        {
            InitializeComponent();
        }

        private void Frm_Mod_Provincia_Load(object sender, EventArgs e)
        {
            cmb_cod_prov.CargarCombo();
            cmb_cod_prov.SelectedIndex = -1;
            Provincia provincia = new Provincia();
            MostrarDatos(provincia.cod_prov(Pp_codigoProvincia));
        }
        private void MostrarDatos(DataTable tabla)
        {
            cmb_cod_prov.SelectedValue = int.Parse(tabla.Rows[0]["codigo_provincia"].ToString());
            txt_nom_prov.Text = tabla.Rows[0]["nombre_provincia"].ToString();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                Provincia provincia = new Provincia();
                provincia.Pp_nombreProvincia = txt_nom_prov.Text;
                provincia.Pp_codigoProvincia = cmb_cod_prov.SelectedValue.ToString();
                provincia.Modificar();
            }
            else
            {
                return;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void cmb_cod_prov_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
