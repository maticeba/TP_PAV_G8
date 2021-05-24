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


namespace ComunicAr.Formularios.Transaccion.Detalles_Servicios.Detalle_Servicios_Fijos
{
    public partial class Frm_Detalle_Servicios_Fijos : Form
    {
        public int numero_fila { get; set; }
        public string Pp_NroCliente { get; set; }
        public string Pp_NroFac { get; set; }
        public string Pp_serv_contratados { get; set; }
        public string Pp_Final { get; set; }
        public float Pp_nro_cuota { get; set; }
        public float Pp_descuento { get; set; }
        public bool flag { get; set; }

        public float precio { get; set; }

        public Frm_Detalle_Servicios_Fijos()
        {
            InitializeComponent();
        }

        private void Frm_Detalle_Servicios_Fijos_Load(object sender, EventArgs e)
        {
            Pp_NroFac = "1";
            Pp_NroCliente = "2";
            flag = false;
            Pp_descuento = 0;
            //Frm_desc desc = new Frm_desc();
            //desc.ShowDialog();
            //Pp_descuento = desc.Pp_descuento;
            DataTable tabla_cliente = new DataTable();
            Detalle_Servicio_Fijo detalle_c = new Detalle_Servicio_Fijo();
            tabla_cliente = detalle_c.CargarCliente(Pp_NroFac);
            Txt_ID_SFijos.Text = tabla_cliente.Rows[0]["nro_cliente"].ToString();
            Txt_Nombre_SFijos.Text = tabla_cliente.Rows[0]["nombre_razonSocial"].ToString();
            Txt_NroFac_SFijos.Text = tabla_cliente.Rows[0]["nro_factura"].ToString();

            DataTable tabla_datos = new DataTable();
            Detalle_Servicio_Fijo detalle_f = new Detalle_Servicio_Fijo();
            tabla_datos = detalle_f.RecoleccionDatos(Pp_NroCliente);
            grid_Serv_Fijos.Rows.Clear();
            CargarDatos(tabla_datos);
        }
        private void CargarDatos(DataTable tabla)
        {
            float total = 0;
            float precio = 0;
            Pp_descuento = 0;
            grid_Serv_Fijos.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_Serv_Fijos.Rows.Add();
                grid_Serv_Fijos.Rows[i].Cells[0].Value = tabla.Rows[i]["cod_servicio"].ToString();
                grid_Serv_Fijos.Rows[i].Cells[1].Value = tabla.Rows[i]["tipo_servicio"].ToString();
                grid_Serv_Fijos.Rows[i].Cells[2].Value = tabla.Rows[i]["descripcion"].ToString();
                string cuota = tabla.Rows[i]["diferencia"].ToString() + "/" + tabla.Rows[i]["duracion"].ToString();
                grid_Serv_Fijos.Rows[i].Cells[4].Value = cuota;
                string costo = tabla.Rows[i]["costo_mensual"].ToString();
                grid_Serv_Fijos.Rows[i].Cells[3].Value = costo;
                string descuento = tabla.Rows[i]["descuento"].ToString();
                grid_Serv_Fijos.Rows[i].Cells[5].Value = descuento;
                if (descuento != "")
                {
                    grid_Serv_Fijos.Rows[i].Cells[6].Value = ((float.Parse(costo) - (float.Parse(costo) * float.Parse(descuento) / 100))).ToString();

              
                }
                else
                {
                    grid_Serv_Fijos.Rows[i].Cells[6].Value = costo;
                }
                precio += float.Parse(grid_Serv_Fijos.Rows[i].Cells[6].Value.ToString());

            }

            txt_subtotla_SF.Text = precio.ToString();
            flag = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                MessageBox.Show("Seleccione un servicio fijo para modificar");
            }
            else
            {
                ABM_Servicios.Contratados.Frm_Modificacion_Servicios_Contratados mod_fijo = new ABM_Servicios.Contratados.Frm_Modificacion_Servicios_Contratados();
                mod_fijo.cod_servicio = Pp_serv_contratados;
                mod_fijo.flag = true;
                mod_fijo.ShowDialog();

                grid_Serv_Fijos.Rows.Clear();
                DataTable tabla_datos = new DataTable();
                Detalle_Servicio_Fijo detalle_f = new Detalle_Servicio_Fijo();
                tabla_datos = detalle_f.RecoleccionDatos(Pp_NroCliente);
                CargarDatos(tabla_datos);
                flag = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                MessageBox.Show("Seleccione un servicio fijo para eliminar");
            }
            else
            {
                ABM_Servicios.Contratados.Frm_Baja_Servicios_Contratados baja_fijo = new ABM_Servicios.Contratados.Frm_Baja_Servicios_Contratados();
                baja_fijo.cod_servicio = Pp_serv_contratados;
                baja_fijo.ShowDialog();

                grid_Serv_Fijos.Rows.Clear();
                DataTable tabla_datos = new DataTable();
                Detalle_Servicio_Fijo Detalle_f = new Detalle_Servicio_Fijo();
                tabla_datos = Detalle_f.RecoleccionDatos(Pp_NroCliente);
                CargarDatos(tabla_datos);
                flag = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Detalle_Servicio_Fijo Detalle = new Detalle_Servicio_Fijo();
            Pp_NroFac = "1";
            if (MessageBox.Show("¿Desea cargar el detalle de llamada?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                for (int i = 0; i < grid_Serv_Fijos.Rows.Count - 1; i++)
                {

                    Detalle.Pp_NroFac = Pp_NroFac;
                    Detalle.Pp_serv_contratados = grid_Serv_Fijos.Rows[i].Cells[0].Value.ToString();
                    Detalle.Pp_Final = txt_subtotla_SF.Text.ToString();
                    Detalle.Pp_nro_cuota =
                    Detalle.Pp_descuento = Pp_descuento;

                    Detalle.insertarDetalleServicioFijo();
                }
                MessageBox.Show("Detalle cargado exitosamente");
            }
        }

        private void grid_Serv_Fijos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Pp_serv_contratados = grid_Serv_Fijos.CurrentRow.Cells[0].Value.ToString();
            flag = true;
            numero_fila = int.Parse(grid_Serv_Fijos.CurrentRow.Index.ToString());
            
        }

        private void descuento_fijo_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                MessageBox.Show("Seleccione un servicio fijo para aplicar el descuento");
            }
            else
            {
                Frm_desc desc = new Frm_desc();
                desc.Pp_cod_servicio = Pp_serv_contratados;
                desc.ShowDialog();

                DataTable tabla_datos = new DataTable();
                Detalle_Servicio_Fijo detalle_f = new Detalle_Servicio_Fijo();
                tabla_datos = detalle_f.RecoleccionDatos(Pp_NroCliente);
                grid_Serv_Fijos.Rows.Clear();
                CargarDatos(tabla_datos);
                flag = false;
            }

        }

    
    }
}

