using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericio_42
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClase obj = new OtraClase();
                obj.MetodoInstancia();
            }
            catch(MiExcepcion ex)
            {
                Console.WriteLine(ex.Message);
                Exception inners;
                inners = ex.InnerException;
                while(inners != null)
                {
                    Console.WriteLine(inners.Message);
                    inners = inners.InnerException;
                }
            }
            Console.ReadKey();
        }
    }
}
