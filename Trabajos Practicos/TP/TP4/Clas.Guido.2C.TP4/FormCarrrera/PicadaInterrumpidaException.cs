using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormCarrrera
{
    public class PicadaInterrumpidaException : Exception
    {
        public PicadaInterrumpidaException() : base("Error, la picada fue interrumpida y no pudo finalizar, se corre de nuevo")
        {

        }
    }
}
