using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Test
{
    [Serializable]
    public class Persona
    {
        private string nombre;
        private string apellido;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }
        
        public Persona()
        {

        }
        
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static void GuardarXml(Persona p)
        {
            XmlTextWriter writer = null;
            XmlSerializer serializer = null;

            try
            {
                writer = new XmlTextWriter("personas.xml", Encoding.UTF8);
                serializer = new XmlSerializer(typeof(Persona));

                serializer.Serialize(writer, p);
            }
            finally
            {
                if (writer != null)
                {
                     writer.Close();
                }
            }
            
            
        }

        public static void GuardarBin(Persona p)
        {
            BinaryFormatter serializador = null;
            Stream fs = null;

            try
            {
                fs = new FileStream("personas.bin", FileMode.Create);
                serializador = new BinaryFormatter();

                serializador.Serialize(fs, p);
            }
            finally
            {
                if(fs != null)
                {
                    fs.Close();
                }
            }
        }

        public static Persona LeerBin(Persona p)
        {
            Stream fs = null;
            BinaryFormatter deserializador = null;

            try
            {
                fs = new FileStream("personas.bin", FileMode.Open);
                deserializador = new BinaryFormatter();

                return (Persona)deserializador.Deserialize(fs);
            }
            finally
            {
                if(fs != null)
                {
                    fs.Close();
                }
            }
        }

        public static Persona LeerXml(Persona p)
        {
            using (XmlTextReader reader = new XmlTextReader("personas.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Persona));
                return (Persona)serializer.Deserialize(reader);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("Apellido: " + this.Apellido);

            return sb.ToString();
        }
    }
}
