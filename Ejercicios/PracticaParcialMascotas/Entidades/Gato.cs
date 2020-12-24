using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato : Mascota
    {
        public Gato(string nombre, string raza)
            : base(nombre, raza)
        {
        }

        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("gato -");
            sb.Append(this.DatosCompletos());

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public static bool operator ==(Gato g1, Gato g2)
        {
            bool output = false;

            if (((object)g1) == null && ((object)g2) == null)
            {
                output = true;
            }
            else
            {
                if (((object)g1) != null && ((object)g2) != null)
                {
                    if (g1.Nombre == g2.Nombre && g1.Raza == g2.Raza)
                    { 
                        output = true;
                    }
                }
            }

            return output;
        }

        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }

        public override bool Equals(object obj)
        {
            bool output = false;

            if (obj is Gato)
            {
                output = this == (Gato)obj;
            }

            return output;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
