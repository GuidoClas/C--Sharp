using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {
        private int dni;

        public Empleado(string nombre, short edad, int dni) 
            : base(nombre, edad)
        {
            this.dni = dni;
        }

        public Empleado(string nombre, short edad)
            : this(nombre, edad, -1)
        {
        }


        /// <summary>
        /// Muestra los datos de la clase padre e implementa el tipo de la clase actual
        /// </summary>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Tipo: Empleado");
            sb.Append(base.Mostrar());
            if(this.dni != -1)
            {
                sb.AppendFormat("Dni: {0}", this.dni);
            }

            return sb.ToString();
        }
        /// <summary>
        /// Validara que el empleado sea mayor a 21 años y su nombre tenga al menos 2 caracteres
        /// </summary>
        public override bool Validar()
        {
            return Edad >= 21 && Nombre.Length > 2;
        }

        /*
        public override string ToString()
        {
            return this.Mostrar();
        }
        */

        /// <summary>
        /// Dos empleados seran iguales si tienen mismo nombre y edad
        /// </summary>
        /// <param name="e1">Empleado1</param>
        /// <param name="e2">Empleado2</param>
        public static bool operator ==(Empleado e1, Empleado e2)
        {
            bool sonIguales = false;

            if (((object)e1) == null && ((object)e2) == null)
            {
                sonIguales = true;
            }
            else
            {
                if (((object)e1) != null && ((object)e2) != null)
                {
                    if (e1.Nombre == e2.Nombre && e1.Edad == e2.Edad)
                    {
                        sonIguales = true;
                    }
                }
            }
            return sonIguales;
        }

        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }
    }
}
