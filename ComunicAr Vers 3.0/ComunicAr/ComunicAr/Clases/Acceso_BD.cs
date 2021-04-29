using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ComunicAr.Clases
{
    class Acceso_BD
    {
        public SqlConnection conexion = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();


        private void conectar() //CONECTAR A BD
        {
            conexion.ConnectionString = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K6G08_2021;Persist Security Info=True;User ID=BD3K6G08_2021;Password=BDG08_9875";
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

        public void Insertar(string sql_comandI)
        {
            conectar();
            cmd.CommandText = sql_comandI;
            cmd.ExecuteNonQuery();
            desconectar();

        }
    }
}
