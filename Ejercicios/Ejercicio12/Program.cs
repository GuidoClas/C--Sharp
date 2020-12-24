using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int sumatoria = 0;
            char letra;
        
            do
            {
                Console.WriteLine("Ingresa un numero entero: ");
                numero = int.Parse(Console.ReadLine());

                sumatoria += numero;

                Console.WriteLine("Desea continuar? S/N: ");
                letra = Convert.ToChar(Console.ReadLine());

            } while (ValidarRespuesta.ValidaS_N(letra));

            Console.WriteLine("Sumatoria: {0}", sumatoria);

            Console.ReadKey(true);
        }
    }
}
