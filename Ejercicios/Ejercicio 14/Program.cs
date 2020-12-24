using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            double areaCuadrado;
            double areaTriangulo;
            double areaCirculo;
            double baseCuadrado=0;
            double radioCirculo=0;
            double baseTriangulo = 0;
            double alturaTriangulo = 0;


            Console.WriteLine("Calcular area, elija opcion\n1-Cuadrado\n2-Triangulo\n3-Circulo");
            opcion = int.Parse(Console.ReadLine());

            switch(opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese la base del cuadrado: ");
                    baseCuadrado = double.Parse(Console.ReadLine());
                    areaCuadrado = CalculoDeArea.CalcularCuadrado(baseCuadrado);
                    Console.WriteLine("Area del cuadrado: {0}", areaCuadrado);
                    break;
                case 2:
                    Console.WriteLine("Ingrese la base del triangulo: ");
                    baseTriangulo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del triangulo: ");
                    alturaTriangulo = double.Parse(Console.ReadLine());
                    areaTriangulo = CalculoDeArea.CalcularTriangulo(baseTriangulo, alturaTriangulo);
                    Console.WriteLine("Area del triangulo: {0}", areaTriangulo);
                    break;
                case 3:
                    Console.WriteLine("Ingrese el radio del circulo: ");
                    radioCirculo = double.Parse(Console.ReadLine());
                    areaCirculo = CalculoDeArea.CalcularCirculo(radioCirculo);
                    Console.WriteLine("Area del circulo: {0}", areaCirculo);
                    break;
                default:
                    Console.WriteLine("No es una opcion valida");
                    break;
            }
            Console.ReadKey(true);
        }
    }
}
