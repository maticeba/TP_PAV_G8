using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComunicAr.Clases;
using ComunicAr.Negocio_Transacciones;
using ComunicAr.Formularios.Transaccion.Detalles_Servicios.Detalle_Servicios_Fijos;
using ComunicAr.Formularios.Transaccion.Detalle_Llamada;
using ComunicAr.Formularios.Transaccion.Detalle_Dsipositivos;
using ComunicAr.Formularios.Transaccion.Detalles_Servicios.Detalles_Servicios_Prepagos;
using ComunicAr.Formularios.Transaccion.Detalles_Servicios.Detalle_Servicios_Datos;


namespace ComunicAr.Formularios.Transaccion.Emision_Factura
{
    public partial class Frm_EmisionFactura : Form
    {
        public bool Flag_serv_fijos { get; set; }
        public bool Flag_serv_datos { get; set; }
        public bool Flag_serv_prepago { get; set; }
        public bool Flag_llamadas { get; set; }
        public bool Flag_vta_dispo { get; set; }

        public Frm_EmisionFactura()
        {
            InitializeComponent();
        }

        private void btn_emision_llamadas_Click(object sender, EventArgs e)
        {
            //Detalle de Llamada
            Detalle_Llamadas det_llamada = new Detalle_Llamadas();
            DataTable tabla = det_llamada.RecoleccionDatos(Txt_Cliente.Text);

            if (tabla.Rows.Count != 0)
            {
                Frm_Detalle_Llamada Llamadas = new Frm_Detalle_Llamada();
                Llamadas.Pp_NroFac = Txt_nroFac.Text;
                Llamadas.Pp_NroCliente = Txt_Cliente.Text;
                Llamadas.ShowDialog();
                chk_emision_Llamadas.Checked = true;
                btn_emision_llamadas.Enabled = false;
                Flag_llamadas = true;
            }
            else
            {
                MessageBox.Show("No hay llamadas de este cliente para agregar");
                chk_emision_Llamadas.Checked = true;
                btn_emision_llamadas.Enabled = false;
                Flag_llamadas = false;
            }

        }

        private void btn_emision_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_emision_buscar_cliente_Click(object sender, EventArgs e)
        {
            if (Txt_Cliente.Text == "")
            {
                MessageBox.Show("Ingrese un número de cliente");
                
            }
            else
            {
                Negocio.Llamadas llamadas = new Negocio.Llamadas();
                DataTable existEmisor = new DataTable();
                existEmisor = llamadas.Search_cliente(Txt_Cliente.Text);
                if (existEmisor.Rows.Count == 0)
                {
                    MessageBox.Show("No se ha encontrado el cliente buscado");
                }
                else
                {
                    string nombre = existEmisor.Rows[0]["nombre_razonSocial"].ToString();
                    string numero = Txt_Cliente.Text;
                    MessageBox.Show("El cliente emisor es " + nombre);
                    Txt_NombreCliente.Text = nombre;
                    Emitir_Factura emicion = new Emitir_Factura();
                    emicion.Pp_nroCliente = numero;
                    DataTable tabla = new DataTable();
                    emicion.CrearSubFactura(numero);
                    tabla = emicion.CargarFactura(numero);
                    Txt_nroFac.Text = tabla.Rows[0]["nro_factura"].ToString();
                    Txt_FechEm.Text = tabla.Rows[0]["fecha_emitido"].ToString();
                    Txt_1er.Text = tabla.Rows[0]["fecha_1er_vto"].ToString();
                    Txt_2do.Text = tabla.Rows[0]["fecha_2do_vto"].ToString();
                    cmb_emision_tipo_factura.Enabled = true;
                    btn_emision_llamadas.Enabled = true;
                    btn_emision_servicio_fijo.Enabled = true;
                    btn_emision_servicio_datos.Enabled = true;
                    btn_emision_servicio_prepago.Enabled = true;
                    btn_emision_vta_dispo.Enabled = true;
                }
            }
        }

        private void bnt_emision_servicio_fijo_Click(object sender, EventArgs e)
        {
            Detalle_Servicio_Fijo det_fijo = new Detalle_Servicio_Fijo();
            DataTable tabla = det_fijo.RecoleccionDatos(Txt_Cliente.Text);

            if (tabla.Rows.Count != 0)
            {
                Frm_Detalle_Servicios_Fijos Frm_det_fijo = new Frm_Detalle_Servicios_Fijos();
                Frm_det_fijo.Pp_NroFac = Txt_nroFac.Text;
                Frm_det_fijo.Pp_NroCliente = Txt_Cliente.Text;
                Frm_det_fijo.ShowDialog();
                chk_emision_serv_fijo.Checked = true;
                btn_emision_servicio_fijo.Enabled = false;
                Flag_serv_fijos = true;
            }
            else
            {
                MessageBox.Show("No hay servicios fijos de este cliente para agregar en la factura");
                chk_emision_serv_fijo.Checked = true;
                btn_emision_servicio_fijo.Enabled = false;
            }
        }

