using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComunicAr.Negocio_Transacciones;

namespace ComunicAr.Formularios.Transaccion.Detalles_Servicios.Detalle_Servicios_Datos
{
    public partial class Frm_Detalle_Servicios_Datos : Form
    {
        public string Pp_IdDetalleDatos { get; set; }
        public string Pp_NroFac { get; set; }
        public string Pp_cod_ { get; set; }
        public bool flag { get; set; }
        public string Pp_serv_contratados { get; set; }
        public float Pp_descuento { get; set; }

        public Frm_Detalle_Servicios_Datos()
        {
            InitializeComponent();
        }

        private void Detalle_Servicios_Datos_Load(object sender, EventArgs e)
        {
            Pp_NroFac = "1";
            Pp_descuento = 0;
            Frm_Descuento_Datos desc = new Frm_Descuento_Datos();
            /*desc.ShowDialog();*/
            //Pp_descuento = desc.Pp_descuento;
            DataTable tabla_cliente = new DataTable();
            ComunicAr.Negocio_Transacciones.Detalle_Servicios_Datos detalle_c = new Negocio_Transacciones.Detalle_Servicios_Datos();
            tabla_cliente = detalle_c.CargarCliente(Pp_NroFac);
            txt_id_cliente.Text = tabla_cliente.Rows[0]["nro_cliente"].ToString();
            txt_nombre_cliente.Text = tabla_cliente.Rows[0]["nombre_razonSocial"].ToString();
            txt_nro_factura.Text = tabla_cliente.Rows[0]["nro_factura"].ToString();

            DataTable tabla_datos = new DataTable();
            Negocio_Transacciones.Detalle_Servicios_Datos detalle = new Negocio_Transacciones.Detalle_Servicios_Datos();
            tabla_datos = detalle.RecoleccionDatos(txt_id_cliente.Text);
            CargarDatos(tabla_datos);
        }
        private void CargarDatos(DataTable tabla)
        {
            float total = 0;
            float precio = 0;
            Pp_descuento = 0;
            grid_Servicios_Datos.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                string costo = tabla.Rows[i]["costo_fijo"].ToString();
                grid_Servicios_Datos.Rows.Add();
                grid_Servicios_Datos.Rows[i].Cells[0].Value = tabla.Rows[i]["cod_servicio"].ToString();
                grid_Servicios_Datos.Rows[i].Cells[1].Value = "Servicios de datos";
                grid_Servicios_Datos.Rows[i].Cells[2].Value = tabla.Rows[i]["costo_fijo"].ToString();
                string cuota = tabla.Rows[i]["diferencia"].ToString() + "/" + tabla.Rows[i]["duracion"].ToString();
                grid_Servicios_Datos.Rows[i].Cells[3].Value = cuota;
                grid_Servicios_Datos.Rows[i].Cells[4].Value = tabla.Rows[i]["descuento"].ToString();

                string descuento = tabla.Rows[i]["descuento"].ToString();
                if (descuento != "")
                {
                    grid_Servicios_Datos.Rows[i].Cells[5].Value = (float.Parse(costo) - float.Parse(costo) * float.Parse(descuento) / 100).ToString();

                }
                else
                {
                    grid_Servicios_Datos.Rows[i].Cells[5].Value = tabla.Rows[i]["costo_fijo"].ToString();
                }
                precio += float.Parse(grid_Servicios_Datos.Rows[i].Cells[5].Value.ToString());
            }
            txt_subtotla_SF.Text = precio.ToString();
            flag = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_descuento_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                MessageBox.Show("Seleccione un servicio de datos para aplicar el descuento");
            }
            else
            {
                Frm_Descuento_Datos descuento = new Frm_Descuento_Datos();
                descuento.Pp_codigo_servicios = Pp_serv_contratados;
                descuento.ShowDialog();

                DataTable tabla_datos = new DataTable();
                Negocio_Transacciones.Detalle_Servicios_Datos detalle = new Negocio_Transacciones.Detalle_Servicios_Datos();
                tabla_datos = detalle.RecoleccionDatos(txt_id_cliente.Text);
                grid_Servicios_Datos.Rows.Clear();
                CargarDatos(tabla_datos);
                flag = false;
            }
        }

        private void grid_Servicios_Datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Pp_serv_contratados = grid_Servicios_Datos.CurrentRow.Cells[0].Value.ToString();
            flag = true;
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            {
                if (flag == false)
                {
                    MessageBox.Show("Seleccione un servicio de datos para eliminar");
                }
                else
                {
                    ABM_Servicios.Contratados.Frm_Baja_Servicios_Contratados baja_dato = new ABM_Servicios.Contratados.Frm_Baja_Servicios_Contratados();
                    baja_dato.cod_servicio = Pp_serv_contratados;
                    baja_dato.ShowDialog();

                    grid_Servicios_Datos.Rows.Clear();
                    DataTable tabla_datos = new DataTable();
                    Negocio_Transacciones.Detalle_Servicios_Datos detalle = new Negocio_Transacciones.Detalle_Servicios_Datos();
                    tabla_datos = detalle.RecoleccionDatos(txt_id_cliente.Text);
                    CargarDatos(tabla_datos);
                    flag = false;
                }
            }
        }
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            {
                if (flag == false)
                {
                    MessageBox.Show("Seleccione un servicio de datos para modificar");
                }
                else
                {
                    ABM_Servicios.Contratados.Frm_Modificacion_Servicios_Contratados mod_dato = new ABM_Servicios.Contratados.Frm_Modificacion_Servicios_Contratados();
                    mod_dato.cod_servicio = Pp_serv_contratados;
                    mod_dato.flag = true;
                    mod_dato.ShowDialog();

                    grid_Servicios_Datos.Rows.Clear();
                    DataTable tabla_datos = new DataTable();
                    Negocio_Transacciones.Detalle_Servicios_Datos detalle = new Negocio_Transacciones.Detalle_Servicios_Datos();
                    tabla_datos = detalle.RecoleccionDatos(txt_id_cliente.Text);
                    CargarDatos(tabla_datos);
                    flag = false;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                DataTable tabla_datos = new DataTable();
                Negocio_Transacciones.Detalle_Servicios_Datos detalle = new Negocio_Transacciones.Detalle_Servicios_Datos();
                tabla_datos = detalle.RecoleccionDatos(txt_id_cliente.Text);
                Negocio_Transacciones.Detalle_Servicios_Datos Detalle = new Negocio_Transacciones.Detalle_Servicios_Datos();
                Pp_NroFac = "1";
                if (MessageBox.Show("¿Desea cargar el detalle del servicio?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    for (int i = 0; i < grid_Servicios_Datos.Rows.Count; i++)
                    {
                        Detalle.Pp_NroFac = Pp_NroFac;
                        Detalle.Pp_serv_contratados = grid_Servicios_Datos.Rows[i].Cells[0].Value.ToString();
                        Detalle.Pp_Final = txt_subtotla_SF.Text.ToString();
                        Detalle.Pp_nro_cuota = tabla_datos.Rows[i]["diferencia"].ToString();
                        //Detalle.Pp_descuento = Pp_descuento;
                        Detalle.Pp_descuento = tabla_datos.Rows[i]["descuento"].ToString();

                        Detalle.insertarDetalleServicioDato();
                    }
                    MessageBox.Show("Detalle cargado exitosamente");
                }
            }
        }
    }
}
