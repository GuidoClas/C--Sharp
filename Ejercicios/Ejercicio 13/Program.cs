using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
            string DecimalBinario(int). Convierte un número de entero a binario.
            int BinarioDecimal(string). Convierte un número binario a entero.
            */
            string numeroBinario;
            int numeroEntero;
            int numeroBinarioConvertido;
            string numeroEnteroConvertido;
            int opcion;

            Console.WriteLine("Ingresa la opcion\n1-Convertir numero entero en binario\n2-Convertir numero binario en entero");
            opcion = int.Parse(Console.ReadLine());

            switch(opcion)
            {
                case 1:
                    Console.WriteLine("Ingresa el numero entero: ");
                    numeroEntero = int.Parse(Console.ReadLine());
                    numeroEnteroConvertido = Conversor.DecimalBinario(numeroEntero);
                    Console.WriteLine("Numero en entero: {0}", numeroEnteroConvertido);
                    break;
                case 2:
                    Console.WriteLine("Ingresa el numero binario: ");
                    numeroBinario = Convert.ToString(Console.ReadLine());
                    numeroBinarioConvertido = Conversor.BinarioDecimal(numeroBinario);
                    Console.WriteLine("Numero en entero: {0}", numeroBinarioConvertido);
                    break;
                default:
                    Console.WriteLine("No es una opcion valida");
                    break;
            }

            Console.ReadKey(true);

        }
    }
}
