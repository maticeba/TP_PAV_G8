﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ComunicAr.Clases;
using System.Windows.Forms;

namespace ComunicAr.Negocio_Transacciones
{
    class Detalle_Llamadas
    {
        public string Pp_NroFac { get; set; }
        public string Pp_IdLlamada { get; set; }
        public string Pp_Subtotal { get; set; }
        Acceso_BD BD = new Acceso_BD();
        public DataTable CargarCliente(string NroFac)
        {
            string sql = @"SELECT f.nro_factura, f.nro_cliente, c.nombre_razonSocial, c.nro_cliente "
                          + "FROM Facturas f, Cliente c"
                          + " WHERE f.nro_factura = " + NroFac + " AND f.nro_cliente = c.nro_cliente ";
            return BD.EjecutarSelect(sql);

        }
        public DataTable RecoleccionDatos(string nro_cliente)
        {
            string sql = @"DECLARE @hoy as datetime = GetDate()" +
                          "DECLARE @1roMes as datetime = DateAdd( day, 1 - Day( @hoy ), @hoy )" +
                          "DECLARE @finmes as datetime = DateAdd( day, -1, DateAdd( month, 1, @1roMes ) )" +
                         "SELECT l.*, nE.*, b.costo,nR.id_numero, nR.cod_nacional as Rcod_nac, nR.cod_area as Rcod_area, nR.nro_telefono as Rnro, DATEDIFF (minute, l.fecha_hora_inicio, l.fecha_hora_fin) as duracion "
                        + "FROM Llamadas l, Numero nE, Banda_horaria b, Numero nR "
                        + "WHERE nE.nro_cliente = " + nro_cliente + " AND nE.id_numero = l.id_nro_emisor AND l.id_band_horar = b.id_banda " +
                        "AND nR.id_numero = l.id_nro_receptor AND @1roMes <= l.fecha_hora_inicio AND L.fecha_hora_inicio <= @finmes ";
            return BD.EjecutarSelect(sql);
        }
        public void insertarDetalleLlamada()
        {
            string sql = @"INSERT INTO Detalle_fact_llamada (nro_factura, id_llamada, costo_final) VALUES( " +
                        Pp_NroFac + ", " +
                        Pp_IdLlamada + ", " +
                         "REPLACE('" + Pp_Subtotal + "', ',', '.'))";
            BD.Insertar(sql);

        }
        public DataTable Factura_llamada(string nro_factura, string nro_cliente)
        {
            string sql = @"SELECT   COUNT(df.id_detalleLlamada) AS cant_llamadas, " +
                                   "SUM(df.costo_final) AS total, " +
                                   "SUM(CONVERT(int, (Cast((l.fecha_hora_fin - l.fecha_hora_inicio) as float) * 1440))) AS tiempo_total " +
                          "FROM Detalle_fact_llamada df, Llamadas l, Facturas f, Numero n " +
                          "WHERE df.id_llamada = l.id_llamada " +
                             "AND f.nro_factura = df.nro_factura " +
                             "AND n.id_numero = l.id_nro_emisor " +
                             "AND n.nro_cliente = " + nro_cliente +
                             "AND df.nro_factura = " + nro_factura;
            return BD.EjecutarSelect(sql);
        }
    }
}
