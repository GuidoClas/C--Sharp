using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                // Instancio los objetos a guardar y leer
                Persona p1 = new Persona("Guido", "Clas");
                Persona p2 = new Persona("Kevin", "Clas");

                // Guardo p1 en XML y guardo p2 en Bin
                Persona.GuardarXml(p1);
                Persona.GuardarBin(p2);

                
                Persona p3 = new Persona();
                Persona p4 = new Persona();

                // Guardo lo que lei en ambos archivos en dos instancias nuevas
                p3 = Persona.LeerXml(p1);
                p4 = Persona.LeerBin(p2);

                // Muestro los datos de ambos
                Console.WriteLine(p3.ToString());
                Console.WriteLine(p4.ToString());

                Console.ReadKey();
            }
            finally
            {
                Console.WriteLine("Programa finalizado");
                Console.ReadKey();
            }
        }
    }
}
