using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private short edad;
        private string nombre;

        protected Persona(string nombre, short edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public short Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public static explicit operator string(Persona p)
        {
            return p.Mostrar();
        }
        /// <summary>
        /// Muestra los datos de la persona y permite nuevas implementaciones en clases derivadas
        /// </summary>
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Edad: {0} - Nombre: {1}\n", this.Edad, this.Nombre);

            return sb.ToString();
        }

        public abstract bool Validar();
    }
}
