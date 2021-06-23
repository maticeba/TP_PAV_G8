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
    class Llamadas
    {
        public string Pp_id_emisor { get; set; }
        public string Pp_id_receptor { get; set; }
        //Pp_duración cambiarlo para poder entrar el tiempo exacto
        public string Pp_fecha_hora_inicio { get; set; }
        public string Pp_fecha_hora_fin { get; set; }
        public string Pp_tipo_comunicación { get; set; }
        public string Pp_banda_horaria { get; set; }
        public string Pp_id_llamada { get; set; }

        Acceso_BD BD = new Acceso_BD();
        public DataTable LlamadasCompletas()
        {
            string sql = @"SELECT c1.Cod_Nacional AS nac_emisor, c1.Cod_Area AS area_emisor, c1.Nro_Telefono AS tel_emisor, " +
		                                "c2.Cod_Nacional AS nac_recept, " +
                                        "c2.Cod_Area AS area_recept, " +
                                        "c2.Nro_Telefono AS tel_recept, " +
                                        "l.fecha_hora_inicio, " +
		                                "CONVERT(int, (Cast((l.fecha_hora_fin - l.fecha_hora_inicio) as float) * 1440)) as duracion, " +
		                                "t.descripcion as Tipo_com, b.descripcion as Banda_horaria, " +
                                        "l.id_llamada as identificador " +
                               "FROM Llamadas l, Numero c1, Numero c2, Tipo_comunicacion t, Banda_horaria b " +
                               "WHERE	l.id_nro_emisor = c1.id_numero " +
	                               "AND l.id_nro_receptor = c2.id_numero " +
	                               "AND t.id_tipo_com = l.id_tipo_comun " +
	                               "AND b.id_banda = l.id_band_horar";
            return BD.EjecutarSelect(sql);
        }
        /*public void Insertar()
        {

            //falta ingresar Pp_duración y crear Pp_inicio

            string sqlInsertar = @"INSERT INTO llamadas (cod_nacional_emisor, cod_area_emisor, nro_telefono_emisor, "
                                                      + " cod_nacional_receptor, cod_area_emisor_receptor, "
                                                      + "nro_tel_emisor_recep, cod_tipo_comunicacion, cod_banda_horaria)"
                                 + "VALUES (" + Pp_cod_pais_emisor + ", " + Pp_cod_area_emisor + " , " + Pp_emisor + ", "  
                                              + Pp_cod_pais_receptor + ", " + Pp_cod_area_receptor + ", " + Pp_receptor + ", "
                                              + Pp_tipo_comunicación + ", " + Pp_banda_horaria + ")";

            BD.Insertar(sqlInsertar);
            MessageBox.Show("Llamada cargado exitosamente");
        }*/

        public void Insertar()
        {
            string sql = @"INSERT INTO Llamadas (id_nro_emisor, id_nro_receptor, fecha_hora_inicio, fecha_hora_fin, " +
						                        "id_tipo_comun, id_band_horar) " + 
                                  "VALUES (" + Pp_id_emisor + ", " 
                                             + Pp_id_receptor + ", "
                                             + "CONVERT(DATETIME, '" + Pp_fecha_hora_inicio + "', 103), "
                                             + "CONVERT(DATETIME, '" + Pp_fecha_hora_fin + "', 103), "
                                             + Pp_tipo_comunicación + ", " + Pp_banda_horaria + ")";
            BD.Insertar(sql);
            MessageBox.Show("La llamada se ha cargado exitosamente");
        }

        public DataTable Search_cliente(string id_cliente)
        {
            string sql = @"SELECT nombre_razonSocial FROM cliente " +
                            "WHERE borrado = 0 " +
                                " AND nro_cliente = " + id_cliente;

            return BD.EjecutarSelect(sql);
        }

        public DataTable Search_datosNroXidNro(string id_nro)
        {
            string sql = @"SELECT n.nro_cliente, c.nombre_razonSocial as nombre_cliente, id_numero " +
                            "FROM Numero n, cliente c " +
                            "WHERE n.nro_cliente = c.nro_cliente " +
                                "AND id_numero = " + id_nro;

            return BD.EjecutarSelect(sql);
        }
        public DataTable Search_numero(string id_cliente)
        {
            string sql = "SELECT id_numero FROM Numero WHERE nro_cliente = " + id_cliente;

            return BD.EjecutarSelect(sql);
        }

        public string GetTypeCom (string id_emisor, string id_receptor)
        {
            string sql_emisor_nac = @"SELECT n.cod_nacional AS nac, n.cod_area AS area, " + 
                                            "d.id_tipo_dispositivo AS tipo " +
                                    "FROM Numero n, Dispositivos d " +
                                    "WHERE   n.id_dispositivo = d.id_dispositivo " +
                                        "AND id_numero = " + id_emisor;
            DataTable tabla_emisor = new DataTable();
            tabla_emisor = BD.EjecutarSelect(sql_emisor_nac);

            string sql_receptor_nac = @"SELECT n.cod_nacional AS nac, n.cod_area AS area, " +
                                            "d.id_tipo_dispositivo AS tipo " +
                                    "FROM Numero n, Dispositivos d " +
                                    "WHERE   n.id_dispositivo = d.id_dispositivo " +
                                        "AND id_numero = " + id_receptor;
            DataTable tabla_receptor = new DataTable();
            tabla_receptor = BD.EjecutarSelect(sql_receptor_nac);

            if (tabla_emisor.Rows[0]["tipo"].ToString() == tabla_receptor.Rows[0]["tipo"].ToString())
            {
                if(tabla_emisor.Rows[0]["nac"].ToString() == tabla_receptor.Rows[0]["nac"].ToString())
                {
                    if(tabla_emisor.Rows[0]["area"].ToString() == tabla_receptor.Rows[0]["area"].ToString())
                    {
                        return "1";
                    }
                    else
                    {
                        return "2";
                    }
                }
                else
                {
                    return "3";
                }
            }
            else
            {
                return "4";
            }
        }

        public string GetTypeBanda(int hora_inicio, int min_inicio, int hora_fin, int min_fin)
        {
            if (hora_inicio >= 21 || hora_inicio < 6) 
            {
                if(hora_fin < 6)
                {
                    return "2";
                }
                else
                {
                    return "3";
                }
            }
            else
            {
                if (hora_fin < 21 && hora_fin >= 6)
                {
                    return "1";
                }
                else
                {
                    return "3";
                }
            }
        }

        public DataTable LlamadasPresent()
        {
            string sql = @"SELECT " +
                                    //Datos de emisor
                                        "c1.nro_cliente AS id_emisor, " +
                                        "c1.Cod_Nacional AS nac_emisor, " + 
                                        "c1.Cod_Area AS area_emisor, " +
                                        "c1.Nro_Telefono AS tel_emisor, " +
                                    //Datos de receptor
                                        "c2.nro_cliente AS id_receptor, " +
                                        "c2.Cod_Nacional AS nac_recept, " +
                                        "c2.Cod_Area AS area_recept, " +
                                        "c2.Nro_Telefono AS tel_recept, " +
                                    //Fecha de inicio
                                        "DATEPART(YEAR, l.fecha_hora_inicio) AS año_inicio, " +
                                        "DATEPART(MONTH, l.fecha_hora_inicio) AS mes_inicio, " +
                                        "DATEPART(DAY, l.fecha_hora_inicio) AS dia_inicio, " +
                                    //Hora de inicio
                                        "DATEPART(HOUR, l.fecha_hora_inicio) AS hora_inicio, " +
                                        "DATEPART(MINUTE, l.fecha_hora_inicio) AS min_inicio, " +
                                        "DATEPART(SECOND, l.fecha_hora_inicio) AS seg_inicio, " +
                                    //Fecha de fin
                                        "DATEPART(YEAR, l.fecha_hora_fin) AS año_fin, " +
                                        "DATEPART(MONTH, l.fecha_hora_fin) AS mes_fin, " +
                                        "DATEPART(DAY, l.fecha_hora_fin) AS dia_fin, " +
                                    //Hora de fin
                                        "DATEPART(HOUR, l.fecha_hora_fin) AS hora_fin, " +
                                        "DATEPART(MINUTE, l.fecha_hora_fin) AS min_fin, " +
                                        "DATEPART(SECOND, l.fecha_hora_fin) AS seg_fin, " +
                                    //Tipo de llamada
                                        "l.id_tipo_comun as Tipo_com, id_band_horar as Banda_horaria " +
                               "FROM Llamadas l, Numero c1, Numero c2 " +
                               "WHERE	l.id_nro_emisor = c1.id_numero " +
                                   "AND l.id_nro_receptor = c2.id_numero " + 
                                   "AND id_llamada = " + Pp_id_llamada;
            return BD.EjecutarSelect(sql);
        }
        public void UpdateLlamada ()
        {
            string sql = @"UPDATE Llamadas SET " +
                                                "id_nro_emisor = " + Pp_id_emisor + ", " +
                                                "id_nro_receptor = " + Pp_id_receptor + ", " +
                                                "fecha_hora_inicio = CONVERT(DATETIME, '" + Pp_fecha_hora_inicio + "', 103), " +
                                                "fecha_hora_fin = CONVERT(DATETIME, '" + Pp_fecha_hora_fin + "', 103), " +
                                                "id_tipo_comun = " + Pp_tipo_comunicación + ", " +
                                                "id_band_horar = " + Pp_banda_horaria + " " +
                                                "WHERE id_llamada = " + Pp_id_llamada;

            BD.Insertar(sql);
            MessageBox.Show("La llamada se ha modificado exitosamente");
        }
        public void EraseLlamada ()
        {
            string sql = @"DELETE FROM Llamadas WHERE id_llamada = " + Pp_id_llamada;
            BD.Borrar(sql);
        }
        public int GetPosNumero(string id, string nac, string area, string nro)
        {
            string sql = @"SELECT cod_nacional AS nac, cod_area AS area, nro_telefono AS tel "
                        + "FROM Numero WHERE nro_cliente = " + id;
            DataTable numeros = new DataTable();
            numeros = BD.EjecutarSelect(sql);


            for (int i = 0; i < numeros.Rows.Count; i++)
            {
                string cod_nac = numeros.Rows[i][0].ToString();
                string cod_area = numeros.Rows[i][1].ToString();
                string nro_tel = numeros.Rows[i][2].ToString();
                if ((nac == cod_nac) && (area == cod_area) && (nro == nro_tel) )
                {
                    return i ;
                }
            }
            return -1;
        }
        
    }
}
