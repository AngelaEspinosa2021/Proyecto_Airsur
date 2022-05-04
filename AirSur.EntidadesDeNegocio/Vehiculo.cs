namespace AirSur.EntidadesDeNegocio
{
    public class Vehiculo
    {
        public long id_vehiculo { get; set; }
        public string nombre { get; set; }
        public int cilindraje { get; set; }
        public int capacidadCargaMunicion { get; set; }
        public long idTipoVehiculo_Fk { get; set; }
        public long idMarca_FK { get; set; }


    }
}
