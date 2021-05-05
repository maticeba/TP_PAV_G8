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

namespace ComunicAr.Formularios.ABM_Servicios.Fijos
{
    public partial class Frm_ABM_ServicioFijo : Form

    {
        public string cod_servicio { get; set; }
        public Frm_ABM_ServicioFijo()
        {
            InitializeComponent();
        }
        private void CargarGrillaServicioFijo(DataTable tabla)
        {
            for (int i = 0; i < tabla.Rows.Count; i++)

            {
                dataGridView_ServicioFijo1.Rows.Add();
                dataGridView_ServicioFijo1.Rows[i].Cells[0].Value = tabla.Rows[i]["cod_servicio"].ToString();
                dataGridView_ServicioFijo1.Rows[i].Cells[1].Value = tabla.Rows[i]["descripcion"].ToString();
                dataGridView_ServicioFijo1.Rows[i].Cells[2].Value = tabla.Rows[i]["costo_mensual"].ToString();
                dataGridView_ServicioFijo1.Rows[i].Cells[3].Value = tabla.Rows[i]["tipo_servicio"].ToString();
            }
        }
        private void dataGridView_ServicioFijo1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cod_servicio = dataGridView_ServicioFijo1.CurrentRow.Cells["Column1"].Value.ToString();
        }
        private void btn_ServicioFijo_Consultar_Click(object sender, EventArgs e)

        {
            ServicioFijo servicioFijo = new ServicioFijo();
            if (textBox1.Text != "")
            {
                dataGridView_ServicioFijo1.Rows.Clear();
                CargarGrillaServicioFijo(servicioFijo.ServicioFijoPorCodigo(textBox1.Text));
                textBox1.Clear();
                return;
            }
            if (textBox2.Text != "")
            {
                dataGridView_ServicioFijo1.Rows.Clear();
                CargarGrillaServicioFijo(servicioFijo.ServicioFijoPorDescripcion(textBox2.Text));
                textBox2.Clear();
            }
        }
        private void btn_ServicioFijo_salir1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_ServicioFijo_refrescar1(object sender, EventArgs e)
        {
            ServicioFijo usuarioSF = new ServicioFijo();
            DataTable tabla = new DataTable();
            tabla = usuarioSF.ServicioFijoCompleto();
            dataGridView_ServicioFijo1.Rows.Clear();
            CargarGrillaServicioFijo(tabla);
        }
        private void btn_ServicioFijo_Eliminar(object sender, EventArgs e)
        {
            Frm_ABM_ServicioFIjo_Baja Baja = new Frm_ABM_ServicioFIjo_Baja();
            Baja.cod_servicio = cod_servicio;
            Baja.ShowDialog();

            /*ServicioFijo serviciofijo = new ServicioFijo() { cod_servicio = cod_servicio };
            serviciofijo.borrarServicioFIjo();
            MessageBox.Show("Cliente borrado");*/
        }
        private void btn_ServicioFijo_Crear_Click(object sender, EventArgs e)
        {
            Frm_ABM_ServicioFijo_Alta alta = new Frm_ABM_ServicioFijo_Alta();
            alta.ShowDialog();
        }
        private void btn_ServicioFijo_Modificar_Click(object sender, EventArgs e)
        {
            Frm_ABM_ServicioFIjo_Modificacion frmserviciomodif = new Frm_ABM_ServicioFIjo_Modificacion();
            frmserviciomodif.cod_servicio = cod_servicio;
            frmserviciomodif.ShowDialog();
        }
        private void Frm_ABM_ServicioFijo_Load_1(object sender, EventArgs e)
        {
            ServicioFijo usuarioSF = new ServicioFijo();
            DataTable tabla = new DataTable();
            tabla = usuarioSF.ServicioFijoCompleto();
            CargarGrillaServicioFijo(tabla);
        }
    }
}
