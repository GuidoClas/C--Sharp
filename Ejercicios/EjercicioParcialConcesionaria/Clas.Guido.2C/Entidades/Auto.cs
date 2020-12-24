using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto : Vehiculo
    {
        public ETipo tipo;

        public Auto(string modelo, float precio, Fabricante fabri, ETipo tipo)
            :base(precio, modelo, fabri)
        {
            this.tipo = tipo;
        }

        public static bool operator ==(Auto a, Auto b)
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
                    if ((((Vehiculo)a) == ((Vehiculo)b)) && a.tipo == b.tipo)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }

        public static explicit operator float(Auto a)
        {
            return a.precio;
        }

        public override bool Equals(object obj)
        {
            bool output = false;

            if (obj is Auto)
            {
                output = this == (Auto)obj;
            }

            return output;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append((string)((Vehiculo)this));
            sb.AppendFormat("Tipo: {0}\n", this.tipo);

            return sb.ToString();
        }

    }
}
