using System;
using main;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            string dibujo = "Pintado!";
            Boligrafo boligrafo1 = new Boligrafo(100, ConsoleColor.Blue);
            boligrafo1.Pintar(5, out dibujo);

            Boligrafo boligrafo2 = new Boligrafo(50, ConsoleColor.Red);
            boligrafo2.Pintar(10, out dibujo);

            Boligrafo boligrafo3 = new Boligrafo(100, ConsoleColor.Magenta);
            boligrafo3.Pintar(42, out dibujo);

            Console.ReadKey(true);
        }
    }
}
