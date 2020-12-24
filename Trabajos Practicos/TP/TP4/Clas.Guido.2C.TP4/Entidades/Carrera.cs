using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carrera
    {
        private string ganador;
        private string corredorElegido;
        private int apuestaDelJugador;

        public Carrera()
        {

        }
        public Carrera(string ganador, string corredorElegido, int totalApuestasPorPicada)
        {
            this.ganador = ganador;
            this.CorredorElegido = corredorElegido;
            this.apuestaDelJugador = totalApuestasPorPicada;
        }

        public string Ganador { get => ganador; set => ganador = value; }
        public string CorredorElegido { get => corredorElegido; set => corredorElegido = value; }
        public int TotalApuestasPorPicada { get => apuestaDelJugador; set => apuestaDelJugador = value; }
    }
}
