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
using ComunicAr.Formularios.Barrio;


namespace ComunicAr.Formularios.Barrio
{
    
    public partial class Frm_ABM_Barrio : Form
    {
        public bool flag { get; set; }
        public string codigo_barrio{ get; set; }
        public Frm_ABM_Barrio()
        {
            InitializeComponent();
        }

        private void bttn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridBarrio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo_barrio = GridBarrio.CurrentRow.Cells["cod_barrio"].Value.ToString();
            flag = true;
        }

        private void Frm_ABM_Barrio_Load(object sender, EventArgs e)
        {
            Barrios barrio = new Barrios();
            DataTable tabla = new DataTable();
            tabla = barrio.barriosCompletos();
            CargarGrilla(tabla);
        }

        private void CargarGrilla(DataTable tabla)
        {
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                GridBarrio.Rows.Add();
                GridBarrio.Rows[i].Cells[0].Value = tabla.Rows[i]["cod_barrio"].ToString();
                GridBarrio.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre_barrio"].ToString();
                GridBarrio.Rows[i].Cells[2].Value = tabla.Rows[i]["nombre_ciudad"].ToString();
            }
            flag = false;
        }

        private void bttn_alta_barrio_Click(object sender, EventArgs e)
        {
            Frm_Alta_Barrio Altas = new Frm_Alta_Barrio();
            Altas.ShowDialog();
            flag = false;
        }

        private void bttn_resfrecar_Click(object sender, EventArgs e)
        {
            Barrios barrio = new Barrios();
            DataTable tabla = new DataTable();
            tabla = barrio.barriosCompletos();
            GridBarrio.Rows.Clear();
            CargarGrilla(tabla);
        }

        private void bttn_modificar_barrio_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                Frm_mod_barrio Frm_Mod = new Frm_mod_barrio();
                Frm_Mod.codigo_barrio = codigo_barrio;
                Frm_Mod.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un barrio para modificar");
            }
        }

        private void bttn_baja_barrio_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                Frm_Baja_Barrio Frm_baja = new Frm_Baja_Barrio();
                Frm_baja.codigo_barrio = codigo_barrio;
                Frm_baja.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un barrio para darlo de baja");
            }
        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            Barrios servicios = new Barrios();
            flag = false;
            if (txt_filtro_cod_servicio.Text != "")
            {
                GridBarrio.Rows.Clear();
                CargarGrilla(servicios.Barrios_por_codigo(txt_filtro_cod_servicio.Text));
                txt_filtro_cod_servicio.Clear();
                return;
            }
        }
    }
}
