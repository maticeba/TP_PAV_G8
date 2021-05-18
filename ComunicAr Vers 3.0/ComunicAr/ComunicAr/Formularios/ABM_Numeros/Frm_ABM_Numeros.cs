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

namespace ComunicAr.Formularios.ABM_Numeros
{
    public partial class Frm_ABM_Numeros : Form
    {
        public bool flag { get; set; }

        public string id_numeros { get; set; }

        public Frm_ABM_Numeros()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Numeros_Load(object sender, EventArgs e)
        {
            Numeros numero = new Numeros();
            DataTable tabla = new DataTable();
            tabla = numero.NumerosCompletos();
            CargarGrilla(tabla);
            flag = false;
        }

        private void CargarGrilla(DataTable tabla)
        {
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                string cod_nac = tabla.Rows[i]["cod_nacional"].ToString();
                string area_cod = tabla.Rows[i]["cod_area"].ToString();
                string nro_tel = tabla.Rows[i]["nro_telefono"].ToString();
                string numero = "+" + cod_nac + " " + area_cod + " " + nro_tel;
                GridNumero.Rows.Add();
                GridNumero.Rows[i].Cells[0].Value = tabla.Rows[i]["id_numero"].ToString();
                GridNumero.Rows[i].Cells[1].Value = numero.ToString();
                GridNumero.Rows[i].Cells[2].Value = tabla.Rows[i]["nombre_razonSocial"].ToString();
                GridNumero.Rows[i].Cells[3].Value = tabla.Rows[i]["modelo"].ToString();
            }
        }

        private void btn_salir_numero_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridNumero_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            id_numeros = GridNumero.CurrentRow.Cells["id_numero"].Value.ToString();
            flag = true;
        }

        private void btn_crear_numero_Click(object sender, EventArgs e)
        {
            Frm_Alta_Numeros Altas = new Frm_Alta_Numeros();
            Altas.ShowDialog();

            flag = false;
        }

        private void btn_modificar_numero_Click(object sender, EventArgs e)
        { 
            if (flag == false)
            {
                MessageBox.Show("No se ha seleccionado ninguna llamada para modificar");
            }
            else
            {
                Frm_Mod_Numero Frm_Mod = new Frm_Mod_Numero();
                Frm_Mod.id_numeros = id_numeros;
                Frm_Mod.ShowDialog();
            }
        }

        private void btn_refrescar_numero_Click(object sender, EventArgs e)
        {
            Numeros numero = new Numeros();
            DataTable tabla = new DataTable();
            tabla = numero.NumerosCompletos();
            GridNumero.Rows.Clear();
            CargarGrilla(tabla);
        }

        private void btn_eliminar_numero_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                MessageBox.Show("Seleccione un numeros de datos para eliminar");
            }
            else
            {
                Frm_Baja_Numeros Frm_Baja = new Frm_Baja_Numeros();
                Frm_Baja.id_numeros = id_numeros;
                Frm_Baja.ShowDialog();
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            flag = false;
            Numeros numero = new Numeros();
            if (filtro_id_numero.Text != "")
            {
                GridNumero.Rows.Clear();
                CargarGrilla(numero.Numeros_por_id(filtro_id_numero.Text));
                filtro_id_numero.Clear();
                return;
            }
            
        }
    }
}
