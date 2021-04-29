using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            DataTable tabla = new DataTable();

            GridServicios.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                GridServicios.Rows.Add();
                GridServicios.Rows[i].Cells[0].Value = tabla.Rows[i]["Cod_Nacional"].ToString();
                GridServicios.Rows[i].Cells[1].Value = tabla.Rows[i]["Cod_Area"].ToString();
                GridServicios.Rows[i].Cells[2].Value = tabla.Rows[i]["Nro_Telefono"].ToString();
                GridServicios.Rows[i].Cells[3].Value = tabla.Rows[i]["Cod_Servicio"].ToString();
                GridServicios.Rows[i].Cells[4].Value = tabla.Rows[i]["Cod_Datos"].ToString();
                GridServicios.Rows[i].Cells[5].Value = tabla.Rows[i]["Fecha_Desde"].ToString();
                GridServicios.Rows[i].Cells[5].Value = tabla.Rows[i]["Fecha_Hasta"].ToString();
            }



        }
    }
}
