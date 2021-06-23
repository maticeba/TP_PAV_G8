using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ComunicAr.Clases;

namespace ComunicAr.Negocio_Estadisticas
{
    class CantidadLlamadas
    {
        Acceso_BD BD = new Acceso_BD();
        DataTable tabla = new DataTable();

        public DataTable Llamadas_sinFiltro(string año)
        {
            string sql = @"SELECT DateName( month , DateAdd( month , MONTH(fecha_hora_inicio) , 0 ) - 1 ) as denominacion, COUNT(MONTH(fecha_hora_inicio)) as valor" +
                        " FROM Llamadas" +
                        " WHERE YEAR(fecha_hora_inicio) = " + año +
                         " GROUP BY MONTH(fecha_hora_inicio)";
            tabla = BD.EjecutarSelect(sql);
            return tabla;

        }

        public DataTable Llamadas_Cliente(string año, string cliente)
        {
            string sql = @"SELECT DateName( month , DateAdd( month , MONTH(fecha_hora_inicio) , 0 ) - 1 ) as denominacion, COUNT(MONTH(fecha_hora_inicio)) as valor" +
            " FROM Llamadas" +
            " WHERE YEAR(fecha_hora_inicio) = " + año +
            "AND (id_nro_emisor = " + cliente +" OR id_nro_receptor = " + cliente +")"+
             " GROUP BY MONTH(fecha_hora_inicio)";
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }
        public DataTable llamadaduracionaño(string año)
        {
            string sql = @"SELECT A.Mes, COUNT (*) AS Total_Llamadas, SUM(A.DURACION) AS Duracion_total,SUM(A.DURACION)/ COUNT (*) AS Duracion_Promedio " +
                           " FROM ( SELECT MONTH (fecha_hora_inicio) AS Mes, DATEDIFF(minute, fecha_hora_inicio, fecha_hora_fin) AS DURACION FROM Llamadas WHERE YEAR(fecha_hora_inicio) = " + año + ") A " +
                           "GROUP BY Mes";
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }

        public DataTable llamadasxduraciontodos()
        {
            string sql = @"SELECT A.Mes, COUNT (*) AS Total_Llamadas, SUM(A.DURACION) AS Duracion_total,SUM(A.DURACION)/ COUNT (*) AS Duracion_Promedio " +
                          " FROM ( SELECT MONTH (fecha_hora_inicio) AS Mes, DATEDIFF(minute, fecha_hora_inicio, fecha_hora_fin) AS DURACION FROM Llamadas) A " +
                          "GROUP BY Mes";
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }
    }
}
