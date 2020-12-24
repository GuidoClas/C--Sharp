using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericio_42
{
    public class MiClase
    {
        public MiClase()
        {
            try
            {
                MiClase.MetodoEstatico();
            }
            catch(DivideByZeroException ex)
            {
                throw ex;
            }
        }

        public MiClase(int i)
        {
            try
            {
                new MiClase();
            }
            catch(DivideByZeroException ex)
            {
                throw new UnaExcepcion("MiClase(int i)", ex);
            }
        }

        public static void MetodoEstatico()
        {
            throw new DivideByZeroException("MetodoEstatico");
        }
    }
}
