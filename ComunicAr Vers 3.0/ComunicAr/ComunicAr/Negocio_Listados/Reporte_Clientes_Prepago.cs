using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComunicAr.Clases;
using System.Data;

namespace ComunicAr.Negocio_Listados
{
    class Reporte_Clientes_Prepago
    {
        Acceso_BD BD = new Acceso_BD();

        public DataTable ReporteDatos_todos()
        {
            string sql = "SELECT c.nombre_razonSocial, sp.descripcion, sp.costo, " +
                      "('+' + n.cod_nacional + ' ' +  n.cod_area + ' ' + n.nro_telefono) AS nro_telefono " +
                      "FROM Cliente c, Numero n, Servicios_contratados sc, Servicios_prepago sp " +
                      "WHERE c.nro_cliente = n.nro_cliente" +
                      " AND n.id_numero = sc.id_numero AND sc.tipo_servicio = sp.tipo_servicio" +
                      " AND sc.id_servicio = sp.id_pack " +
                      "ORDER BY c.nro_cliente";
            DataTable tabla = new DataTable();
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }
        public DataTable ReporteDatos_cantidadMayor(string tope)
        {
            //string sql = ;
            DataTable tabla = new DataTable();
            //tabla = BD.EjecutarSelect(sql);
            return tabla;
        }
    }
}
