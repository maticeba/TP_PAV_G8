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
    class ServicioFijo
    {
        public string cod_servicio { get; set; }
        public string descripcion { get; set; }
        public string costo_mensual { get; set; }
        public string tipo_servicio { get; set; }


        Acceso_BD BD = new Acceso_BD();
        public DataTable ServicioFijoCompleto()
        {
            string sql = "SELECT * FROM servicios_fijos";
            return BD.EjecutarSelect(sql);
        }
        public DataTable ServicioFijoMM(int numero, string signo)
        {
            string sql = @"SELECT s.* FROM servicios_fijos s "
                         + "WHERE s.costo_mensual " + signo + numero;
            return BD.EjecutarSelect(sql);
        }
        public DataTable ServicioFijoPorCodigo(string cod_servicio)
        {
            string sql = @"SELECT s.* FROM servicios_fijos s "
                        + "WHERE s.cod_servicio = " + cod_servicio;
            return BD.EjecutarSelect(sql);
        }
        public DataTable ServicioFijoPorDescripcion(string descripcion)
        {
            string sql = @"SELECT s.* FROM servicios_fijos s "
                        + "WHERE s.descripcion like '%" + descripcion.Trim() + "%'";
            return BD.EjecutarSelect(sql);
        }
        public void borrarServicioFIjo()
        {
            string sqlBorrarSF = " DELETE FROM servicios_fijos WHERE cod_servicio = " + cod_servicio ;
            BD.Borrar(sqlBorrarSF);
        }
        public void insertarServicioFijo()
        {
            string sqlIN = @"INSERT INTO servicios_fijos (descripcion, costo_mensual, tipo_servicio)"
                            + " VALUES ('"
                            + descripcion + "', "
                            + "REPLACE('" + costo_mensual + "', ',', '.'), '"
                            + tipo_servicio + "')";

            BD.Insertar(sqlIN);
            MessageBox.Show("Servicio Fijo agregado exitosamente");
        }
        public void ModificarServicioFijo()
       {
            string sqlMod = @"UPDATE servicios_fijos SET "
                            + " descripcion = '" + descripcion + "'"
                            + ", costo_mensual = REPLACE('" + costo_mensual + "', ',', '.')"
                            + " WHERE cod_servicio = " + cod_servicio;
            BD.EjecutarModificar(sqlMod);
            MessageBox.Show("Modificacion completada");
        }
    }
}
