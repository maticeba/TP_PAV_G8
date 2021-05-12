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
using ComunicAr.Formularios.ABM_Dispositivos;


namespace ComunicAr.Formularios.ABM_Dispositivos
{
    public partial class Frm_ABM_Dispositivos : Form
    {
        public bool flag { get; set; }
        public string id_dispositivos { get; set; }
        public Frm_ABM_Dispositivos()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Dispositivos_Load(object sender, EventArgs e)
        {
            Dispositivos dispositivo = new Dispositivos();
            DataTable tabla = new DataTable();
            tabla = dispositivo.Dispositivos_Completos();
            CargarGrilla(tabla);
            cmb_FiltroMarca.CargarCombo();
            cmb_FiltroMarca.SelectedIndex = -1;
            flag = false;
        }

        private void grid_Dispo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_dispositivos = grid_Dispo.CurrentRow.Cells[0].Value.ToString();
            flag = true;
        }

        private void CargarGrilla(DataTable tabla)
        {
            //LLenar Grilla
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_Dispo.Rows.Add();
                grid_Dispo.Rows[i].Cells[0].Value = tabla.Rows[i]["id_dispositivo"].ToString();
                grid_Dispo.Rows[i].Cells[1].Value = tabla.Rows[i]["fecha_elaboracion"].ToString();
                grid_Dispo.Rows[i].Cells[2].Value = tabla.Rows[i]["marca"].ToString();
                grid_Dispo.Rows[i].Cells[3].Value = tabla.Rows[i]["modelo"].ToString();
                grid_Dispo.Rows[i].Cells[4].Value = tabla.Rows[i]["caracteristicas"].ToString();
                grid_Dispo.Rows[i].Cells[5].Value = tabla.Rows[i]["precio"].ToString();
                grid_Dispo.Rows[i].Cells[6].Value = tabla.Rows[i]["id_tipo_dispositivo"].ToString();
            }
        }


        private void btn_salir_Dispo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btm_Consulta_Click(object sender, EventArgs e)
        {
            Dispositivos dispositivo = new Dispositivos();
            flag = false;
            if (filtro_ID_Dis.Text != "")
            {
                grid_Dispo.Rows.Clear();
                CargarGrilla(dispositivo.FiltroXid(filtro_ID_Dis.Text));
                filtro_ID_Dis.Clear();
                return;

            }
            if (cmb_FiltroMarca.SelectedIndex != -1)
            {
                grid_Dispo.Rows.Clear();
                CargarGrilla(dispositivo.FiltroXmarca(cmb_FiltroMarca.SelectedValue.ToString()));
                return;

            }
        }

        private void btn_crear_Dispo_Click(object sender, EventArgs e)
        {
            Frm_ABM_Alta_Dispositivo Altas = new Frm_ABM_Alta_Dispositivo();
            Altas.ShowDialog();
        }

        private void btn_refrescar_Dispo_Click(object sender, EventArgs e)
        {
            Dispositivos dispositivo = new Dispositivos();
            DataTable tabla = new DataTable();
            tabla = dispositivo.Dispositivos_Completos();
            grid_Dispo.Rows.Clear();
            CargarGrilla(tabla);
            flag = false;
        }

        private void btn_modificar_Dispo_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                MessageBox.Show("No se ha seleccionado un dispositivo");

            }
            else
            {
                Frm_ABM_Modificar_Dispositivo mod = new Frm_ABM_Modificar_Dispositivo();
                mod.id_dispositivo = id_dispositivos;
                mod.ShowDialog();
                flag = false;
            }
        }

        private void btn_eliminar_Dispo_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                MessageBox.Show("No se ha seleccionado un dispositivo");

            }
            else
            {
                Frm_ABM_Baja_Dispositivo del = new Frm_ABM_Baja_Dispositivo();
                del.id_dispositivo = id_dispositivos;
                del.ShowDialog();
                flag = false;
            }

        }
    }
}
