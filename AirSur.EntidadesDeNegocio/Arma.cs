using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirSur.EntidadesDeNegocio
{
    public class Arma
    {
        [Key]
        public int Id_arma { get; set; }
        public string Nombre { get; set; }
        public int Peso { get; set; }
        public int CantidadMunicion { get; set; }
        [ForeignKey("TipoArma")]
        public int IdTipoArma_Fk { get; set; }
        [ForeignKey("Marca")]
        public int IdMarca_Fk { get; set; }
    }
}
