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
        public string Pp_cod_servicio { get; set; }
        public string Pp_id_servicio { get; set; }
        public string Pp_tipo_servicio { get; set; }
        public string Pp_fecha_desde { get; set; }
        public string Pp_fecha_hasta { get; set; }
        public string Pp_id_numero { get; set; }
      


        Acceso_BD BD = new Acceso_BD();
        public DataTable ServiciosCompletos()
        {
            string sql = @"SELECT s.cod_servicio, s.tipo_servicio, s.id_servicio, " +
                            "DATEPART(DAY, s.fecha_desde) AS dia_desde, " +
                            "DATEPART(MONTH, s.fecha_desde) AS mes_desde, " +
                            "DATEPART(YEAR, s.fecha_desde) AS año_desde, " +
                            "DATEPART(DAY, s.fecha_hasta) AS dia_hasta, " +
                            "DATEPART(MONTH, s.fecha_hasta) AS mes_hasta, " +
                            "DATEPART(YEAR, s.fecha_hasta) AS año_hasta, " +
                            "n.cod_nacional, n.cod_area, n.nro_telefono " +
                            "FROM servicios_contratados s, Numero n " +
                            "WHERE s.id_numero = n.id_numero " +
                                "AND n.borrado = 0 " +
                            "ORDER BY s.cod_servicio";
            return BD.EjecutarSelect(sql);
        }

        public string servicio_ofrecido(string tipo, string id)
        {
            DataTable tabla = new DataTable();
            if (tipo == "A")
            {
                string sql = "SELECT descripcion FROM Servicios_datos WHERE cod_datos = " + id;
                tabla = BD.EjecutarSelect(sql);

                return tabla.Rows[0]["descripcion"].ToString();
            }
            else if (tipo == "B")
            {
                string sql = "SELECT descripcion FROM Servicios_fijos WHERE cod_servicio = " + id;
                tabla = BD.EjecutarSelect(sql);

                return tabla.Rows[0]["descripcion"].ToString();
            }
            else
            {
                string sql = "SELECT descripcion FROM Servicios_prepago WHERE id_pack = " + id;
                tabla = BD.EjecutarSelect(sql);

                return tabla.Rows[0]["descripcion"].ToString();
            }
        }

        public DataTable Servicios_contratados_por_codigo(string cod_servicio)
        {
            string sql = @"SELECT s.cod_servicio, s.id_servicio, s.tipo_servicio, s.id_numero, " +
                       " n.cod_nacional, n.cod_area, n.nro_telefono, " +
                       " DATEPART(DAY, s.fecha_desde) AS dia_desde, " +
                       " DATEPART(DAY, s.fecha_desde) AS dia_desde, " +
                       " DATEPART(MONTH, s.fecha_desde) AS mes_desde, " +
                       " DATEPART(YEAR, s.fecha_desde) AS año_desde, " +
                       " DATEPART(DAY, s.fecha_hasta) AS dia_hasta, " +
                       " DATEPART(MONTH, s.fecha_hasta) AS mes_hasta, " +
                       " DATEPART(YEAR, s.fecha_hasta) AS año_hasta " +
                       " FROM servicios_contratados s, Numero n " +
                       " WHERE s.id_numero = n.id_numero " +
                            " AND s.cod_servicio = " + cod_servicio + " " +
                            " AND n.borrado = 0";
            return BD.EjecutarSelect(sql);
        }

        public void Insertar()
        {
            string sqlIN = @"INSERT INTO servicios_contratados (tipo_servicio, id_servicio, fecha_desde, fecha_hasta, id_numero)"
                            + " VALUES ('" + Pp_tipo_servicio + "',"
                            + Pp_id_servicio + ","
                            + "'" + Pp_fecha_desde + "',"
                            + "'" + Pp_fecha_hasta + "',"
                            + Pp_id_numero + " )";

            BD.Insertar(sqlIN);
            MessageBox.Show("Servicio agregado exitosamente");




            /*string sqlInsertar = @"INSERT INTO servicios_c (nombre_razonSocial, calle, nro, piso, cod_barrio)"
                                  + "VALUES ('" + Pp_Tipo_Servicio + "','" + Pp_Nombre_Servicio + "','" + Pp_Cod_Nacional + "', '" + Pp_Cod_Area + "' , " + Pp_Nro_Telefono + ", " + Pp_Cod_Servicio + ", " +
                                  ", " + "" + Pp_Cod_Servicio + "', " + Pp_Fecha_Desde + ", " + Pp_Fecha_Hasta + ")";
      
            BD.Insertar(sqlInsertar);
            MessageBox.Show("Servicio cargado exitosamente");*/
        }

        public void Modificar()
        {
            string sqlMod = @"UPDATE servicios_contratados SET "
                            + " tipo_servicio = '" + Pp_tipo_servicio + "'"
                            + ", id_servicio = " + Pp_id_servicio 
                            + ", fecha_desde = (CONVERT(DATETIME, '" + Pp_fecha_desde + "',103))"
                            + ", fecha_hasta = (CONVERT(DATETIME, '" + Pp_fecha_hasta + "',103))"
                            + ", id_numero = " + Pp_id_numero
                            + " WHERE cod_servicio = " + Pp_cod_servicio;
            
            BD.EjecutarModificar(sqlMod);
            MessageBox.Show("Modificacion realizada con exito");
        }

        public void Borrar()
        {
            string sqlBorrar = "DELETE FROM servicios_contratados WHERE cod_servicio = " + Pp_cod_servicio;
            BD.Borrar(sqlBorrar);
        }

        public DataTable Search_servicio(string tipo)
        {
            if (tipo == "A")
            {
                string sql = "SELECT DISTINCT cod_datos as cod FROM servicios_datos ";
                return BD.EjecutarSelect(sql);

            }
            else if (tipo == "B")
            {
                string sql = "SELECT DISTINCT cod_servicio as cod FROM servicios_fijos ";
                return BD.EjecutarSelect(sql);
            }

            else
            {
                string sql = "SELECT DISTINCT id_pack as cod FROM servicios_prepago ";
                return BD.EjecutarSelect(sql);
            }
        }
    }
}