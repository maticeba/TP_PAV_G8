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

namespace ComunicAr.Formularios.Servicios
{
    public partial class Frm_ABM_Servicios : Form
    {
        public Frm_ABM_Servicios()
        {
            InitializeComponent();
        }

        private void GridServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Servicios_Contratados servicio = new Servicios_Contratados();
            DataTable tabla = new DataTable();
            tabla = servicio.ServiciosCompletos();


            GridServicios.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                GridServicios.Rows.Add();
                GridServicios.Rows[i].Cells[0].Value = tabla.Rows[i]["tipo_servicio"].ToString();
                GridServicios.Rows[i].Cells[0].Value = tabla.Rows[i]["nombre_servicio"].ToString();
                GridServicios.Rows[i].Cells[0].Value = tabla.Rows[i]["cod_nacional"].ToString();
                GridServicios.Rows[i].Cells[1].Value = tabla.Rows[i]["cod_area"].ToString();
                GridServicios.Rows[i].Cells[2].Value = tabla.Rows[i]["nro_telefono"].ToString();
                GridServicios.Rows[i].Cells[3].Value = tabla.Rows[i]["cod_servicio"].ToString();
                GridServicios.Rows[i].Cells[4].Value = tabla.Rows[i]["fecha_desde"].ToString();
                GridServicios.Rows[i].Cells[5].Value = tabla.Rows[i]["fecha_hasta"].ToString();
                
            }



        }

        private void Frm_ABM_Servicios_Load(object sender, EventArgs e)
        {

        }

    }
}
