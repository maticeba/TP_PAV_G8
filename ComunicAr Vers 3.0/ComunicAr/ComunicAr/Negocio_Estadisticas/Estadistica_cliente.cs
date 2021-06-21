using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComunicAr.Clases;
using System.Data;
using System.Windows.Forms;

namespace ComunicAr.Negocio_Estadisticas
{
    class Estadistica_cliente
    {
        Acceso_BD BD = new Acceso_BD();
        DataTable tabla = new DataTable();

        public DataTable SearchClientes_baja(string año)
        {
            string sql = @"SELECT MONTH(fecha_baja) AS denominacion, COUNT(MONTH(fecha_baja)) as VALOR "
                          + "FROM Cliente c " +
                          " WHERE c.borrado = 1 " +
                                " AND YEAR(fecha_baja) = " + año +
                          "GROUP BY MONTH(fecha_baja)";

            tabla = BD.EjecutarSelect(sql);
            tabla.Columns.Add("nombre");
            if (tabla.Rows.Count == 0)
            {
                tabla.Rows.Add("0", 0);
            }
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (tabla.Rows[i][0].ToString() == "1")
                {
                    tabla.Rows[i][2] = "Enero";
                }
                else if (tabla.Rows[i][0].ToString() == "2")
                {
                    tabla.Rows[i][2] = "Febrero";
                }
                else if (tabla.Rows[i][0].ToString() == "3")
                {
                    tabla.Rows[i][2] = "Marzo";
                }
                else if (tabla.Rows[i][0].ToString() == "4")
                {
                    tabla.Rows[i][2] = "Abril";
                }
                else if (tabla.Rows[i][0].ToString() == "5")
                {
                    tabla.Rows[i][2] = "Mayo";
                }
                else if (tabla.Rows[i][0].ToString() == "6")
                {
                    tabla.Rows[i][2] = "Junio";
                }
                else if (tabla.Rows[i][0].ToString() == "7")
                {
                    tabla.Rows[i][2] = "Julio";
                }
                else if (tabla.Rows[i][0].ToString() == "8")
                {
                    tabla.Rows[i][2] = "Agosto";
                }
                else if (tabla.Rows[i][0].ToString() == "9")
                {
                    tabla.Rows[i][2] = "Septiembre";
                }
                else if (tabla.Rows[i][0].ToString() == "10")
                {
                    tabla.Rows[i][2] = "Octubre";
                }
                else if (tabla.Rows[i][0].ToString() == "11")
                {
                    tabla.Rows[i][2] = "Noviembre";
                }
                else if (tabla.Rows[i][0].ToString() == "12")
                {
                    tabla.Rows[i][2] = "Diciembre";
                }
                else
                {
                    tabla.Rows[i][2] = "En el año '" + año + "' no hubo clientes dados de baja";
                }
            }
            return tabla;
        }
    }
}
