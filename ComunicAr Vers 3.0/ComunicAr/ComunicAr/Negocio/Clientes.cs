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
    class Clientes
    {
        public string Pp_nombre { get; set; }
        public string Pp_calle { get; set; }
        public string Pp_nro { get; set; }
        public string Pp_piso { get; set; }
        public string Pp_barrio { get; set; }
        public string Pp_nroCliente { get; set; }

        Acceso_BD BD = new Acceso_BD();
        public DataTable ClientesCompletos()
        {
            string sql = "SELECT * FROM clientes";
            /*string sql = @"SELECT c.*, b.nombre_barrio as cod_barrio"
                         + "from clientes c join barrios b"
                         + "on c.cod_barrio = b.cod_barrio";*/
            return BD.EjecutarSelect(sql);
        }
        public DataTable Clientes_por_Numero(string nro_Cliente)
        {
            string sql = @"SELECT c.* FROM clientes c "
                        + "WHERE c.nro_cliente = " + nro_Cliente;
            return BD.EjecutarSelect(sql);
        }
        public DataTable Clientes_por_Nombre(string nombre)
        {
            string sql = @"SELECT c.* FROM clientes c "
                        + "WHERE c.nombre_razonSocial like '%" + nombre.Trim() + "%'";
            return BD.EjecutarSelect(sql);
        }
        public void Insertar(Control.ControlCollection controles)
        {
            TratamientosEspeciales tratamientos = new TratamientosEspeciales();
            BD.Insertar(tratamientos.ConstructorInsert("Clientes", controles));
            MessageBox.Show("Cliente cargado exitosamente");
        }

        public void Modificar()
        {
            string sqlMod = @"UPDATE clientes SET "
                            + " nombre_razonSocial = '" + Pp_nombre + "'"
                            + ", calle = '" + Pp_calle + "'"
                            + ", nro = " + Pp_nro
                            + ", piso =" + Pp_piso
                            + ", cod_barrio = " + Pp_barrio
                            + "WHERE nro_cliente = " + Pp_nroCliente;
            BD.EjecutarModificar(sqlMod);
            MessageBox.Show("Modificacion realizada con exito");
        }
    }
}
