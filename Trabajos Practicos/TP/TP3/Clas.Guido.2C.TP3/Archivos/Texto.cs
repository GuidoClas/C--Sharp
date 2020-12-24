using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        /// <summary>
        /// Se encarga de serializar los datos que recibe en formato string, en el path recibido.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>Retorna true si pudo serializar correctamente, retornara false si se lanzo una excepcion y se capturó</returns>
        public bool Guardar(string archivo, string datos)
        {
            bool retorno = true;

            try
            {
                using(StreamWriter sw = new StreamWriter(archivo, false))
                {
                    sw.WriteLine(datos);
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
        /// Se encarga de deserializar los datos del path recibido, y los almacena en la variable datos recibida.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>Retorna true si pudo deserializar correctamente, retornara false si se lanzo una excepcion y se capturó</returns>
        public bool Leer(string archivo, out string datos)
        {
            bool retorno = true;

            try
            {
                using (StreamReader sr = new StreamReader(archivo))
                {
                    datos = sr.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                retorno = false;
                throw new ArchivosException(ex);
            }

            return retorno;
        }
            
    }
}
