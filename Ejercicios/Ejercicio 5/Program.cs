using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 05";
            int numero;
            int contador = 1;

            Console.WriteLine("Calculo de Centro Numerico\n");
            Console.WriteLine("Ingresa un numero hasta el que desees calcular: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("\nCentros numericos:\n"); 
            
            while(contador < numero)
            {
                int acumuladorAtras = 0;
                int acumuladorAdelante = 0;

                for(int i=0; i < contador; i++)
                {
                    acumuladorAtras += i;
                }
                for(int j= contador+1; j <= acumuladorAtras; j++)
                {
                    if (acumuladorAdelante == acumuladorAtras || acumuladorAdelante > acumuladorAtras)
                    {
                        break;
                    }
                    acumuladorAdelante += j;
                }

                if(contador != 1 && acumuladorAtras == acumuladorAdelante)
                {
                    Console.WriteLine("Numero: " + contador + " Suma: " + acumuladorAtras);
                }
                contador++;
            }
            
        }
    }
}
