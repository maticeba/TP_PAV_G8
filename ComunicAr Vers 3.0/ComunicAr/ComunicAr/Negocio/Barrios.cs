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
    class Barrios
    {
        public string Pp_codigo_barrio { get; set; }
        public string Pp_nombre_barrio { get; set; }
        public string Pp_codigo_ciudad { get; set; }

        Acceso_BD BD = new Acceso_BD();
        public DataTable barriosCompletos()
        {
            string sql = "SELECT b.*, c.nombre_ciudad " +
                            "FROM Barrio b, Ciudad c " +
                            "WHERE b.id_ciudad = c.cod_ciudad";
            return BD.EjecutarSelect(sql);
        }

        public DataTable Barrios_por_codigo(string codigo_barrio)
        {
            string sql = @"SELECT b.*, c.nombre_ciudad " 
                        + "FROM Barrio b, Ciudad c "
                        + "WHERE b.id_ciudad = c.cod_ciudad AND b.cod_barrio = " + codigo_barrio;
            return BD.EjecutarSelect(sql);
        }


        public void Insertar()
        {
            string sqlIN = @"INSERT INTO Barrio (nombre_barrio, id_ciudad) "
                            + " VALUES ('" + Pp_nombre_barrio + "',"
                            + Pp_codigo_ciudad +" )";
            BD.Insertar(sqlIN);
            MessageBox.Show("Barrio cargado exitosamente");
        }
        
        public void Modificar()
        {
            string sqlMod = @"UPDATE Barrio SET "
                            + " nombre_barrio = '" + Pp_nombre_barrio + "'"
                            + ", id_ciudad = " + Pp_codigo_ciudad
                            + "WHERE cod_barrio = " + Pp_codigo_barrio;

            BD.EjecutarModificar(sqlMod);
            MessageBox.Show("Modificacion realizada con exito");
        }

        public void Borrar()
        {
            string sqlBorrar = "DELETE FROM Barrio WHERE cod_barrio = " + Pp_codigo_barrio;
            BD.Borrar(sqlBorrar);
        }
    }
}