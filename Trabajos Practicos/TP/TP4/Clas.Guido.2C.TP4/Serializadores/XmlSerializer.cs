using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Entidades;

namespace Serializadores
{
    public class XmlSerializer<V>: ISerializador<V>
    {
        public bool Guardar(string archivo, V datos)
        {
            bool retorno = true;

            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(V));
                    serializer.Serialize(writer, datos);
                }
            }
            catch (Exception)
            {
                retorno = false;
                throw new ArchivosException("Error al guardar el archivo en XML");
            }

            return retorno;
        }

        public bool Leer(string archivo, out V datos)
        {
            bool retorno = true;
            try
            {
                using (XmlTextReader writer = new XmlTextReader(archivo))
                {

                    XmlSerializer serializer = new XmlSerializer(typeof(V));
                    datos = (V)serializer.Deserialize(writer);
                }
            }
            catch (Exception)
            {
                datos = default(V);
                retorno = false;
                throw new ArchivosException("Error al leer el archivo XML");
            }

            return retorno;
        }
        public bool Guardar(string archivo, List<V> datos)
        {
            bool retorno = true;

            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<V>));
                    serializer.Serialize(writer, datos);
                }
            }
            catch (Exception)
            {
                retorno = false;
                throw new ArchivosException("Error al guardar el archivo en XML");
            }

            return retorno;
        }
        public bool Leer(string archivo, out List<V> carreras)
        {
            bool retorno = true;
            try
            {
                using (XmlTextReader writer = new XmlTextReader(archivo))
                {

                    XmlSerializer serializer = new XmlSerializer(typeof(List<V>));
                    carreras = (List<V>)serializer.Deserialize(writer);
                }
            }
            catch (Exception)
            {
                carreras = default(List<V>);
                retorno = false;
                throw new ArchivosException("Error al leer el archivo XML");
            }

            return retorno;
        }
    }
}
