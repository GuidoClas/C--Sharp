using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Entidades
{
    public delegate void CorrePicada(string corredor); //Delegado que recibe como parametro el nombre del corredor, del cual se trazará el trayecto.

    public abstract class Vehiculo
    {
        protected int carril;
        protected int cantidadRuedas;
        protected int velocidadPunta;

        public event CorrePicada Trayecto; //Evento que permite calcular/observar el trayecto del corredor.

        public Vehiculo(int carril, int cantidadRuedas, int velocidadPunta)
        {
            this.carril = carril;
            this.cantidadRuedas = cantidadRuedas;
            this.velocidadPunta = velocidadPunta;
        }

        public int Carril
        {
            get
            {
                return this.carril;
            }
        }

        public int CantidadDeRuedas
        {
            get
            {
                return this.cantidadRuedas;
            }
            set
            {
                this.cantidadRuedas = value;
            }
        }

        /// <summary>
        /// Se valida que, al ser Muscle Cars, no superen una velocidad maxima de 300 km/h, y no decaigan a una velocidad maxima de 250 km/h.
        /// </summary>
        public int VelocidadPunta
        {
            get
            {
                return this.velocidadPunta;
            }
            set
            {
                if (value > 300)
                {
                    value = 300;
                }

                if(value < 250)
                {
                    value = 250;
                }
                this.velocidadPunta = value;
            }
        }

        /// <summary>
        /// Metodo que invocará al evento, enviandole como parametro el nombre del corredor que se pretende trazar.
        /// </summary>
        /// <param name="corredor"></param>
        protected void CaptarTrayecto(string corredor)
        {
            this.Trayecto.Invoke(corredor);
        }

    }
}
