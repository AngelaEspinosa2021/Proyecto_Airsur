using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesDeNegocio
{
    public class Soldado
    {
        public long id_soldado { get; set; }
        public Nullable<int> edad { get; set; }
        public Nullable<int> experiencia { get; set; }
        public Nullable<int> capacidadCarga { get; set; }
        public Nullable<long> idPais_Fk { get; set; }
        public Nullable<long> idProfesion_Fk { get; set; }
        public Nullable<long> idRango_Fk { get; set; }
    }
}
