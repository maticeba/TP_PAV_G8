using System;
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
            string sql = @"SELECT l.*, nE.*, b.costo,nR.id_numero, nR.cod_nacional as Rcod_nac, nR.cod_area as Rcod_area, nR.nro_telefono as Rnro, DATEDIFF (minute, l.fecha_hora_inicio, l.fecha_hora_fin) as duracion "
                        + "FROM Llamadas l, Numero nE, Banda_horaria b, Numero nR "
                        + "WHERE nE.nro_cliente = " + nro_cliente + " AND nE.id_numero = l.id_nro_emisor AND l.id_band_horar = b.id_banda " +
                        "AND nR.id_numero = l.id_nro_receptor ";
            return BD.EjecutarSelect(sql);
        }
        public void insertarDetalleLlamada()
        {
            string sql = @"INSERT INTO Detalle_fact_llamada (nro_factura, id_llamada, costo_final) VALUES( " +
                        Pp_NroFac + ", " +
                        Pp_IdLlamada + ", " +
                        Pp_Subtotal + ") ";
            BD.Insertar(sql);
            MessageBox.Show("Detalle cargado exitosamente");


        }
    }
}
