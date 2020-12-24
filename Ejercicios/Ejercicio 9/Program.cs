using System;
using System.Linq;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 09";

            int cantidad;

            Console.WriteLine("Ingrese la cantidad de escalones de la piramide: ");
            cantidad = int.Parse(Console.ReadLine());

            string resultado;
            
            for (int i=1; i <= cantidad; i++)
            {
                resultado = String.Concat(Enumerable.Repeat("*", i*2-1));
                Console.WriteLine(resultado);
            }
           
        }
    }
}
