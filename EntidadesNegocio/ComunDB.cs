using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AirSur.BaseDatos
{
    public class ComunDB
    {
        const string StrConexion = @"Data Source=conflictosaisur.database.windows.net;Persist Security Info=True;User ID=adminaisu;Password=@isur1234";

        private static SqlConnection obtenerConexion()
        {
            SqlConnection connection = new SqlConnection(StrConexion);
            connection.Open();
            return connection;
        }

        public static SqlCommand obtenerComando()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = obtenerConexion();
            return command;
        }

        public static int ejecutarComando(SqlCommand pComando)
        {
            int resultado = pComando.ExecuteNonQuery();
            pComando.Connection.Close();
            return resultado;
        }

        public static SqlDataReader ejecutarComandoReader(SqlCommand pComando)
        {
            SqlDataReader reader = pComando.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }
    }
}
