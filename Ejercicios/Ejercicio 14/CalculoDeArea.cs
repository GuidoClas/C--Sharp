using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double base1) //BASE x ALTURA o base^2
        {
            return Math.Pow(base1, 2);
        }
        public static double CalcularTriangulo(double base1, double altura) //Base * Altura /2
        { 
            return (base1 * altura) /2;
        }
        public static double CalcularCirculo(double radio) //Pi * radio^2
        {
            double pi = 3.1415926535897931;
            return pi *(Math.Pow(radio, 2));
        }
    }
}
