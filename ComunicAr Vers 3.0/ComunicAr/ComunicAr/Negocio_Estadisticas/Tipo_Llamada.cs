using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ComunicAr.Clases;

namespace ComunicAr.Negocio_Estadisticas
{
    class Tipo_Llamada
    {
        Acceso_BD BD = new Acceso_BD();
        DataTable tabla = new DataTable();

        public DataTable Llamadas_tipo_Completas()
        {
            string sql = @"SELECT  t.descripcion as Denominacion, l.id_llamada as Valor " +
                           " FROM Llamadas l , Tipo_comunicacion t " +
                           " WHERE t.id_tipo_com = l.id_tipo_comun " +
                           "GROUP BY t.descripcion, l.id_llamada";
            tabla = BD.EjecutarSelect(sql);
            return tabla;

        }
        public DataTable Llamadas_tipo_mes(string mes, string año)
        {
            string sql = @"SELECT  t.descripcion as Denominacion, l.id_llamada as Valor " +
                           " FROM Llamadas l , Tipo_comunicacion t " +
                           " WHERE t.id_tipo_com = l.id_tipo_comun AND MONTH(l.fecha_hora_inicio) = " + mes +
                           " AND YEAR(l.fecha_hora_inicio) =" + año +
                           "GROUP BY t.descripcion, l.id_llamada";
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }
        public DataTable Llamadas_tipo_rango(string mes1, string año1 , string mes2,string año2)
        {
            string sql = @"SELECT  t.descripcion as Denominacion, l.id_llamada as Valor " +
                           " FROM Llamadas l , Tipo_comunicacion t " +
                           " WHERE t.id_tipo_com = l.id_tipo_comun AND MONTH(l.fecha_hora_inicio) >= " + mes1 +
                           " AND YEAR(l.fecha_hora_inicio) >=" + año1 +
                           "AND MONTH(l.fecha_hora_inicio) <=" + mes2 +
                           "AND YEAR(l.fecha_hora_inicio) <= " + año2 +
                           "GROUP BY t.descripcion, l.id_llamada";
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }
    }
}
