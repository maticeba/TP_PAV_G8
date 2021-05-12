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


namespace ComunicAr.Formularios.ABM_Ciudad
{
    public partial class Frm_Baja_Ciudad : Form
    {
        public string nro_Ciudad { get; set; }
        public string Pp_codigoCiudad { get; set; }
        public Frm_Baja_Ciudad()
        {
            InitializeComponent();
        }

        private void Frm_Baja_Ciudad_Load(object sender, EventArgs e)
        {
            cmb_baja_ciud.CargarCombo();
            cmb_baja_ciud.SelectedIndex = -1;
            Ciudad ciudad = new Ciudad();
            MostrarDatos(ciudad.Ciudad_por_codigo(Pp_codigoCiudad));
        }
        private void MostrarDatos(DataTable tabla)
        {
            txt_cod_ciud.Text = tabla.Rows[0]["cod_ciudad"].ToString();
            txt_nom_ciud.Text = tabla.Rows[0]["nombre_ciudad"].ToString();
            cmb_baja_ciud.SelectedText = tabla.Rows[0]["cod_prov"].ToString();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Ciudad ciudad = new Ciudad() { Pp_codCiudad = Pp_codigoCiudad };
            if (MessageBox.Show("¿Esta seguro de eliminar?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                ciudad.Pp_codProvincia = txt_cod_ciud.Text;
                ciudad.Pp_nombreCiudad = txt_nom_ciud.Text;

                ciudad.Borrar();
                MessageBox.Show("Ciudad borrada con exito");

            }
        }
    
    }
}
