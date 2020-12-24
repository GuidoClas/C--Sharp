using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
        }

        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        private float CalcularCosto()
        { 
            return this.costo * this.Duracion;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendFormat("Costo de Llamada: {0}\n", this.CostoLlamada);

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            bool output = false;

            if (obj is Local)
            {
                output = true;
            }

            return output;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
