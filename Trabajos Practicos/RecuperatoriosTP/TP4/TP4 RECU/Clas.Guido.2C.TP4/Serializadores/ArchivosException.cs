using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializadores
{
    public class ArchivosException : Exception
    {
        public ArchivosException(string message) : base(message)
        {

        }
    }
}
