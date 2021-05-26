using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ComunicAr.Clases;
using System.Windows.Forms;

namespace ComunicAr.Negocio_Transacciones
{
    class Emitir_Factura
    {
        public string Pp_nroCliente { get; set; }
        Acceso_BD BD = new Acceso_BD();

        public void CrearSubFactura(string Pp_nroCliente)
        {
            int pos = BuscarLastFactura();
            if (pos == 0)
            {
                string sql = @"DECLARE @fechaAct date = CAST(GETDATE() AS DATE) " +
                "INSERT INTO  Facturas (fecha_emitido, fecha_1er_vto, fecha_2do_vto, nro_cliente) " +
                       "VALUES (@fechaAct, DATEADD(DAY,10,@fechaAct), DATEADD(DAY,20,@fechaAct), " + Pp_nroCliente + ")";
                BD.Insertar(sql);
            }
            else
            {
                string sql = @"DECLARE @fechaAct date = CAST(GETDATE() AS DATE) " +
                                "UPDATE  Facturas SET fecha_emitido = @fechaAct" +
                                                   ", fecha_1er_vto = DATEADD(DAY,10,@fechaAct)" +
                                                   ", fecha_2do_vto = DATEADD(DAY,20,@fechaAct)" +
                                                   ", nro_cliente = " + Pp_nroCliente + " " +
                                                  "WHERE nro_factura = " + pos.ToString();
                BD.Insertar(sql);
            }
        }

        public int BuscarLastFactura()
        {
            string sql = "SELECT MAX(nro_factura) FROM Facturas";
            DataTable tabla = new DataTable();
            tabla = BD.EjecutarSelect(sql);

            if (tabla.Rows[0][0].ToString() != "")
            {
                string sql1 = "SELECT facturado FROM Facturas WHERE nro_factura = " + tabla.Rows[0][0].ToString();
                DataTable tabla1 = new DataTable();
                tabla1 = BD.EjecutarSelect(sql1);
                if (tabla1.Rows[0][0].ToString() == "False")
                {
                    return int.Parse(tabla.Rows[0][0].ToString());
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        public DataTable CargarFactura(string Pp_nroCliente)
        {
            string sql = @"SELECT F.* FROM Facturas f " +
                        "WHERE f.nro_cliente = " + Pp_nroCliente + "AND f.nro_factura = (SELECT MAX(nro_factura) FROM Facturas) ";
            return BD.EjecutarSelect(sql);
        }


    }
}
