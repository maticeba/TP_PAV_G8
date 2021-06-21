using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ComunicAr.Clases;

namespace ComunicAr.Negocio_Estadisticas
{
    class DispVendidos
    {
        Acceso_BD BD = new Acceso_BD();
        DataTable tabla = new DataTable();
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////DISP VENDIDOS POR MES /////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public DataTable DispVendxMes(int mes, int year)
        {
            string sql = "SELECT d.marca, d.modelo, COUNT(*) as 'valor' FROM Dispositivos d JOIN Venta_Dispositivo v " +
                            "ON (d.id_dispositivo = v.id_dispositivo) " +
                            "WHERE MONTH(v.fecha_venta) = " + mes + " AND YEAR(v.fecha_venta) = " + year + 
                            "GROUP BY d.id_dispositivo,d.marca,d.modelo";
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }

        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////DISP VENDIDOS POR MES SEGUN AÑO////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public DataTable DispVendxAnio(int year)
        {
            string sql = @"SELECT Mes = CASE MONTH(v.fecha_venta) WHEN 1 THEN 'Enero'" +
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
                                        "COUNT(*) as 'valor' FROM Dispositivos d JOIN Venta_Dispositivo v ON (d.id_dispositivo = v.id_dispositivo) " +
                                        "WHERE YEAR(v.fecha_venta) = " + year +
                                        " Group By MONTH(l.fecha_desde) ";
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }

        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////DISP VENDIDOS POR SERVICIO////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///
        public DataTable DispxServicio()
        {
            string sql = @"SELECT tipo_serv = CASE sc.tipo_servicio WHEN 'A' THEN 'Servicio de Datos' " +
                           " WHEN 'B' THEN 'Servicios Fijos' " +
                           " WHEN 'C' THEN 'Servicios Prepagos'  "+
                           " END, COUNT(*) as 'valor' FROM Numero n JOIN Servicios_contratados sc ON sc.id_numero = n.id_numero " +
                           " GROUP BY sc.tipo_servicio";
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }

    }
}
