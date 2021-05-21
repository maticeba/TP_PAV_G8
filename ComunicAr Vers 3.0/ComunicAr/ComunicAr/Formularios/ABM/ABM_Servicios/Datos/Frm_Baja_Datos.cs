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


namespace ComunicAr.Formularios.ABM_Servicios.Datos
{
    public partial class Frm_Baja_Datos : Form
    {
        public string cod_Datos { get; set; }

        public Frm_Baja_Datos()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            Servicios_Datos datos = new Servicios_Datos() { Pp_codDatos= cod_Datos };

            if ( MessageBox.Show("¿Esta seguro que desea eliminarlo definitiamente?", "AVISO", MessageBoxButtons.OKCancel)== DialogResult.OK)
            {
                datos.Borrar();
                MessageBox.Show("El Servicio fue borrado con exito!");

            }
            this.Close();
        }

        private void Frm_Baja_Datos_Load(object sender, EventArgs e)
        {
          
            Servicios_Datos datos = new Servicios_Datos();

            MostrarDatos(datos.DatosXCodigo(cod_Datos));

        }
        private void MostrarDatos(DataTable tabla)
        {
            txt_limite_B.Text = tabla.Rows[0]["limite_datos"].ToString();
            txt_descripcion_B.Text = tabla.Rows[0]["descripcion"].ToString();
            txt_costoFijo_B.Text = tabla.Rows[0]["costo_fijo"].ToString();
            txt_tipo.Text = tabla.Rows[0]["tipo_servicio"].ToString();


        }
    }
}
