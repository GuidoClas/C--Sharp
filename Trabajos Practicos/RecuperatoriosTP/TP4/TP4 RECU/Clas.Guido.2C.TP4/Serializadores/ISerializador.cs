using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializadores
{
    public interface ISerializador<X>
    {
        bool Guardar(string archivo, List<X> datos);
        bool Leer(string archivo, out List<X> datos);
    }
}
