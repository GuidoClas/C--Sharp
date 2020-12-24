using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;

        public Perro(string nombre, string raza)
            : base(nombre, raza)
        {
            this.edad = 0;
            this.esAlfa = false;
        }

        public Perro(string nombre, string raza, int edad, bool esAlfa) : this(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }

        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("perro -");
            sb.Append(this.DatosCompletos());

            if (this.esAlfa)
            {
                sb.Append(" alfa de la manada,");
                sb.AppendFormat(" edad {0}", this.edad);
            }
            else
            {
                sb.AppendFormat(" edad {0}", this.edad);
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public static bool operator ==(Perro p1, Perro p2)
        {
            bool output = false;

            if (((object)p1) == null && ((object)p2) == null)
            {
                output = true;
            }
            else
            {
                if (((object)p1) != null && ((object)p2) != null)
                {
                    if (p1.Nombre == p2.Nombre && p1.Raza == p2.Raza && p1.edad == p2.edad)
                    {
                        output = true;
                    }
                }
            }

            return output;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        public static explicit operator int(Perro p)
        {
            return p.edad;
        }
  
        public override bool Equals(object obj)
        {
            bool output = false;

            if (obj is Perro)
            {
                output = this == (Perro)obj;
            }

            return output;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
