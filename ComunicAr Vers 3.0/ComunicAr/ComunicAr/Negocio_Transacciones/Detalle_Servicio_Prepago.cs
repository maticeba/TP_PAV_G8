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
        public float Pp_nro_cuota { get; set; }
        public float Pp_descuento { get; set; }

        Acceso_BD BD = new Acceso_BD();

        public DataTable CargarCliente(string NroFac)
        {
            string sql = @"SELECT f.nro_factura, f.cod_serv_contratado, c.nombre_razonSocial, c.nro_cliente "
                          + "FROM Facturas f, Cliente c"
                          + " WHERE f.nro_factura = " + NroFac + " AND f.nro_cliente = c.nro_cliente ";
            return BD.EjecutarSelect(sql);
            // reveer

        }
        public DataTable RecoleccionDatos(string id_pack)
        {
            string sql = @"SELECT s. *, r.descripcion_region " + " FROM servicios_prepago s, region r "

                       + "WHERE s.id_pack = " + id_pack + "AND s.id_region = r.id_region";
            return BD.EjecutarSelect(sql);
        }

        public void insertarDetalleServicioPrepago()
        {
            string sql = @"INSERT INTO Detalle_fact_prepago (nro_factura, cod_serv_contratados, costo_final,descuento,nro_cuota) VALUES( " +
                        Pp_NroFac + ", " +
                        Pp_cod_serv_contratados + ", " +
                         Pp_Final+", "+ ", " + Pp_descuento + ", "+ 4 + " ) ";
            BD.Insertar(sql);



        }
    }
}
