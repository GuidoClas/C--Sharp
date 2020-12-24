using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 02";
            int numero;

            Console.WriteLine("Ingresa un numero mayor a 0: ");
            numero = int.Parse(Console.ReadLine());

            while (numero < 1)
            {
                Console.WriteLine("Error! Reingresa el numero mayor a 0: ");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Numero: {numero}");
            Console.WriteLine($"Cuadrado: {Math.Pow(numero, 2)}");
            Console.WriteLine($"Cubo: {Math.Pow(numero, 3)}");

        }
    }
}
