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
using ComunicAr.Formularios.ABM_Servicios.Contratados;

namespace ComunicAr.Formularios.Servicios
{
    public partial class Frm_ABM_Servicios_Contratados : Form
    {

        public string cod_servicio { get; set; }
        public bool flag { get; set; }
        public Frm_ABM_Servicios_Contratados()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Servicios_Load(object sender, EventArgs e)
        {
            Servicios_Contratados servicio = new Servicios_Contratados();
            DataTable tabla = new DataTable();
            tabla = servicio.ServiciosCompletos();
            CargarGrilla(tabla);

            flag = false;
        }

        private void CargarGrilla(DataTable tabla)
        {
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                GridServicios.Rows.Add();

                GridServicios.Rows[i].Cells[0].Value = tabla.Rows[i]["cod_servicio"].ToString();

                string tipo = tabla.Rows[i]["tipo_servicio"].ToString();
                if (tipo == "A")
                {
                    GridServicios.Rows[i].Cells[1].Value = "Servicio de Datos";
                }
                else if (tipo == "B")
                {
                    GridServicios.Rows[i].Cells[1].Value = "Servicio Fijo";
                }
                else
                {
                    GridServicios.Rows[i].Cells[1].Value = "Servicio Prepago";
                }

                string id = tabla.Rows[i]["id_servicio"].ToString();
                Servicios_Contratados serv_contratado = new Servicios_Contratados();
                string servicio_ofrec = serv_contratado.servicio_ofrecido(tipo, id);
                GridServicios.Rows[i].Cells[2].Value = servicio_ofrec;

                string dia_desde = tabla.Rows[i]["dia_desde"].ToString();
                string mes_desde = tabla.Rows[i]["mes_desde"].ToString();
                string año_desde = tabla.Rows[i]["año_desde"].ToString();
                GridServicios.Rows[i].Cells[3].Value = dia_desde + "/" + mes_desde + "/" + año_desde;

                string dia_hasta = tabla.Rows[i]["dia_hasta"].ToString();
                string mes_hasta = tabla.Rows[i]["mes_hasta"].ToString();
                string año_hasta = tabla.Rows[i]["año_hasta"].ToString();
                GridServicios.Rows[i].Cells[4].Value = dia_hasta + "/" + mes_hasta + "/" + año_hasta;

                string cod_nacional = tabla.Rows[i]["cod_nacional"].ToString();
                string cod_area = tabla.Rows[i]["cod_area"].ToString();
                string nro_tel = tabla.Rows[i]["nro_telefono"].ToString();
                GridServicios.Rows[i].Cells[5].Value = "+" + cod_nacional + " " + cod_area + " " + nro_tel;

            }
        }

        private void btn_salir_cliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttn_modificar_servicios_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                MessageBox.Show("No se ha seleccionado ninguna llamada para modificar");
            }
            else
            {
                Frm_Modificacion_Servicios_Contratados Frm_Mod = new Frm_Modificacion_Servicios_Contratados();
                Frm_Mod.cod_servicio = cod_servicio;
                Frm_Mod.ShowDialog();
            }
        }  
        
        private void GridServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cod_servicio = GridServicios.CurrentRow.Cells["codigo_servicio"].Value.ToString();
            flag = true;
        }

        private void bttn_alta_servicio_Click(object sender, EventArgs e)
        {
            Frm_Alta_Servicios_Contratados Altas = new Frm_Alta_Servicios_Contratados();
            Altas.ShowDialog();

            flag = false;
        }

        private void bttn_baja_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                MessageBox.Show("No se ha seleccionado una llamada para eliminar");
            }
            else
            {

                Frm_Baja_Servicios_Contratados Bajas = new Frm_Baja_Servicios_Contratados();
                Bajas.cod_servicio = cod_servicio;
                Bajas.ShowDialog();

            }

            flag = false;
        }

        private void bttn_refrescar_Click(object sender, EventArgs e)
        {
            Servicios_Contratados servicios = new Servicios_Contratados();
            DataTable tabla = new DataTable();
            tabla = servicios.ServiciosCompletos();
            GridServicios.Rows.Clear();
            CargarGrilla(tabla);

            flag = false;
        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            Servicios_Contratados servicios = new Servicios_Contratados();
            if (txt_filtro_cod_servicio.Text != "")
            {
                GridServicios.Rows.Clear();
                CargarGrilla(servicios.Servicios_contratados_por_codigo(txt_filtro_cod_servicio.Text));
                txt_filtro_cod_servicio.Clear();
                return;
            }
        }

        private void txt_filtro_cod_servicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
