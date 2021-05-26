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
using System.IO;
using System.Diagnostics;
using System.Security.Principal;


namespace ComunicAr.Transaccion.Emision_de_Factura
{
    public partial class Frm_EmisionFactura : Form
    {
        public bool Flag_serv_fijos { get; set; }
        public bool Flag_serv_datos { get; set; }
        public bool Flag_serv_prepago { get; set; }
        public bool Flag_llamadas { get; set; }
        public bool Flag_vta_dispo { get; set; }

        Detalle_Llamadas det_llamada = new Detalle_Llamadas();
        Frm_Detalle_Llamada Llamadas = new Frm_Detalle_Llamada();

        public Frm_EmisionFactura()
        {
            InitializeComponent();
        }

        private void btn_emision_llamadas_Click(object sender, EventArgs e)
        {
            //Detalle de Llamada

            DataTable tabla = det_llamada.RecoleccionDatos(Txt_Cliente.Text);
            if (tabla.Rows.Count != 0)
            {
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

        private void Frm_EmisionFactura_Load(object sender, EventArgs e)
        {

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
                    //Tratamiento de obtención del usuario del sistema que utiliza el sistema
                    WindowsIdentity Usuario = WindowsIdentity.GetCurrent();
                    string nombreCompleto = Usuario.Name.ToString();
                    string[] user = nombreCompleto.Split('\\');

                    //ubicación donde se guardan las facturas
                    string path = @"C:\\Users\\" + user[1] + "\\Desktop\\Facturas_ComunicAr";

                    //Creación del directorio por si no existe en el Escritorio\Facturas_Comunicar
                    if (Directory.Exists(path) == false)
                    {
                        Directory.CreateDirectory(path);
                    }

                    //Crea la factura en el directorio anterior mente mensionado. Su nombre contiene: 
                    //          [año]_[mes]_[tipoFactura][nroFactura]_[idCliente]
                    string name_arch = DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month.ToString() + "_" +
                                       cmb_emision_tipo_factura.Text.ToString() + Txt_nroFac.Text + "_" + Txt_Cliente.Text;
                    File.Create(path + "\\" + name_arch + ".txt").Dispose();

                    //Escribir en el archivo
                    using (TextWriter tw = new StreamWriter(path + "\\" + name_arch + ".txt", true)) // El true es mucho muy importante sino reescribe el archivo en vez de agregar
                    {
                        float subtotal = 0;
                        tw.WriteLine("*****************************************************************************");
                        tw.WriteLine("                                COMUNIC-AR");
                        tw.WriteLine("*****************************************************************************");
                        tw.WriteLine("");
                        tw.WriteLine("CUIT: 33-71548658-9  -  Responsable Inscripto");
                        tw.WriteLine("Av. Hipólito Yrigoyen 146, Córdoba Capital, Córdoba, Argentina");
                        tw.WriteLine("Tel: 0800-9998967 - info@comunicar.com.ar - www.comunicar.com.ar");
                        tw.WriteLine("_____________________________________________________________________________");
                        tw.WriteLine("                                  FACTURA");
                        tw.WriteLine("");
                        tw.WriteLine("- Tipo: " + cmb_emision_tipo_factura.Text.ToString());
                        tw.WriteLine("- Nro. Factura: " + Txt_nroFac.Text);
                        tw.WriteLine("- Fecha: " + DateTime.Now.ToString());
                        MessageBox.Show(DateTime.Now.ToString());
                        tw.WriteLine("_____________________________________________________________________________");
                        tw.WriteLine("                                  CLIENTE");
                        tw.WriteLine("");
                        tw.WriteLine("Nro. Cliente: " + Txt_Cliente.Text);
                        tw.WriteLine("Nombre: " + Txt_NombreCliente.Text);
                        tw.WriteLine("DNI: " + " - Consumidor Final");
                        tw.WriteLine("_____________________________________________________________________________");
                        tw.WriteLine("Item\tTipo Servicio\t\tDetalle\t\t\t\tImporte");
                        int count = 0;
                        float descuento = 0;
                        if (Flag_llamadas == true)
                        {
                            DataTable tabla = det_llamada.Factura_llamada(Txt_nroFac.Text, Txt_Cliente.Text);
                            count += 1;
                            string cant = tabla.Rows[0][0].ToString();
                            string total = tabla.Rows[0][1].ToString();
                            string tiempo_tot = tabla.Rows[0][2].ToString();
                            tw.WriteLine(count.ToString() + "\tLlamadas\t\t" + "Cant.: "+ cant + " / Tiempo: " + tiempo_tot + "\t\t$" + total);
                            subtotal = float.Parse(total.ToString());
                        }
                        if (Flag_serv_fijos == true)
                        {

                        }
                        if (Flag_serv_datos == true)
                        {

                        }
                        if (Flag_serv_prepago == true)
                        {

                        }
                        if (Flag_vta_dispo == true)
                        {

                        }
                        //tw.WriteLine("*****************************************************************************");
                        tw.WriteLine("_____________________________________________________________________________");
                        tw.WriteLine("Subtotal: \t\t\t$" + subtotal.ToString());
                        tw.WriteLine("Descuento: \t\t\t$" + descuento.ToString());
                        tw.WriteLine("Total: \t\t\t\t$" + (subtotal-descuento).ToString());
                    }

                    Process p = new Process();
                    ProcessStartInfo ps = new ProcessStartInfo(path + "\\" + name_arch + ".txt");
                    ps.FileName = name_arch + ".txt";
                    ps.Arguments = path + "\\" + name_arch + ".txt";
                    ps.UseShellExecute = false;
                    ps.RedirectStandardInput = true;

                    p.StartInfo = ps;
                    Process.Start("notepad.exe", path + "\\" + name_arch + ".txt");
                }
            }
        }

        private void bnt_emision_servicio_datos_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("No hay servicios datos de este cliente para agregar en la factura");
            MessageBox.Show("Mantenimiento");
            chk_emision_serv_datos.Checked = true;
            btn_emision_servicio_datos.Enabled = false;
        }

        private void bnt_emision_servicio_prepago_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("No hay servicios prepagos de este cliente para agregar en la factura");
            MessageBox.Show("Mantenimiento");
            chk_emision_serv_prepago.Checked = true;
            btn_emision_servicio_prepago.Enabled = false;
        }

        private void bnt_emision_vta_dispo_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("No hay venta de dispostivos de este cliente para agregar en la factura");
            MessageBox.Show("Mantenimiento");
            chk_emision_vta_dispo.Checked = true;
            btn_emision_vta_dispo.Enabled = false;
        }
    }
}
