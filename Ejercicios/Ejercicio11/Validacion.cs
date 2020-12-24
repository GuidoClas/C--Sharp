using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Validacion
    {
        public static bool validar(int valor, int min, int max)
        {
            bool esValido = false;

            if(valor <= max && valor >= min)
            {
                esValido = true;
            }
            return esValido;
        }
    }
}
