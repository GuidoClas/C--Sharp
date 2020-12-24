using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Calculadora
    {
        public static double Calcular(float num1, float num2, char operador)
        {
            double resultado = 0; 

            if(operador == '+')
            {
                resultado = num1 + num2;
            }
            else if(operador == '-')
            {
                resultado = num1 - num2;
            }
            else if(operador == '*')
            {
                resultado = num1 * num2;
            }
            else
            {
                if(Validar(num2))
                {
                    resultado = num1 / num2;
                }
                else
                {
                    Console.WriteLine("No se puede dividir entre 0");
                }
            }
            return resultado;
        }

        private static bool Validar(float num2)
        {
            bool esDistintoDeCero = false;
            if(num2 != 0)
            {
                esDistintoDeCero = true;
            }
            return esDistintoDeCero;
        }
    }
}
