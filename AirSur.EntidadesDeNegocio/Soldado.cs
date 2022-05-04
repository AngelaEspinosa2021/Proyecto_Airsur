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
        
        [Display(Name ="Edad")]
        public int? edad { get; set; }

        [Display(Name = "Experiencia")]
        public int? experiencia { get; set; }

        [Display(Name = "Capacidad de Carga")]
        public int? capacidadCarga { get; set; }

        [Display(Name = "Pais")]
        [ForeignKey("Pais")]
        public long idPais_Fk { get; set; }

        [Display(Name = "Profesion")]
        [ForeignKey("Profesion")]
        public long idProfesion_Fk { get; set; }

        [Display(Name = "Rango")]
        [ForeignKey("Rango")]
        public long idRango_Fk { get; set; }

        
    }
}
