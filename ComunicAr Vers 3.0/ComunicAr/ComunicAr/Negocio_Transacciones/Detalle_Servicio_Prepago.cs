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
    class Detalle_Servicio_Prepago
    {
        public string Pp_IdDetallePrepago { get; set; }
        public string Pp_NroFac { get; set; }
        public string Pp_cod_serv_contratados { get; set; }
        public string Pp_Final { get; set; }
        public string Pp_nro_cuota { get; set; }
        public string Pp_descuento { get; set; }

        Acceso_BD BD = new Acceso_BD();

        public DataTable CargarCliente(string NroFac)
        {
            string sql = @"SELECT f.nro_factura, c.nombre_razonSocial, c.nro_cliente "
                          + "FROM Facturas f, Cliente c "
                          + " WHERE f.nro_factura = " + NroFac + " AND f.nro_cliente = c.nro_cliente ";
            return BD.EjecutarSelect(sql);
           

        }
        public DataTable RecoleccionDatos(string nro_cliente)
        {
            string sql = @"SELECT DISTINCT  c.fecha_desde, c.fecha_hasta, DATEDIFF(month,c.fecha_desde,convert(date,GETDATE())) as diferencia,DATEDIFF (month, c.fecha_desde, c.fecha_hasta) as duracion, "
                        + "p.costo,p.tipo_servicio,p.descripcion,r.descripcion_region, n.id_numero ,c.cod_servicio, c.id_numero ,n.nro_cliente,c.descuento, p.id_pack "
                        + "FROM Servicios_prepago p,Servicios_Contratados c, Numero n ,Region r "
                        + "WHERE c.tipo_servicio= p.tipo_servicio AND c.id_servicio = p.id_pack  AND p.id_region = r.id_region " +
                        "AND n.nro_cliente = " + nro_cliente  +" AND c.id_numero = n.id_numero " ;
        
            return BD.EjecutarSelect(sql);
        }

        public void InsertarDetalleServicioPrepago()
        {
            if (Pp_descuento == "")
            {
                Pp_descuento = "0";
            }
            string sql = @"INSERT INTO Detalle_fact_prepago (nro_factura, cod_servicio_contratado, costo_final, descuento) " +
                                 "VALUES (" + Pp_NroFac + ", " + Pp_cod_serv_contratados + ", " + Pp_Final + ", " +
                                 "REPLACE('" + Pp_descuento + "', ',', '.'))";
            BD.Insertar(sql);
        }
        public DataTable Factura_prepago(string nro_factura, string nro_cliente)
        {
            string sql = @"SELECT  sp.descripcion AS detalle, " +
                                    "dp.costo_final AS importe, " +
                                    "dp.descuento," +
                                    "sp.costo " +
                          "FROM Detalle_fact_prepago dp, Servicios_contratados c, Facturas f, Servicios_prepago sp, Numero n " +
                          "WHERE dp.cod_servicio_contratado = c.cod_servicio " +
                                "AND f.nro_factura = dp.nro_factura " +
                                "AND c.id_servicio = sp.id_pack " +
                                "AND c.tipo_servicio = 'C' " +
                                "AND c.id_numero = n.id_numero " +
                                "AND n.nro_cliente = " + nro_cliente + " "+
                                "AND dp.nro_factura = " + nro_factura + " " +
                                "AND MONTH(c.fecha_desde) = MONTH(DATEADD(MM, -1, GETDATE())) " +
                                "AND YEAR(c.fecha_desde) = YEAR(DATEADD(MM, -1, GETDATE()))";
            return BD.EjecutarSelect(sql);
        }
    }
}
