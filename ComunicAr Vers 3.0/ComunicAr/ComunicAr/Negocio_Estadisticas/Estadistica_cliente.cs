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
        ////////////////////////////////// CLIENTES POR SERVICIO ////////////////////////////////////

        public DataTable Todos_clientes()
        {
            string sql = "SELECT sc.tipo_servicio, COUNT(*) as 'cantidad'" +
                        " FROM Servicios_contratados sc" +
                        " GROUP BY sc.tipo_servicio";
            tabla = BD.EjecutarSelect(sql);
            tabla.Columns.Add("nombre_servicio");
            if (tabla.Rows.Count == 0)
            {
                tabla.Rows.Add("0", 0);
            }
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (tabla.Rows[i][0].ToString() == "A")
                {
                    tabla.Rows[i][2] = "Servicios de Datos";
                }
                else if (tabla.Rows[i][0].ToString() == "B")
                {
                    tabla.Rows[i][2] = "Servicios Fijos";
                }
                else if (tabla.Rows[i][0].ToString() == "C")
                {
                    tabla.Rows[i][2] = "Servicios Prepagos";
                }

            }
            return tabla;
        }
        public DataTable Servicio_en_un_año(int año)
        {
            string sql = "SELECT sc.tipo_servicio, COUNT(*) as cantidad" +
                " FROM Numero n JOIN Cliente c ON n.nro_cliente = c.nro_cliente" +
                " JOIN Servicios_contratados sc ON n.id_numero = sc.id_numero" +
                " WHERE YEAR(sc.fecha_desde) = " + año +
                " GROUP BY sc.tipo_servicio";
            tabla = BD.EjecutarSelect(sql);
            tabla.Columns.Add("nombre_servicio");
            if (tabla.Rows.Count == 0)
            {
                tabla.Rows.Add("0", 0);
            }
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (tabla.Rows[i][0].ToString() == "A")
                {
                    tabla.Rows[i][2] = "Servicios de Datos";
                }
                else if (tabla.Rows[i][0].ToString() == "B")
                {
                    tabla.Rows[i][2] = "Servicios Fijos";
                }
                else if (tabla.Rows[i][0].ToString() == "C")
                {
                    tabla.Rows[i][2] = "Servicios Prepagos";
                }

            }
            return tabla;
        }

        public DataTable Servicio_en_alta_año(string año)
        {
            string sql = "SELECT sc.tipo_servicio, COUNT(c.nro_cliente) as cantidad" +
                " FROM Numero n JOIN Cliente c ON n.nro_cliente = c.nro_cliente" +
                " JOIN Servicios_contratados sc ON n.id_numero = sc.id_numero" +
                " WHERE '" + año + "' BETWEEN YEAR(sc.fecha_desde) AND YEAR(sc.fecha_hasta)" +
                " GROUP BY sc.tipo_servicio";
            tabla = BD.EjecutarSelect(sql);
            tabla.Columns.Add("nombre_servicio");
            if (tabla.Rows.Count == 0)
            {
                tabla.Rows.Add("0", 0);
            }
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (tabla.Rows[i][0].ToString() == "A")
                {
                    tabla.Rows[i][2] = "Servicios de Datos";
                }
                else if (tabla.Rows[i][0].ToString() == "B")
                {
                    tabla.Rows[i][2] = "Servicios Fijos";
                }
                else if (tabla.Rows[i][0].ToString() == "C")
                {
                    tabla.Rows[i][2] = "Servicios Prepagos";
                }

            }
            return tabla;
        }

        ///////////////////////////////// CLIENTES POR PROVINCIA //////////////////////////////////

        public DataTable Todas_provincias()
        {
            string sql = "SELECT p.nombre_prov, COUNT(*) as 'cantidad'" +
                        " FROM Barrio b JOIN Cliente c ON b.cod_barrio = c.cod_barrio" +
                        " JOIN Ciudad cd ON b.id_ciudad = cd.cod_ciudad" +
                        " JOIN Provincia p ON cd.id_provincia = p.cod_prov" +
                        " GROUP BY p.nombre_prov";
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }
        public DataTable fecha_alta(string año)
        {
            string sql = "SELECT p.nombre_prov, COUNT(*) as cantidad" +
                        " FROM Barrio b JOIN Cliente c ON b.cod_barrio = c.cod_barrio" +
                        " JOIN Ciudad cd ON b.id_ciudad = cd.cod_ciudad" +
                        " JOIN Provincia p ON cd.id_provincia = p.cod_prov" +
                        " WHERE '2011' BETWEEN YEAR(c.fecha_alta) AND YEAR(c.fecha_baja)" +
                        " GROUP BY p.nombre_prov";
            tabla = BD.EjecutarSelect(sql);
            return tabla;
        }
    }
}
