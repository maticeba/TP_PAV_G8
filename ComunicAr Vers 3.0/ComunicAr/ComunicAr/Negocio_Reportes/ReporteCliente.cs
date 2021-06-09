using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComunicAr.Clases;
using System.Windows.Forms;
using System.Data;

namespace ComunicAr.Negocio_Reportes
{
    class ReporteCliente
    {
        Acceso_BD BD = new Acceso_BD();
        public DataTable SearchClientes_todos()
        {
            string sql = @"SELECT c.nro_cliente, c.nombre_razonSocial, c.calle, c.nro, c.piso, p.nombre_prov " +
                          "FROM Cliente c, Barrio b, Ciudad ci, Provincia p " +
                          "WHERE c.cod_barrio = b.cod_barrio AND b.id_ciudad = ci.cod_ciudad AND ci.id_provincia = p.cod_prov";
            return BD.EjecutarSelect(sql);
        }
        public DataTable SearchClientes_comienzo(string letra)
        {
            string sql = @"SELECT c.nro_cliente, c.nombre_razonSocial, c.calle, c.nro, c.piso, p.nombre_prov " +
                          "FROM Cliente c, Barrio b, Ciudad ci, Provincia p " +
                          "WHERE c.cod_barrio = b.cod_barrio AND b.id_ciudad = ci.cod_ciudad AND ci.id_provincia = p.cod_prov " +
                          "AND c.nombre_razonSocial LIKE '" + letra.Trim() + "%'";
            return BD.EjecutarSelect(sql);
        }
        public DataTable SearchClientes_wherever(string letra)
        {
            string sql = @"SELECT c.nro_cliente, c.nombre_razonSocial, c.calle, c.nro, c.piso, p.nombre_prov " +
                          "FROM Cliente c, Barrio b, Ciudad ci, Provincia p " +
                          "WHERE c.cod_barrio = b.cod_barrio AND b.id_ciudad = ci.cod_ciudad AND ci.id_provincia = p.cod_prov " +
                          "AND c.nombre_razonSocial LIKE '%" + letra.Trim() + "%'";
            return BD.EjecutarSelect(sql);
        }
        public DataTable SearchClientesXmodeloDispositivo(string modelo)
        {
            string sql = @"SELECT c.nro_cliente, c.nombre_razonSocial, " +
                                 "('+' + n.cod_nacional + ' ' + n.cod_area + ' ' + n.nro_telefono) AS nro_telefono, " +
                                 "p.nombre_prov " +
                          "FROM Cliente c, Numero n, Barrio b, Ciudad ci, Provincia p " +
                          "WHERE c.nro_cliente = n.nro_cliente " +
                            "AND c.cod_barrio = b.cod_barrio " +
                            "AND b.id_ciudad = ci.cod_ciudad " +
                            "AND ci.id_provincia = p.cod_prov " +
                            "AND n.id_dispositivo = " + modelo;
            return BD.EjecutarSelect(sql);
        }

        public DataTable SearchClienteXtiempo(int tiempo)
        {
            string sql = @"SELECT l.fecha_hora_inicio, l.fecha_hora_fin, c.nombre_razonSocial, c.nro_cliente FROM Llamadas l, Cliente c, Numero n " +
                "WHERE c.nro_cliente = n.nro_cliente AND l.id_nro_emisor = c.nro_cliente " +
                "GROUP BY l.fecha_hora_inicio, l.fecha_hora_fin, c.nombre_razonSocial, c.nro_cliente " +
                "HAVING DATEDIFF(hour, l.fecha_hora_inicio, l.fecha_hora_fin) > " + tiempo;

            return BD.EjecutarSelect(sql);

        }

      

        public DataTable SearchClienteTodosxDuracion()
        {
            string sql = @"SELECT l.fecha_hora_inicio, l.fecha_hora_fin, c.nombre_razonSocial, c.nro_cliente FROM Llamadas l, Cliente c, Numero n " +
                "WHERE c.nro_cliente = n.nro_cliente AND l.id_nro_emisor = c.nro_cliente "
                ;

            return BD.EjecutarSelect(sql);

        }
    }
}
