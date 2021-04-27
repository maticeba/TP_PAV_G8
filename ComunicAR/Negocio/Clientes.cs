using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ComunicAR.Clases;
using System.Windows.Forms;
namespace ComunicAR.Negocio
{
    class Clientes
    {
        public string Pp_nombre { get; set; }
        public string Pp_calle { get; set; }
        public string Pp_nro { get; set; }
        public string Pp_piso { get; set; }
        public string Pp_barrio { get; set; }
        
        Acceso_BD BD = new Acceso_BD();
        public DataTable ClientesCompletos()
        {
            string sql = "SELECT * FROM clientes";
            return BD.EjecutarSelect(sql);
        }

        public void Insertar()
        {

            string sqlInsertar = @"INSERT INTO clientes (nombre_razonSocial, calle, nro, piso, cod_barrio"
                                  + "VALUES ("
                                  + Pp_nombre
                                  + ", '" + Pp_calle + "'"
                                  + ", '" + Pp_nro + "'"
                                  + ", '" + Pp_piso + "'"
                                  + "," + Pp_barrio + ")";
            BD.Insertar(sqlInsertar);
            MessageBox.Show("Cliente cargado exitosamente");
                                 
                                 
        }
    
    }

}
