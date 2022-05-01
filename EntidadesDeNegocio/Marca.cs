using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesDeNegocio
{
    public class Marca
    {
        public int? Id_Marca { get; set; }
        public string nombre { get; set; }
        public int IdClasificcion_Fk { get; set; }
    }
}
