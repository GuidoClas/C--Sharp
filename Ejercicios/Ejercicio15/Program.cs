using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio12;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            char continua;
            char operador;
            int numero1;
            int numero2;
            double resultado;

            do
            {
                Console.WriteLine("Ingresa el primer numero: ");
                numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el segundo numero: ");
                numero2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el operador: ");
                operador = Convert.ToChar(Console.ReadLine());

                resultado = Calculadora.Calcular(numero1, numero2, operador);
                Console.WriteLine("Resultado de la operacion: {0}", resultado);

                Console.WriteLine("Desea continuar con otra cuenta? S/N");
                continua = Convert.ToChar(Console.ReadLine());

                Console.Clear();
            } while (ValidarRespuesta.ValidaS_N(continua));

        }
    }
}
