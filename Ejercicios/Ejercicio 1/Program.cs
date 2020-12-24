using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 01";
            int numero;
            int contador = 0;
            int acumuladorNum = 0;
            int maximo = 0;
            int minimo = 0;
            float promedio;
            

            while(contador < 5)
            {
                Console.WriteLine("Ingresa un numero: ");

                numero = int.Parse(Console.ReadLine());

                acumuladorNum += numero;

                if(contador == 0 || numero > maximo)
                {
                    maximo = numero;   
                }

                if(contador == 0 || numero < minimo)
                {
                    minimo = numero;
                }

                contador++;
            }

            promedio = acumuladorNum / 5;

            Console.WriteLine($"Promedio: {promedio}");
            Console.WriteLine($"Maximo: {maximo}");
            Console.WriteLine($"Minimo: {minimo}");


        }
    }
}
