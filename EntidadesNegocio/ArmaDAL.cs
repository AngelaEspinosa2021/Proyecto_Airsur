using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesNegocio
{
    public class ArmaDAL
    {
        private bdaisurEntities modeloBd = new bdaisurEntities();

        public bool Guardar(arma datosArma)
        {
            modeloBd.arma.Add(datosArma);
            modeloBd.SaveChanges();
            return true;
        }

    }
}
