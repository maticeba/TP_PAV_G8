﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ComunicAr.Clases;
using System.Windows.Forms;

namespace ComunicAr.Negocio
{
   
    class Numeros
    {
        public string Pp_id_numero { get; set; }
        public string Pp_cod_nacional { get; set; }
        public string Pp_cod_area { get; set; }
        public string Pp_nro_telefono { get; set; }
        public string Pp_nro_cliente { get; set; }
        public string Pp_id_dispositivo { get; set; }

        Acceso_BD BD = new Acceso_BD();
        public DataTable NumerosCompletos()
        {
            string sql = "SELECT * FROM numero";
            return BD.EjecutarSelect(sql);
        }

        public DataTable Numeros_por_id(string id_numero)
        {
            string sql = @"SELECT n.* FROM numero n "
                       + "WHERE n.id_numero = " + id_numero;
            return BD.EjecutarSelect(sql);
        }

        public void Insertar()
        {
            string sqlIN = @"INSERT INTO numero (cod_nacional, cod_area, nro_telefono, nro_cliente, id_dispositivo)"
                            + " VALUES (" + Pp_cod_nacional + ","
                            + Pp_cod_area + ","
                            + Pp_nro_telefono + ","
                            + Pp_nro_cliente + ","
                            + Pp_id_dispositivo + " )";

            BD.Insertar(sqlIN);
            MessageBox.Show("Servicio agregado exitosamente");
        }

        public void Modificar()
        {
            string sqlMod = @"UPDATE numero SET  "
                            + " cod_nacional = '" + Pp_cod_nacional + "'"
                            + ", cod_area = " + Pp_cod_area
                            + ", nro_telefono = " + Pp_nro_telefono 
                            + ", nro_cliente = " + Pp_nro_cliente  
                            + ", id_dispositivo = " + Pp_id_dispositivo
                            + " WHERE id_numero = " + Pp_id_numero;

            BD.EjecutarModificar(sqlMod);
            MessageBox.Show("Modificacion realizada con exito");
        }

        public void Borrar()
        {
            string sqlBorrar = "DELETE FROM numero WHERE id_numero = " + Pp_id_numero;
            BD.Borrar(sqlBorrar);
        }
    }
}