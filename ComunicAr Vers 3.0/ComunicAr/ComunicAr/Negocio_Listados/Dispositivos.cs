using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ComunicAr.Clases;
using System.Windows.Forms;


namespace ComunicAr.Negocio_Listados
{
    
    class Dispositivos
    {

        Acceso_BD BD = new Acceso_BD();
        public DataTable ReporteDispositivosVendidos_Todos()
        {
            string sql = "SELECT v.id_venta_dispo, v.fecha_venta, v.id_dispositivo, d.marca, d.precio, t.nombre_tipo FROM Dispositivos d " +
                "JOIN Venta_dispositivo v ON (v.id_dispositivo = d.id_dispositivo)" +
                "JOIN Tipo_dispositivo t ON (t.id_tipo_dispositivo = d.id_tipo_dispositivo) " +
                "WHERE DATEPART(mm, fecha_venta) = DATEPART(mm, DATEADD (mm, -1, GETDATE())) " +
                "ORDER BY v.id_dispositivo";
            DataTable tabla = new DataTable();
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }

        public DataTable ReporteDispositivosVendidos_PrecioEsp(string precio)
        {
            string sql = "SELECT v.id_venta_dispo, v.fecha_venta, v.id_dispositivo, d.marca, d.precio - (d.precio * v.descuento * 0.01) as 'precio', t.nombre_tipo FROM Dispositivos d " +
                "JOIN Venta_dispositivo v ON (v.id_dispositivo = d.id_dispositivo)" +
                "JOIN Tipo_dispositivo t ON (t.id_tipo_dispositivo = d.id_tipo_dispositivo) " +
                "WHERE DATEPART(mm, fecha_venta) = DATEPART(mm, DATEADD (mm, -1, GETDATE())) AND (d.precio - (d.precio * v.descuento * 0.01)) = '" + precio + "'" +
                "ORDER BY v.id_dispositivo";
            DataTable tabla = new DataTable();
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }

        public DataTable ReporteDispositivosVendidos_PrecioRango(string precio1, string precio2)
        {
            string sql = "SELECT v.id_venta_dispo, v.fecha_venta, v.id_dispositivo, d.marca, d.precio - (d.precio * v.descuento * 0.01) as 'precio', t.nombre_tipo FROM Dispositivos d " +
                "JOIN Venta_dispositivo v ON (v.id_dispositivo = d.id_dispositivo)" +
                "JOIN Tipo_dispositivo t ON (t.id_tipo_dispositivo = d.id_tipo_dispositivo) " +
                "WHERE DATEPART(mm, fecha_venta) = DATEPART(mm, DATEADD (mm, -1, GETDATE())) AND (d.precio - (d.precio * v.descuento * 0.01)) BETWEEN '" + precio1 + "' AND '" + precio2 + "'" +
                "ORDER BY v.id_dispositivo";
            DataTable tabla = new DataTable();
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }

        public DataTable ReporteDispositivosVendidos_MesEsp(string mes, string anio)
        {
            string sql = "SELECT v.id_venta_dispo, v.fecha_venta, v.id_dispositivo, d.marca, d.precio - (d.precio * v.descuento * 0.01) as 'precio', t.nombre_tipo FROM Dispositivos d " +
                "JOIN Venta_dispositivo v ON (v.id_dispositivo = d.id_dispositivo)" +
                "JOIN Tipo_dispositivo t ON (t.id_tipo_dispositivo = d.id_tipo_dispositivo) " +
                "WHERE MONTH(v.fecha_venta) =  '" + mes + "' AND YEAR(v.fecha_venta) = '" + anio + "'" +
                "ORDER BY v.id_dispositivo";
            DataTable tabla = new DataTable();
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }

    }

}