using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseDatos;
using EntidadesDeNegocio;


namespace LogicaNegocios
{
    public class SoldadoBL
    {
        public static int guardar(Soldado pSoldado)
        {
            return SoldadoDAL.guardar(pSoldado);
        }

        public static List<Soldado> obtenerListaSoldados()
        {
            return SoldadoDAL.obtenerListaSoldados();
        }
    }
}
