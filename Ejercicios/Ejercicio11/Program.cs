using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int numMinimo = 0;
            int numMaximo = 0;
            int acumulador = 0;
            float promedio;
 
            Console.WriteLine("Ingrese 10 numeros enteros entre -100 y 100: ");
            for(int i=0; i<10; i++)
            {
                numero = int.Parse(Console.ReadLine());
                while (!(Validacion.validar(numero, -100, 100)))
                {
                    Console.Write("Error, solo numeros enteros dentro del rango: ");
                    numero = int.Parse(Console.ReadLine());
                }

                if(i==0 || numero > numMaximo)
                {
                    numMaximo = numero;
                }

                if (i == 0 || numero < numMinimo)
                {
                    numMinimo = numero;
                }

                acumulador += numero;
            }

            promedio = acumulador / 10;

            Console.WriteLine("Valor minimo: {0}", numMinimo);
            Console.WriteLine("Valor maximo: {0}", numMaximo);
            Console.WriteLine("Promedio: {0:.0}", promedio);

            Console.ReadKey(true);
        }
    }
}
