using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirSur.AccesoADatos;

namespace AirSur.AccesoADatos
{
    public class ProfesionC_DATOS
    {
        bdaisurEntities db = new bdaisurEntities();

        public bool guardar(profesion profesion)
        {
            db.profesion.Add(profesion);
            db.SaveChanges();
            return true;
        }

        public List<profesion> mostrarprofesiones()
        {
            var query = (from p in db.profesion select p);
            return query.ToList();
        }
    }
}
