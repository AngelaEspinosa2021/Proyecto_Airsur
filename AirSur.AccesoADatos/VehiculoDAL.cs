using System.Collections.Generic;
using System.Linq;

namespace AirSur.AccesoADatos
{
    public class VehiculoDAL
    {
        bdaisurEntities _db = new bdaisurEntities();

        public bool guardar(vehiculo vehiculo)
        {
            _db.vehiculo.Add(vehiculo);
            _db.SaveChanges();
            return true;
        }

        public List<vehiculo> mostrarVehiculos()
        {
            var query = (from s in _db.vehiculo select s);
            return query.ToList();
        }
    }
}
