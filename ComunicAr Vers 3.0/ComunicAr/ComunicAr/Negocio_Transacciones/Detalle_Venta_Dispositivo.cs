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
            string sql = @"select v.id_venta_dispo, v.fecha_venta,d.marca, d.modelo, v.cant_cuotas, d.precio, v.descuento, DATEDIFF(MONTH,v.fecha_venta,GETDATE ()) as diferencia "
                         + " from Dispositivos d , venta_dispositivo v, numero n"
                         + " where n.nro_cliente =  " + nro_cliente + " and v.id_dispositivo = d.id_dispositivo and n.id_dispositivo = d.id_dispositivo " +
                         "and DATEDIFF(MONTH,v.fecha_venta,GETDATE ()) BETWEEN 1 AND v.cant_cuotas ";
            return BD.EjecutarSelect(sql);


        }
        public void insertarDetalleVentaDispositivo()
        {
            if (pp_descuento == "")
            {
                pp_descuento = "0";
            }
            string sql = @"insert into Detalle_fact_dispositivo (nro_factura,id_venta_dispo, marca,modelo,precio_venta,descuento,nro_cuota) values ( " +
                Pp_NroFac + ", " + Pp_venta_dispositivo + ",'" + pp_marca + "','" + pp_modelo + "'," + "REPLACE('" + Pp_precioVta + "', ',', '.')" + ", " + "REPLACE('" + pp_descuento + "', ',', '.')" + ", " + pp_nroCuota + " )";
            BD.Insertar(sql);
        }
        public DataTable Factura_Dispositivo(string nro_factura, string nro_cliente)
        {
            string sql = @"SELECT  d.marca AS marca, " + 
                                  "d.modelo AS modelo, " +
                                  "dd.precio_venta AS importe, " +
                                  "dd.nro_cuota AS cuota, " +
                                  "vd.cant_cuotas, " +
                                  "dd.descuento, " +
                                  "d.precio " +
                          "FROM Detalle_fact_dispositivo dd, Venta_dispositivo vd, Facturas f, Dispositivos d, Numero n " +
                          "WHERE dd.id_venta_dispo = vd.id_venta_dispo " +
                          "AND f.nro_factura = dd.nro_factura " +
                          "AND vd.id_dispositivo = d.id_dispositivo " +
                          "AND d.id_dispositivo = n.id_dispositivo " +
                          "AND n.nro_cliente = " + nro_cliente + " " +
                          "AND dd.nro_factura = " + nro_factura + " " +
                          "AND DATEDIFF(MONTH,vd.fecha_venta,GETDATE ()) BETWEEN 1 AND vd.cant_cuotas";
            return BD.EjecutarSelect(sql);
        }
    }
}
