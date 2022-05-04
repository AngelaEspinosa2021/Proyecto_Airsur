using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirSur.EntidadesDeNegocio
{
    public class Soldado
    {
        [Key]
        public long id_soldado { get; set; }
        
        public int? edad { get; set; }
        
        public int? experiencia { get; set; }
        
        public int? capacidadCarga { get; set; }

        [ForeignKey("Pais")]
        public long idPais_Fk { get; set; }

        [ForeignKey("Profesion")]
        public long idProfesion_Fk { get; set; }

        [ForeignKey("Rango")]
        public long idRango_Fk { get; set; }

        
    }
}
