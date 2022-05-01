using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EntidadesDeNegocio;

namespace EntidadesNegocio
{
    public class TipoArmaDAL
    {
        //public static int Guardar(TipoArma pTipoArma)
        //{
        //    string consultaTipoArma = "INSERT INTO tipoArma(nombre, clasificacion) VALUES (@Nombre, @Clasificacion)";
        //    SqlComand
        //}

        private bdaisurEntities modeloBd = new bdaisurEntities();

        public bool Guardar(tipoArma datosTipoArma)
        {
            modeloBd.tipoArma.Add(datosTipoArma);
            modeloBd.SaveChanges();
            return true;
        }
    }
}
