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
    class Servicios_Prepagos
    {
        public string Pp_tipo_servicios { get; set; }
        public string Pp_id_pack { get; set; }
        public string Pp_duracion { get; set; }
        public string Pp_descripcion { get; set; }
        public string Pp_costo { get; set; }
        public string Pp_id_region { get; set; }


        Acceso_BD BD = new Acceso_BD();
        public DataTable ServiciosCompletos()
        {
           
            string sql = "SELECT s. *, r.descripcion_region " + " FROM servicios_prepago s, region r " +
                "WHERE s.id_region = r.id_region";

            return BD.EjecutarSelect(sql);
        }
        public DataTable ServiciosPrepagosMMCosto(int numero, string signo)
        {
            string sql = @"SELECT s. *, r.descripcion_region " + " FROM servicios_prepago s, region r "
                         + "WHERE s.id_region = r.id_region "
                         + "AND s.costo " + signo + numero;
            return BD.EjecutarSelect(sql);
        }
        public DataTable ServicioPrepagoMMDuracion(int numero, string signo)
        {
            string sql = @"SELECT s. *, r.descripcion_region " + " FROM servicios_prepago s, region r "
                         + "WHERE s.id_region = r.id_region "
                         + "AND s.duracion " + signo + numero;
            return BD.EjecutarSelect(sql);
        }

        public DataTable Servicios_prepagos_por_id(string id_pack)
        {
            string sql = @"SELECT s. *, r.descripcion_region " + " FROM servicios_prepago s, region r " 
                            
                        + "WHERE s.id_pack = " + id_pack + "AND s.id_region = r.id_region";
            return BD.EjecutarSelect(sql);
        }
        
        public void Modificar()
        {
            string sqlMod = @"UPDATE servicios_prepago SET "
                            + " duracion  = " + Pp_duracion
                            + ", descripcion  = '" + Pp_descripcion + "'" 
                            + ", costo = REPLACE('" + Pp_costo + "', ',', '.')"
                            + ", id_region = " + Pp_id_region
                            + " WHERE id_pack = " + Pp_id_pack;

            BD.EjecutarModificar(sqlMod);
            MessageBox.Show("Modificacion realizada con exito");
        }

        public void Insertar()
        {
           
            string sqlIN = @"INSERT INTO servicios_prepago ( tipo_servicio, duracion, descripcion, costo, id_region)"
                            + " VALUES ('" + 'C' + "'," 
                            + Pp_duracion + ","
                            + "'" + Pp_descripcion + "',"
                            +  Pp_costo + ","
                            + Pp_id_region + " )";


            BD.Insertar(sqlIN);
            MessageBox.Show("Servicio agregado exitosamente");
        }

        public void Borrar()
        {
            string sqlBorrar = "DELETE FROM servicios_prepago WHERE id_pack = " + Pp_id_pack;
            BD.Borrar(sqlBorrar);
        }
    }


}