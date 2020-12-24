using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Temporizador
{
    public delegate void encargadoTiempo();
    public sealed class Temporizador
    {
        private Thread hilo;
        private int intervalo;

        public bool Activo
        {
            get
            { 
                return this.hilo.IsAlive; 
            }
            set 
            { 
                if(value == true && !this.Activo)
                {
                    this.hilo = new Thread(Corriendo);
                    this.hilo.Start();
                }
                else
                {
                    if(this.hilo != null)
                    {
                        this.hilo.Abort();
                    }
                }
            }
        }

        public int Intervalo
        {
            get 
            {
                return this.intervalo; 
            }
            set 
            { 
                this.intervalo = value; 
            }
        }

        public event encargadoTiempo EventoTiempo;

        private void Corriendo()
        {
            while(this.Activo)
            {
                Thread.Sleep(this.Intervalo);
                this.EventoTiempo.Invoke();
            }
        }
           
    }
}
