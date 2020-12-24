using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gente : Persona
    {
        // se construye pero no agrega al bar si no es mayor a 18años
        public Gente(short edad)
            : base("", edad)
        {
            
        }

        /// <summary>
        /// Muestra los datos de la clase padre e implementa el tipo de la clase actual
        /// </summary>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Tipo: Gente");
            sb.Append(base.Mostrar());

            return sb.ToString();
        }
        /// <summary>
        /// Validara que la gente sea mayor a 18 años
        /// </summary>
        public override bool Validar()
        {
            return this.Edad >= 18;
        }
        /*
        public override string ToString()
        {
            return this.Mostrar();
        }
        */
    }
}
