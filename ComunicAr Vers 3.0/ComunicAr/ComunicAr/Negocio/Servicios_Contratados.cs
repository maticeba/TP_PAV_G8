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
    class Servicios_Contratados
    {
        public string Pp_Tipo_Servicio { get; set; }
        public string Pp_Nombre_Servicio { get; set; }
        public string Pp_Cod_Nacional { get; set; }
        public string Pp_Cod_Area { get; set; }
        public string Pp_Nro_Telefono { get; set; }
        public string Pp_Cod_Servicio { get; set; }
        public string Pp_Fecha_Desde { get; set; }
        public string Pp_Fecha_Hasta { get; set; }


        Acceso_BD BD = new Acceso_BD();
        public DataTable ServiciosCompletos()
        {
            string sql = "SELECT * FROM servicios_contratados";
            return BD.EjecutarSelect(sql);
        }
        public void Insertar()
        {

            string sqlInsertar = @"INSERT INTO servicios_c (nombre_razonSocial, calle, nro, piso, cod_barrio)"
                                  + "VALUES ('" + Pp_Tipo_Servicio + "','" + Pp_Nombre_Servicio + "','" + Pp_Cod_Nacional + "', '" + Pp_Cod_Area + "' , " + Pp_Nro_Telefono + ", " + Pp_Cod_Servicio + ", " +
                                  ", " + "" + Pp_Cod_Servicio + "', " + Pp_Fecha_Desde + ", " + Pp_Fecha_Hasta + ")";
        /*       + ", '" + Pp_calle + "'"
               + "," + Pp_nro 
               + "," + Pp_piso 
               + "," + Pp_barrio + ")";
string sqlInsertar = @"INSERT INTO clientes(nombre_razonSocial, calle, nro, piso, cod_barrio)
                VALUES('Ivan artime', 'Arroabarrena', 85, 2, 4)";*/
            BD.Insertar(sqlInsertar);
            MessageBox.Show("Cliente cargado exitosamente");
        }
    
    }
}