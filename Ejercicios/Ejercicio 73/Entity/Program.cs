using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;

            Console.Write("Ingrese una cadena de texto: ");
            cadena = Console.ReadLine();

            Console.WriteLine(cadena.CantidadDeSignos());


            Console.ReadKey();
        }
    }
}
