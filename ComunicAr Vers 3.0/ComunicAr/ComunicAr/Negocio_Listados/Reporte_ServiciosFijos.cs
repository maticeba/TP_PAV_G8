using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ComunicAr.Clases;

namespace ComunicAr.Negocio_Listados
{
    class Reporte_ServiciosFijos
    {
        DataTable tabla = new DataTable();
        Acceso_BD BD = new Acceso_BD();

        public DataTable ReporteTodos()
        {
            string sql = @"SELECT n.nro_telefono, n.cod_nacional, n.cod_area, c.nombre_razonSocial, s.descripcion, s.costo_mensual " +
                           " FROM Cliente c, Numero n, Servicios_fijos s, Servicios_contratados p " + 
                           " WHERE n.id_numero = p.id_numero AND n.nro_cliente = c.nro_cliente AND s.cod_servicio = p.cod_servicio AND p.tipo_servicio = 'B'";
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }
        public DataTable ReporteCliente(string nro_cliente)
        {
            string sql = @"SELECT n.nro_telefono, n.cod_nacional, n.cod_area, c.nombre_razonSocial, s.descripcion, s.costo_mensual " +
                           " FROM Cliente c, Numero n, Servicios_fijos s, Servicios_contratados p " +
                           " WHERE n.id_numero = p.id_numero AND n.nro_cliente = c.nro_cliente AND s.cod_servicio = p.cod_servicio AND p.tipo_servicio = 'B' AND c.nro_cliente = " + nro_cliente;
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }
        public DataTable ReportNum(string menor,string mayor)
        {
            string sql = @"SELECT n.nro_telefono, n.cod_nacional, n.cod_area, c.nombre_razonSocial, s.descripcion, s.costo_mensual " +
                           " FROM Cliente c, Numero n, Servicios_fijos s, Servicios_contratados p " +
                           " WHERE n.id_numero = p.id_numero AND n.nro_cliente = c.nro_cliente AND s.cod_servicio = p.cod_servicio AND p.tipo_servicio = 'B'" +
                           "AND s.costo_mensual >" + menor + " AND s.costo_mensual < " + mayor ;
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }
    }
}
