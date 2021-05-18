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
    class Ciudad
    {
        public string Pp_codCiudad { get; set; }
        public string Pp_nombreCiudad { get; set; }
        public string Pp_codProvincia { get; set; }


        Acceso_BD BD = new Acceso_BD();
        public DataTable CiudadesCompletas()
        {
            string sql = "SELECT c.*, p.nombre_provincia " +
                            "FROM Ciudad c, Provincia p " +
                            "WHERE c.id_provincia = p.codigo_provincia";
            return BD.EjecutarSelect(sql);
        }
        public void Insertar()
        {

            string sqlInsertar = @"INSERT INTO Ciudad (nombre_ciudad, id_provincia)"
                                  + "VALUES ('" + Pp_nombreCiudad + "' , " + Pp_codProvincia + ")";
            BD.Insertar(sqlInsertar);
            MessageBox.Show("Ciudad cargada exitosamente");
        }
        public void Borrar()
        {
            string sqlBorrar = "DELETE FROM Ciudad WHERE codigo_ciudad = " + Pp_codCiudad;
            BD.Borrar(sqlBorrar);
        }
        public DataTable Ciudad_por_codigo(string codigo)
        {
            string sql = @"SELECT c.*, p.nombre_provincia " +
                          "FROM Ciudad c , Provincia p "
                        + "WHERE c.id_provincia = p.codigo_provincia " +
                            "AND c.codigo_ciudad = " + codigo;
            return BD.EjecutarSelect(sql);
        }
        public DataTable Ciudad_por_nombre(string nombre)
        {
            string sql = @"SELECT c.*, p.nombre_provincia " +
                          "FROM Ciudad c, Provincia p "
                        //+ "WHERE c.nombre_ciudad '" + nombre + "'";
                        + "WHERE c.id_provincia = p.codigo_provincia " +
                        "AND c.nombre_ciudad like '%" + nombre.Trim() + "%'";
            return BD.EjecutarSelect(sql);
        }
        public DataTable Ciudad_por_cod_prov(string codigo)
        {
            string sql = @"SELECT c.*, p.nombre_provincia FROM Ciudad c, Provincia p "
                        + "WHERE c.id_provincia = p.codigo_provincia AND c.id_provincia = " + codigo;
            return BD.EjecutarSelect(sql);
        }
        public void Modificar()
        {
            string sqlMod = @"UPDATE Ciudad SET "
                            + " codigo_provincia = " + Pp_codProvincia 
                            + ", nombre_ciudad = '" + Pp_nombreCiudad + "'"
                            + " WHERE codigo_ciudad = " + Pp_codCiudad;
            BD.EjecutarModificar(sqlMod);
            MessageBox.Show("Modificacion realizada con exito");
        }
    }   
}
