using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public abstract float CostoLlamada { get;}

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("\nDuracion: {0}\n", this.Duracion);
            sb.AppendFormat("Nro Origen: {0}\n", this.NroOrigen);
            sb.AppendFormat("Nro Destino: {0}\n", this.NroDestino);
            
            return sb.ToString();
        }
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return String.Compare(llamada1.Duracion.ToString(), llamada2.Duracion.ToString());
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            bool retorno = false;
         
            if (((object)l1) == null && ((object)l2) == null)
            {
                retorno = true;
            }
            else
            {
                if (((object)l1) != null && ((object)l2) != null)
                {
                    if (l1.Equals(l2) && l1.NroOrigen == l2.NroOrigen && l1.NroDestino == l2.NroDestino)
                    {
                        retorno = true;
                    }
                }
            }

            return retorno; 
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }
    }
}
