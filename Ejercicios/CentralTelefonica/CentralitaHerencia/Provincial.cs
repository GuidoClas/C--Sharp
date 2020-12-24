using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        protected Franja franjaHoraria;

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroOrigen)
        {

        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            :base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        private float CalcularCosto()
        {
            float costoTotal = 0;

            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    costoTotal = this.Duracion * (float)0.99;
                    break;
                case Franja.Franja_2:
                    costoTotal = this.Duracion * (float)1.25;
                    break;
                case Franja.Franja_3:
                    costoTotal = this.Duracion * (float)0.66;
                    break;
                default:
                    break;
            }

            return costoTotal;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendFormat("Costo de Llamada: {0}\n", this.CostoLlamada);
            sb.AppendFormat("Franja Horaria: {0}\n", this.franjaHoraria);

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            bool output = false;

            if (obj is Provincial)
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
