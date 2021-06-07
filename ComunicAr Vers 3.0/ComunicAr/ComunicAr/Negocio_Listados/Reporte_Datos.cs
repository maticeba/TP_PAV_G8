using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComunicAr.Clases;
using System.Data;


namespace ComunicAr.Negocio_Listados
{
    class Reporte_Datos
    {
        Acceso_BD BD = new Acceso_BD();
        public DataTable ReporteDatos_limitedatos(string tope)
        {
            string sql = "SELECT d.cod_datos, d.limite_datos, d.descripcion, d.costo_fijo " +
                "FROM Servicios_datos d " +
                "WHERE d.limite_datos <= '" + tope + "' " +
                "ORDER BY d.cod_datos";
            DataTable tabla = new DataTable();
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }
        public DataTable ReporteDatos_limitecosto(string tope)
        {
            string sql = "SELECT d.cod_datos, d.limite_datos, d.descripcion, d.costo_fijo " +
                "FROM Servicios_datos d " +
                "WHERE d.costo_fijo <= '" + tope + "' " +
                "ORDER BY d.cod_datos";
            DataTable tabla = new DataTable();
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }
        public DataTable ReporteDatos_todos()
        {
            string sql = "SELECT * FROM Servicios_datos";
            DataTable tabla = new DataTable();
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }
    }
}
