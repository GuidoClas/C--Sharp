using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();

            //Hardcode
            alumno1.legajo = 100;
            alumno2.legajo = 101;
            alumno3.legajo = 102;

            alumno1.nombre = "Guido";
            alumno2.nombre = "Eliana";
            alumno3.nombre = "Kevin";

            alumno1.apellido = "Clas";
            alumno2.apellido = "Nardi";
            alumno3.apellido = "Costner";

            alumno1.Estudiar(3, 7);
            alumno2.Estudiar(4, 5);
            alumno3.Estudiar(8, 9);

            alumno1.CalcularFinal();
            alumno2.CalcularFinal();
            alumno3.CalcularFinal();

            Console.WriteLine("************ALUMNOS************");
            Console.WriteLine("{0,1}   {1,1}      {2,1}   {3,-1}   {4,-1}   {5,-1}", "Legajo", "Nombre", "Apellido", "Nota 1", "Nota 2", "Nota final");

            alumno1.Mostrar();
            alumno2.Mostrar();
            alumno3.Mostrar();

            Console.ReadKey(true);
        }
    }
}
