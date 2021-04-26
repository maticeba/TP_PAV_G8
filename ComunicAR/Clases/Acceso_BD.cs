using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ComunicAR.Clases
{
    class Acceso_BD
    {
        
        public SqlConnection conexion = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        

        private void conectar() //CONECTAR A BD
        {
            conexion.ConnectionString = "Data Source=DESKTOP-RAMDSGS;Initial Catalog=ComunicAR;Integrated Security=True"; //ACA VA LA CADENA DE CONECCION A BD
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
        }
        private void desconectar() // DESCONECTAR DE BD
        {
            conexion.Close();
        }

        public DataTable EjecutarSelect(string sql_command) 
        {
            conectar();
            cmd.CommandText = sql_command;
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            desconectar();
            return tabla;

        }

        
        
        
           
            

    }
}
