using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AirSur.EntidadesDeNegocio;

namespace AirSur.BaseDatos
{
    public class SoldadoDAL
    {
        public static int guardar(Soldado pSoldado)
        {
            string consulta = "INSERT INTO soldado(edad,capacidadCarga,idPais_Fk,idProfesion_Fk,idRango_Fk) VALUES(@edad,@experiencia,@capacidadCarga,@idPais_Fk,@idProfesion_Fk,@idRango_Fk)";
            SqlCommand comando = ComunDb.
        }
    }
}
