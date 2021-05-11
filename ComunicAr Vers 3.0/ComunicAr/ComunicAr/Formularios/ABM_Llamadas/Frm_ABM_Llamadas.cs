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
using ComunicAr.Formularios.ABM_Llamadas;

namespace ComunicAr.Formularios.ABM_Llamadas
{
    public partial class Frm_ABM_Llamadas : Form
    {
        public string id_llamada { get; set; }
        public bool flag { get; set; }
        public Frm_ABM_Llamadas()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Llamadas_Load(object sender, EventArgs e)
        {
            //LLENAR EL GRIDBOX CON LOS DATOS DE LA TABLA LLAMADAS APENAS CARGUE EL FORMULARIO
            Llamadas llamadas = new Llamadas();
            DataTable tabla = new DataTable();
            tabla = llamadas.LlamadasCompletas();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dataGridView1.Rows.Add();
                string cod_nac_emisor = tabla.Rows[i]["nac_emisor"].ToString();
                string cod_area_emisor = tabla.Rows[i]["area_emisor"].ToString();
                string nro_emisor = tabla.Rows[i]["tel_emisor"].ToString();
                string emisor = "+" + cod_nac_emisor + " " + cod_area_emisor + " " + nro_emisor;
                dataGridView1.Rows[i].Cells[0].Value = emisor;
                string cod_nac_receptor = tabla.Rows[i]["nac_recept"].ToString();
                string cod_area_receptor = tabla.Rows[i]["area_recept"].ToString();
                string nro_receptor = tabla.Rows[i]["tel_recept"].ToString();
                string receptor = "+" + cod_nac_receptor + " " + cod_area_receptor + " " + nro_receptor;
                dataGridView1.Rows[i].Cells[1].Value = receptor;
                dataGridView1.Rows[i].Cells[2].Value = tabla.Rows[i]["fecha_hora_inicio"].ToString();
                dataGridView1.Rows[i].Cells[3].Value = tabla.Rows[i]["duracion"].ToString();
                dataGridView1.Rows[i].Cells[4].Value = tabla.Rows[i]["Tipo_com"].ToString();
                dataGridView1.Rows[i].Cells[5].Value = tabla.Rows[i]["Banda_horaria"].ToString();
                dataGridView1.Rows[i].Cells[6].Value = tabla.Rows[i]["identificador"].ToString();
            }
            flag = false;
        }

