using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Excepciones
{
    public class DniInvalidoException : Exception
    {
        public DniInvalidoException() :base("El Dni es invalido")
        {

        }
        public DniInvalidoException(Exception e) : this("El Dni es invalido", e)
        {

        }
        public DniInvalidoException(string message) : base(message)
        {

        }
        public DniInvalidoException(string message, Exception e) : base(message, e)
        {

        }
    }
}
