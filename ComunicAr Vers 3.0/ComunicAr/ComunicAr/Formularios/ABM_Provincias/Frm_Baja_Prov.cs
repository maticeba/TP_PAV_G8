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

namespace ComunicAr.Formularios.ABM_Provincia
{

    public partial class Frm_Baja_Prov : Form
    {
        public string nro_Prov { get; set; }
        public string Pp_codigoProvincia { get; set; }
        public Frm_Baja_Prov()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
                Provincia provincia = new Provincia() { Pp_codigoProvincia = Pp_codigoProvincia };
                if (MessageBox.Show("¿Esta seguro de Borrar?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    provincia.Borrar();
                    MessageBox.Show("Se borró correctamente la Provincia");
                }
        }

        private void Frm_Baja_Prov_Load(object sender, EventArgs e)
        {
            cmb_baja_prov.CargarCombo();
            cmb_baja_prov.SelectedIndex = -1;
            Provincia provincia = new Provincia();
            MostrarDatos(provincia.cod_prov(Pp_codigoProvincia));
        }
        private void MostrarDatos(DataTable tabla)
        {
            cmb_baja_prov.SelectedValue = int.Parse(tabla.Rows[0]["cod_prov"].ToString());
            txt_nom_prov.Text = tabla.Rows[0]["nombre_prov"].ToString();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
