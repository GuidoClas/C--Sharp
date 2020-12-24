using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 06";

            int anioInicio;
            int anioFin;

            Console.WriteLine("Ingresa el año de inicio: ");
            anioInicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el año de fin: ");
            anioFin = int.Parse(Console.ReadLine());


            Console.WriteLine("Años bisiestos: \n");
            while(anioInicio <= anioFin)
            {
                if (anioInicio % 4 == 0 && (anioInicio % 100 != 0 || anioInicio % 400 == 0))
                {
                     Console.WriteLine(anioInicio);
                }
                anioInicio++;
            }  
        }
    }
}
