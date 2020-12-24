using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Salidas
    {
        private DateTime fechaInicio;
        private DateTime fechaFin;

        public Salidas()
        {
            this.FechaInicio = DateTime.Now;
        }

        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }

        public int TiempoTotal
        {
            get
            {
                return this.fechaInicio.DiferenciaEnMinutos(this.FechaFin);
            }
        }
        public void FinalizarSalida()
        {
            this.FechaFin = DateTime.Now;
        }
    }
}
