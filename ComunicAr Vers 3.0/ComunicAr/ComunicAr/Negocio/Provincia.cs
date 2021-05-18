using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComunicAr.Clases;
using System.Data;
using System.Windows.Forms;

namespace ComunicAr.Negocio
{
    class Provincia
    {
        public string Pp_nombreProvincia { get; set; }
        public string Pp_codigoProvincia { get; set; }

        Acceso_BD BD = new Acceso_BD();
        public DataTable ProvinciasCompletas()
        {
            string sql = "SELECT * FROM Provincia";
            return BD.EjecutarSelect(sql);
        }
        public void Insertar()
        {

            string sqlInsertar = @"INSERT INTO Provincia (nombre_prov)"
                                  + "VALUES ('" + Pp_nombreProvincia + "')";
            BD.Insertar(sqlInsertar);
            MessageBox.Show("Provincia cargada exitosamente");
        }

        public void Modificar()
        {
            string sqlMod = @"UPDATE Provincia SET "
                            + " nombre_prov = '" + Pp_nombreProvincia + "'"
                            + " WHERE cod_prov = " + Pp_codigoProvincia;
            BD.EjecutarModificar(sqlMod);
            MessageBox.Show("Modificacion realizada con exito");
        }

        public DataTable cod_prov(string nro_prov)
        {
            string sql = @"SELECT c.* FROM Provincia c "
                        + "WHERE c.cod_prov = " + nro_prov;
            return BD.EjecutarSelect(sql);
        }
        public DataTable Cod_prov_nombre(string nombre)
        {
            string sql = @"SELECT c.* FROM Provincia c "
                        + "WHERE c.nombre_prov like '%" + nombre.Trim() + "%'";
            return BD.EjecutarSelect(sql);
        }
        public void Borrar()
        {
            string sqlBorrar = "DELETE FROM Provincia WHERE cod_prov = " + Pp_codigoProvincia;
            BD.Borrar(sqlBorrar);
        }
    }
}
