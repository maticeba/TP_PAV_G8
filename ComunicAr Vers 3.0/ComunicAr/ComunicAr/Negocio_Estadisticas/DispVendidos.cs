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
        ///////////////////////////////////DISP POR SERVICIO////////////////////////////////////////////////
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

        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////DISP POR SERVICIO Y CODIGO NACIONAL////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///

        public DataTable DispxServicioCodN(int cod_nacional)
        {
            string sql = @"SELECT tipo_serv = CASE sc.tipo_servicio WHEN 'A' THEN 'Servicio de Datos' " +
                           " WHEN 'B' THEN 'Servicios Fijos' " +
                           " WHEN 'C' THEN 'Servicios Prepagos'  " +
                           " END, COUNT(*) as 'valor' FROM Numero n JOIN Servicios_contratados sc ON sc.id_numero = n.id_numero WHERE n.cod_nacional = " + cod_nacional +
                           " GROUP BY sc.tipo_servicio";
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }

        public DataTable DispxServicioCliente(int index)
        {
            string sql = @"SELECT tipo_serv = CASE sc.tipo_servicio WHEN 'A' THEN 'Servicio de Datos' " +
                           " WHEN 'B' THEN 'Servicios Fijos' " +
                           " WHEN 'C' THEN 'Servicios Prepagos'  " +
                           " END, COUNT(*) as 'valor' FROM Numero n JOIN Servicios_contratados sc ON sc.id_numero = n.id_numero WHERE n.nro_cliente = " + index +
                           " GROUP BY sc.tipo_servicio";
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }
        public DataTable DispxServicioTipo(int index)
        {
            string sql = @"SELECT tipo_serv = CASE sc.tipo_servicio WHEN 'A' THEN 'Servicio de Datos' " +
                           " WHEN 'B' THEN 'Servicios Fijos' " +
                           " WHEN 'C' THEN 'Servicios Prepagos'  " +
                           " END, COUNT(*) as 'valor' FROM Numero n JOIN Servicios_contratados sc ON sc.id_numero = n.id_numero " +
                           " JOIN Dispositivos d ON n.id_dispositivo = d.id_dispositivo AND d.id_tipo_dispositivo = " + index +
                           " GROUP BY sc.tipo_servicio";
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }

    

        public DataTable DispxServicioMarca(string marca)
        {
            string sql = @"SELECT tipo_serv = CASE sc.tipo_servicio WHEN 'A' THEN 'Servicio de Datos' " +
                           " WHEN 'B' THEN 'Servicios Fijos' " +
                           " WHEN 'C' THEN 'Servicios Prepagos'  " +
                           " END, COUNT(*) as 'valor' FROM Numero n JOIN Servicios_contratados sc ON sc.id_numero = n.id_numero " +
                           " JOIN Dispositivos d ON n.id_dispositivo = d.id_dispositivo AND d.marca = '" + marca + "'" +
                           " GROUP BY sc.tipo_servicio";
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }

        public DataTable VentaDispoxcuotatodos()
        {
            string sql = @"select v.cant_cuotas,COUNT(*) as 'valor' " +
                            " from Venta_dispositivo v " +
                            " where v.cant_cuotas in (1,3,6,12) " +
                            " group by v.cant_cuotas ";
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }

        public DataTable VentaDispoxcuotasfechas(string mes, string año)
        {
            string sql = @"select v.cant_cuotas,COUNT(*) as 'valor' " +
                         " from Venta_dispositivo v " +
                         " where month(v.fecha_venta) = " + mes + " and year(v.fecha_venta) = " + año +
                         " group by v.cant_cuotas ";
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }
    }
}
