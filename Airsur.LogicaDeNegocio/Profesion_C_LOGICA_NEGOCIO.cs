using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirSur.AccesoADatos;

namespace Airsur.LogicaDeNegocio
{
    class Profesion_C_LOGICA_NEGOCIO
    {        
        ProfesionC_DATOS objdatos = new ProfesionC_DATOS();
        public bool guardar(profesion pProfesion)
        {
           profesion _profesion = new profesion();
            _profesion.id_profesion = pProfesion.id_profesion;
            _profesion.nombre = pProfesion.nombre;
           

            return objdatos.guardar(_profesion);
        }

        public List<profesion> obtenerListaprofesiones()
        {
            return objdatos.mostrarprofesiones();
        }
    }
}
