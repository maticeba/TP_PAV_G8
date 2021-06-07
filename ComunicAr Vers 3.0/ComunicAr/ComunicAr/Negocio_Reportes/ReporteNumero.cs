using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComunicAr.Clases;
using System.Data;

namespace ComunicAr.Negocio_Reportes
{
    class ReporteNumero
    {
        DataTable tabla = new DataTable();
        Acceso_BD BD = new Acceso_BD();
        public  DataTable ReporteTodos()
        {
            string sql = "SELECT n.nro_telefono, n.cod_nacional, n.cod_area, c.nombre_razonSocial FROM Numero n, Cliente c WHERE n.nro_cliente = c.nro_cliente";
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }
        public DataTable ReporteNacional(string cod_nac)
        {
            string sql = "SELECT n.nro_telefono, n.cod_nacional, n.cod_area, c.nombre_razonSocial FROM Numero n, Cliente c WHERE n.nro_cliente = c.nro_cliente AND n.cod_nacional = " + cod_nac;
            tabla = BD.EjecutarSelect(sql);
            return tabla;

        }
        public DataTable ReporteArea(string cod_nac, string cod_area)
        {
            string sql = "SELECT n.nro_telefono, n.cod_nacional, n.cod_area, c.nombre_razonSocial FROM Numero n, Cliente c WHERE n.nro_cliente = c.nro_cliente AND n.cod_nacional = " + cod_nac + "AND cod_area =" + cod_area;
            tabla = BD.EjecutarSelect(sql);
            return tabla;

        }
    }

}
