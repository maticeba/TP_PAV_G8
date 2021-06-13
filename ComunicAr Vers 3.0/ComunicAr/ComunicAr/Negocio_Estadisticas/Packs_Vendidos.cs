using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ComunicAr.Clases;

namespace ComunicAr.Negocio_Estadisticas
{
    class Packs_Vendidos
    {
        Acceso_BD BD = new Acceso_BD();
        DataTable tabla = new DataTable();
		/// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
		///////////////////////////////////PACKS VENDIDOS POR MES SEGUN AÑO////////////////////////////////////////////////
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

		public DataTable PacksDatosXAño(int year)
        {
			string sql = "SELECT Mes = CASE MONTH(l.fecha_desde) WHEN 1 THEN 'Enero'" +
										"WHEN 2 THEN 'Feb'" +
										"WHEN 3 THEN 'Marzo'" +
										"WHEN 4 THEN 'Abril'" +
										"WHEN 5 THEN 'Mayo'" +
										"WHEN 6 THEN 'Junio'" +
										"WHEN 7 THEN 'Julio'" +
										"WHEN 8 THEN 'Agosto'" +
										"WHEN 9 THEN 'Sep'" +
										"WHEN 10 THEN 'Oct'" +
										"WHEN 11 THEN 'Nov'" +
										"WHEN 12 THEN 'Dec'" +
										"END" +
						", count(*) as Cantidad FROM Servicios_contratados l WHERE l.tipo_servicio = 'A' AND YEAR(l.fecha_desde) =" +year + "Group By MONTH(l.fecha_desde)";
		
			tabla = BD.EjecutarSelect(sql);
            return tabla;

        }
		/// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
		///////////////////////////////////PACKS VENDIDOS POR MES /////////////////////////////////////////////////////////
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		public DataTable ServiciosXmes(int mes, int year)
        {
			string sql = "SELECT tipo_serv = CASE l.tipo_servicio WHEN 'A' THEN 'Servicio de Datos'" +
							"WHEN 'B' THEN 'Servicios Fijos' " +
							"WHEN 'C' THEN 'Servicios Prepagos'" +
							"END " +
						", COUNT(*) as cantidad FROM Servicios_contratados l WHERE MONTH(l.fecha_desde) = " + mes + " AND YEAR(l.fecha_desde) = " + year + " GROUP BY l.tipo_servicio";
			tabla = BD.EjecutarSelect(sql);
			return tabla;
		}

		public DataTable ServiciosXIntervalo(int MDesde, int ADesde,int MHasta, int AHasta)
		{
			string sql = "SELECT tipo_serv = CASE l.tipo_servicio WHEN 'A' THEN 'Servicio de Datos'" +
							"WHEN 'B' THEN 'Servicios Fijos' " +
							"WHEN 'C' THEN 'Servicios Prepagos'" +
							"END " +
						", COUNT(*) as cantidad FROM Servicios_contratados l WHERE MONTH(l.fecha_desde) >= " + MDesde + " AND YEAR(l.fecha_desde) >= " + ADesde +
						" AND MONTH(l.fecha_desde) <= " + MHasta +
						" AND YEAR(l.fecha_desde) <= " + AHasta+ " GROUP BY l.tipo_servicio";
			tabla = BD.EjecutarSelect(sql);
			return tabla;
		}
	}
}
