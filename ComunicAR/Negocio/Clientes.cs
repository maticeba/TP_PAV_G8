using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ComunicAR.Clases;
namespace ComunicAR.Negocio
{
    class Clientes
    {
        Acceso_BD BD = new Acceso_BD();
        public DataTable ClientesCompletos()
        {
            string sql = "SELECT * FROM clientes";
            return BD.EjecutarSelect(sql);
        }
    }
}
