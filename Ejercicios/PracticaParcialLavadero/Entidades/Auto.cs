using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto : Vehiculo
    {
        protected int cantidadAsientos;

        public Auto(string patente, byte cantRuedas, eMarca marca, int cantidadAsientos):base(patente, cantRuedas, marca)
        {
            this.cantidadAsientos = cantidadAsientos;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder(base.Mostrar());

            sb.AppendFormat("Asientos: {0}", this.cantidadAsientos);
            sb.AppendLine();

            return sb.ToString();
        }
    }
}
