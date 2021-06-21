using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ComunicAr.Clases;

namespace ComunicAr.Negocio_Estadisticas
{
    class Estadistica_Nros
    {
        DataTable tabla = new DataTable();
        Acceso_BD BD = new Acceso_BD();
        public DataTable SearchNro_baja(string año, string mes, bool flag)
        {
            string sql = @"SELECT s.tipo_servicio AS denominacion, COUNT(*) as valor" +
                          " FROM Numero n, Servicios_contratados s " +
                          " WHERE s.id_numero = n.id_numero	" +
                              " AND n.borrado = 1 ";
            if (flag == true)
            {
                sql += " AND YEAR(n.fecha_baja) = " + año + " GROUP BY s.tipo_servicio";
            }
            else
            {
                sql += " AND YEAR(n.fecha_baja) = " + año + " AND MONTH(n.fecha_baja) = " + mes +" GROUP BY s.tipo_servicio";
            }

            tabla = BD.EjecutarSelect(sql);
            int count = 0;
            int filas = tabla.Rows.Count;
            DataTable data = new DataTable();
            data.Columns.Add("denominacion");
            data.Columns.Add("valor");
            data.Columns.Add("Porcentaje");

            if (filas == 0)
            {
                data.Rows.Add("0", 0, 0);
            }
            else
            {
                for (int i = 0; i < filas; i++)
                {
                    count += int.Parse(tabla.Rows[i][1].ToString());
                }
                for (int i = 0; i < filas; i++)
                {
                    data.Rows.Add();
                    if (tabla.Rows[i][0].ToString() == "A")
                    {
                        data.Rows[i][0] = "Datos";
                    }
                    else if (tabla.Rows[i][0].ToString() == "B")
                    {
                        data.Rows[i][0] = "Fijos";
                    }
                    else
                    {
                        data.Rows[i][0] = "Prepago";
                    }
                    data.Rows[i][2] = ((float.Parse(tabla.Rows[i][1].ToString())*100)/count);
                    data.Rows[i][1] = tabla.Rows[i][1].ToString();
                }
            }
            return data;
        }
        public string mes (string nro_mes)
        {
            String nombre_mes = " ";
            if (nro_mes.ToString() == "1")
            {
                nombre_mes = "Enero";
            }
            else if (nro_mes.ToString() == "2")
            {
                nombre_mes = "Febrero";
            }
            else if (nro_mes.ToString() == "3")
            {
                nombre_mes = "Marzo";
            }
            else if (nro_mes.ToString() == "4")
            {
                nombre_mes = "Abril";
            }
            else if (nro_mes.ToString() == "5")
            {
                nombre_mes = "Mayo";
            }
            else if (nro_mes.ToString() == "6")
            {
                nombre_mes = "Junio";
            }
            else if (nro_mes.ToString() == "7")
            {
                nombre_mes = "Julio";
            }
            else if (nro_mes.ToString() == "8")
            {
                 nombre_mes = "Agosto";
            }
            else if (nro_mes.ToString() == "9")
            {
                 nombre_mes = "Septiembre";
            }
            else if (nro_mes.ToString() == "10")
            {
                 nombre_mes = "Octubre";
            }
            else if (nro_mes.ToString() == "11")
            {
                 nombre_mes = "Noviembre";
            }
            else if (nro_mes.ToString() == "12")
            {
                 nombre_mes = "Diciembre";
            }

            return nombre_mes;
        }
    }
}
