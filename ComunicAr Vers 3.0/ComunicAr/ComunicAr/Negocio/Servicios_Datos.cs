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
    class Servicios_Datos
    {
        public string Pp_codDatos { get; set; }
        public string Pp_limite { get; set; }
        public string Pp_descripcion { get; set; }
        public string Pp_costofijo { get; set; }
        public string Pp_recargo { get; set; }
        public string Pp_tipoServicio { get; set; }
        Acceso_BD BD = new Acceso_BD();

        public DataTable ServDatos_Completos()
        {
            string sql = "SELECT * FROM servicios_datos";
            return BD.EjecutarSelect(sql);
        }
        public DataTable DatosXCodigo(string codDatos)
        {
            string sql = @"SELECT  * FROM servicios_datos  "
                        + "WHERE cod_datos = " + codDatos;
            return BD.EjecutarSelect(sql);
        }
        public DataTable DatosxTipoServicio(string tipo_servicio)
        {
            string sql = @"SELECT * FROM servicios_datos "
                       + "WHERE tipo_servicio = " + tipo_servicio;
            return BD.EjecutarSelect(sql);
        }
        public void Insertar(Control.ControlCollection controles)
        {
            TratamientosEspeciales tratamientos = new TratamientosEspeciales();
            BD.Insertar(tratamientos.ConstructorInsert("servicios_datos", controles));
            MessageBox.Show("Servicio de datos cargado exitosamente!");
        }
        public void Insertar()
        {

            string sqlIN = @"INSERT INTO servicios_datos (cod_datos, limite_datos, descripcion, costo_fijo, recargo,tipo_servicio) "
                            + " VALUES (" + Pp_codDatos + "," + Pp_limite + ",'"
                            + Pp_descripcion + "',$"
                            + Pp_costofijo + ",$"
                            + Pp_recargo + ","
                            + Pp_tipoServicio + " )";
            BD.Insertar(sqlIN);
            MessageBox.Show("Servicio de datos cargado exitosamente!");
        }

        public void Borrar()
        {
            string sqlDelete = "DELETE FROM servicios_datos WHERE cod_datos  =" + Pp_codDatos;
            BD.Borrar(sqlDelete);
        }

        
        public void Modificar()
        {
            string sqlMod = @"UPDATE servicios_datos SET "
                            + "cod_datos = "+ Pp_codDatos+ ", limite_datos = " + Pp_limite 
                            + ", descripcion = '" + Pp_descripcion + "'"
                            + ", costo_fijo = $" + Pp_costofijo
                            + ", recargo = $" + Pp_recargo
                            + ", tipo_servicio = " + Pp_tipoServicio
                            + "WHERE cod_datos = " + Pp_codDatos;
            BD.EjecutarModificar(sqlMod);
            MessageBox.Show("Modificacion realizada con exito");
        }

    }

}
