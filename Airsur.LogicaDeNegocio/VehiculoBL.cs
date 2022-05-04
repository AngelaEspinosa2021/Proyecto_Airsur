using AirSur.AccesoADatos;
using AirSur.EntidadesDeNegocio;
using System.Collections.Generic;

namespace Airsur.LogicaDeNegocio
{
    public class VehiculoBL
    {
        VehiculoDAL _metodos = new VehiculoDAL();
        public bool guardar(Vehiculo pVehiculo)
        {
            vehiculo _vehiculo = new vehiculo();
            _vehiculo.id_vehiculo = pVehiculo.id_vehiculo;
            _vehiculo.nombre = pVehiculo.nombre;
            _vehiculo.cilindraje = pVehiculo.cilindraje;
            _vehiculo.capacidadCargaMunicion = pVehiculo.capacidadCargaMunicion;
            _vehiculo.idTipoVehiculo_Fk = pVehiculo.idTipoVehiculo_Fk;
            _vehiculo.idMarca_Fk = pVehiculo.idMarca_FK;


            return _metodos.guardar(_vehiculo);
        }

        public List<vehiculo> obtenerListaVehiculos()
        {
            return _metodos.mostrarVehiculos();
        }
    }
}
