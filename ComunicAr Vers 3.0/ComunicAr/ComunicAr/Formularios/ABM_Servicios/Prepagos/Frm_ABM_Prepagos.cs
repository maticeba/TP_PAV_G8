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
using ComunicAr.Formularios.ABM_Servicios.Prepagos;

namespace ComunicAr.Formularios.ABM_Servicios.Prepagos
{
    public partial class Frm_ABM_Prepagos : Form
    {
        public string id_pack { get; set; }
        public bool flag { get; set; }
        public Frm_ABM_Prepagos()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Prepagos_Load(object sender, EventArgs e)
        {
            Servicios_Prepagos servicio = new Servicios_Prepagos();
            DataTable tabla = new DataTable();
            tabla = servicio.ServiciosCompletos();
            CargarGrilla(tabla);

            flag = false;
        }

        private void CargarGrilla(DataTable tabla)
        {
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                GridPrepago.Rows.Add();
                GridPrepago.Rows[i].Cells[0].Value = tabla.Rows[i]["tipo_servicio"].ToString();
                GridPrepago.Rows[i].Cells[1].Value = tabla.Rows[i]["id_pack"].ToString();
                GridPrepago.Rows[i].Cells[2].Value = tabla.Rows[i]["duracion"].ToString();
                GridPrepago.Rows[i].Cells[3].Value = tabla.Rows[i]["descripcion"].ToString();
                GridPrepago.Rows[i].Cells[4].Value = tabla.Rows[i]["costo"].ToString();
                GridPrepago.Rows[i].Cells[5].Value = tabla.Rows[i]["id_region"].ToString();
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttn_modificar_prepago_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                MessageBox.Show("No se ha seleccionado ninguna llamada para modificar");
            }
            else
            {
                Frm_Modificar_prepagos Frm_Mod = new Frm_Modificar_prepagos();
                Frm_Mod.id_pack = id_pack;
                Frm_Mod.ShowDialog();
            }

            flag = false;
        }

      

        private void bttn_alta_prepago_Click_1(object sender, EventArgs e)
        {
            Frm_Alta_prepago Altas = new Frm_Alta_prepago();
            Altas.ShowDialog();

            flag = false;
        }

        private void bttn_refrescar_Click(object sender, EventArgs e)
        {
            Servicios_Prepagos servicios = new Servicios_Prepagos();
            DataTable tabla = new DataTable();
            tabla = servicios.ServiciosCompletos();
            GridPrepago.Rows.Clear();
            CargarGrilla(tabla);

            flag = false;
        }

        private void bttn_baja_Click_1(object sender, EventArgs e)
        {
            if (flag == false)
            {
                MessageBox.Show("No se ha seleccionado una llamada para eliminar");
            }
            else
            {

                Frm_Baja_prepago Bajas = new Frm_Baja_prepago();
                Bajas.id_pack = id_pack;
                Bajas.ShowDialog();

            }

            flag = false;
        }

        private void GridPrepago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_pack = GridPrepago.CurrentRow.Cells["id_packs"].Value.ToString();
            flag = true;
        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            Servicios_Prepagos servicios = new Servicios_Prepagos();
            if (txt_filtro_id_pack.Text != "")
            {
                GridPrepago.Rows.Clear();
                CargarGrilla(servicios.Servicios_prepagos_por_id(txt_filtro_id_pack.Text));
                txt_filtro_id_pack.Clear();
                return;
            }
        }
    }
}
