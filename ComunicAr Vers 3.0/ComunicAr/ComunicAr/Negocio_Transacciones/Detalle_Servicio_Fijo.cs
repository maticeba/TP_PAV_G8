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
    class Detalle_Servicio_Fijo
    {
        public string Pp_NroFac { get; set; }
        public string Pp_serv_contratados { get; set; }
        public string Pp_Final { get; set; }
        public float Pp_nro_cuota { get; set; }
        public float Pp_descuento { get; set; }

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
            string sql = @"SELECT DISTINCT  c.fecha_desde, c.fecha_hasta, DATEDIFF(month,c.fecha_desde,convert(date,GETDATE())) as diferencia,DATEDIFF (month, c.fecha_desde, c.fecha_hasta) as duracion, "
                        + "f.costo_mensual,f.tipo_servicio,f.descripcion,c.cod_servicio,c.id_numero,n.id_numero,n.nro_cliente,c.descuento "
                        + "FROM Servicios_fijos f,Servicios_Contratados c, Numero n "
                        + "WHERE c.tipo_servicio= f.tipo_servicio AND c.id_servicio= f.cod_servicio " +
                        "AND n.nro_cliente = " + nro_cliente + " AND c.id_numero = n.id_numero ";
            return BD.EjecutarSelect(sql);
        }

        public void insertarDetalleServicioFijo()
        {
            string sql = @"INSERT INTO Detalle_fact_fijos (nro_factura, cod_serv_contratados, costo_final,descuento,nro_cuota) VALUES( " +
                        Pp_NroFac + ", " +
                        Pp_serv_contratados + ", " +
                         Pp_Final+", "+ ", " + Pp_descuento + ", "+ 4 + " ) ";
            BD.Insertar(sql);



        }
    }
}