        private void btn_emision_emitir_Click(object sender, EventArgs e)
        {
            if (Flag_serv_fijos == false && Flag_llamadas == false && Flag_serv_datos == false && Flag_serv_prepago == false
                    && Flag_vta_dispo == false)
            {
                MessageBox.Show("El cliente no tiene elementos para ser facturado");
            }
            else
            {
                TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
                if (Tratamiento.Validar(Controls) == TratamientosEspeciales.Resultado.correcto)
                {
                    Text Texto = new Text();
                    Texto.Pb_Flag_Llamadas = Flag_llamadas;
                    Texto.Pb_Flag_Serv_Datos = Flag_serv_datos;
                    Texto.Pb_Flag_Serv_Fijos = Flag_serv_fijos;
                    Texto.Pb_Flag_Serv_Prepago = Flag_serv_prepago;
                    Texto.Pb_Flag_Vta_Dispo = Flag_vta_dispo;
                    Texto.Ps_Nombre_Cliente = Txt_NombreCliente.Text;
                    Texto.Ps_Nro_Cliente = Txt_Cliente.Text;
                    Texto.Ps_Nro_Factura = Txt_nroFac.Text;
                    Texto.Ps_Tipo_Factura = cmb_emision_tipo_factura.Text.ToString();
                    Texto.CreateFactura();
                }
            }
        }

        private void bnt_emision_servicio_datos_Click(object sender, EventArgs e)
        {
            Frm_Detalle_Servicios_Datos datos = new Frm_Detalle_Servicios_Datos();
            datos.ShowDialog();

            
            //MessageBox.Show("Mantenimiento");
            chk_emision_serv_datos.Checked = true;
            btn_emision_servicio_datos.Enabled = false;
        }

        private void bnt_emision_servicio_prepago_Click(object sender, EventArgs e)
        {
            //Detalle de Servicio Prepago
            Detalle_Servicio_Prepago det_prepago = new Detalle_Servicio_Prepago() ;
            DataTable tabla = det_prepago.RecoleccionDatos(Txt_Cliente.Text);

            if (tabla.Rows.Count != 0)
            {
                Frm_Detalle_SPrepago Prepago = new Frm_Detalle_SPrepago();
                Prepago.Pp_NroFac = Txt_nroFac.Text;
                Prepago.Pp_NroCliente = Txt_Cliente.Text;
                Prepago.ShowDialog();
                chk_emision_serv_prepago.Checked = true;
                btn_emision_servicio_prepago.Enabled = false;
                Flag_serv_prepago = true;
            }
            else
            {
                MessageBox.Show("No hay servicios prepagos de este cliente para agregar en la factura");
                chk_emision_serv_prepago.Checked = true;
                btn_emision_servicio_prepago.Enabled = false;
                Flag_serv_prepago = false;
            }

        }

        private void bnt_emision_vta_dispo_Click(object sender, EventArgs e)
        {
            //Detalle de Servicio Prepago
            Detalle_Venta_Dispositivo det_vta_dispo = new Detalle_Venta_Dispositivo();
            DataTable tabla = det_vta_dispo.RecoleccionDatos(Txt_Cliente.Text);

            //MessageBox.Show("No hay venta de dispostivos de este cliente para agregar en la factura");
            chk_emision_vta_dispo.Checked = true;
            btn_emision_vta_dispo.Enabled = false;
            Flag_vta_dispo = false;

            if (tabla.Rows.Count != 0)
            {
                Frm_Detalle_VtaDispo vta_dispo = new Frm_Detalle_VtaDispo();
                vta_dispo.Pp_NroFac = Txt_nroFac.Text;
                vta_dispo.Pp_NroCliente = Txt_Cliente.Text;
                vta_dispo.ShowDialog();
                chk_emision_vta_dispo.Checked = true;
                btn_emision_vta_dispo.Enabled = false;
                Flag_vta_dispo = true;
            }
            else
            {
                MessageBox.Show("No hay venta de dispostivos de este cliente para agregar en la factura");
                chk_emision_vta_dispo.Checked = true;
                btn_emision_vta_dispo.Enabled = false;
                Flag_vta_dispo = false;
            }

        }

        private void Frm_EmisionFactura_Load(object sender, EventArgs e)
        {

        }
    }
}
