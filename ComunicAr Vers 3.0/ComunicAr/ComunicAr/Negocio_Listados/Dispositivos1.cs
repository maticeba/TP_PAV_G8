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
    class Dispositivos1
    { 
        Acceso_BD BD = new Acceso_BD();
        public DataTable ReporteDispositivos_Todos(string fecha)
        {
            string sql = "SELECT  d.id_dispositivo, d.fecha_elaboracion, d.marca, d.modelo" +
                " FROM Dispositivos d " +
                "WHERE d.fecha_elaboracion < '" + fecha + "'" +
                "ORDER BY d.id_dispositivo";
            DataTable tabla = new DataTable();
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }

        public DataTable ReporteDispositivos_Marca(string marca)
        {
            string sql = "SELECT  d.id_dispositivo, d.fecha_elaboracion, d.marca, d.modelo" +
                " FROM Dispositivos d " +
                "WHERE d.marca = '" + marca + "'" + 
                "ORDER BY d.id_dispositivo";
            DataTable tabla = new DataTable();
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }
    }

}
