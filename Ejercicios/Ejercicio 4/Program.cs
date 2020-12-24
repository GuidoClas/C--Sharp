using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 04";
            int numero = 1;
            int contadorNumerosPerfectos = 0;
 
            Console.WriteLine("Numeros perfectos: ");
            while(contadorNumerosPerfectos < 4)
            {
                int acumuladorDivisores = 0;
                int divisor = 1;
                while(divisor < numero)
                {
                    if(numero % divisor == 0)
                    {
                        acumuladorDivisores += divisor;
                    }
                    divisor++;
                }
                if (acumuladorDivisores == numero)
                {
                    contadorNumerosPerfectos++;
                    Console.WriteLine(numero);
                }
                numero++;
            }   
        }
    }
}
