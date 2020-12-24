using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 03";
            int numero;
            int contador = 2;
            int contadorPrimos = 0;
            
            
            Console.WriteLine("Ingresa un numero: ");
            numero = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Numeros Primos: ");
            while(contador <= numero)
            {
                int divisor = 1;
                int contadorDivisores = 0;
                while (divisor <= contador)
                {                 
                    if(contador % divisor == 0)
                    {
                        contadorDivisores++;
                    }
                    divisor++;                              
                }
                if (contadorDivisores == 2 || contadorDivisores == 1)
                {
                    contadorPrimos++;
                    Console.WriteLine(contador);
                }
                contador++;
            }     
        }
    }
}
