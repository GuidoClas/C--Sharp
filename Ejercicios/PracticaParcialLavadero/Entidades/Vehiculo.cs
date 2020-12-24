using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vehiculo
    {
        protected string patente;
        protected byte cantRuedas;
        protected eMarca marca;

        public string Patente { get { return this.patente; } }
        public eMarca Marca { get { return this.marca; } }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Patente: {0}", this.Patente);
            sb.AppendLine();
            sb.AppendFormat("Cantidad de Ruedas: {0}", this.cantRuedas);
            sb.AppendLine();
            sb.AppendFormat("Marca: {0}", this.Marca.ToString());
            sb.AppendLine();

            return sb.ToString();
        }

        public Vehiculo(string patente, byte cantRuedas, eMarca marca)
        {
            this.patente = patente;
            this.cantRuedas = cantRuedas;
            this.marca = marca;
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool retorno = false;
            
            if(((object)v1) == null && ((object)v2) == null)
            {
                retorno = true;
            }
            else
            {
                if(((object)v1) != null && ((object)v2) != null)
                {
                    if(v1.Patente == v2.Patente && v1.Marca == v2.Marca)
                    {
                        retorno = true;
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
