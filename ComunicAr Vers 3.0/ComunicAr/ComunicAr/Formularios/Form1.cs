using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComunicAr.Formularios
{
    public partial class ServiciosContratados : Form
    {
        public ServiciosContratados()
        {
            InitializeComponent();
        }

        private void ServiciosContratados_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*tabla = usuario.ClientesCompletos();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Grid_Servicios.Rows.Add();
                Grid_Servicios.Rows[i].Cells[0].Value = tabla.Rows[i]["nro_cliente"].ToString();
                Grid_Servicios.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre_razonSocial"].ToString();
                Grid_Servicios.Rows[i].Cells[2].Value = tabla.Rows[i]["cod_barrio"].ToString();
                Grid_Servicios.Rows[i].Cells[3].Value = tabla.Rows[i]["calle"].ToString();
                Grid_Servicios.Rows[i].Cells[4].Value = tabla.Rows[i]["nro"].ToString();
                Grid_Servicios.Rows[i].Cells[5].Value = tabla.Rows[i]["piso"].ToString();

            }
            */
        }
    }
}
