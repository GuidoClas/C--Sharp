using System;
using System.Linq;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 10";

            int i;
            int j;
            int cantidad;
            int asterisco;

            Console.WriteLine("Ingrese la cantidad de escalones de la piramide: ");
            cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("PIRAMIDE");
            for (i = 1; i <= cantidad; i++)//2
            {
                for(j = 0; j < cantidad-i; j++)//
                {
                    Console.Write(" ");
                }

                for(asterisco = 1; asterisco <= (i*2)-1; asterisco++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
