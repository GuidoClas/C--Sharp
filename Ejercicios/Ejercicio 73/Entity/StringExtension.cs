using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public static class StringExtension
    {
        public static string CantidadDeSignos(this string cadena)
        {
            int cantidadComas = 0;
            int cantidadPuntos = 0;
            int cantidadPuntoYComas = 0;
            StringBuilder sb = new StringBuilder();

            foreach(char c in cadena)
            {
                if(c == ',')
                {
                    cantidadComas++;
                }
                if (c == '.')
                {
                    cantidadPuntos++; 
                }
                if (c == ';')
                {
                    cantidadPuntoYComas++;
                }
            }

            sb.AppendFormat("Cantidad de Comas: {0}\n", cantidadComas);
            sb.AppendFormat("Cantidad de Puntos: {0}\n", cantidadPuntos);
            sb.AppendFormat("Cantidad de Punto y comas: {0}\n", cantidadPuntoYComas);

            return sb.ToString();
        }

        public static long CantidadDeDigitos(this long numero)
        {
            long cantidadDigitos;

            cantidadDigitos = numero.ToString().Count(char.IsDigit);

            return cantidadDigitos;
        }
    }
}
