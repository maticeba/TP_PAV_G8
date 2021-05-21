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
namespace ComunicAr.Formularios.ABM_Servicios.Datos
{
    public partial class Frm_ABM_Datos : Form
    {
        public string cod_Datos { get; set; }
        public bool flag { get; set; }

        public Frm_ABM_Datos()
        {
            InitializeComponent();
        }
        private void btn_salir_cliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarGrilla(DataTable tabla)
        {
            //LLenar Grilla
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_Datos.Rows.Add();
                grid_Datos.Rows[i].Cells[0].Value = tabla.Rows[i]["tipo_servicio"].ToString();
                grid_Datos.Rows[i].Cells[0].Value = tabla.Rows[i]["cod_datos"].ToString();
                grid_Datos.Rows[i].Cells[1].Value = tabla.Rows[i]["limite_datos"].ToString();
                grid_Datos.Rows[i].Cells[2].Value = tabla.Rows[i]["descripcion"].ToString();
                grid_Datos.Rows[i].Cells[3].Value = tabla.Rows[i]["costo_fijo"].ToString();

            }
            flag = false;
        }
 

        private void Frm_ABM_Datos_Load(object sender, EventArgs e)
        {
            Servicios_Datos datos = new Servicios_Datos();
            DataTable tabla = new DataTable();
            tabla = datos.ServDatos_Completos();
            CargarGrilla(tabla);
            flag = false;
        }
     
        private void btm_Consulta_Click(object sender, EventArgs e)
        {
            flag = false;
            Servicios_Datos datos = new Servicios_Datos();
            if (filtro_Cod.Text != "")
            {
                grid_Datos.Rows.Clear();
                CargarGrilla(datos.DatosXCodigo(filtro_Cod.Text));
                filtro_Cod.Clear();
                return;

            }
        }
        private void grid_Datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cod_Datos = grid_Datos.CurrentRow.Cells[0].Value.ToString();
            flag = true;
        }
        private void btn_crear_Datos_Click(object sender, EventArgs e)
        {
            Frm_Alta_Datos Altas = new Frm_Alta_Datos();
            Altas.ShowDialog();
            flag = false;

        }

        private void btn_eliminar_cliente_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                MessageBox.Show("Seleccione un Servicio de datos para eliminar");
            }
            else
            {
                Frm_Baja_Datos Frm_Baja = new Frm_Baja_Datos();
                Frm_Baja.cod_Datos = cod_Datos;
                Frm_Baja.ShowDialog();

                Servicios_Datos datos = new Servicios_Datos();
                DataTable tabla = new DataTable();
                tabla = datos.ServDatos_Completos();
                grid_Datos.Rows.Clear();
                CargarGrilla(tabla);

            }
        }

        private void btn_modificar_Datos_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                MessageBox.Show("Seleccione un Servicio de datos para eliminar");
            }
            else
            {
                Frm_ABM_Datos_Modificar Frm_Mod = new Frm_ABM_Datos_Modificar();
                Frm_Mod.cod_Datos = cod_Datos;
                Frm_Mod.ShowDialog();

                Servicios_Datos datos = new Servicios_Datos();
                DataTable tabla = new DataTable();
                tabla = datos.ServDatos_Completos();
                grid_Datos.Rows.Clear();
                CargarGrilla(tabla);
            }
        }

        private void btn_refrescar_dato_Click(object sender, EventArgs e)
        {
            Servicios_Datos datos = new Servicios_Datos();
            DataTable tabla = new DataTable();
            tabla = datos.ServDatos_Completos();
            grid_Datos.Rows.Clear();
            CargarGrilla(tabla);
            flag = false;

        }
    }
}
