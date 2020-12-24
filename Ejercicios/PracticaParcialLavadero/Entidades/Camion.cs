using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion : Vehiculo
    {
        protected float tara;

        public Camion(string patente, byte cantRuedas, eMarca marca, float tara) : base(patente, cantRuedas, marca)
        {
            this.tara = tara;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder(base.Mostrar());

            sb.AppendFormat("Tara: {0}", this.tara);
            sb.AppendLine();

            return sb.ToString();
        }
    }
}
