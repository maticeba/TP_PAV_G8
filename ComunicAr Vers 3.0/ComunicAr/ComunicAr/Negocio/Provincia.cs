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

            string sqlInsertar = @"INSERT INTO Provincia (nombre_provincia)"
                                  + "VALUES ('" + Pp_nombreProvincia + "')";
            BD.Insertar(sqlInsertar);
            MessageBox.Show("Provincia cargada exitosamente");
        }

        public void Modificar()
        {
            string sqlMod = @"UPDATE Provincia SET "
                            + " nombre_provincia = '" + Pp_nombreProvincia + "'"
                            + " WHERE codigo_provincia = " + Pp_codigoProvincia;
            BD.EjecutarModificar(sqlMod);
            MessageBox.Show("Modificacion realizada con exito");
        }

        public DataTable cod_prov(string nro_prov)
        {
            string sql = @"SELECT c.* FROM Provincia c "
                        + "WHERE c.codigo_provincia = " + nro_prov;
            return BD.EjecutarSelect(sql);
        }
        public DataTable Cod_prov_nombre(string nombre)
        {
            string sql = @"SELECT c.* FROM Provincia c "
                        + "WHERE c.nombre_provincia like '%" + nombre.Trim() + "%'";
            return BD.EjecutarSelect(sql);
        }
        public void Borrar()
        {
            string sqlBorrar = "DELETE FROM Provincia WHERE codigo_provincia = " + Pp_codigoProvincia;
            BD.Borrar(sqlBorrar);
        }
    }
}
