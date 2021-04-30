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
using ComunicAr.Formularios.ABM_Clientes;

namespace ComunicAr.Formularios.ABM_Clientes
{
    public partial class Frm_ABM_Cliente : Form
    {
        public Frm_ABM_Cliente()
        {
            InitializeComponent();
        }

        private void btn_salir_cliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ABM_Cliente_Load(object sender, EventArgs e)
        {
            //LLENAR EL GRIDBOX CON LOS DATOS DE LA TABLA CLIENTES APENAS CARGUE EL FORMULARIO
            Clientes usuario = new Clientes();
            DataTable tabla = new DataTable();
            tabla = usuario.ClientesCompletos();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = tabla.Rows[i]["nro_cliente"].ToString();
                dataGridView1.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre_razonSocial"].ToString();
                dataGridView1.Rows[i].Cells[2].Value = tabla.Rows[i]["cod_barrio"].ToString();
                dataGridView1.Rows[i].Cells[3].Value = tabla.Rows[i]["calle"].ToString();
                dataGridView1.Rows[i].Cells[4].Value = tabla.Rows[i]["nro"].ToString();
                dataGridView1.Rows[i].Cells[5].Value = tabla.Rows[i]["piso"].ToString();

            }
        }

        private void btn_refresh_client_Click(object sender, EventArgs e)
        {
            Clientes usuario = new Clientes();
            DataTable tabla = new DataTable();
            tabla = usuario.ClientesCompletos();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = tabla.Rows[i]["nro_cliente"].ToString();
                dataGridView1.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre_razonSocial"].ToString();
                dataGridView1.Rows[i].Cells[2].Value = tabla.Rows[i]["cod_barrio"].ToString();
                dataGridView1.Rows[i].Cells[3].Value = tabla.Rows[i]["calle"].ToString();
                dataGridView1.Rows[i].Cells[4].Value = tabla.Rows[i]["nro"].ToString();
                dataGridView1.Rows[i].Cells[5].Value = tabla.Rows[i]["piso"].ToString();
            }
        }

        private void btn_crear_cliente_Click(object sender, EventArgs e)
        {
            Frm_Alta_Cliente Altas = new Frm_Alta_Cliente();
            Altas.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
