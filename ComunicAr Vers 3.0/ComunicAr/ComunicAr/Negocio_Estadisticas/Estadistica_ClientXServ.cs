using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ComunicAr.Clases;

namespace ComunicAr.Negocio_Estadisticas
{
    class Estadistica_ClientXServ
    {
        Acceso_BD BD = new Acceso_BD();
        DataTable tabla = new DataTable();
        public DataTable CantServXAño(int year)
        {
            string sql = @"SELECT DISTINCT MONTH(c.fecha_desde) as mes, +
			COUNT(DISTINCT n.nro_cliente) as cantidad FROM Servicios_contratados c, +
			Numero n WHERE n.id_numero = c.id_numero AND YEAR(c.fecha_desde) = "+ year + "GROUP BY MONTH(c.fecha_desde)";

            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }
    }
}
