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
using ComunicAr.Formularios.ABM_Servicios.Contratados;
using ComunicAr.Formularios.Transaccion.Detalles_Servicios.Detalle_Servicios_Fijos;


namespace ComunicAr.Formularios.Transaccion.Detalles_Servicios.Detalles_Servicios_Prepagos
{
    public partial class Frm_Detalle_SPrepago : Form
    {
        public string Pp_IdDetallePrepago { get; set; }
        public string Pp_NroCliente { get; set; }
        public string Pp_NroFac { get; set; }
        public string Pp_cod_serv_contratados { get; set; }
        public string Pp_Costo_Final { get; set; }
        public string Pp_nro_cuota { get; set; }
        public string Pp_descuento { get; set; }
        public bool bandera { get; set; }
        public int numero_fila { get; set; }

        public float precio { get; set; }
        public Frm_Detalle_SPrepago()
        {
            InitializeComponent();
        }

        private void Frm_Detalle_SPrepago_Load(object sender, EventArgs e)
        {
            bandera = false;
            DataTable tabla_cliente = new DataTable();
            Detalle_Servicio_Prepago detalle_c = new Detalle_Servicio_Prepago();
            tabla_cliente = detalle_c.CargarCliente(Pp_NroFac);
            Txt_ID_SPrepagos.Text = tabla_cliente.Rows[0]["nro_cliente"].ToString();
            Txt_Nombre_SPrepagos.Text = tabla_cliente.Rows[0]["nombre_razonSocial"].ToString();
            Txt_NroFac_SPrepagos.Text = tabla_cliente.Rows[0]["nro_factura"].ToString();

            DataTable tabla_datos = new DataTable();
            Detalle_Servicio_Prepago detalle_f = new Detalle_Servicio_Prepago();
            tabla_datos = detalle_f.RecoleccionDatos(Pp_NroCliente);
            grid_Serv_Prepagos.Rows.Clear();
            CargarDatos(tabla_datos);

        }
        private void CargarDatos(DataTable tabla)
        {
            float precio = 0;
            grid_Serv_Prepagos.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {

                grid_Serv_Prepagos.Rows.Add();
                grid_Serv_Prepagos.Rows[i].Cells[0].Value = tabla.Rows[i]["cod_servicio"].ToString();
                grid_Serv_Prepagos.Rows[i].Cells[1].Value = tabla.Rows[i]["tipo_servicio"].ToString();
                grid_Serv_Prepagos.Rows[i].Cells[2].Value = tabla.Rows[i]["descripcion"].ToString();
                string costo = tabla.Rows[i]["costo"].ToString();
                grid_Serv_Prepagos.Rows[i].Cells[3].Value = costo;
                string descuento = tabla.Rows[i]["descuento"].ToString();
                grid_Serv_Prepagos.Rows[i].Cells[4].Value = descuento;
                if (descuento != "")

                {
                    grid_Serv_Prepagos.Rows[i].Cells[5].Value = ((float.Parse(costo) - (float.Parse(costo) * float.Parse(descuento) / 100))).ToString();

                }
                else
                {
                    grid_Serv_Prepagos.Rows[i].Cells[5].Value = costo;

                }
                precio += float.Parse(grid_Serv_Prepagos.Rows[i].Cells[5].Value.ToString());
            }
            txt_subtotla_SP.Text = precio.ToString();
            bandera = false;
        }

        private void grid_Serv_Prepagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable tabla_datos = new DataTable();
            Detalle_Servicio_Prepago detalle_f = new Detalle_Servicio_Prepago();
            tabla_datos = detalle_f.RecoleccionDatos(Pp_NroCliente);
            Pp_cod_serv_contratados = grid_Serv_Prepagos.CurrentRow.Cells[0].Value.ToString();
            bandera = true;
            numero_fila = int.Parse(grid_Serv_Prepagos.CurrentRow.Index.ToString());
        }
        private void btn_det_prepago_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_det_prepago_modificar_Click(object sender, EventArgs e)
        {
            if (bandera == false)
            {
                MessageBox.Show("Seleccione un servicio fijo para modificar");
            }
            else
            {
                ABM_Servicios.Contratados.Frm_Modificacion_Servicios_Contratados mod_fijo = new ABM_Servicios.Contratados.Frm_Modificacion_Servicios_Contratados();
                mod_fijo.cod_servicio = Pp_cod_serv_contratados;
                mod_fijo.flag = true;
                mod_fijo.ShowDialog();

                grid_Serv_Prepagos.Rows.Clear();
                DataTable tabla_datos = new DataTable();
                Detalle_Servicio_Prepago detalle_f = new Detalle_Servicio_Prepago();
                tabla_datos = detalle_f.RecoleccionDatos(Pp_NroCliente);
                CargarDatos(tabla_datos);
                bandera = false;

            }
        }
        private void btn_det_prepago_borrar_Click(object sender, EventArgs e)
        {
            if (bandera == false)
            {
                MessageBox.Show("Seleccione un servicio prepago para eliminar");
            }
            else
            {
                ABM_Servicios.Contratados.Frm_Baja_Servicios_Contratados baja_fijo = new ABM_Servicios.Contratados.Frm_Baja_Servicios_Contratados();
                baja_fijo.cod_servicio = Pp_cod_serv_contratados;
                baja_fijo.ShowDialog();

                DataTable tabla_datos = new DataTable();
                Detalle_Servicio_Prepago detalle_f = new Detalle_Servicio_Prepago();
                tabla_datos = detalle_f.RecoleccionDatos(Pp_NroCliente);
                grid_Serv_Prepagos.Rows.Clear();
                CargarDatos(tabla_datos);
                bandera = false;
            }
        }



        private void descuento_Click(object sender, EventArgs e)
        {

            if (bandera == false)
            {
                MessageBox.Show("Seleccione un servicio prepago para aplicar el descuento");
            }
            else
            {
                Frm_desc desc = new Frm_desc();
                desc.Pp_cod_servicio = Pp_cod_serv_contratados;
                desc.ShowDialog();

                DataTable tabla_datos = new DataTable();
                Detalle_Servicio_Prepago detalle_f = new Detalle_Servicio_Prepago();
                tabla_datos = detalle_f.RecoleccionDatos(Pp_NroCliente);
                grid_Serv_Prepagos.Rows.Clear();
                CargarDatos(tabla_datos);
                bandera = false;
            }
        }

        private void btn_det_prepago_generar_Click(object sender, EventArgs e)
        {
            DataTable tabla_datos = new DataTable();
            Detalle_Servicio_Prepago Detalle = new Detalle_Servicio_Prepago();
            tabla_datos = Detalle.RecoleccionDatos(Pp_NroCliente);
            if (MessageBox.Show("¿Desea cargar el detalle de servicio?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                for (int i = 0; i < grid_Serv_Prepagos.Rows.Count; i++)
                {
                    Detalle.Pp_NroFac = Pp_NroFac;
                    Detalle.Pp_cod_serv_contratados = grid_Serv_Prepagos.Rows[i].Cells[0].Value.ToString();
                    Detalle.Pp_Final = txt_subtotla_SP.Text.ToString();
                    Detalle.Pp_descuento = grid_Serv_Prepagos.Rows[i].Cells[4].Value.ToString();
                    Detalle.InsertarDetalleServicioPrepago();
                }
                MessageBox.Show("Detalle cargado exitosamente");
            }
            this.Close();
        }

        private void txt_subtotla_SP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
