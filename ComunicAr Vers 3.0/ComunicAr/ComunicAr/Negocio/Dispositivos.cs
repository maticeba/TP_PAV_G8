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
    class Dispositivos
    {
        public string Pp_id_dispositivo { get; set; }
        public string Pp_fecha_elaboracion { get; set; }
        public string Pp_marca { get; set; }
        public string Pp_modelo { get; set; }
        public string Pp_caracteristicas { get; set; }
        public string Pp_precio { get; set; }
        public string Pp_id_tipo_dispositivo { get; set; }
        Acceso_BD BD = new Acceso_BD();

        public DataTable Dispositivos_Completos()
        {
            string sql = "SELECT d.*, t.nombre_tipo FROM dispositivos d, Tipo_dispositivo t " +
                         "WHERE d.id_tipo_dispositivo = t.id_tipo_dispositivo";
            return BD.EjecutarSelect(sql);
        }
        public DataTable FiltroXid(string id_dispositivo)
        {
            string sql = @"SELECT  d.* , t.nombre_tipo "  +
                        "FROM dispositivos d, Tipo_dispositivo t " +
                        "WHERE d.id_tipo_dispositivo = t.id_tipo_dispositivo" +
                        " AND id_dispositivo = " + id_dispositivo;
            return BD.EjecutarSelect(sql);
        }
        public DataTable FiltroXmarca(string marca)
        {
            string sql = @"SELECT * FROM dispositivos "
                       + "WHERE marca = '" + marca + "'";
            return BD.EjecutarSelect(sql);
        }
        public void Insertar(Control.ControlCollection controles)
        {
            TratamientosEspeciales tratamientos = new TratamientosEspeciales();
            BD.Insertar(tratamientos.ConstructorInsert("id_dispositivo)", controles));
            MessageBox.Show("Dispositivo cargado exitosamente!");

        }
        public void Insertar()
        {

            string sqlIN = @"INSERT INTO dispositivos ( fecha_elaboracion, marca, modelo, caracteristicas,precio,id_tipo_dispositivo) "
                            + " VALUES (" +"'" + Pp_fecha_elaboracion + "','"                         
                            + Pp_marca + "', "
                            + "REPLACE('" + Pp_modelo + "', ',', '.'), "
                            + "REPLACE('" + Pp_caracteristicas + "', ',', '.'), "
                            + Pp_precio +","
                            + Pp_id_tipo_dispositivo + ")";
            BD.Insertar(sqlIN);
            MessageBox.Show("Dispositivo cargado exitosamente!");
        }

        public void Borrar()
        {
            string sqlDelete = "DELETE FROM Dispositivos WHERE id_dispositivo  =" + Pp_id_dispositivo;
            BD.Borrar(sqlDelete);
        }
        public void Modificar()
        {
            string sqlMod = @"UPDATE dispositivos SET "
                            + " fecha_elaboracion = (CONVERT(DATETIME, '" + Pp_fecha_elaboracion + "',103))"
                            + ", marca = '" + Pp_marca + "'"
                            + ", modelo = '" + Pp_modelo + "'"
                            + ", caracteristicas = '" + Pp_caracteristicas + "'"
                            + ", id_tipo_dispositivo = " + Pp_id_tipo_dispositivo 
                            + " WHERE id_dispositivo = " + Pp_id_dispositivo;


            BD.EjecutarModificar(sqlMod);
            MessageBox.Show("Modificacion realizada con exito");
        }

    }
}
