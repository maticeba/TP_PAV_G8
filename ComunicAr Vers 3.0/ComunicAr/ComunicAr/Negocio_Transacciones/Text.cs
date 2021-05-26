using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using ComunicAr.Clases;
using ComunicAr.Negocio_Transacciones;
using ComunicAr.Formularios.Transaccion.Detalles_Servicios.Detalle_Servicios_Fijos;
using ComunicAr.Formularios.Transaccion.Detalle_Llamada;
using System.IO;
using System.Diagnostics;
using System.Security.Principal;

namespace ComunicAr.Negocio_Transacciones
{
    class Text
    {
        public bool Pb_Flag_Llamadas { get; set; }
        public bool Pb_Flag_Serv_Fijos { get; set; }
        public bool Pb_Flag_Serv_Datos { get; set; }
        public bool Pb_Flag_Serv_Prepago { get; set; }
        public bool Pb_Flag_Vta_Dispo { get; set; }
        public string Ps_Tipo_Factura { get; set; }
        public string Ps_Nro_Factura { get; set; }
        public string Ps_Nro_Cliente { get; set; }
        public string Ps_Nombre_Cliente { get; set; }
        public void CreateFactura()
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
                               Ps_Tipo_Factura + Ps_Nro_Factura + "_" + Ps_Nro_Cliente;
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
                tw.WriteLine("- Tipo: " + Ps_Tipo_Factura);
                tw.WriteLine("- Nro. Factura: " + Ps_Nro_Factura);
                tw.WriteLine("- Fecha: " + DateTime.Now.ToString());
                MessageBox.Show(DateTime.Now.ToString());
                tw.WriteLine("_____________________________________________________________________________");
                tw.WriteLine("                                  CLIENTE");
                tw.WriteLine("");
                tw.WriteLine("Nro. Cliente: " + Ps_Nro_Cliente);
                tw.WriteLine("Nombre: " + Ps_Nombre_Cliente);
                tw.WriteLine("DNI: " + " - Consumidor Final");
                tw.WriteLine("_____________________________________________________________________________");
                tw.WriteLine("Item\tTipo Servicio\t\tDetalle\t\t\t\tImporte");
                int count = 0;
                float descuento = 0;
                if (Pb_Flag_Llamadas == true)
                {
                    Detalle_Llamadas det_llamada = new Detalle_Llamadas();
                    DataTable tabla = det_llamada.Factura_llamada(Ps_Nro_Factura, Ps_Nro_Cliente);
                    count += 1;
                    string cant = tabla.Rows[0][0].ToString();
                    string total = tabla.Rows[0][1].ToString();
                    string tiempo_tot = tabla.Rows[0][2].ToString();
                    tw.WriteLine(count.ToString() + "\tLlamadas\t\t" + "Cant.: " + cant + " / Tiempo: " + tiempo_tot + "\t\t$" + total);
                    subtotal = float.Parse(total.ToString());
                }
                if (Pb_Flag_Serv_Fijos == true)
                {

                }
                if (Pb_Flag_Serv_Datos == true)
                {

                }
                if (Pb_Flag_Serv_Prepago == true)
                {

                }
                if (Pb_Flag_Vta_Dispo == true)
                {

                }
                //tw.WriteLine("*****************************************************************************");
                tw.WriteLine("_____________________________________________________________________________");
                tw.WriteLine("Subtotal: \t\t\t$" + subtotal.ToString());
                tw.WriteLine("Descuento: \t\t\t$" + descuento.ToString());
                tw.WriteLine("Total: \t\t\t\t$" + (subtotal - descuento).ToString());
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
