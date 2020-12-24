using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public static class LongExtension
    {
        public static long CantidadDeDigitos(this long numero)
        {
            long cantidadDigitos;

            cantidadDigitos = numero.ToString().Count(char.IsDigit);

            return cantidadDigitos;
        }
    }
}
