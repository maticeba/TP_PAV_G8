using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComunicAr.Formularios.ABM_Provincia;
using ComunicAr.Negocio;

namespace ComunicAr.Formularios.ABM_Provincia
{
    public partial class Frm_ABM_Provincia : Form
    {
        public string nro_Provincia { get; set; }
        public string Pp_codigoProvincia { get; set; }
        public bool flag { get; set; }
        public Frm_ABM_Provincia()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_crear_provincia_Click(object sender, EventArgs e)
        {
            Frm_Alta_Provincia MenuAltas = new Frm_Alta_Provincia();
            MenuAltas.ShowDialog();
            flag = false;
        }

        private void Frm_ABM_Provincia_Load(object sender, EventArgs e)
        {
            //LLENAR EL GRIDBOX CON LOS DATOS DE LA TABLA PROVINCIAS APENAS CARGUE EL FORMULARIO
            Provincia provincia = new Provincia();
            DataTable tabla = new DataTable();
            tabla = provincia.ProvinciasCompletas();
            CargarGrilla(tabla);
            flag = false;
        }
        private void btn_refrescar_Click(object sender, EventArgs e)
        {

            Provincia provincia = new Provincia();
            DataTable tabla = new DataTable();
            tabla = provincia.ProvinciasCompletas();
            dataGrid_Provincia.Rows.Clear();
            CargarGrilla(tabla);
            flag = false;

        }

        private void btn_modificar_provinciaClick(object sender, EventArgs e)
        {
            if (flag == false)
            {
                MessageBox.Show("No se ha seleccionado ninguna provincia para modificar");
            }
            else
            {
                Frm_Mod_Provincia Frm_Mod = new Frm_Mod_Provincia();
                Frm_Mod.Pp_codigoProvincia = Pp_codigoProvincia;
                Frm_Mod.ShowDialog();
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                MessageBox.Show("No se ha seleccionado una Provincia para eliminar");
            }
            else
            {
                Frm_Baja_Prov Frm_Baja = new Frm_Baja_Prov();
                Frm_Baja.Pp_codigoProvincia = Pp_codigoProvincia;
                Frm_Baja.ShowDialog();
                flag = false;
            }
        }

        private void dataGrid_Provincia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Pp_codigoProvincia = dataGrid_Provincia.CurrentRow.Cells["Column1"].Value.ToString();
            flag = true;
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            Provincia provincia = new Provincia();
            if (txt_filtro_cod.Text != "")
            {
                dataGrid_Provincia.Rows.Clear();
                CargarGrilla(provincia.cod_prov(txt_filtro_cod.Text));
                txt_filtro_cod.Clear();
                return;
            }
            if (txt_filtro_nomb.Text != "")
            {
                dataGrid_Provincia.Rows.Clear();
                CargarGrilla(provincia.Cod_prov_nombre(txt_filtro_nomb.Text));
                txt_filtro_nomb.Clear();
            }
        }
        private void CargarGrilla(DataTable tabla)
        {
            //LLenar Grilla
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dataGrid_Provincia.Rows.Add();
                dataGrid_Provincia.Rows[i].Cells[0].Value = tabla.Rows[i]["cod_prov"].ToString();
                dataGrid_Provincia.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre_prov"].ToString();

            }
        }
    }
}
