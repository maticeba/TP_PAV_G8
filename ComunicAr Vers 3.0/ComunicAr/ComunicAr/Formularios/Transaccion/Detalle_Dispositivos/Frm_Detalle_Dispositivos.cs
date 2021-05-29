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
using ComunicAr.Formularios.Transaccion.Detalle_Dispositivos.Descuento_Venta;
using ComunicAr.Formularios;
using ComunicAr.Clases;

namespace ComunicAr.Formularios.Transaccion.Detalle_Dsipositivos
{

    public partial class Frm_Detalle_VtaDispo : Form
    {
        public int numero_fila { get; set; }
        public string Pp_NroCliente { get; set; }
        public string Pp_NroFac { get; set; }
        public bool flag { get; set; }
        public float Pp_descuento { get; set; }
        public string Pp_venta_dispositivo { get; set; }

        public Frm_Detalle_VtaDispo()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void CargarDatos(DataTable tabla)
        {
            float total = 0;
            float precio = 0;
            Pp_descuento = 0;
            dataGridView_DetVtaDisp.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dataGridView_DetVtaDisp.Rows.Add();
                dataGridView_DetVtaDisp.Rows[i].Cells[0].Value = tabla.Rows[i]["id_venta_dispo"].ToString();
                dataGridView_DetVtaDisp.Rows[i].Cells[1].Value = tabla.Rows[i]["fecha_venta"].ToString();
                dataGridView_DetVtaDisp.Rows[i].Cells[2].Value = tabla.Rows[i]["marca"].ToString();
                dataGridView_DetVtaDisp.Rows[i].Cells[3].Value = tabla.Rows[i]["modelo"].ToString();
                string cuota = tabla.Rows[i]["diferencia"].ToString() + "/" + tabla.Rows[i]["cant_cuotas"].ToString();
                dataGridView_DetVtaDisp.Rows[i].Cells[4].Value = cuota;
                dataGridView_DetVtaDisp.Rows[i].Cells[8].Value = tabla.Rows[i]["diferencia"].ToString();
                string costo = tabla.Rows[i]["precio"].ToString();
                dataGridView_DetVtaDisp.Rows[i].Cells[5].Value = costo;
                string descuento = tabla.Rows[i]["descuento"].ToString();
                dataGridView_DetVtaDisp.Rows[i].Cells[6].Value = descuento;

                if (descuento != "")
                {
                    dataGridView_DetVtaDisp.Rows[i].Cells[7].Value = ((float.Parse(costo) - (float.Parse(costo) * float.Parse(descuento) / 100))).ToString();


                }
                else
                {
                    dataGridView_DetVtaDisp.Rows[i].Cells[7].Value = costo;
                }
                precio += float.Parse(dataGridView_DetVtaDisp.Rows[i].Cells[7].Value.ToString());


              
            }


            txt_DetVtaDispo_Subtotal.Text = precio.ToString();
            flag = false;

        }
       

        private void btn_DetVtaDisp_Generar_Click(object sender, EventArgs e)
        {
            Detalle_Venta_Dispositivo detalle = new Detalle_Venta_Dispositivo();
            Pp_NroFac = "1";
            if (MessageBox.Show("¿Desea cargar el detalle de Venta de Dispositivo?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                for (int i = 0; i < dataGridView_DetVtaDisp.Rows.Count - 1; i++)
                {
                    detalle.Pp_NroFac = Pp_NroFac;
                    detalle.Pp_venta_dispositivo = dataGridView_DetVtaDisp.Rows[i].Cells[0].Value.ToString();
                    detalle.pp_marca = dataGridView_DetVtaDisp.Rows[i].Cells[2].Value.ToString();
                    detalle.pp_modelo = dataGridView_DetVtaDisp.Rows[i].Cells[3].Value.ToString();
                    detalle.Pp_precioVta = dataGridView_DetVtaDisp.Rows[i].Cells[5].Value.ToString();
                    detalle.pp_descuento = dataGridView_DetVtaDisp.Rows[i].Cells[6].Value.ToString();
                    detalle.pp_nroCuota =  dataGridView_DetVtaDisp.Rows[i].Cells[8].Value.ToString();

                    detalle.insertarDetalleVentaDispositivo();


                }
                MessageBox.Show("Detalle cargado exitosamente");
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                MessageBox.Show("Seleccione un dispositivo para aplicar el descuento");
            }
            else
            {
                Frm_Descuento_VtaDisp desc = new Frm_Descuento_VtaDisp();
                desc.Pp_venta_dispositivo = Pp_venta_dispositivo;
                desc.ShowDialog();

                DataTable tabla_datos = new DataTable();
                Detalle_Venta_Dispositivo detalle_v = new Detalle_Venta_Dispositivo();
                tabla_datos = detalle_v.RecoleccionDatos(Pp_NroCliente);
                dataGridView_DetVtaDisp.Rows.Clear();
                CargarDatos(tabla_datos);
                flag = false;
            }

        }

        private void Frm_Detalle_VtaDispo_Load(object sender, EventArgs e)
        {
            Pp_NroFac = "1";
            Pp_NroCliente = "1";
            flag = false;
            Pp_descuento = 0;
            //Frm_desc desc = new Frm_desc();
            //desc.ShowDialog();
            //Pp_descuento = desc.Pp_descuento;
            DataTable tabla_cliente = new DataTable();
            Detalle_Venta_Dispositivo detalle_v = new Detalle_Venta_Dispositivo();
            tabla_cliente = detalle_v.CargarCliente(Pp_NroFac);
            txt_DetVtaDisp_IdCliente.Text = tabla_cliente.Rows[0]["nro_cliente"].ToString();
            txt_DetVtaDisp_NombCliente.Text = tabla_cliente.Rows[0]["nombre_razonSocial"].ToString();
            txt_DetVtaDisp_NroFactura.Text = tabla_cliente.Rows[0]["nro_factura"].ToString();

            DataTable tabla_datos = new DataTable();
            Detalle_Venta_Dispositivo detalle_f = new Detalle_Venta_Dispositivo();
            tabla_datos = detalle_v.RecoleccionDatos(Pp_NroCliente);
            dataGridView_DetVtaDisp.Rows.Clear();
            CargarDatos(tabla_datos);
        }

        private void dataGridView_DetVtaDisp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Pp_venta_dispositivo = dataGridView_DetVtaDisp.CurrentRow.Cells[0].Value.ToString();
            flag = true;
            
        }

       
    }
}
