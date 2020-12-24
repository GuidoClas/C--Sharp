using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    public class ValidarRespuesta
    {
        public static bool ValidaS_N(char c)
        {
            bool esS = false;

            if(c == 's' || c == 'S')
            {
                esS = true;
            }
            return esS;
        }
    }
}
