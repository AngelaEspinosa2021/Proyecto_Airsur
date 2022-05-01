using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesDeNegocio
{
    public class Arma
    {
        public int? Id_arma { get; set; }
        public string Nombre { get; set; }
        public int Peso { get; set; }
        public int CantidadMunicion { get; set; }
        public int IdTipoArma_Fk { get; set; }
        public int IdMarca_Fk { get; set; }
    }
}
