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
    }
}
