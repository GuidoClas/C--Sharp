using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Serializadores
{
    public class Xml<V> : IArchivos<V>
    {
        public bool Guardar(string archivo, V datos)
        {
            try
            {
                using(XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(V));
                    serializer.Serialize(writer, datos);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool Leer(string archivo, out V datos)
        {
            try
            {
                using (XmlTextReader writer = new XmlTextReader(archivo))
                {

                    XmlSerializer serializer = new XmlSerializer(typeof(V));
                    datos = (V)serializer.Deserialize(writer);
                }
                return true;
            }
            catch (Exception)
            {
                datos = default(V);
                return false;
            }
        }
    }
}
