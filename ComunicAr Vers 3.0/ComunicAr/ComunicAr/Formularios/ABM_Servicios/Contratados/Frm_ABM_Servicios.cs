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
using ComunicAr.Formularios.ABM_Servicios.Contratados;

namespace ComunicAr.Formularios.Servicios
{
    public partial class Frm_ABM_Servicios : Form
    {

        public string cod_servicio { get; set; }
        public Frm_ABM_Servicios()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Servicios_Load(object sender, EventArgs e)
        {
            Servicios_Contratados servicio = new Servicios_Contratados();
            DataTable tabla = new DataTable();
            tabla = servicio.ServiciosCompletos();


            GridServicios.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                GridServicios.Rows.Add();
                GridServicios.Rows[i].Cells[0].Value = tabla.Rows[i]["cod_servicio"].ToString();
                GridServicios.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre_servicio"].ToString();
                GridServicios.Rows[i].Cells[2].Value = tabla.Rows[i]["tipo_servicio"].ToString();
                GridServicios.Rows[i].Cells[3].Value = tabla.Rows[i]["fecha_desde"].ToString();
                GridServicios.Rows[i].Cells[4].Value = tabla.Rows[i]["fecha_hasta"].ToString();
                GridServicios.Rows[i].Cells[5].Value = tabla.Rows[i]["id_numero"].ToString();

            }

            

        }

      
      

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_salir_cliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttn_modificar_servicios_Click(object sender, EventArgs e)
        {
            Frm_Modificacion_Servicios Frm_Mod = new Frm_Modificacion_Servicios();
            Frm_Mod.cod_servicio = cod_servicio;
            Frm_Mod.ShowDialog();
        }  
        
        private void GridServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
