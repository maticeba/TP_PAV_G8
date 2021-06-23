using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ComunicAr.Clases;
using System.Windows.Forms;


namespace ComunicAr.Negocio_Transacciones
{
    class Detalle_Servicios_Datos
    {
        public string Pp_IdDetallePrepago { get; set; }
        public string Pp_NroFac { get; set; }
        public string Pp_serv_contratados {get; set;}
        public string Pp_cod_serv_contratados { get; set; }
        public string Pp_Final { get; set; }
        public string Pp_nro_cuota { get; set; }
        public string Pp_descuento { get; set; }

        Acceso_BD BD = new Acceso_BD();
        public DataTable CargarCliente(string NroFac)
        {
            string sql = @"SELECT f. *, f.nro_factura, c.nombre_razonSocial, c.nro_cliente "
                          + "FROM Facturas f, Cliente c"
                          + " WHERE f.nro_factura = " + NroFac + " " +
                          " AND f.nro_cliente = c.nro_cliente ";
            return BD.EjecutarSelect(sql);
            // reveer

        }
        public DataTable RecoleccionDatos(string nro_cliente)
        {
            string sql = @"SELECT DISTINCT  sc.tipo_servicio, sc.cod_servicio, " +
                                          " d.id_dispositivo, n.nro_cliente, sd.costo_fijo, sc.descuento, " +
                                          " DATEDIFF(month, sc.fecha_desde, convert(date,GETDATE())) as diferencia, " +
                                          " DATEDIFF(month, sc.fecha_desde, sc.fecha_hasta) as duracion " +
                          "FROM Servicios_contratados sc, Dispositivos d, Servicios_datos sd, Numero n " +
                          "WHERE sc.id_servicio = sd.cod_datos AND d.id_dispositivo = n.id_dispositivo " +
                                 "AND sc.id_numero = n.id_numero " +
                                 "AND sc.tipo_servicio = sd.tipo_servicio " +
                                 "AND n.nro_cliente = " + nro_cliente + " " +
                                 "AND (DATEDIFF(month, sc.fecha_desde, convert(date,GETDATE())) <= DATEDIFF(month, sc.fecha_desde, sc.fecha_hasta)) " +
                                 "AND (DATEDIFF(month, sc.fecha_desde, convert(date,GETDATE())) > 0)";
            return BD.EjecutarSelect(sql);
        }
        public void insertarDetalleServicioDato()
        {
            if (Pp_descuento == "")
            {
                Pp_descuento = "0";
            }
            string sql = @"INSERT INTO Detalle_fact_datos (nro_factura, cod_serv_contratado, costo_final, descuento, nro_cuota)"
                        + " VALUES (" + Pp_NroFac + ", " + Pp_serv_contratados + ", REPLACE('" + Pp_Final + "', ',', '.'), REPLACE('" + Pp_descuento + "', ',', '.'), "  + Pp_nro_cuota + " ) ";
            BD.Insertar(sql);
        }
        public DataTable Factura_datos(string nro_factura, string nro_cliente)
        {
            string sql = @"SELECT  sd.descripcion AS detalle, " +
                                    "dd.costo_final AS importe, " +
                                    "dd.descuento," +
                                    "sd.costo_fijo " +
                          "FROM Detalle_fact_datos dd, Servicios_contratados c, Facturas f, Servicios_datos sd, Numero n " +
                          "WHERE dd.cod_serv_contratado = c.cod_servicio " +
                                "AND f.nro_factura = dd.nro_factura " +
                                "AND c.id_servicio = sd.cod_datos " +
                                "AND c.tipo_servicio = 'A' " +
                                "AND c.id_numero = n.id_numero " +
                                "AND n.nro_cliente = " + nro_cliente + " " +
                                "AND dd.nro_factura = " + nro_factura + " ";
            return BD.EjecutarSelect(sql);
        }
    }
}
