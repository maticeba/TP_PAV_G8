using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ComunicAr.Clases;
using System.Windows.Forms;

namespace ComunicAr.Negocio_Transacciones
{
    class Detalle_Venta_Dispositivo
    {
        public string Pp_NroFac { get; set; }
        public string Pp_precioVta { get; set; }

        public string Pp_venta_dispositivo { get; set; }

        public string pp_marca { get; set; }

        public string pp_modelo { get; set; }

        public string pp_descuento { get; set; }
        public string pp_nroCuota { get; set; }

        Acceso_BD BD = new Acceso_BD();

        public DataTable CargarCliente(string NroFac)
        {
            string sql = @"SELECT f.nro_factura, f.nro_cliente, c.nombre_razonSocial, c.nro_cliente "
                          + "FROM Facturas f, Cliente c"
                          + " WHERE f.nro_factura = " + NroFac + " AND f.nro_cliente = c.nro_cliente ";
            return BD.EjecutarSelect(sql);

        }

        public DataTable RecoleccionDatos(string nro_cliente)
        {
            string sql = @"select v.id_venta_dispo, v.fecha_venta,d.marca, d.modelo, v.cant_cuotas, d.precio, v.descuento "
                         + "from Dispositivos d , venta_dispositivo v, numero n"
                         + "where n.nro_cliente =  " + nro_cliente + " and v.id_dispositivo = d.id_dispositivo and n.id_dispositivo = d.id_dispositivo";
            return BD.EjecutarSelect(sql);


        }


        public void insertarDetalleVentaDispositivo()
        {
            string sql = @"insert into Detalle_fact_dispositivo (nro_factura,id_venta_dispo, marca,modelo,precio_venta,descuento,nro_cuota) values ( " +
                Pp_NroFac + ", " + Pp_venta_dispositivo + ", " + pp_marca + "," + pp_modelo + "," + Pp_precioVta + "," + pp_descuento + ", " + pp_nroCuota + " ) ";
            BD.Insertar(sql);

        }



    }
}
