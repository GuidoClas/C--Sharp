using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal 
        {
            get 
            {
                return this.CalcularGanancia(TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Todas);
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        private float CalcularGanancia(TipoLlamada tipo)
        {
            float gananciaTotal = 0;
            float gananciaProvincial = 0;
            float gananciaLocal = 0;

            foreach (Llamada item in this.listaDeLlamadas)
            { 
                switch (tipo)
                {
                    case TipoLlamada.Local:
                        if(item is Local)
                        {
                            gananciaTotal = ((Local)item).CostoLlamada;
                        }         
                        break;
                    case TipoLlamada.Provincial:
                        if (item is Provincial)
                        {
                            gananciaTotal = ((Provincial)item).CostoLlamada;
                        }
                        break;
                    case TipoLlamada.Todas:
                        if (item is Local)
                        {
                            gananciaLocal = ((Local)item).CostoLlamada;
                        }

                        if (item is Provincial)
                        {
                            gananciaProvincial = ((Provincial)item).CostoLlamada;
                        }
                        gananciaTotal = gananciaLocal + gananciaProvincial;
                        break;
                    default:
                        break;
                }
            }

            return gananciaTotal;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Razon Social: {0}\n", this.razonSocial);
            sb.AppendFormat("Ganancia Total: {0}\n", this.GananciasPorTotal);
            sb.AppendFormat("Ganancia Local: {0}\n", this.GananciasPorLocal);
            sb.AppendFormat("Ganancia Provincial: {0}\n", this.GananciasPorProvincial);

            foreach(Llamada item in this.listaDeLlamadas)
            {
                if(item is Local)
                {
                    sb.AppendLine(item.ToString());
                }

                if (item is Provincial)
                {
                    sb.AppendLine(item.ToString());
                }
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaDeLlamadas.Add(nuevaLlamada);
        }
        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if(!(c == nuevaLlamada))
            {
                c.AgregarLlamada(nuevaLlamada);
            }

            return c;
        }

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool retorno = false;

            foreach(Llamada item in c.listaDeLlamadas)
            {
                if(item == llamada)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }
    }
}
