using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ComunicAr.Clases;
using System.Windows.Forms;

namespace ComunicAr.Negocio
{
    class Clientes
    {
        public string Pp_nombre { get; set; }
        public string Pp_calle { get; set; }
        public string Pp_nro { get; set; }
        public string Pp_piso { get; set; }
        public string Pp_barrio { get; set; }
        public string Pp_nroCliente { get; set; }

        Acceso_BD BD = new Acceso_BD();
        public DataTable ClientesCompletos()
        {
            string sql = @"SELECT c.*, b.nombre_barrio " +
                            "FROM Cliente c, barrio b " +
                            "WHERE c.cod_barrio = b.cod_barrio " +
                                " AND borrado = 0";
            /*string sql = @"SELECT c.*, b.nombre_barrio as cod_barrio"
                         + "from clientes c join barrios b"
                         + "on c.cod_barrio = b.cod_barrio";*/
            return BD.EjecutarSelect(sql);
        }
        public DataTable Clientes_por_Numero(string nro_Cliente)
        {
            string sql = @"SELECT c.*, b.nombre_barrio FROM Cliente c, Barrio b "
                        + "WHERE nro_cliente = " + nro_Cliente + " " +
                            "AND c.cod_barrio = b.cod_barrio " +
                            "AND borrado = 0" ;
            return BD.EjecutarSelect(sql);
        }
        public DataTable Clientes_por_Nombre(string nombre)
        {
            string sql = @"SELECT c.*, b.nombre_barrio FROM Cliente c, Barrio b "
                        + "WHERE c.nombre_razonSocial like '%" + nombre.Trim() + "%' " +
                            " AND c.cod_barrio = b.cod_barrio " +
                            " AND borrado = 0";
            return BD.EjecutarSelect(sql);
        }

        public DataTable Clientes_por_solo_Numero(string id_cliente)
        {
            string sql = @"SELECT c.* FROM Cliente c "
                        + "WHERE c.nro_cliente = '" + id_cliente + "' " +
                                " AND borrado = 0";
            return BD.EjecutarSelect(sql);
        }
        public void Insertar()
        {
            string sqlIN = @"INSERT INTO Cliente (nombre_razonSocial, calle, nro, piso, cod_barrio) "
                            +" VALUES ('" + Pp_nombre +"',"
                            +"'" + Pp_calle + "',"
                            + Pp_nro + ","
                            + Pp_piso + ","
                            +Pp_barrio +" )";
            BD.Insertar(sqlIN);
            MessageBox.Show("Cliente cargado exitosamente");
        }
        public void Modificar()
        {
            string sqlMod = @"UPDATE Cliente SET "
                            + " nombre_razonSocial = '" + Pp_nombre + "'"
                            + ", calle = '" + Pp_calle + "'"
                            + ", nro = " + Pp_nro
                            + ", piso =" + Pp_piso
                            + ", cod_barrio = " + Pp_barrio
                            + "WHERE nro_cliente = " + Pp_nroCliente;
            BD.EjecutarModificar(sqlMod);
            MessageBox.Show("Modificacion realizada con exito");
        }
        public void Borrar()
        {
            DateTime actual = new DateTime();
            string fecha_borrado = actual.Year.ToString() + "-" + actual.Month.ToString() + "-" + actual.Day.ToString();
            string sqlBorrar = "UPDATE Cliente SET " +
                                " borrado = 1, " +
                                " fecha_baja = '" + fecha_borrado + "'" +   
                                " WHERE nro_cliente = " + Pp_nroCliente + " " +
                                " " +
                                "UPDATE Numero SET " +
                                " borrado = 1, " +
                                " fecha_baja = '" + fecha_borrado + "'" +
                                " WHERE nro_cliente = " + Pp_nroCliente + " " ;
            BD.Borrar(sqlBorrar);
        }
        public DataTable Obtener_ubicacion(string cod_barrio)
        {
            string sql = @"SELECT DISTINCT b.cod_barrio, b.id_ciudad, c.cod_ciudad, c.id_provincia, p.cod_prov " +
                          "FROM Barrio b, Ciudad c, Provincia p " +
                          "WHERE b.cod_barrio = " + cod_barrio + " AND b.id_ciudad = c.cod_ciudad AND c.id_provincia = p.cod_prov";
            return BD.EjecutarSelect(sql);
        }
    }
}
