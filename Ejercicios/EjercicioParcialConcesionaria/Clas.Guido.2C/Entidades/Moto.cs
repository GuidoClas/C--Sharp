using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        public ECilindrada cilindrada;

        public Moto(string marca, EPais pais, string modelo, float precio, ECilindrada cilindrada)
            : base(precio, modelo, new Fabricante(marca, pais))
        {
            this.cilindrada = cilindrada;
        }

        public static bool operator ==(Moto a, Moto b)
        {
            bool retorno = false;

            if (((object)a) == null && ((object)b) == null)
            {
                retorno = true;
            }
            else
            {
                if (((object)a) != null && ((object)b) != null)
                {
                    if ((((Vehiculo)a) == ((Vehiculo)b)) && a.cilindrada == b.cilindrada)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Moto a, Moto b)
        {
            return !(a == b);
        }

        public static implicit operator float(Moto a)
        {
            return a.precio;
        }

        public override bool Equals(object obj)
        {
            bool output = false;

            if (obj is Moto)
            {
                output = this == (Moto)obj;
            }

            return output;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append((string)((Vehiculo)this));
            sb.AppendFormat("Cilindrada: {0}\n", this.cilindrada);

            return sb.ToString();
        }
    }
}
