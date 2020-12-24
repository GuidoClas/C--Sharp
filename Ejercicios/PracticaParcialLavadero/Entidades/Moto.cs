using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        protected float cilindrada;

        public Moto(string patente, byte cantRuedas, eMarca marca, float cilindrada) : base(patente, cantRuedas, marca)
        {
            this.cilindrada = cilindrada;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder(base.Mostrar());

            sb.AppendFormat("Cilindrada: {0}", this.cilindrada);
            sb.AppendLine();

            return sb.ToString();
        }
    }
}
