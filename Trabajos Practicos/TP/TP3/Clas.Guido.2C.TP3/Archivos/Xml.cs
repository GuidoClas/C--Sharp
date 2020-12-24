using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class Xml <T> : IArchivo<T>
    {
        /// <summary>
        /// Se encarga de serializar los datos que recibe del objeto generico T, en el path recibido.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>Retorna true si pudo serializar correctamente, retornara false si se lanzo una excepcion y se capturó</returns>
        public bool Guardar(string archivo, T datos)
        {
            bool retorno = true;

            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(archivo, System.Text.Encoding.UTF8))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));

                    serializer.Serialize(writer, datos);
                }
            }
            catch(Exception ex)
            {
                retorno = false;
                throw new ArchivosException(ex);
            }

            return retorno;
        }

        /// <summary>
        /// Se encarga de deserializar los datos del path recibido, y los almacena en la variable generica datos recibida.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>Retorna true si pudo serializar correctamente, retornara false si se lanzo una excepcion y se capturó</returns>
        public bool Leer(string archivo, out T datos)
        {
            bool retorno = true;

            try
            {
                using(XmlTextReader reader = new XmlTextReader(archivo))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));

                    datos = (T)serializer.Deserialize(reader);
                }
            }
            catch(Exception ex)
            {
                retorno = false;
                throw new ArchivosException(ex);
            }

            return retorno;
        }
    }
}
