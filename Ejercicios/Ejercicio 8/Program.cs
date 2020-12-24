using Ejercicio12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int valorHora;
            int antiguedad;
            int horasTrabajadas;
            char letra;
            double totalBruto;
            double total;
            double descuento;

            do
            {
                Console.WriteLine("Ingresa el nombre: ");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingresa el valor de la hora: ");
                valorHora = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa la antiguedad en años: ");
                antiguedad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa las horas trabajadas por mes: ");
                horasTrabajadas = int.Parse(Console.ReadLine());
                ////////////////////////////////////////////////////////
                totalBruto = (horasTrabajadas * valorHora) + (antiguedad * 150);
                descuento = totalBruto * 0.13;
                total = totalBruto - descuento;

                Console.WriteLine("NOMBRE: {0}", nombre);
                Console.WriteLine("Antiguedad: {0}", antiguedad);
                Console.WriteLine("Valor de la hora: {0}", valorHora);
                Console.WriteLine("Total Bruto: {0}", totalBruto);
                Console.WriteLine("Total Descuentos: {0}", descuento);
                Console.WriteLine("Importe Neto: {0}", total);


                Console.WriteLine("Desea continuar ingresando? S/N: ");
                letra = Convert.ToChar(Console.ReadLine());
            } while (ValidarRespuesta.ValidaS_N(letra));
        }
    }
}
