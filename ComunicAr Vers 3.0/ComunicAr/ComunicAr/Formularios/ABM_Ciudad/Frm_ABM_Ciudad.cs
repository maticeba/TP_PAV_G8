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

namespace ComunicAr.Formularios.ABM_Ciudad
{
    public partial class Frm_ABM_Ciudad : Form
    {
        public string nro_Ciudad {get; set;}
        public string Pp_codigoCiudad { get; set; }
        public bool flag { get; set; }
        public Frm_ABM_Ciudad()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nro_Ciudad = dataGrid_Ciudad.CurrentRow.Cells["Column1"].Value.ToString();
            flag = true;
        }

        private void btn_salir_ciudad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_crear_ciudad_Click(object sender, EventArgs e)
        {
            Frm_Alta_Ciudad MenuAltas = new Frm_Alta_Ciudad();
            MenuAltas.ShowDialog();
            flag = false;
        }
        private void Frm_ABM_Ciudad_Load(object sender, EventArgs e)
        {
            Ciudad ciudad = new Ciudad();
            DataTable tabla = new DataTable();
            tabla = ciudad.CiudadesCompletas();
            CargarGrilla(tabla);
            flag = false;
        }
        private void btn_refresh_client_Click(object sender, EventArgs e)
        {
            Ciudad ciudad = new Ciudad();
            DataTable tabla = new DataTable();
            tabla = ciudad.CiudadesCompletas();
            dataGrid_Ciudad.Rows.Clear();
            CargarGrilla(tabla);
            flag = false;
        }

        private void btn_modificar_ciud_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                MessageBox.Show("No se ha seleccionado ninguna Ciudad para modificar");
            }
            else
            {
                Frm_Mod_Ciudad Frm_Mod = new Frm_Mod_Ciudad();
                Frm_Mod.Pp_codigoCiudad = Pp_codigoCiudad;
                Frm_Mod.ShowDialog();
            }
        }

        private void btn_eliminar_ciud_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                MessageBox.Show("No se ha seleccionado ninguna Ciudad para eliminar");
            }
            else
            {
                Frm_Baja_Ciudad Frm_Baja = new Frm_Baja_Ciudad();
                Frm_Baja.Pp_codigoCiudad = Pp_codigoCiudad;
                Frm_Baja.ShowDialog();
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            Ciudad ciudad = new Ciudad();
            if (txt_cod_ciud.Text != "")
            {
                dataGrid_Ciudad.Rows.Clear();
                CargarGrilla(ciudad.Ciudad_por_codigo(txt_cod_ciud.Text));
                txt_cod_ciud.Clear();
                return;
            }
            if (txt_nomb_ciud.Text != "")
            {
                dataGrid_Ciudad.Rows.Clear();
                CargarGrilla(ciudad.Ciudad_por_nombre(txt_nomb_ciud.Text));
                txt_nomb_ciud.Clear();
            }
            if (txt_cod_prov.Text != "")
            {
                dataGrid_Ciudad.Rows.Clear();
                CargarGrilla(ciudad.Ciudad_por_cod_prov(txt_cod_prov.Text));
                txt_cod_prov.Clear();
            }
        }
        private void CargarGrilla(DataTable tabla)
        {
            //LLenar Grilla
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dataGrid_Ciudad.Rows.Add();
                dataGrid_Ciudad.Rows[i].Cells[0].Value = tabla.Rows[i]["cod_ciudad"].ToString();
                dataGrid_Ciudad.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre_ciudad"].ToString();
                dataGrid_Ciudad.Rows[i].Cells[2].Value = tabla.Rows[i]["cod_prov"].ToString();

            }
        }
    }
}
