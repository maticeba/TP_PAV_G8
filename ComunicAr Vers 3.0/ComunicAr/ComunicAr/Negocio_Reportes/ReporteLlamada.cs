using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComunicAr.Clases;
using System.Data;
using System.Windows.Forms;


namespace ComunicAr.Negocio_Listados
{
    
    class ReporteLlamada
    {
        Acceso_BD BD = new Acceso_BD();

        public DataTable Reportellamadas_todos()
        {
            string sql = "select l.id_llamada,l.id_nro_emisor,l.id_nro_receptor,l.fecha_hora_inicio,l.fecha_hora_fin from llamadas l";
            DataTable tabla = new DataTable();
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }

        public DataTable Buscar_cliente(string id_cliente)
        {
            string sql = "SELECT nombre_razonSocial FROM cliente WHERE nro_cliente = " + id_cliente;

            return BD.EjecutarSelect(sql);
        }
        public DataTable ReporteLlamadaCliente(string nro_cliente)
        {
            string sql = @"Select distinct l.id_llamada,l.id_nro_emisor,l.id_nro_receptor,l.fecha_hora_inicio,l.fecha_hora_fin " +
                           " from llamadas l, numero n, cliente c " +
                           " where l.id_nro_emisor = n.id_numero and n.nro_cliente = " + nro_cliente;
            DataTable tabla = new DataTable();
            tabla = BD.EjecutarSelect(sql);
            return tabla;

        }

        public DataTable ReporteLlamadaFecha(string desde, string hasta)
        {
            string sql = @"Select distinct  l.id_llamada,l.id_nro_emisor, l.id_nro_receptor,l.fecha_hora_inicio,l.fecha_hora_fin " +
                         " from llamadas l " +
                         " where l.fecha_hora_inicio between '" + desde + "' and '" + hasta + "'";
            DataTable tabla = new DataTable();
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }

    }
}
