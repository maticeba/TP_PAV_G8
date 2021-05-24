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
using ComunicAr.Negocio_Transacciones;
using ComunicAr.Formularios;
using ComunicAr.Clases;
using ComunicAr.Formularios.ABM_Servicios;
namespace ComunicAr.Formularios.Transaccion.Detalles_Servicios.Detalles_Servicios_Prepagos
{
    public partial class Frm_Detalle_Servicio_Prepago : Form

    {

        public string Pp_IdDetallePrepago { get; set; }
        public string Pp_NroFac { get; set; }
        public string Pp_cod_serv_contratados { get; set; }
        public string Pp_Costo_Final { get; set; }
        public float Pp_nro_cuota { get; set; }
        public float Pp_descuento { get; set; }


        public Frm_Detalle_Servicio_Prepago()
        {
            InitializeComponent();
        }
        private void Frm_Detalle_Servicios_Prepago_Load(object sender, EventArgs e)
        {
            Pp_NroFac = "1";
            Pp_descuento = 0;
            Frm_Descuento_Prepago desc = new Frm_Descuento_Prepago();
            desc.ShowDialog();
            Pp_descuento = desc.Pp_descuento;
            DataTable tabla_cliente = new DataTable();
            Detalle_Servicio_Prepago detalle_c = new Detalle_Servicio_Prepago();
            tabla_cliente = detalle_c.CargarCliente(Pp_NroFac);
            Txt_ID_Prepago.Text = tabla_cliente.Rows[0]["nro_cliente"].ToString();
            Txt_Nombre_Prepago.Text = tabla_cliente.Rows[0]["nombre_razonSocial"].ToString();
            Txt_NroFac_Prepago.Text = tabla_cliente.Rows[0]["nro_factura"].ToString();

            DataTable tabla_datos = new DataTable();
            Detalle_Servicio_Fijo detalle_f = new Detalle_Servicio_Fijo();
            tabla_datos = detalle_f.RecoleccionDatos(Pp_IdDetallePrepago);
            grid_Serv_Prepago.Rows.Clear();
            CargarDatos(tabla_datos);
        }

        private void CargarDatos(DataTable tabla)
        {
            float total = 0;
            float precio = 0;
            Pp_descuento = 0;
            grid_Serv_Prepago.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {

                grid_Serv_Prepago.Rows.Add();
                grid_Serv_Prepago.Rows[i].Cells[0].Value = tabla.Rows[i]["cod_detalle"].ToString();
                grid_Serv_Prepago.Rows[i].Cells[1].Value = tabla.Rows[i]["codigo_servicio_contratado"].ToString();
                grid_Serv_Prepago.Rows[i].Cells[2].Value = tabla.Rows[i]["descripcion"].ToString();
                grid_Serv_Prepago.Rows[i].Cells[3].Value = tabla.Rows[i]["costo_mensual"].ToString();
                grid_Serv_Prepago.Rows[i].Cells[4].Value = tabla.Rows[i]["Cuota"].ToString();
                if (Pp_descuento > 0)
                {
                    float desc = ((float.Parse(tabla.Rows[i]["costo_mensual"].ToString()) + float.Parse(tabla.Rows[i]["Cuota"].ToString())) * Pp_descuento) / 100;
                    precio = (float.Parse(tabla.Rows[i]["costo_mensual"].ToString()) + float.Parse(tabla.Rows[i]["Cuota"].ToString())) - desc;

                }
                else
                {
                    precio = (float.Parse(tabla.Rows[i]["costo_mensual"].ToString()) + float.Parse(tabla.Rows[i]["Cuota"].ToString()));

                }
                total += precio;
            }
            txt_subtotal_prepago.Text = total.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            MessageBox.Show("Seleccione un servicio fijo para modificar");


            {
                ABM_Servicios.Prepagos.Frm_Modificar_prepagos mod_prepago = new ABM_Servicios.Prepagos.Frm_Modificar_prepagos();
                mod_prepago.id_pack = Pp_IdDetallePrepago;
                mod_prepago.ShowDialog();

                grid_Serv_Prepago.Rows.Clear();
                DataTable tabla_datos = new DataTable();
                Detalle_Servicio_Fijo detalle_f = new Detalle_Servicio_Fijo();
                tabla_datos = detalle_f.RecoleccionDatos(Pp_IdDetallePrepago);
                CargarDatos(tabla_datos);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ABM_Servicios.Prepagos.Frm_Baja_prepago baja_prepago = new ABM_Servicios.Prepagos.Frm_Baja_prepago();
            baja_prepago.id_pack = Pp_IdDetallePrepago;
            baja_prepago.ShowDialog();

            grid_Serv_Prepago.Rows.Clear();
            DataTable tabla_datos = new DataTable();
            Detalle_Servicio_Fijo Detalle_f = new Detalle_Servicio_Fijo();
            tabla_datos = Detalle_f.RecoleccionDatos(Pp_IdDetallePrepago);
            CargarDatos(tabla_datos);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frm_Detalle_Servicio_Prepago Detalle = new Frm_Detalle_Servicio_Prepago();
            Pp_NroFac = "1";
            if (MessageBox.Show("¿Desea cargar el detalle de Servicio Prepago?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                for (int i = 0; i < grid_Serv_Prepago.Rows.Count - 1; i++)
                {
                    //Detalle.Pp_IdDetallePrepago = grid_Serv_Prepago.Rows[i].Cells[0].Value.ToString();
                    //Detalle.Pp_cod_serv_contratado = grid_Serv_Prepago.Rows[i].Cells[1].Value.ToString();
                    //Detalle.Pp_NroFac = Pp_NroFac;
                    //Detalle.Pp_descuento = txt_subtotal_prepago.Text.ToString();
                    //Detalle.Pp_nro_cuota = grid_Serv_Prepago.Rows[i].Cells[4].Value.ToString();
                    //Detalle.insertarDetalleServicioPrepago();
                }
                MessageBox.Show("Detalle cargado exitosamente");
            }
        }
    }
}