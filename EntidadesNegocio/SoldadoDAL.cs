using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EntidadesDeNegocio;

namespace BaseDatos
{
    public class SoldadoDAL
    {
        public static int guardar(Soldado pSoldado)
        {
            string consulta = "INSERT INTO soldado(edad,capacidadCarga,idPais_Fk,idProfesion_Fk,idRango_Fk) VALUES(@edad,@experiencia,@capacidadCarga,@idPais_Fk,@idProfesion_Fk,@idRango_Fk)";
            SqlCommand comando = ComunDB.obtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@edad", pSoldado.edad);
            comando.Parameters.AddWithValue("@experiencia", pSoldado.experiencia);
            comando.Parameters.AddWithValue("@capacidadCarga", pSoldado.capacidadCarga);
            comando.Parameters.AddWithValue("@idPais_Fk", pSoldado.idPais_Fk);
            comando.Parameters.AddWithValue("@idProfesion_Fk", pSoldado.idProfesion_Fk);
            comando.Parameters.AddWithValue("@idRango_Fk", pSoldado.idRango_Fk);
            return ComunDB.ejecutarComando(comando);
        }

        public static List<Soldado> obtenerListaSoldados()
        {
            string consulta = "SELECT TOP 500 s.id_soldado, s.edad, s.experiencia, s.capacidadCarga, s.idPais_Fk, s.idProfesion_Fk, s.idRango_Fk FROM soldado s";
            SqlCommand comando = ComunDB.obtenerComando();
            comando.CommandText = consulta;
            SqlDataReader reader = ComunDB.ejecutarComandoReader(comando);
            List<Soldado> listaSoldados = new List<Soldado>();
            while (reader.Read())
            {
                Soldado soldado = new Soldado();
                soldado.id_soldado = reader.GetInt32(0);
                soldado.edad = reader.GetInt32(1);
                soldado.experiencia = reader.GetInt32(2);
                soldado.capacidadCarga = reader.GetInt32(3);
                soldado.idPais_Fk = reader.GetInt32(4);
                soldado.idProfesion_Fk = reader.GetInt32(5);
                soldado.idRango_Fk = reader.GetInt32(6);
                listaSoldados.Add(soldado);
            }
            return listaSoldados;
        }
    }
}
