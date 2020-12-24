using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            long numero;

            Console.Write("Ingrese un número: ");
            numero = long.Parse(Console.ReadLine());
            

            Console.WriteLine("Numero de       " + numero.CantidadDeDigitos() + " dígitos");
            Console.ReadKey();      
        }
    }
}