        private void btn_refresh_ABM_llamadas_Click(object sender, EventArgs e)
        {
            Llamadas llamadas = new Llamadas();
            DataTable tabla = new DataTable();
            tabla = llamadas.LlamadasCompletas();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dataGridView1.Rows.Add();
                string cod_nac_emisor = tabla.Rows[i]["nac_emisor"].ToString();
                string cod_area_emisor = tabla.Rows[i]["area_emisor"].ToString();
                string nro_emisor = tabla.Rows[i]["tel_emisor"].ToString();
                string emisor = "+" + cod_nac_emisor + " " + cod_area_emisor + " " + nro_emisor;
                dataGridView1.Rows[i].Cells[0].Value = emisor;
                string cod_nac_receptor = tabla.Rows[i]["nac_recept"].ToString();
                string cod_area_receptor = tabla.Rows[i]["area_recept"].ToString();
                string nro_receptor = tabla.Rows[i]["tel_recept"].ToString();
                string receptor = "+" + cod_nac_receptor + " " + cod_area_receptor + " " + nro_receptor;
                dataGridView1.Rows[i].Cells[1].Value = receptor;
                dataGridView1.Rows[i].Cells[2].Value = tabla.Rows[i]["fecha_hora_inicio"].ToString();
                dataGridView1.Rows[i].Cells[3].Value = tabla.Rows[i]["duracion"].ToString();
                dataGridView1.Rows[i].Cells[4].Value = tabla.Rows[i]["Tipo_com"].ToString();
                dataGridView1.Rows[i].Cells[5].Value = tabla.Rows[i]["Banda_horaria"].ToString();
                dataGridView1.Rows[i].Cells[6].Value = tabla.Rows[i]["identificador"].ToString();
            }
            flag = false;
        }

        private void btn_crear_ABM_llamadas_Click(object sender, EventArgs e)
        {
            Frm_Alta_Llamadas Alta_Llamada = new Frm_Alta_Llamadas();
            Alta_Llamada.ShowDialog();

            Llamadas llamadas = new Llamadas();
            DataTable tabla = new DataTable();
            tabla = llamadas.LlamadasCompletas();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dataGridView1.Rows.Add();
                string cod_nac_emisor = tabla.Rows[i]["nac_emisor"].ToString();
                string cod_area_emisor = tabla.Rows[i]["area_emisor"].ToString();
                string nro_emisor = tabla.Rows[i]["tel_emisor"].ToString();
                string emisor = "+" + cod_nac_emisor + " " + cod_area_emisor + " " + nro_emisor;
                dataGridView1.Rows[i].Cells[0].Value = emisor;
                string cod_nac_receptor = tabla.Rows[i]["nac_recept"].ToString();
                string cod_area_receptor = tabla.Rows[i]["area_recept"].ToString();
                string nro_receptor = tabla.Rows[i]["tel_recept"].ToString();
                string receptor = "+" + cod_nac_receptor + " " + cod_area_receptor + " " + nro_receptor;
                dataGridView1.Rows[i].Cells[1].Value = receptor;
                dataGridView1.Rows[i].Cells[2].Value = tabla.Rows[i]["fecha_hora_inicio"].ToString();
                dataGridView1.Rows[i].Cells[3].Value = tabla.Rows[i]["duracion"].ToString();
                dataGridView1.Rows[i].Cells[4].Value = tabla.Rows[i]["Tipo_com"].ToString();
                dataGridView1.Rows[i].Cells[5].Value = tabla.Rows[i]["Banda_horaria"].ToString();
                dataGridView1.Rows[i].Cells[6].Value = tabla.Rows[i]["identificador"].ToString();
            }
            flag = false;
        }

        private void btn_salir_ABM_llamadas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_llamada = dataGridView1.CurrentRow.Cells["identificador"].Value.ToString();
            flag = true;
        }

        private void btn_modificar_ABM_llamadas_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                MessageBox.Show("No se ha seleccionado ninguna llamada para modificar");
            }
            else
            {
                Frm_Modificar_Llamadas Mod_Llamada = new Frm_Modificar_Llamadas();
                Mod_Llamada.id_llamada = id_llamada;
                Mod_Llamada.ShowDialog();

                Llamadas llamadas = new Llamadas();
                DataTable tabla = new DataTable();
                tabla = llamadas.LlamadasCompletas();
                dataGridView1.Rows.Clear();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    string cod_nac_emisor = tabla.Rows[i]["nac_emisor"].ToString();
                    string cod_area_emisor = tabla.Rows[i]["area_emisor"].ToString();
                    string nro_emisor = tabla.Rows[i]["tel_emisor"].ToString();
                    string emisor = "+" + cod_nac_emisor + " " + cod_area_emisor + " " + nro_emisor;
                    dataGridView1.Rows[i].Cells[0].Value = emisor;
                    string cod_nac_receptor = tabla.Rows[i]["nac_recept"].ToString();
                    string cod_area_receptor = tabla.Rows[i]["area_recept"].ToString();
                    string nro_receptor = tabla.Rows[i]["tel_recept"].ToString();
                    string receptor = "+" + cod_nac_receptor + " " + cod_area_receptor + " " + nro_receptor;
                    dataGridView1.Rows[i].Cells[1].Value = receptor;
                    dataGridView1.Rows[i].Cells[2].Value = tabla.Rows[i]["fecha_hora_inicio"].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = tabla.Rows[i]["duracion"].ToString();
                    dataGridView1.Rows[i].Cells[4].Value = tabla.Rows[i]["Tipo_com"].ToString();
                    dataGridView1.Rows[i].Cells[5].Value = tabla.Rows[i]["Banda_horaria"].ToString();
                    dataGridView1.Rows[i].Cells[6].Value = tabla.Rows[i]["identificador"].ToString();
                }
            }
        }

        private void btn_eliminar_ABM_llamadas_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                MessageBox.Show("No se ha seleccionado una llamada para eliminar");
            }
            else
            {
                Frm_Baja_Llamadas Baja_Llamada = new Frm_Baja_Llamadas();
                Baja_Llamada.id_llamada = id_llamada;
                Baja_Llamada.ShowDialog();

                Llamadas llamadas = new Llamadas();
                DataTable tabla = new DataTable();
                tabla = llamadas.LlamadasCompletas();
                dataGridView1.Rows.Clear();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    string cod_nac_emisor = tabla.Rows[i]["nac_emisor"].ToString();
                    string cod_area_emisor = tabla.Rows[i]["area_emisor"].ToString();
                    string nro_emisor = tabla.Rows[i]["tel_emisor"].ToString();
                    string emisor = "+" + cod_nac_emisor + " " + cod_area_emisor + " " + nro_emisor;
                    dataGridView1.Rows[i].Cells[0].Value = emisor;
                    string cod_nac_receptor = tabla.Rows[i]["nac_recept"].ToString();
                    string cod_area_receptor = tabla.Rows[i]["area_recept"].ToString();
                    string nro_receptor = tabla.Rows[i]["tel_recept"].ToString();
                    string receptor = "+" + cod_nac_receptor + " " + cod_area_receptor + " " + nro_receptor;
                    dataGridView1.Rows[i].Cells[1].Value = receptor;
                    dataGridView1.Rows[i].Cells[2].Value = tabla.Rows[i]["fecha_hora_inicio"].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = tabla.Rows[i]["duracion"].ToString();
                    dataGridView1.Rows[i].Cells[4].Value = tabla.Rows[i]["Tipo_com"].ToString();
                    dataGridView1.Rows[i].Cells[5].Value = tabla.Rows[i]["Banda_horaria"].ToString();
                    dataGridView1.Rows[i].Cells[6].Value = tabla.Rows[i]["identificador"].ToString();
                }
                flag = false;
            }
        }
    }
}
