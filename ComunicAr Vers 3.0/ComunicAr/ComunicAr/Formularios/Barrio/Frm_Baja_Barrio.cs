using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComunicAr.Formularios.Barrio;
using ComunicAr.Negocio;
using ComunicAr.Clases;


namespace ComunicAr.Formularios.Barrio
{
    public partial class Frm_Baja_Barrio : Form
    {
        public string codigo_barrio { get; set; }
        public Frm_Baja_Barrio()
        {
            InitializeComponent();
        }

        private void cmb_cliente_alta_barrio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Baja_Barrio_Load(object sender, EventArgs e)
        {
            cmb_codigo_ciudad.CargarCombo();
            cmb_codigo_ciudad.SelectedIndex = -1;
            Barrios barrio = new Barrios();
            MostrarDatos(barrio.Barrios_por_codigo(codigo_barrio));
        }

        private void MostrarDatos(DataTable tabla)
        {
            txt_nombre_barrio.Text = tabla.Rows[0]["nombre_barrio"].ToString();
            cmb_codigo_ciudad.SelectedValue = tabla.Rows[0]["cod_ciudad"].ToString();
        }

        private void bttn_aceptar_baja_barrios(object sender, EventArgs e)
        {
            Barrios barrio = new Barrios() { Pp_codigo_barrio = codigo_barrio };
            if (MessageBox.Show("¿Esta seguro de Borrar?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                barrio.Borrar();
                MessageBox.Show("Se borró correctamente el cliente");
            }
        }

        private void bttn_cancelar_baja_barrio(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
