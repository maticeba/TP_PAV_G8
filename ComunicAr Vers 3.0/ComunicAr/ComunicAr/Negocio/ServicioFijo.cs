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
            string sql = "SELECT * FROM servicio_fijo";
            return BD.EjecutarSelect(sql);
        }
        public DataTable ServicioFijoPorCodigo(string cod_servicio)
        {
            string sql = @"SELECT s.* FROM servicio_fijo s "
                        + "WHERE s.cod_servicio = " + cod_servicio;
            return BD.EjecutarSelect(sql);
        }
        public DataTable ServicioFijoPorDescripcion(string descripcion)
        {
            string sql = @"SELECT s.* FROM servicio_fijo s "
                        + "WHERE s.descripcion like '%" + descripcion.Trim() + "%'";
            return BD.EjecutarSelect(sql);
        }
        public void borrarServicioFIjo()
        {
            string sqlBorrarSF = " DELETE FROM servicio_fijo WHERE cod_servicio = " + cod_servicio;
            BD.Borrar(sqlBorrarSF);
        }
        public void insertarServicioFijo(Control.ControlCollection controles)
        {
            string sqlIN = @"INSERT INTO servicio_fijo (cod_servicio, descripcion, costo_mensual, tipo_servicio)"
                            + " VALUES (" + cod_servicio + ", '"
                            + descripcion + "', "
                            + "REPLACE('" + costo_mensual + "', ',', '.'), "
                            + tipo_servicio + " )";

            BD.Insertar(sqlIN);
            MessageBox.Show("Servicio Fijo agregado exitosamente");
        }
        public void ModificarServicioFijo()
       {
            string sqlMod = @"UPDATE servicio_fijo SET "
                            + " descripcion = '" + descripcion + "'"
                            + ", costo_mensual = REPLACE('" + costo_mensual + "', ',', '.')"
                            + ", tipo_servicio = " + tipo_servicio
                            + " WHERE cod_servicio = " + cod_servicio;
            BD.EjecutarModificar(sqlMod);
            MessageBox.Show("Modificacion completada");
        }
    }
}
