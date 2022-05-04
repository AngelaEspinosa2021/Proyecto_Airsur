using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSur.EntidadesDeNegocio
{
    public class Rango
    {
        [Key]
        public long id_rango { get; set;}

        public string nombre { get; set;}
    }
}
