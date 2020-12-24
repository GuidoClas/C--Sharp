using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IFiles<T>
    {
        public string GetDirectoryPath
        {
            get
            {
                string path = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString();
                path += @"\";
                return path;
            }
        }

        public bool FileExists(string nombreArchivo)
        {
            return File.Exists(this.GetDirectoryPath + nombreArchivo);
        }

        public void Guardar(string nombreArchivo, T objeto)
        {
            Guardar(nombreArchivo, objeto, Encoding.UTF8);
        }

        public void Guardar(string nombreArchivo, T objeto, Encoding encoding)
        {
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(this.GetDirectoryPath + nombreArchivo, encoding))
                {
                    writer.Formatting = Formatting.Indented;
                    XmlSerializer serializer = new XmlSerializer(typeof(T));

                    serializer.Serialize(writer, objeto);
                }
            }
            catch (Exception ex)
            {
                throw new ArchivosExcepcion("Error al serializar", ex);
            }
        }

        public bool Leer(string nombreArchivo, out T objeto)
        {
            return Leer(nombreArchivo, out objeto, Encoding.UTF8);
        }

        public bool Leer(string nombreArchivo, out T objeto, Encoding encoding)
        {
            bool retorno = true;

            try
            {
                if(nombreArchivo.Contains('\\') ||  !FileExists(nombreArchivo))
                {
                    throw new ArchivosExcepcion("Ruta invalida");
                }
                using (XmlTextReader reader = new XmlTextReader(this.GetDirectoryPath + nombreArchivo))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));

                    objeto = (T)serializer.Deserialize(reader, encoding.EncodingName);
                }
            }
            catch (Exception ex)
            {
                retorno = false;
                throw new ArchivosExcepcion("Error al serializar", ex);
            }

            return retorno;
        }
    }
}
